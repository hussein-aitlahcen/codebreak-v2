using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyIdol : Idol
	{
		public Int64[] OwnersIds { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < OwnersIds.Length; i++)
			{
				writer.WriteVarLong(OwnersIds[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			OwnersIds = new Int64[reader.ReadShort()];
			for (var i = 0; i < OwnersIds.Length; i++)
			{
				OwnersIds[i] = reader.ReadVarLong();
			}
		}
	}
}
