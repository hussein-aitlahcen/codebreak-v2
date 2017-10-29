using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMountSterilizeFromPaddockMessage
	{
		public String Name { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public String Sterilizator { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteUTF(Sterilizator);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			Sterilizator = reader.ReadUTF();
		}
	}
}
