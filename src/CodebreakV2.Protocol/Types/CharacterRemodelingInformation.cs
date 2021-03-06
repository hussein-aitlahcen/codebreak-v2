using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterRemodelingInformation : AbstractCharacterInformation
	{
		public String Name { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public UInt16 CosmeticId { get; set; }
		public Int32[] Colors { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
			writer.WriteVarShort((Int16)CosmeticId);
			for (var i = 0; i < Colors.Length; i++)
			{
				writer.WriteInt(Colors[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
			CosmeticId = (UInt16)reader.ReadVarShort();
			Colors = new Int32[reader.ReadShort()];
			for (var i = 0; i < Colors.Length; i++)
			{
				Colors[i] = reader.ReadInt();
			}
		}
	}
}
