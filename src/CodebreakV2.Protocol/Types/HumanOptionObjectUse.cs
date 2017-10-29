using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionObjectUse : HumanOption
	{
		public Byte DelayTypeId { get; set; }
		public Double DelayEndTime { get; set; }
		public UInt16 ObjectGID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(DelayTypeId);
			writer.WriteDouble(DelayEndTime);
			writer.WriteVarShort((Int16)ObjectGID);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DelayTypeId = reader.ReadByte();
			DelayEndTime = reader.ReadDouble();
			ObjectGID = (UInt16)reader.ReadVarShort();
		}
	}
}
