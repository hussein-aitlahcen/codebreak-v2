using System;
namespace CodebreakV2.Protocol.Types
{
	public class PlayerStatusExtended : PlayerStatus
	{
		public String Message { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Message);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Message = reader.ReadUTF();
		}
	}
}
