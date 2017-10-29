using System;
namespace CodebreakV2.Protocol.Types
{
	public class TreasureHuntStepFollowDirection : TreasureHuntStep
	{
		public Byte Direction { get; set; }
		public UInt16 MapCount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Direction);
			writer.WriteVarShort((Int16)MapCount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Direction = reader.ReadByte();
			MapCount = (UInt16)reader.ReadVarShort();
		}
	}
}
