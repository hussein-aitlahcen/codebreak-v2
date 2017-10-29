using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StatsUpgradeResultMessage
	{
		public SByte Result { get; set; }
		public UInt16 NbCharacBoost { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)Result);
			writer.WriteVarShort((Int16)NbCharacBoost);
		}
		public void Deserialize(IDataReader reader)
		{
			Result = (SByte)reader.ReadByte();
			NbCharacBoost = (UInt16)reader.ReadVarShort();
		}
	}
}
