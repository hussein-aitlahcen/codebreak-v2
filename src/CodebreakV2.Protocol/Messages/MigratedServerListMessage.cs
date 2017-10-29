using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MigratedServerListMessage
	{
		public UInt16[] MigratedServerIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < MigratedServerIds.Length; i++)
			{
				writer.WriteVarShort((Int16)MigratedServerIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MigratedServerIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < MigratedServerIds.Length; i++)
			{
				MigratedServerIds[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
