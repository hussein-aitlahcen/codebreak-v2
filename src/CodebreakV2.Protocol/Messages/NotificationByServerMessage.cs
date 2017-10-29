using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NotificationByServerMessage
	{
		public UInt16 Id { get; set; }
		public String[] Parameters { get; set; }
		public Boolean ForceOpen { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
			for (var i = 0; i < Parameters.Length; i++)
			{
				writer.WriteUTF(Parameters[i]);
			}
			writer.WriteBoolean(ForceOpen);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
			Parameters = new String[reader.ReadShort()];
			for (var i = 0; i < Parameters.Length; i++)
			{
				Parameters[i] = reader.ReadUTF();
			}
			ForceOpen = reader.ReadBoolean();
		}
	}
}
