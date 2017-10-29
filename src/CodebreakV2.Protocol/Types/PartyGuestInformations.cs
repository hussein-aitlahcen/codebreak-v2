using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyGuestInformations
	{
		public Int64 GuestId { get; set; }
		public Int64 HostId { get; set; }
		public String Name { get; set; }
		public EntityLook GuestLook { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public PlayerStatus Status { get; set; }
		public PartyCompanionBaseInformations[] Companions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(GuestId);
			writer.WriteVarLong(HostId);
			writer.WriteUTF(Name);
			GuestLook.Serialize(writer);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
			Status.Serialize(writer);
			for (var i = 0; i < Companions.Length; i++)
			{
				Companions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			GuestId = reader.ReadVarLong();
			HostId = reader.ReadVarLong();
			Name = reader.ReadUTF();
			GuestLook = new EntityLook();
			GuestLook.Deserialize(reader);
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
			Companions = new PartyCompanionBaseInformations[reader.ReadShort()];
			for (var i = 0; i < Companions.Length; i++)
			{
				(Companions[i] = new PartyCompanionBaseInformations()).Deserialize(reader);
			}
		}
	}
}
