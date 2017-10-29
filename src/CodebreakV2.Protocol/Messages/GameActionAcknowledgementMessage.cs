using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionAcknowledgementMessage
	{
		public Boolean Valid { get; set; }
		public SByte ActionId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Valid);
			writer.WriteByte((Byte)ActionId);
		}
		public void Deserialize(IDataReader reader)
		{
			Valid = reader.ReadBoolean();
			ActionId = (SByte)reader.ReadByte();
		}
	}
}
