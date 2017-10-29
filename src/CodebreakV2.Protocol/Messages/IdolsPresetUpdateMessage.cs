using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolsPresetUpdateMessage
	{
		public IdolsPreset IdolsPreset { get; set; }
		public void Serialize(IDataWriter writer)
		{
			IdolsPreset.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			IdolsPreset = new IdolsPreset();
			IdolsPreset.Deserialize(reader);
		}
	}
}
