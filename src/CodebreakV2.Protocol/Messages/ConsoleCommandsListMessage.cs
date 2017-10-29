using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ConsoleCommandsListMessage
	{
		public String[] Aliases { get; set; }
		public String[] Args { get; set; }
		public String[] Descriptions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Aliases.Length; i++)
			{
				writer.WriteUTF(Aliases[i]);
			}
			for (var i = 0; i < Args.Length; i++)
			{
				writer.WriteUTF(Args[i]);
			}
			for (var i = 0; i < Descriptions.Length; i++)
			{
				writer.WriteUTF(Descriptions[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Aliases = new String[reader.ReadShort()];
			for (var i = 0; i < Aliases.Length; i++)
			{
				Aliases[i] = reader.ReadUTF();
			}
			Args = new String[reader.ReadShort()];
			for (var i = 0; i < Args.Length; i++)
			{
				Args[i] = reader.ReadUTF();
			}
			Descriptions = new String[reader.ReadShort()];
			for (var i = 0; i < Descriptions.Length; i++)
			{
				Descriptions[i] = reader.ReadUTF();
			}
		}
	}
}
