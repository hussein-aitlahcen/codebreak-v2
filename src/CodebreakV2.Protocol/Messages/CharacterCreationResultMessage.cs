using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterCreationResultMessage
	{
		public Byte Result { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Result);
		}
		public void Deserialize(IDataReader reader)
		{
			Result = reader.ReadByte();
		}
	}
}
