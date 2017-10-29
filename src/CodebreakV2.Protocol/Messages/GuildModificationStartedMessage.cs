using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildModificationStartedMessage
	{
		public Boolean CanChangeName { get; set; }
		public Boolean CanChangeEmblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, CanChangeName);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, CanChangeEmblem);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			CanChangeName = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			CanChangeEmblem = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
