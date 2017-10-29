using System;
namespace CodebreakV2.Protocol.Types
{
	public class EntityLook
	{
		public UInt16 BonesId { get; set; }
		public UInt16[] Skins { get; set; }
		public Int32[] IndexedColors { get; set; }
		public Int16[] Scales { get; set; }
		public SubEntity[] Subentities { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)BonesId);
			for (var i = 0; i < Skins.Length; i++)
			{
				writer.WriteVarShort((Int16)Skins[i]);
			}
			for (var i = 0; i < IndexedColors.Length; i++)
			{
				writer.WriteInt(IndexedColors[i]);
			}
			for (var i = 0; i < Scales.Length; i++)
			{
				writer.WriteVarShort(Scales[i]);
			}
			for (var i = 0; i < Subentities.Length; i++)
			{
				Subentities[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			BonesId = (UInt16)reader.ReadVarShort();
			Skins = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Skins.Length; i++)
			{
				Skins[i] = (UInt16)reader.ReadVarShort();
			}
			IndexedColors = new Int32[reader.ReadShort()];
			for (var i = 0; i < IndexedColors.Length; i++)
			{
				IndexedColors[i] = reader.ReadInt();
			}
			Scales = new Int16[reader.ReadShort()];
			for (var i = 0; i < Scales.Length; i++)
			{
				Scales[i] = reader.ReadVarShort();
			}
			Subentities = new SubEntity[reader.ReadShort()];
			for (var i = 0; i < Subentities.Length; i++)
			{
				(Subentities[i] = new SubEntity()).Deserialize(reader);
			}
		}
	}
}
