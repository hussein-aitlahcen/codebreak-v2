using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolSelectRequestMessage
	{
		public UInt16 IdolId { get; set; }
		public Boolean Activate { get; set; }
		public Boolean Party { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteVarShort((Int16)IdolId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Activate);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, Party);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			IdolId = (UInt16)reader.ReadVarShort();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Activate = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Party = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
