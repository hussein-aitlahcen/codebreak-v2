using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMountsTakenFromPaddockMessage
	{
		public String Name { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public String Ownername { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteUTF(Ownername);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			Ownername = reader.ReadUTF();
		}
	}
}
