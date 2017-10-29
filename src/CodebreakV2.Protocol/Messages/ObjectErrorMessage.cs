using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectErrorMessage
	{
		public SByte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			Reason = (SByte)reader.ReadByte();
		}
	}
}
