using System;
namespace CodebreakV2.Protocol.Types
{
	public class ServerSessionConstantString : ServerSessionConstant
	{
		public String Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = reader.ReadUTF();
		}
	}
}
