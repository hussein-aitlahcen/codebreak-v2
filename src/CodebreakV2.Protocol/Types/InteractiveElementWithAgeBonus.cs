using System;
namespace CodebreakV2.Protocol.Types
{
	public class InteractiveElementWithAgeBonus : InteractiveElement
	{
		public Int16 AgeBonus { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(AgeBonus);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AgeBonus = reader.ReadShort();
		}
	}
}
