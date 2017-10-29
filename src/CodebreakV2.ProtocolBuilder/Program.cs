using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodebreakV2.ProtocolBuilder
{
    class Program
    {
        static Configuration Configuration = Newtonsoft.Json.JsonConvert.DeserializeObject<Configuration>(File.ReadAllText("../data/protocol/Configuration.json"));
        static Protocol Protocol = Newtonsoft.Json.JsonConvert.DeserializeObject<Protocol>(File.ReadAllText("../data/protocol/DofusProtocol.json"));
        static Dictionary<string, string> TypeDictionary = new Dictionary<string, string>()
        {
            ["uint8"] = "Byte",
            ["uint16"] = "UInt16",
            ["uint32"] = "UInt32",
            ["uint64"] = "UInt64",
            ["int8"] = "SByte",
            ["int16"] = "Int16",
            ["int32"] = "Int32",
            ["int64"] = "Int64",
            ["float32"] = "Single",
            ["float64"] = "Double",
            ["bool"] = "Boolean",
            ["string"] = "String"
        };

        static void Main(string[] args)
        {
            Generate();
        }

        static void Generate()
        {
            foreach (var e in Protocol.Enums)
                GenerateEnum(e);
            foreach (var type in Protocol.Types)
                GenerateType(type);
            foreach (var message in Protocol.Messages)
                GenerateMessage(message);
        }

        static void GenerateEnum(Enum e)
        {
            WriteFile($"{e.Name}.cs", new string[] { }, "Enums", WriteEnum(e));
        }

        static void GenerateMessage(Message message)
        {
            WriteFile($"{message.Name}.cs", new[] { $"{Configuration.Namespace}.Types" }, "Messages", WriteClass(message));
        }

        static void GenerateType(Message message)
        {
            WriteFile($"{message.Name}.cs", new string[] { }, "Types", WriteClass(message));
        }

        static string TransformName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;
            return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);
        }

        static string InverseFunction(string name)
        {
            return name.Replace("Write", "Read");
        }

        static string TransformType(string type)
        {
            if (TypeDictionary.ContainsKey(type))
                return TypeDictionary[type];
            switch (type)
            {
                case "Version":
                    return $"{Configuration.Namespace}.Types.Version";
            }
            return type;
        }

        static void WriteFile(string fileName, string[] imports, string customNamespace, Action<Action<string>> f)
        {
            var outputDirectory = $"{Configuration.OutputPath}/{customNamespace}";
            var filePath = $"{outputDirectory}/{fileName}";
            Directory.CreateDirectory(outputDirectory);
            var output = new StringBuilder();
            output.AppendLine("using System;");
            foreach (var import in imports)
            {
                output.AppendLine($"using {import};");
            }
            output.AppendLine($"namespace {Configuration.Namespace}.{customNamespace}");
            Bracket(line => output.AppendLine(line))(indented =>
            {
                f(indented);
            });
            File.WriteAllText(filePath, output.ToString());
        }

        static void WriteSerialize(string parent, Field[] fields, Action<string> f)
        {
            f($"public{(string.IsNullOrWhiteSpace(parent) ? string.Empty : " new")} void Serialize(IDataWriter writer)");
            Bracket(f)(g =>
            {
                if (!string.IsNullOrWhiteSpace(parent))
                {
                    g($"base.Serialize(writer);");
                }
                var bbwOffset = 0;
                if (fields.Any(field => field.UseBBW))
                {
                    g($"UInt32 wrappedBoolean = 0;");
                }
                foreach (var field in fields)
                {
                    if (!field.UseBBW && bbwOffset > 0)
                    {
                        g("writer.WriteByte((Byte)wrappedBoolean);");
                        bbwOffset = 0;
                    }
                    var type = TransformType(field.Type);
                    var name = TransformName(field.Name);
                    var writeMethod = TransformName(field.WriteMethod);
                    var writeLengthMethod = TransformName(field.WriteLengthMethod);
                    var readMethod = InverseFunction(writeMethod);
                    var readLengthMethod = InverseFunction(writeLengthMethod);
                    var castedType = !writeMethod.StartsWith("WriteUnsigned") && type[0] == 'U' || type == "SByte" ? $"({type.Substring(1)})" : string.Empty;
                    if (field.IsVector)
                    {
                        g($"for (var i = 0; i < {name}.Length; i++)");
                        Bracket(g)(h =>
                        {
                            if (field.UseTypeManager || readMethod == string.Empty)
                            {
                                h($"{name}[i].Serialize(writer);");
                            }
                            else
                            {
                                h($"writer.{writeMethod}({castedType}{name}[i]);");
                            }
                        });
                    }
                    else
                    {
                        if (writeMethod == string.Empty)
                        {
                            if (field.UseBBW)
                            {
                                if (bbwOffset == 0)
                                {
                                    g($"wrappedBoolean = 0;");
                                }
                                g($"wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, {bbwOffset++}, {name});");
                            }
                            else
                            {
                                g($"{name}.Serialize(writer);");
                            }
                        }
                        else
                        {
                            g($"writer.{writeMethod}({castedType}{name});");
                        }
                    }
                }
                if (bbwOffset > 0)
                {
                    g("writer.WriteByte((Byte)wrappedBoolean);");
                }
            });
        }

        static void WriteDeserialize(string parent, Field[] fields, Action<string> f)
        {
            f($"public{(string.IsNullOrWhiteSpace(parent) ? string.Empty : " new")} void Deserialize(IDataReader reader)");
            Bracket(f)(g =>
            {
                if (!string.IsNullOrWhiteSpace(parent))
                {
                    g($"base.Deserialize(reader);");
                }
                var bbwOffset = 0;
                if (fields.Any(field => field.UseBBW))
                {
                    g($"UInt32 wrappedBoolean = 0;");
                }
                foreach (var field in fields)
                {
                    if (!field.UseBBW)
                    {
                        bbwOffset = 0;
                    }
                    var type = TransformType(field.Type);
                    var name = TransformName(field.Name);
                    var writeMethod = TransformName(field.WriteMethod);
                    var writeLengthMethod = TransformName(field.WriteLengthMethod);
                    var readMethod = InverseFunction(writeMethod);
                    var readLengthMethod = InverseFunction(writeLengthMethod);
                    var castedType = !writeMethod.StartsWith("WriteUnsigned") && type[0] == 'U' || type == "SByte" ? $"({type})" : string.Empty;
                    if (field.IsVector)
                    {
                        if (field.IsDynamicLength)
                        {
                            g($"{name} = new {type}[reader.{readLengthMethod}()];");
                        }
                        else
                        {
                            g($"{name} = new {type}[{field.Length}];");
                        }
                        g($"for (var i = 0; i < {name}.Length; i++)");
                        Bracket(g)(h =>
                        {
                            if (field.UseTypeManager || readMethod == string.Empty)
                            {
                                h($"({name}[i] = new {type}()).Deserialize(reader);");
                            }
                            else
                            {
                                h($"{name}[i] = {castedType}reader.{readMethod}();");
                            }
                        });
                    }
                    else
                    {
                        if (readMethod == string.Empty)
                        {
                            if (field.UseBBW)
                            {
                                if (bbwOffset == 0)
                                {
                                    g($"wrappedBoolean = (UInt32)reader.ReadByte();");
                                }
                                g($"{name} = BooleanByteWrapper.GetFlag(wrappedBoolean, {bbwOffset++});");
                            }
                            else
                            {
                                g($"{name} = new {type}();");
                                g($"{name}.Deserialize(reader);");
                            }
                        }
                        else
                        {
                            g($"{name} = {castedType}reader.{readMethod}();");
                        }
                    }
                }
            });
        }

        static void WriteField(Field field, Action<string> f)
        {
            f($"public {TransformType(field.Type) + (field.IsVector ? "[]" : string.Empty)} {TransformName(field.Name)} " + "{ get; set; }");
        }

        static Action<Action<string>> WriteEnum(Enum e) =>
            f =>
            {
                f($"public enum {e.Name}");
                Bracket(f)(g =>
                {
                    foreach (var constant in e.Values)
                    {
                        g($"{constant.Name} = {constant.Value},");
                    }
                });
            };

        static Action<Action<string>> WriteClass(Message message) =>
            f =>
            {
                if (message.Parent != string.Empty)
                {
                    f($"public class {message.Name} : {message.Parent}");
                }
                else
                {
                    f($"public class {message.Name}");
                }
                Bracket(f)(g =>
                {
                    if (message.Fields == null)
                    {
                        message.Fields = new Field[0];
                    }
                    foreach (var field in message.Fields)
                    {
                        WriteField(field, g);
                    }
                    WriteSerialize(message.Parent, message.Fields, g);
                    WriteDeserialize(message.Parent, message.Fields, g);
                });
            };

        static Action<Action<Action<string>>> Bracket(Action<string> f) =>
            g =>
            {
                f("{");
                g(line => f($"\t{line}"));
                f("}");
            };
    }
}
