using System;
namespace CodebreakV2.Protocol.Types
{
	public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
	{
		public Byte Direction { get; set; }
		public UInt16 NpcId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Direction);
			writer.WriteVarShort((Int16)NpcId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Direction = reader.ReadByte();
			NpcId = (UInt16)reader.ReadVarShort();
		}
	}
}
