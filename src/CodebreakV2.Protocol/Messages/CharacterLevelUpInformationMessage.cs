using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
	{
		public String Name { get; set; }
		public Int64 Id { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
			writer.WriteVarLong(Id);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
			Id = reader.ReadVarLong();
		}
	}
}
