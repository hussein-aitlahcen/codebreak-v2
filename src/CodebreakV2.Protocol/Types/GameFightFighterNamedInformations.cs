using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterNamedInformations : GameFightFighterInformations
	{
		public String Name { get; set; }
		public PlayerStatus Status { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
			Status.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
		}
	}
}
