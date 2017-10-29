using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AlmanachCalendarDateMessage
	{
		public Int32 Date { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(Date);
		}
		public void Deserialize(IDataReader reader)
		{
			Date = reader.ReadInt();
		}
	}
}
