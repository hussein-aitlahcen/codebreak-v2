using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
	{
		public Boolean Preview { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Preview);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Preview = reader.ReadBoolean();
		}
	}
}
