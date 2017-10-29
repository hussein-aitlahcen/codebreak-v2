using System;
namespace CodebreakV2.Protocol.Types
{
	public class MapCoordinatesExtended : MapCoordinatesAndId
	{
		public UInt16 SubAreaId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)SubAreaId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SubAreaId = (UInt16)reader.ReadVarShort();
		}
	}
}
