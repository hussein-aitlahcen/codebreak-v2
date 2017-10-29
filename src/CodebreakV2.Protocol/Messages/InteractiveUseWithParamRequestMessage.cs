using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
	{
		public Int32 Id { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(Id);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Id = reader.ReadInt();
		}
	}
}
