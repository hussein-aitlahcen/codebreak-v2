using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismUseRequestMessage
	{
		public Byte ModuleToUse { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ModuleToUse);
		}
		public void Deserialize(IDataReader reader)
		{
			ModuleToUse = reader.ReadByte();
		}
	}
}
