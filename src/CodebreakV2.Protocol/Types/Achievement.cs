using System;
namespace CodebreakV2.Protocol.Types
{
	public class Achievement
	{
		public UInt16 Id { get; set; }
		public AchievementObjective[] FinishedObjective { get; set; }
		public AchievementStartedObjective[] StartedObjectives { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
			for (var i = 0; i < FinishedObjective.Length; i++)
			{
				FinishedObjective[i].Serialize(writer);
			}
			for (var i = 0; i < StartedObjectives.Length; i++)
			{
				StartedObjectives[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
			FinishedObjective = new AchievementObjective[reader.ReadShort()];
			for (var i = 0; i < FinishedObjective.Length; i++)
			{
				(FinishedObjective[i] = new AchievementObjective()).Deserialize(reader);
			}
			StartedObjectives = new AchievementStartedObjective[reader.ReadShort()];
			for (var i = 0; i < StartedObjectives.Length; i++)
			{
				(StartedObjectives[i] = new AchievementStartedObjective()).Deserialize(reader);
			}
		}
	}
}
