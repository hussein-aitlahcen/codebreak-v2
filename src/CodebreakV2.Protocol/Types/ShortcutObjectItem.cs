using System;
namespace CodebreakV2.Protocol.Types
{
	public class ShortcutObjectItem : ShortcutObject
	{
		public Int32 ItemUID { get; set; }
		public Int32 ItemGID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(ItemUID);
			writer.WriteInt(ItemGID);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ItemUID = reader.ReadInt();
			ItemGID = reader.ReadInt();
		}
	}
}
