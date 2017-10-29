using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayPrismInformations : GameRolePlayActorInformations
	{
		public PrismInformation Prism { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Prism.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Prism = new PrismInformation();
			Prism.Deserialize(reader);
		}
	}
}
