using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountEquipedErrorMessage
	{
		public Byte ErrorType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ErrorType);
		}
		public void Deserialize(IDataReader reader)
		{
			ErrorType = reader.ReadByte();
		}
	}
}
