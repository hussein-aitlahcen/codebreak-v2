using System;
namespace CodebreakV2.Protocol.Types
{
	public class AllianceFactSheetInformations : AllianceInformations
	{
		public UInt32 CreationDate { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)CreationDate);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CreationDate = (UInt32)reader.ReadInt();
		}
	}
}
