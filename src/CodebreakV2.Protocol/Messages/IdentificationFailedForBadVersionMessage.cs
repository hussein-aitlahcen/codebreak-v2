using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
	{
		public CodebreakV2.Protocol.Types.Version RequiredVersion { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			RequiredVersion.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			RequiredVersion = new CodebreakV2.Protocol.Types.Version();
			RequiredVersion.Deserialize(reader);
		}
	}
}
