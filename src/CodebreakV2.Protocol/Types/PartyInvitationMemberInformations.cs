using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyInvitationMemberInformations : CharacterBaseInformations
	{
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public UInt16 SubAreaId { get; set; }
		public PartyCompanionBaseInformations[] Companions { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			writer.WriteVarShort((Int16)SubAreaId);
			for (var i = 0; i < Companions.Length; i++)
			{
				Companions[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			SubAreaId = (UInt16)reader.ReadVarShort();
			Companions = new PartyCompanionBaseInformations[reader.ReadShort()];
			for (var i = 0; i < Companions.Length; i++)
			{
				(Companions[i] = new PartyCompanionBaseInformations()).Deserialize(reader);
			}
		}
	}
}
