using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LockableShowCodeDialogMessage
	{
		public Boolean ChangeOrUse { get; set; }
		public Byte CodeSize { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(ChangeOrUse);
			writer.WriteByte(CodeSize);
		}
		public void Deserialize(IDataReader reader)
		{
			ChangeOrUse = reader.ReadBoolean();
			CodeSize = reader.ReadByte();
		}
	}
}
