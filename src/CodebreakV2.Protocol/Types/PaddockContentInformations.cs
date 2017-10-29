using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockContentInformations : PaddockInformations
	{
		public Double PaddockId { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public Boolean Abandonned { get; set; }
		public MountInformationsForPaddock[] MountsInformations { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(PaddockId);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteBoolean(Abandonned);
			for (var i = 0; i < MountsInformations.Length; i++)
			{
				MountsInformations[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PaddockId = reader.ReadDouble();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			Abandonned = reader.ReadBoolean();
			MountsInformations = new MountInformationsForPaddock[reader.ReadShort()];
			for (var i = 0; i < MountsInformations.Length; i++)
			{
				(MountsInformations[i] = new MountInformationsForPaddock()).Deserialize(reader);
			}
		}
	}
}
