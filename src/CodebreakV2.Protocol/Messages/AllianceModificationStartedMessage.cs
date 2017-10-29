using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceModificationStartedMessage
	{
		public Boolean CanChangeName { get; set; }
		public Boolean CanChangeTag { get; set; }
		public Boolean CanChangeEmblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, CanChangeName);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, CanChangeTag);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, CanChangeEmblem);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			CanChangeName = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			CanChangeTag = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			CanChangeEmblem = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
		}
	}
}
