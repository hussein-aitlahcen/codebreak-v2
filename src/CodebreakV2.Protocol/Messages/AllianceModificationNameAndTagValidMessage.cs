using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceModificationNameAndTagValidMessage
	{
		public String AllianceName { get; set; }
		public String AllianceTag { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(AllianceName);
			writer.WriteUTF(AllianceTag);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceName = reader.ReadUTF();
			AllianceTag = reader.ReadUTF();
		}
	}
}
