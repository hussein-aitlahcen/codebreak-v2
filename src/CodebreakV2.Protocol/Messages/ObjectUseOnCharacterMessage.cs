using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectUseOnCharacterMessage : ObjectUseMessage
	{
		public Int64 CharacterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(CharacterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CharacterId = reader.ReadVarLong();
		}
	}
}
