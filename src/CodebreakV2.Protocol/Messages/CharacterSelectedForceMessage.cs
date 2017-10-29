using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterSelectedForceMessage
	{
		public Int32 Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadInt();
		}
	}
}
