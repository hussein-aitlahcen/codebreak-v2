using System;
namespace CodebreakV2.Protocol.Types
{
	public class SkillActionDescriptionCraft : SkillActionDescription
	{
		public Byte Probability { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Probability);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Probability = reader.ReadByte();
		}
	}
}
