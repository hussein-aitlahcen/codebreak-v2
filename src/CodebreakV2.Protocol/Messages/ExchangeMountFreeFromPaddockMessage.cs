using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMountFreeFromPaddockMessage
	{
		public String Name { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public String Liberator { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteUTF(Liberator);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			Liberator = reader.ReadUTF();
		}
	}
}
