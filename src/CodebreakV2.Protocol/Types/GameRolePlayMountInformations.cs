using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
	{
		public String OwnerName { get; set; }
		public Byte Level { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(OwnerName);
			writer.WriteByte(Level);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			OwnerName = reader.ReadUTF();
			Level = reader.ReadByte();
		}
	}
}
