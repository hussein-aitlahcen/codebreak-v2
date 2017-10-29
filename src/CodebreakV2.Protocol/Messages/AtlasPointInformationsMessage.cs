using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AtlasPointInformationsMessage
	{
		public AtlasPointsInformations Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Type.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = new AtlasPointsInformations();
			Type.Deserialize(reader);
		}
	}
}
