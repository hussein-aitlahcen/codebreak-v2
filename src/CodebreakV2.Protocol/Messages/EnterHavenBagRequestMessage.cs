using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EnterHavenBagRequestMessage
	{
		public Int64 HavenBagOwner { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(HavenBagOwner);
		}
		public void Deserialize(IDataReader reader)
		{
			HavenBagOwner = reader.ReadVarLong();
		}
	}
}
