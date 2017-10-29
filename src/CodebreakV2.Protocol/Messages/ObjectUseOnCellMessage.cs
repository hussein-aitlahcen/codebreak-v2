using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectUseOnCellMessage : ObjectUseMessage
	{
		public UInt16 Cells { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Cells);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Cells = (UInt16)reader.ReadVarShort();
		}
	}
}
