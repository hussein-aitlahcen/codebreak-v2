using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterFirstSelectionMessage : CharacterSelectionMessage
	{
		public Boolean DoTutorial { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(DoTutorial);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DoTutorial = reader.ReadBoolean();
		}
	}
}
