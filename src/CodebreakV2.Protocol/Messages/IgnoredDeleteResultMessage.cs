using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IgnoredDeleteResultMessage
	{
		public Boolean Success { get; set; }
		public String Name { get; set; }
		public Boolean Session { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Success);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteUTF(Name);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Session);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			Success = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Name = reader.ReadUTF();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Session = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
