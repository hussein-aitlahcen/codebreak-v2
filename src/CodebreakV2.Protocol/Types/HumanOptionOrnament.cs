using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionOrnament : HumanOption
	{
		public UInt16 OrnamentId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)OrnamentId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			OrnamentId = (UInt16)reader.ReadVarShort();
		}
	}
}
