using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PortalDialogCreationMessage : NpcDialogCreationMessage
	{
		public UInt32 Type { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt((Int32)Type);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Type = (UInt32)reader.ReadInt();
		}
	}
}
