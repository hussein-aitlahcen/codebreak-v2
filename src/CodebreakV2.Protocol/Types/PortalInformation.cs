using System;
namespace CodebreakV2.Protocol.Types
{
	public class PortalInformation
	{
		public Int32 PortalId { get; set; }
		public Int16 AreaId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(PortalId);
			writer.WriteShort(AreaId);
		}
		public void Deserialize(IDataReader reader)
		{
			PortalId = reader.ReadInt();
			AreaId = reader.ReadShort();
		}
	}
}
