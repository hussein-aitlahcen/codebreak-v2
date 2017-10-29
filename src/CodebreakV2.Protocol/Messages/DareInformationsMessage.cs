using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareInformationsMessage
	{
		public DareInformations DareFixedInfos { get; set; }
		public DareVersatileInformations DareVersatilesInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			DareFixedInfos.Serialize(writer);
			DareVersatilesInfos.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			DareFixedInfos = new DareInformations();
			DareFixedInfos.Deserialize(reader);
			DareVersatilesInfos = new DareVersatileInformations();
			DareVersatilesInfos.Deserialize(reader);
		}
	}
}
