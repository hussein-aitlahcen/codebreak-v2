using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DownloadErrorMessage
	{
		public Byte ErrorId { get; set; }
		public String Message { get; set; }
		public String HelpUrl { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ErrorId);
			writer.WriteUTF(Message);
			writer.WriteUTF(HelpUrl);
		}
		public void Deserialize(IDataReader reader)
		{
			ErrorId = reader.ReadByte();
			Message = reader.ReadUTF();
			HelpUrl = reader.ReadUTF();
		}
	}
}
