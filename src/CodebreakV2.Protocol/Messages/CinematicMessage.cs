using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CinematicMessage
	{
		public UInt16 CinematicId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CinematicId);
		}
		public void Deserialize(IDataReader reader)
		{
			CinematicId = (UInt16)reader.ReadVarShort();
		}
	}
}
