using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TrustStatusMessage
	{
		public Boolean Trusted { get; set; }
		public Boolean Certified { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Trusted);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, Certified);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			Trusted = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Certified = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
