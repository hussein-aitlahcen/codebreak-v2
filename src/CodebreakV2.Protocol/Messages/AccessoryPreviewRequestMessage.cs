using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccessoryPreviewRequestMessage
	{
		public UInt16[] GenericId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < GenericId.Length; i++)
			{
				writer.WriteVarShort((Int16)GenericId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			GenericId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < GenericId.Length; i++)
			{
				GenericId[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
