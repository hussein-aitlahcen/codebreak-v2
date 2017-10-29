using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffect
	{
		public UInt16 ActionId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ActionId);
		}
		public void Deserialize(IDataReader reader)
		{
			ActionId = (UInt16)reader.ReadVarShort();
		}
	}
}
