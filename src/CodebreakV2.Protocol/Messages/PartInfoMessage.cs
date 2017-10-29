using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartInfoMessage
	{
		public ContentPart Part { get; set; }
		public Single InstallationPercent { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Part.Serialize(writer);
			writer.WriteFloat(InstallationPercent);
		}
		public void Deserialize(IDataReader reader)
		{
			Part = new ContentPart();
			Part.Deserialize(reader);
			InstallationPercent = reader.ReadFloat();
		}
	}
}
