using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LockableStateUpdateAbstractMessage
	{
		public Boolean Locked { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Locked);
		}
		public void Deserialize(IDataReader reader)
		{
			Locked = reader.ReadBoolean();
		}
	}
}
