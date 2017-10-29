using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameDataPlayFarmObjectAnimationMessage
	{
		public UInt16[] CellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < CellId.Length; i++)
			{
				writer.WriteVarShort((Int16)CellId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < CellId.Length; i++)
			{
				CellId[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
