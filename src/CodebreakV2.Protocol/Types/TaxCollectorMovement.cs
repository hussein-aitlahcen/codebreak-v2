using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorMovement
	{
		public Byte MovementType { get; set; }
		public TaxCollectorBasicInformations BasicInfos { get; set; }
		public Int64 PlayerId { get; set; }
		public String PlayerName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(MovementType);
			BasicInfos.Serialize(writer);
			writer.WriteVarLong(PlayerId);
			writer.WriteUTF(PlayerName);
		}
		public void Deserialize(IDataReader reader)
		{
			MovementType = reader.ReadByte();
			BasicInfos = new TaxCollectorBasicInformations();
			BasicInfos.Deserialize(reader);
			PlayerId = reader.ReadVarLong();
			PlayerName = reader.ReadUTF();
		}
	}
}
