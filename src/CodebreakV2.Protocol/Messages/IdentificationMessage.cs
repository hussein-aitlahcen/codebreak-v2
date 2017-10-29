using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationMessage
	{
		public VersionExtended Version { get; set; }
		public String Lang { get; set; }
		public SByte[] Credentials { get; set; }
		public Int16 ServerId { get; set; }
		public Boolean Autoconnect { get; set; }
		public Boolean UseCertificate { get; set; }
		public Boolean UseLoginToken { get; set; }
		public Int64 SessionOptionalSalt { get; set; }
		public UInt16[] FailedAttempts { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			Version.Serialize(writer);
			writer.WriteUTF(Lang);
			for (var i = 0; i < Credentials.Length; i++)
			{
				writer.WriteByte((Byte)Credentials[i]);
			}
			writer.WriteShort(ServerId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Autoconnect);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, UseCertificate);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, UseLoginToken);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(SessionOptionalSalt);
			for (var i = 0; i < FailedAttempts.Length; i++)
			{
				writer.WriteVarShort((Int16)FailedAttempts[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			Version = new VersionExtended();
			Version.Deserialize(reader);
			Lang = reader.ReadUTF();
			Credentials = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Credentials.Length; i++)
			{
				Credentials[i] = (SByte)reader.ReadByte();
			}
			ServerId = reader.ReadShort();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Autoconnect = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			UseCertificate = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			UseLoginToken = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			SessionOptionalSalt = reader.ReadVarLong();
			FailedAttempts = new UInt16[reader.ReadShort()];
			for (var i = 0; i < FailedAttempts.Length; i++)
			{
				FailedAttempts[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
