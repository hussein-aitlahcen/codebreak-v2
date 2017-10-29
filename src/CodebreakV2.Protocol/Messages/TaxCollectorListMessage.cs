using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
	{
		public Byte NbcollectorMax { get; set; }
		public TaxCollectorFightersInformation[] FightersInformations { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(NbcollectorMax);
			for (var i = 0; i < FightersInformations.Length; i++)
			{
				FightersInformations[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NbcollectorMax = reader.ReadByte();
			FightersInformations = new TaxCollectorFightersInformation[reader.ReadShort()];
			for (var i = 0; i < FightersInformations.Length; i++)
			{
				(FightersInformations[i] = new TaxCollectorFightersInformation()).Deserialize(reader);
			}
		}
	}
}
