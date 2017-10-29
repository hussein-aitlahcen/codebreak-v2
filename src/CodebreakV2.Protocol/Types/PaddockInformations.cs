using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockInformations
	{
		public UInt16 MaxOutdoorMount { get; set; }
		public UInt16 MaxItems { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)MaxOutdoorMount);
			writer.WriteVarShort((Int16)MaxItems);
		}
		public void Deserialize(IDataReader reader)
		{
			MaxOutdoorMount = (UInt16)reader.ReadVarShort();
			MaxItems = (UInt16)reader.ReadVarShort();
		}
	}
}
