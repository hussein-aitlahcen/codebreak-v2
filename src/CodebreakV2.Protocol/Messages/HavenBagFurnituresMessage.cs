using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HavenBagFurnituresMessage
	{
		public HavenBagFurnitureInformation[] FurnituresInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < FurnituresInfos.Length; i++)
			{
				FurnituresInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FurnituresInfos = new HavenBagFurnitureInformation[reader.ReadShort()];
			for (var i = 0; i < FurnituresInfos.Length; i++)
			{
				(FurnituresInfos[i] = new HavenBagFurnitureInformation()).Deserialize(reader);
			}
		}
	}
}
