using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextKickMessage
	{
		public Double TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			TargetId = reader.ReadDouble();
		}
	}
}
