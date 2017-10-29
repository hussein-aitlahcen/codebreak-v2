using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
	{
		public UInt16 ShieldLoss { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)ShieldLoss);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ShieldLoss = (UInt16)reader.ReadVarShort();
		}
	}
}
