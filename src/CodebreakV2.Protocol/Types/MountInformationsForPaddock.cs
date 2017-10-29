using System;
namespace CodebreakV2.Protocol.Types
{
	public class MountInformationsForPaddock
	{
		public UInt16 ModelId { get; set; }
		public String Name { get; set; }
		public String OwnerName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ModelId);
			writer.WriteUTF(Name);
			writer.WriteUTF(OwnerName);
		}
		public void Deserialize(IDataReader reader)
		{
			ModelId = (UInt16)reader.ReadVarShort();
			Name = reader.ReadUTF();
			OwnerName = reader.ReadUTF();
		}
	}
}
