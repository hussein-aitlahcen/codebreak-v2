using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class UpdateMountBoostMessage
	{
		public Int32 RideId { get; set; }
		public UpdateMountBoost[] BoostToUpdateList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(RideId);
			for (var i = 0; i < BoostToUpdateList.Length; i++)
			{
				BoostToUpdateList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			RideId = reader.ReadVarInt();
			BoostToUpdateList = new UpdateMountBoost[reader.ReadShort()];
			for (var i = 0; i < BoostToUpdateList.Length; i++)
			{
				(BoostToUpdateList[i] = new UpdateMountBoost()).Deserialize(reader);
			}
		}
	}
}
