using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkMountWithOutPaddockMessage
	{
		public MountClientData[] StabledMountsDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < StabledMountsDescription.Length; i++)
			{
				StabledMountsDescription[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			StabledMountsDescription = new MountClientData[reader.ReadShort()];
			for (var i = 0; i < StabledMountsDescription.Length; i++)
			{
				(StabledMountsDescription[i] = new MountClientData()).Deserialize(reader);
			}
		}
	}
}
