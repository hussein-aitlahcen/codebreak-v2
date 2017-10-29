using System;
namespace CodebreakV2.Protocol.Types
{
	public class StartupActionAddObject
	{
		public UInt32 Uid { get; set; }
		public String Title { get; set; }
		public String Text { get; set; }
		public String DescUrl { get; set; }
		public String PictureUrl { get; set; }
		public ObjectItemInformationWithQuantity[] Items { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)Uid);
			writer.WriteUTF(Title);
			writer.WriteUTF(Text);
			writer.WriteUTF(DescUrl);
			writer.WriteUTF(PictureUrl);
			for (var i = 0; i < Items.Length; i++)
			{
				Items[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Uid = (UInt32)reader.ReadInt();
			Title = reader.ReadUTF();
			Text = reader.ReadUTF();
			DescUrl = reader.ReadUTF();
			PictureUrl = reader.ReadUTF();
			Items = new ObjectItemInformationWithQuantity[reader.ReadShort()];
			for (var i = 0; i < Items.Length; i++)
			{
				(Items[i] = new ObjectItemInformationWithQuantity()).Deserialize(reader);
			}
		}
	}
}
