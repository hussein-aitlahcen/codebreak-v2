using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class KickHavenBagRequestMessage
	{
		public Int64 GuestId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(GuestId);
		}
		public void Deserialize(IDataReader reader)
		{
			GuestId = reader.ReadVarLong();
		}
	}
}
