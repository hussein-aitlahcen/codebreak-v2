using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
	{
		public AbstractFightDispellableEffect Effect { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Effect.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Effect = new AbstractFightDispellableEffect();
			Effect.Deserialize(reader);
		}
	}
}
