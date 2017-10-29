using System;
namespace CodebreakV2.Protocol.Types
{
	public class AchievementStartedObjective : AchievementObjective
	{
		public UInt16 Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = (UInt16)reader.ReadVarShort();
		}
	}
}
