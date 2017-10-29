using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamMemberInformations
	{
		public Double Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
		}
	}
}
