using System;
namespace CodebreakV2.Protocol.Types
{
	public class UpdateMountIntBoost : UpdateMountBoost
	{
		public Int32 Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = reader.ReadInt();
		}
	}
}
