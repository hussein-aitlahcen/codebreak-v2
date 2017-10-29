using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccountHouseMessage
	{
		public AccountHouseInformations[] Houses { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Houses.Length; i++)
			{
				Houses[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Houses = new AccountHouseInformations[reader.ReadShort()];
			for (var i = 0; i < Houses.Length; i++)
			{
				(Houses[i] = new AccountHouseInformations()).Deserialize(reader);
			}
		}
	}
}
