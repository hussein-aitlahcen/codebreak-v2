using System;
namespace CodebreakV2.Protocol.Types
{
	public class IgnoredInformations : AbstractContactInformations
	{
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}
