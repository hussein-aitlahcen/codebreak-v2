using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TitlesAndOrnamentsListMessage
	{
		public UInt16[] Titles { get; set; }
		public UInt16[] Ornaments { get; set; }
		public UInt16 ActiveTitle { get; set; }
		public UInt16 ActiveOrnament { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Titles.Length; i++)
			{
				writer.WriteVarShort((Int16)Titles[i]);
			}
			for (var i = 0; i < Ornaments.Length; i++)
			{
				writer.WriteVarShort((Int16)Ornaments[i]);
			}
			writer.WriteVarShort((Int16)ActiveTitle);
			writer.WriteVarShort((Int16)ActiveOrnament);
		}
		public void Deserialize(IDataReader reader)
		{
			Titles = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Titles.Length; i++)
			{
				Titles[i] = (UInt16)reader.ReadVarShort();
			}
			Ornaments = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Ornaments.Length; i++)
			{
				Ornaments[i] = (UInt16)reader.ReadVarShort();
			}
			ActiveTitle = (UInt16)reader.ReadVarShort();
			ActiveOrnament = (UInt16)reader.ReadVarShort();
		}
	}
}
