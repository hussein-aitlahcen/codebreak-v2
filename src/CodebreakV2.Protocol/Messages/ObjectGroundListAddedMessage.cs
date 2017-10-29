using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectGroundListAddedMessage
	{
		public UInt16[] Cells { get; set; }
		public UInt16[] ReferenceIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Cells.Length; i++)
			{
				writer.WriteVarShort((Int16)Cells[i]);
			}
			for (var i = 0; i < ReferenceIds.Length; i++)
			{
				writer.WriteVarShort((Int16)ReferenceIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Cells = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Cells.Length; i++)
			{
				Cells[i] = (UInt16)reader.ReadVarShort();
			}
			ReferenceIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < ReferenceIds.Length; i++)
			{
				ReferenceIds[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
