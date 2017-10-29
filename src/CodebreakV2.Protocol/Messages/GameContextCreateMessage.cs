using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextCreateMessage
	{
		public Byte Context { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Context);
		}
		public void Deserialize(IDataReader reader)
		{
			Context = reader.ReadByte();
		}
	}
}
