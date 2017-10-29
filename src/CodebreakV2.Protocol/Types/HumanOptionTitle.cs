using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionTitle : HumanOption
	{
		public UInt16 TitleId { get; set; }
		public String TitleParam { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)TitleId);
			writer.WriteUTF(TitleParam);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TitleId = (UInt16)reader.ReadVarShort();
			TitleParam = reader.ReadUTF();
		}
	}
}
