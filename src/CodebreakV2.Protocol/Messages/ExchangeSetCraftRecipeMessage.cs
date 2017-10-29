using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeSetCraftRecipeMessage
	{
		public UInt16 ObjectGID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ObjectGID);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectGID = (UInt16)reader.ReadVarShort();
		}
	}
}
