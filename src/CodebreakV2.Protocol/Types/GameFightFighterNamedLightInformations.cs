using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
	{
		public String Name { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
		}
	}
}
