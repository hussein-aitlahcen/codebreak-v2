using System;
namespace CodebreakV2.Protocol.Types
{
	public class SkillActionDescriptionTimed : SkillActionDescription
	{
		public Byte Time { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Time);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Time = reader.ReadByte();
		}
	}
}
