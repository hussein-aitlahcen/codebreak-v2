using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccessoryPreviewMessage
	{
		public EntityLook Look { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Look.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Look = new EntityLook();
			Look.Deserialize(reader);
		}
	}
}
