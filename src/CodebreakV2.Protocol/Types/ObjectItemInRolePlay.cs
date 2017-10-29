using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemInRolePlay
	{
		public UInt16 CellId { get; set; }
		public UInt16 ObjectGID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CellId);
			writer.WriteVarShort((Int16)ObjectGID);
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = (UInt16)reader.ReadVarShort();
			ObjectGID = (UInt16)reader.ReadVarShort();
		}
	}
}
