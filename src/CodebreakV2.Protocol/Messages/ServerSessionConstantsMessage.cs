using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerSessionConstantsMessage
	{
		public ServerSessionConstant[] Variables { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Variables.Length; i++)
			{
				Variables[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Variables = new ServerSessionConstant[reader.ReadShort()];
			for (var i = 0; i < Variables.Length; i++)
			{
				(Variables[i] = new ServerSessionConstant()).Deserialize(reader);
			}
		}
	}
}
