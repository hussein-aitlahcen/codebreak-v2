using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareCreatedListMessage
	{
		public DareInformations[] DaresFixedInfos { get; set; }
		public DareVersatileInformations[] DaresVersatilesInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < DaresFixedInfos.Length; i++)
			{
				DaresFixedInfos[i].Serialize(writer);
			}
			for (var i = 0; i < DaresVersatilesInfos.Length; i++)
			{
				DaresVersatilesInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			DaresFixedInfos = new DareInformations[reader.ReadShort()];
			for (var i = 0; i < DaresFixedInfos.Length; i++)
			{
				(DaresFixedInfos[i] = new DareInformations()).Deserialize(reader);
			}
			DaresVersatilesInfos = new DareVersatileInformations[reader.ReadShort()];
			for (var i = 0; i < DaresVersatilesInfos.Length; i++)
			{
				(DaresVersatilesInfos[i] = new DareVersatileInformations()).Deserialize(reader);
			}
		}
	}
}
