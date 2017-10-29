using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
	{
		public Boolean IsDungeon { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(IsDungeon);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			IsDungeon = reader.ReadBoolean();
		}
	}
}
