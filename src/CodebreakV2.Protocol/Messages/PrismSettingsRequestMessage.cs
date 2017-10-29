using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismSettingsRequestMessage
	{
		public UInt16 SubAreaId { get; set; }
		public Byte StartDefenseTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteByte(StartDefenseTime);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			StartDefenseTime = reader.ReadByte();
		}
	}
}
