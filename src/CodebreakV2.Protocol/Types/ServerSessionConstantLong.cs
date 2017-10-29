using System;
namespace CodebreakV2.Protocol.Types
{
	public class ServerSessionConstantLong : ServerSessionConstant
	{
		public Double Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = reader.ReadDouble();
		}
	}
}
