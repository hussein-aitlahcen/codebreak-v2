using System;
namespace CodebreakV2.Protocol.Types
{
	public class AbstractCharacterInformation
	{
		public Int64 Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadVarLong();
		}
	}
}
