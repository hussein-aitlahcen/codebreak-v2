using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeErrorMessage
	{
		public SByte ErrorType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)ErrorType);
		}
		public void Deserialize(IDataReader reader)
		{
			ErrorType = (SByte)reader.ReadByte();
		}
	}
}
