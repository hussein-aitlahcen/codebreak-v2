using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SetCharacterRestrictionsMessage
	{
		public Double ActorId { get; set; }
		public ActorRestrictionsInformations Restrictions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(ActorId);
			Restrictions.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ActorId = reader.ReadDouble();
			Restrictions = new ActorRestrictionsInformations();
			Restrictions.Deserialize(reader);
		}
	}
}
