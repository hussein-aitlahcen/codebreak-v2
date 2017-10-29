using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterCreationRequestMessage
	{
		public String Name { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public Int32[] Colors { get; set; }
		public UInt16 CosmeticId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
			for (var i = 0; i < Colors.Length; i++)
			{
				writer.WriteInt(Colors[i]);
			}
			writer.WriteVarShort((Int16)CosmeticId);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
			Colors = new Int32[5];
			for (var i = 0; i < Colors.Length; i++)
			{
				Colors[i] = reader.ReadInt();
			}
			CosmeticId = (UInt16)reader.ReadVarShort();
		}
	}
}
