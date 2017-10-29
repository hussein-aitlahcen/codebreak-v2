using System;
namespace CodebreakV2.Protocol.Types
{
	public class InteractiveElementNamedSkill : InteractiveElementSkill
	{
		public UInt32 NameId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)NameId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NameId = (UInt32)reader.ReadVarInt();
		}
	}
}
