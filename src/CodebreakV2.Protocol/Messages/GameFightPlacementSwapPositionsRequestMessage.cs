using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
	{
		public Double RequestedId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(RequestedId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			RequestedId = reader.ReadDouble();
		}
	}
}
