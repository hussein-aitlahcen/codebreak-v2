using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightOptionsInformations
	{
		public Boolean IsSecret { get; set; }
		public Boolean IsRestrictedToPartyOnly { get; set; }
		public Boolean IsClosed { get; set; }
		public Boolean IsAskingForHelp { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsSecret);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, IsRestrictedToPartyOnly);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, IsClosed);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 3, IsAskingForHelp);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsSecret = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			IsRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			IsClosed = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			IsAskingForHelp = BooleanByteWrapper.GetFlag(wrappedBoolean, 3);
		}
	}
}
