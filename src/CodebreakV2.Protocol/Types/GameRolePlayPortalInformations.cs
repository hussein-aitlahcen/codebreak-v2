using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayPortalInformations : GameRolePlayActorInformations
	{
		public PortalInformation Portal { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Portal.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Portal = new PortalInformation();
			Portal.Deserialize(reader);
		}
	}
}
