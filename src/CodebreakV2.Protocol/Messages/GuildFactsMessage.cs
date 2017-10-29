using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFactsMessage
	{
		public GuildFactSheetInformations Infos { get; set; }
		public UInt32 CreationDate { get; set; }
		public UInt16 NbTaxCollectors { get; set; }
		public CharacterMinimalInformations[] Members { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Infos.Serialize(writer);
			writer.WriteInt((Int32)CreationDate);
			writer.WriteVarShort((Int16)NbTaxCollectors);
			for (var i = 0; i < Members.Length; i++)
			{
				Members[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Infos = new GuildFactSheetInformations();
			Infos.Deserialize(reader);
			CreationDate = (UInt32)reader.ReadInt();
			NbTaxCollectors = (UInt16)reader.ReadVarShort();
			Members = new CharacterMinimalInformations[reader.ReadShort()];
			for (var i = 0; i < Members.Length; i++)
			{
				(Members[i] = new CharacterMinimalInformations()).Deserialize(reader);
			}
		}
	}
}
