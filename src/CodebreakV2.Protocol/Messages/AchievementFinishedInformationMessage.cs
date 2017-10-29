using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementFinishedInformationMessage : AchievementFinishedMessage
	{
		public String Name { get; set; }
		public Int64 PlayerId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
			writer.WriteVarLong(PlayerId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
			PlayerId = reader.ReadVarLong();
		}
	}
}
