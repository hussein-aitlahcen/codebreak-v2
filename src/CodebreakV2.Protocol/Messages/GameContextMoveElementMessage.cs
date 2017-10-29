using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextMoveElementMessage
	{
		public EntityMovementInformations Movement { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Movement.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Movement = new EntityMovementInformations();
			Movement.Deserialize(reader);
		}
	}
}
