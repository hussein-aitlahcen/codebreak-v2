using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemNotInContainer : Item
	{
		public UInt16 ObjectGID { get; set; }
		public ObjectEffect[] Effects { get; set; }
		public UInt32 ObjectUID { get; set; }
		public UInt32 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)ObjectGID);
			for (var i = 0; i < Effects.Length; i++)
			{
				Effects[i].Serialize(writer);
			}
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteVarInt((Int32)Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectGID = (UInt16)reader.ReadVarShort();
			Effects = new ObjectEffect[reader.ReadShort()];
			for (var i = 0; i < Effects.Length; i++)
			{
				(Effects[i] = new ObjectEffect()).Deserialize(reader);
			}
			ObjectUID = (UInt32)reader.ReadVarInt();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
