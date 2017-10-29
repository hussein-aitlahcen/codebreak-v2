using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
	{
		public CharacterMinimalInformations OwnerInformations { get; set; }
		public SByte Theme { get; set; }
		public Byte RoomId { get; set; }
		public Byte MaxRoomId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			OwnerInformations.Serialize(writer);
			writer.WriteByte((Byte)Theme);
			writer.WriteByte(RoomId);
			writer.WriteByte(MaxRoomId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			OwnerInformations = new CharacterMinimalInformations();
			OwnerInformations.Deserialize(reader);
			Theme = (SByte)reader.ReadByte();
			RoomId = reader.ReadByte();
			MaxRoomId = reader.ReadByte();
		}
	}
}
