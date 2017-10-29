using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IgnoredListMessage
	{
		public IgnoredInformations[] IgnoredList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < IgnoredList.Length; i++)
			{
				IgnoredList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			IgnoredList = new IgnoredInformations[reader.ReadShort()];
			for (var i = 0; i < IgnoredList.Length; i++)
			{
				(IgnoredList[i] = new IgnoredInformations()).Deserialize(reader);
			}
		}
	}
}
