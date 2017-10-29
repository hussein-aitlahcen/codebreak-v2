using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LockableUseCodeMessage
	{
		public String Code { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Code);
		}
		public void Deserialize(IDataReader reader)
		{
			Code = reader.ReadUTF();
		}
	}
}
