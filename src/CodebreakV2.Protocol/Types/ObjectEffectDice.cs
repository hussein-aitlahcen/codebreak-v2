using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectDice : ObjectEffect
	{
		public UInt16 DiceNum { get; set; }
		public UInt16 DiceSide { get; set; }
		public UInt16 DiceConst { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)DiceNum);
			writer.WriteVarShort((Int16)DiceSide);
			writer.WriteVarShort((Int16)DiceConst);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DiceNum = (UInt16)reader.ReadVarShort();
			DiceSide = (UInt16)reader.ReadVarShort();
			DiceConst = (UInt16)reader.ReadVarShort();
		}
	}
}
