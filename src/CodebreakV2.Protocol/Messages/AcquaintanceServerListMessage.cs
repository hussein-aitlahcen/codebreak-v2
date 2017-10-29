using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AcquaintanceServerListMessage
	{
		public UInt16[] Servers { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Servers.Length; i++)
			{
				writer.WriteVarShort((Int16)Servers[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Servers = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Servers.Length; i++)
			{
				Servers[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
