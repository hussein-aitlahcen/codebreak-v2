using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareSubscribedMessage
	{
		public Double DareId { get; set; }
		public Boolean Success { get; set; }
		public Boolean Subscribe { get; set; }
		public DareVersatileInformations DareVersatilesInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteDouble(DareId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Success);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, Subscribe);
			writer.WriteByte((Byte)wrappedBoolean);
			DareVersatilesInfos.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			DareId = reader.ReadDouble();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Success = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Subscribe = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			DareVersatilesInfos = new DareVersatileInformations();
			DareVersatilesInfos.Deserialize(reader);
		}
	}
}
