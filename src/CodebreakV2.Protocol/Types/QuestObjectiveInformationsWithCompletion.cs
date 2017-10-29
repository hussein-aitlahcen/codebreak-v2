using System;
namespace CodebreakV2.Protocol.Types
{
	public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
	{
		public UInt16 CurCompletion { get; set; }
		public UInt16 MaxCompletion { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)CurCompletion);
			writer.WriteVarShort((Int16)MaxCompletion);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CurCompletion = (UInt16)reader.ReadVarShort();
			MaxCompletion = (UInt16)reader.ReadVarShort();
		}
	}
}
