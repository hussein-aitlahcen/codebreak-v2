using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountHarnessColorsUpdateRequestMessage
	{
		public Boolean UseHarnessColors { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(UseHarnessColors);
		}
		public void Deserialize(IDataReader reader)
		{
			UseHarnessColors = reader.ReadBoolean();
		}
	}
}
