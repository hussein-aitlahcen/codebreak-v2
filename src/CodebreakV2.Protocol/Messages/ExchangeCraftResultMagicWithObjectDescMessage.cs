using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
	{
		public SByte MagicPoolStatus { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte((Byte)MagicPoolStatus);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MagicPoolStatus = (SByte)reader.ReadByte();
		}
	}
}
