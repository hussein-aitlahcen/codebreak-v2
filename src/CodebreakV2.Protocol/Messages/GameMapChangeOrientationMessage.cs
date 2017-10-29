using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapChangeOrientationMessage
	{
		public ActorOrientation Orientation { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Orientation.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Orientation = new ActorOrientation();
			Orientation.Deserialize(reader);
		}
	}
}
