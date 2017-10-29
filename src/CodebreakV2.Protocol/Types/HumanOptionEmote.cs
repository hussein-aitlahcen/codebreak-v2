using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionEmote : HumanOption
	{
		public Byte EmoteId { get; set; }
		public Double EmoteStartTime { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(EmoteId);
			writer.WriteDouble(EmoteStartTime);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			EmoteId = reader.ReadByte();
			EmoteStartTime = reader.ReadDouble();
		}
	}
}
