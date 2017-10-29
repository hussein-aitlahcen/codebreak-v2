using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CurrentMapInstanceMessage : CurrentMapMessage
	{
		public Double InstantiatedMapId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(InstantiatedMapId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			InstantiatedMapId = reader.ReadDouble();
		}
	}
}
