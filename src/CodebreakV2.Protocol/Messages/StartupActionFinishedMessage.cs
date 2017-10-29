using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StartupActionFinishedMessage
	{
		public Boolean Success { get; set; }
		public UInt32 ActionId { get; set; }
		public Boolean AutomaticAction { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Success);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteInt((Int32)ActionId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, AutomaticAction);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			Success = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ActionId = (UInt32)reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			AutomaticAction = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
