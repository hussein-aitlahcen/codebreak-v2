using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyMemberArenaInformations : PartyMemberInformations
	{
		public UInt16 Rank { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Rank);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Rank = (UInt16)reader.ReadVarShort();
		}
	}
}
