using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SymbioticObjectErrorMessage : ObjectErrorMessage
	{
		public SByte ErrorCode { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte((Byte)ErrorCode);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ErrorCode = (SByte)reader.ReadByte();
		}
	}
}
