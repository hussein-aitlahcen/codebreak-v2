using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DungeonKeyRingMessage
	{
		public UInt16[] Availables { get; set; }
		public UInt16[] Unavailables { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Availables.Length; i++)
			{
				writer.WriteVarShort((Int16)Availables[i]);
			}
			for (var i = 0; i < Unavailables.Length; i++)
			{
				writer.WriteVarShort((Int16)Unavailables[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Availables = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Availables.Length; i++)
			{
				Availables[i] = (UInt16)reader.ReadVarShort();
			}
			Unavailables = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Unavailables.Length; i++)
			{
				Unavailables[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
