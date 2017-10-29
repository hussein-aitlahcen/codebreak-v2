using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
	{
		public MountClientData[] PaddockedMountsDescription { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < PaddockedMountsDescription.Length; i++)
			{
				PaddockedMountsDescription[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PaddockedMountsDescription = new MountClientData[reader.ReadShort()];
			for (var i = 0; i < PaddockedMountsDescription.Length; i++)
			{
				(PaddockedMountsDescription[i] = new MountClientData()).Deserialize(reader);
			}
		}
	}
}
