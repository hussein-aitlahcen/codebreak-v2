using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightCastOnTargetRequestMessage
	{
		public UInt16 SpellId { get; set; }
		public Double TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteDouble(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = (UInt16)reader.ReadVarShort();
			TargetId = reader.ReadDouble();
		}
	}
}
