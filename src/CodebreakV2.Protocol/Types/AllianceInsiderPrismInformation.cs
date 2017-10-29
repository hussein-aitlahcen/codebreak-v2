using System;
namespace CodebreakV2.Protocol.Types
{
	public class AllianceInsiderPrismInformation : PrismInformation
	{
		public UInt32 LastTimeSlotModificationDate { get; set; }
		public UInt32 LastTimeSlotModificationAuthorGuildId { get; set; }
		public Int64 LastTimeSlotModificationAuthorId { get; set; }
		public String LastTimeSlotModificationAuthorName { get; set; }
		public ObjectItem[] ModulesObjects { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)LastTimeSlotModificationDate);
			writer.WriteVarInt((Int32)LastTimeSlotModificationAuthorGuildId);
			writer.WriteVarLong(LastTimeSlotModificationAuthorId);
			writer.WriteUTF(LastTimeSlotModificationAuthorName);
			for (var i = 0; i < ModulesObjects.Length; i++)
			{
				ModulesObjects[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			LastTimeSlotModificationDate = (UInt32)reader.ReadInt();
			LastTimeSlotModificationAuthorGuildId = (UInt32)reader.ReadVarInt();
			LastTimeSlotModificationAuthorId = reader.ReadVarLong();
			LastTimeSlotModificationAuthorName = reader.ReadUTF();
			ModulesObjects = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < ModulesObjects.Length; i++)
			{
				(ModulesObjects[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
