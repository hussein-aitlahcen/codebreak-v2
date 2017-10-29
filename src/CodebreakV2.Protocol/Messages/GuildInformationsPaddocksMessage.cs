using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInformationsPaddocksMessage
	{
		public Byte NbPaddockMax { get; set; }
		public PaddockContentInformations[] PaddocksInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(NbPaddockMax);
			for (var i = 0; i < PaddocksInformations.Length; i++)
			{
				PaddocksInformations[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			NbPaddockMax = reader.ReadByte();
			PaddocksInformations = new PaddockContentInformations[reader.ReadShort()];
			for (var i = 0; i < PaddocksInformations.Length; i++)
			{
				(PaddocksInformations[i] = new PaddockContentInformations()).Deserialize(reader);
			}
		}
	}
}
