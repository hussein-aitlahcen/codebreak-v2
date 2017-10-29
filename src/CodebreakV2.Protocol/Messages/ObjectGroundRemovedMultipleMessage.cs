using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectGroundRemovedMultipleMessage
	{
		public UInt16[] Cells { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Cells.Length; i++)
			{
				writer.WriteVarShort((Int16)Cells[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Cells = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Cells.Length; i++)
			{
				Cells[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
