using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountInformationInPaddockRequestMessage
	{
		public Int32 MapRideId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(MapRideId);
		}
		public void Deserialize(IDataReader reader)
		{
			MapRideId = reader.ReadVarInt();
		}
	}
}
