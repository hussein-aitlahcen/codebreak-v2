using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HavenBagFurnituresRequestMessage
	{
		public UInt16[] CellIds { get; set; }
		public Int32[] FunitureIds { get; set; }
		public Byte[] Orientations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < CellIds.Length; i++)
			{
				writer.WriteVarShort((Int16)CellIds[i]);
			}
			for (var i = 0; i < FunitureIds.Length; i++)
			{
				writer.WriteInt(FunitureIds[i]);
			}
			for (var i = 0; i < Orientations.Length; i++)
			{
				writer.WriteByte(Orientations[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			CellIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < CellIds.Length; i++)
			{
				CellIds[i] = (UInt16)reader.ReadVarShort();
			}
			FunitureIds = new Int32[reader.ReadShort()];
			for (var i = 0; i < FunitureIds.Length; i++)
			{
				FunitureIds[i] = reader.ReadInt();
			}
			Orientations = new Byte[reader.ReadShort()];
			for (var i = 0; i < Orientations.Length; i++)
			{
				Orientations[i] = reader.ReadByte();
			}
		}
	}
}
