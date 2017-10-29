using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectMount : ObjectEffect
	{
		public UInt32 MountId { get; set; }
		public Double Date { get; set; }
		public UInt16 ModelId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)MountId);
			writer.WriteDouble(Date);
			writer.WriteVarShort((Int16)ModelId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MountId = (UInt32)reader.ReadInt();
			Date = reader.ReadDouble();
			ModelId = (UInt16)reader.ReadVarShort();
		}
	}
}
