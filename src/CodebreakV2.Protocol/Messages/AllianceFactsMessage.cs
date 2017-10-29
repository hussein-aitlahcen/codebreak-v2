using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceFactsMessage
	{
		public AllianceFactSheetInformations Infos { get; set; }
		public GuildInAllianceInformations[] Guilds { get; set; }
		public UInt16[] ControlledSubareaIds { get; set; }
		public Int64 LeaderCharacterId { get; set; }
		public String LeaderCharacterName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Infos.Serialize(writer);
			for (var i = 0; i < Guilds.Length; i++)
			{
				Guilds[i].Serialize(writer);
			}
			for (var i = 0; i < ControlledSubareaIds.Length; i++)
			{
				writer.WriteVarShort((Int16)ControlledSubareaIds[i]);
			}
			writer.WriteVarLong(LeaderCharacterId);
			writer.WriteUTF(LeaderCharacterName);
		}
		public void Deserialize(IDataReader reader)
		{
			Infos = new AllianceFactSheetInformations();
			Infos.Deserialize(reader);
			Guilds = new GuildInAllianceInformations[reader.ReadShort()];
			for (var i = 0; i < Guilds.Length; i++)
			{
				(Guilds[i] = new GuildInAllianceInformations()).Deserialize(reader);
			}
			ControlledSubareaIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < ControlledSubareaIds.Length; i++)
			{
				ControlledSubareaIds[i] = (UInt16)reader.ReadVarShort();
			}
			LeaderCharacterId = reader.ReadVarLong();
			LeaderCharacterName = reader.ReadUTF();
		}
	}
}
