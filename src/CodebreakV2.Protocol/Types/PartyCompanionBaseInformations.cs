using System;
namespace CodebreakV2.Protocol.Types
{
	public class PartyCompanionBaseInformations
	{
		public Byte IndexId { get; set; }
		public Byte CompanionGenericId { get; set; }
		public EntityLook EntityLook { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(IndexId);
			writer.WriteByte(CompanionGenericId);
			EntityLook.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			IndexId = reader.ReadByte();
			CompanionGenericId = reader.ReadByte();
			EntityLook = new EntityLook();
			EntityLook.Deserialize(reader);
		}
	}
}
