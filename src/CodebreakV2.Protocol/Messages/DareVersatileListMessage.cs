using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareVersatileListMessage
	{
		public DareVersatileInformations[] Dares { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Dares.Length; i++)
			{
				Dares[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Dares = new DareVersatileInformations[reader.ReadShort()];
			for (var i = 0; i < Dares.Length; i++)
			{
				(Dares[i] = new DareVersatileInformations()).Deserialize(reader);
			}
		}
	}
}
