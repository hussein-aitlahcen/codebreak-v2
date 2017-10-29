using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuestModeMessage
	{
		public Boolean Active { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Active);
		}
		public void Deserialize(IDataReader reader)
		{
			Active = reader.ReadBoolean();
		}
	}
}
