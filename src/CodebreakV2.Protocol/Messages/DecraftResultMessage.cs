using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DecraftResultMessage
	{
		public DecraftedItemStackInfo[] Results { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Results.Length; i++)
			{
				Results[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Results = new DecraftedItemStackInfo[reader.ReadShort()];
			for (var i = 0; i < Results.Length; i++)
			{
				(Results[i] = new DecraftedItemStackInfo()).Deserialize(reader);
			}
		}
	}
}
