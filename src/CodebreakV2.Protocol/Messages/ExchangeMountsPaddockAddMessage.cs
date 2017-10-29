using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMountsPaddockAddMessage
	{
		public MountClientData[] MountDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < MountDescription.Length; i++)
			{
				MountDescription[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MountDescription = new MountClientData[reader.ReadShort()];
			for (var i = 0; i < MountDescription.Length; i++)
			{
				(MountDescription[i] = new MountClientData()).Deserialize(reader);
			}
		}
	}
}
