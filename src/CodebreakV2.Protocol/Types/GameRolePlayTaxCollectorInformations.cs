using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
	{
		public TaxCollectorStaticInformations Identification { get; set; }
		public Byte GuildLevel { get; set; }
		public Int32 TaxCollectorAttack { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Identification.Serialize(writer);
			writer.WriteByte(GuildLevel);
			writer.WriteInt(TaxCollectorAttack);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Identification = new TaxCollectorStaticInformations();
			Identification.Deserialize(reader);
			GuildLevel = reader.ReadByte();
			TaxCollectorAttack = reader.ReadInt();
		}
	}
}
