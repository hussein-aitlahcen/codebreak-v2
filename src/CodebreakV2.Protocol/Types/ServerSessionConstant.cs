using System;
namespace CodebreakV2.Protocol.Types
{
	public class ServerSessionConstant
	{
		public UInt16 Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
		}
	}
}
