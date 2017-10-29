using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightStartMessage
	{
		public Idol[] Idols { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Idols.Length; i++)
			{
				Idols[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Idols = new Idol[reader.ReadShort()];
			for (var i = 0; i < Idols.Length; i++)
			{
				(Idols[i] = new Idol()).Deserialize(reader);
			}
		}
	}
}
