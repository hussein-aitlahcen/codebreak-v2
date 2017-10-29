using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpouseInformationsMessage
	{
		public FriendSpouseInformations Spouse { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Spouse.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Spouse = new FriendSpouseInformations();
			Spouse.Deserialize(reader);
		}
	}
}
