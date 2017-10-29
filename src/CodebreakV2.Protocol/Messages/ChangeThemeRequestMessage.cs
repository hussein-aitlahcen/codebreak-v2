using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChangeThemeRequestMessage
	{
		public SByte Theme { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)Theme);
		}
		public void Deserialize(IDataReader reader)
		{
			Theme = (SByte)reader.ReadByte();
		}
	}
}
