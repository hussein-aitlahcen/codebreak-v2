using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextMoveMultipleElementsMessage
	{
		public EntityMovementInformations[] Movements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Movements.Length; i++)
			{
				Movements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Movements = new EntityMovementInformations[reader.ReadShort()];
			for (var i = 0; i < Movements.Length; i++)
			{
				(Movements[i] = new EntityMovementInformations()).Deserialize(reader);
			}
		}
	}
}
