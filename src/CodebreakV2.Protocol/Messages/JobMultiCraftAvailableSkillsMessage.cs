using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
	{
		public Int64 PlayerId { get; set; }
		public UInt16[] Skills { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(PlayerId);
			for (var i = 0; i < Skills.Length; i++)
			{
				writer.WriteVarShort((Int16)Skills[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PlayerId = reader.ReadVarLong();
			Skills = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Skills.Length; i++)
			{
				Skills[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
