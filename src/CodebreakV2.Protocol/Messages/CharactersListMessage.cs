using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharactersListMessage : BasicCharactersListMessage
	{
		public Boolean HasStartupActions { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(HasStartupActions);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			HasStartupActions = reader.ReadBoolean();
		}
	}
}
