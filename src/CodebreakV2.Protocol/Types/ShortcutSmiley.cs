using System;
namespace CodebreakV2.Protocol.Types
{
	public class ShortcutSmiley : Shortcut
	{
		public UInt16 SmileyId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)SmileyId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SmileyId = (UInt16)reader.ReadVarShort();
		}
	}
}
