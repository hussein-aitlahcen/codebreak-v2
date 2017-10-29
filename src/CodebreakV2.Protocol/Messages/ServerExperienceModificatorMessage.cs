using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerExperienceModificatorMessage
	{
		public UInt16 ExperiencePercent { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ExperiencePercent);
		}
		public void Deserialize(IDataReader reader)
		{
			ExperiencePercent = (UInt16)reader.ReadVarShort();
		}
	}
}
