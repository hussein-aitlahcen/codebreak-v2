using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameContextActorInformations
	{
		public Double ContextualId { get; set; }
		public EntityLook Look { get; set; }
		public EntityDispositionInformations Disposition { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(ContextualId);
			Look.Serialize(writer);
			Disposition.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ContextualId = reader.ReadDouble();
			Look = new EntityLook();
			Look.Deserialize(reader);
			Disposition = new EntityDispositionInformations();
			Disposition.Deserialize(reader);
		}
	}
}
