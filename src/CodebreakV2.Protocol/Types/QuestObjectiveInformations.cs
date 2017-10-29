using System;
namespace CodebreakV2.Protocol.Types
{
	public class QuestObjectiveInformations
	{
		public UInt16 ObjectiveId { get; set; }
		public Boolean ObjectiveStatus { get; set; }
		public String[] DialogParams { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ObjectiveId);
			writer.WriteBoolean(ObjectiveStatus);
			for (var i = 0; i < DialogParams.Length; i++)
			{
				writer.WriteUTF(DialogParams[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectiveId = (UInt16)reader.ReadVarShort();
			ObjectiveStatus = reader.ReadBoolean();
			DialogParams = new String[reader.ReadShort()];
			for (var i = 0; i < DialogParams.Length; i++)
			{
				DialogParams[i] = reader.ReadUTF();
			}
		}
	}
}
