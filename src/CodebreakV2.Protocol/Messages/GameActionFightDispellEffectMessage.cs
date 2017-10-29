using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
	{
		public UInt32 BoostUID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)BoostUID);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			BoostUID = (UInt32)reader.ReadInt();
		}
	}
}
