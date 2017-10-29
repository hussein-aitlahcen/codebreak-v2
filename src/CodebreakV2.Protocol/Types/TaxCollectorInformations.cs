using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorInformations
	{
		public Double UniqueId { get; set; }
		public UInt16 FirtNameId { get; set; }
		public UInt16 LastNameId { get; set; }
		public AdditionalTaxCollectorInformations AdditionalInfos { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public UInt16 SubAreaId { get; set; }
		public Byte State { get; set; }
		public EntityLook Look { get; set; }
		public TaxCollectorComplementaryInformations[] Complements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(UniqueId);
			writer.WriteVarShort((Int16)FirtNameId);
			writer.WriteVarShort((Int16)LastNameId);
			AdditionalInfos.Serialize(writer);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteByte(State);
			Look.Serialize(writer);
			for (var i = 0; i < Complements.Length; i++)
			{
				Complements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			UniqueId = reader.ReadDouble();
			FirtNameId = (UInt16)reader.ReadVarShort();
			LastNameId = (UInt16)reader.ReadVarShort();
			AdditionalInfos = new AdditionalTaxCollectorInformations();
			AdditionalInfos.Deserialize(reader);
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			SubAreaId = (UInt16)reader.ReadVarShort();
			State = reader.ReadByte();
			Look = new EntityLook();
			Look.Deserialize(reader);
			Complements = new TaxCollectorComplementaryInformations[reader.ReadShort()];
			for (var i = 0; i < Complements.Length; i++)
			{
				(Complements[i] = new TaxCollectorComplementaryInformations()).Deserialize(reader);
			}
		}
	}
}
