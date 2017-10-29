using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StatsUpgradeRequestMessage
	{
		public Boolean UseAdditionnal { get; set; }
		public Byte StatId { get; set; }
		public UInt16 BoostPoint { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(UseAdditionnal);
			writer.WriteByte(StatId);
			writer.WriteVarShort((Int16)BoostPoint);
		}
		public void Deserialize(IDataReader reader)
		{
			UseAdditionnal = reader.ReadBoolean();
			StatId = reader.ReadByte();
			BoostPoint = (UInt16)reader.ReadVarShort();
		}
	}
}
