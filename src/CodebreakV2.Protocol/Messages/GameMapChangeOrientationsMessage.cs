using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapChangeOrientationsMessage
	{
		public ActorOrientation[] Orientations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Orientations.Length; i++)
			{
				Orientations[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Orientations = new ActorOrientation[reader.ReadShort()];
			for (var i = 0; i < Orientations.Length; i++)
			{
				(Orientations[i] = new ActorOrientation()).Deserialize(reader);
			}
		}
	}
}
