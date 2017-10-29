using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class UpdateSelfAgressableStatusMessage
	{
		public Byte Status { get; set; }
		public UInt32 ProbationTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Status);
			writer.WriteInt((Int32)ProbationTime);
		}
		public void Deserialize(IDataReader reader)
		{
			Status = reader.ReadByte();
			ProbationTime = (UInt32)reader.ReadInt();
		}
	}
}
