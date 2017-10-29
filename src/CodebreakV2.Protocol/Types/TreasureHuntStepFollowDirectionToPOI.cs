using System;
namespace CodebreakV2.Protocol.Types
{
	public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
	{
		public Byte Direction { get; set; }
		public UInt16 PoiLabelId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Direction);
			writer.WriteVarShort((Int16)PoiLabelId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Direction = reader.ReadByte();
			PoiLabelId = (UInt16)reader.ReadVarShort();
		}
	}
}
