using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismsListMessage
	{
		public PrismSubareaEmptyInfo[] Prisms { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Prisms.Length; i++)
			{
				Prisms[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Prisms = new PrismSubareaEmptyInfo[reader.ReadShort()];
			for (var i = 0; i < Prisms.Length; i++)
			{
				(Prisms[i] = new PrismSubareaEmptyInfo()).Deserialize(reader);
			}
		}
	}
}
