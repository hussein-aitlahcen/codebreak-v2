using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpouseStatusMessage
	{
		public Boolean HasSpouse { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(HasSpouse);
		}
		public void Deserialize(IDataReader reader)
		{
			HasSpouse = reader.ReadBoolean();
		}
	}
}
