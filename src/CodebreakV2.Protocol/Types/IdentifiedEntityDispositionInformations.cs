using System;
namespace CodebreakV2.Protocol.Types
{
	public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
	{
		public Double Id { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(Id);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Id = reader.ReadDouble();
		}
	}
}
