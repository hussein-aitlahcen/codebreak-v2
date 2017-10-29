using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionAlliance : HumanOption
	{
		public AllianceInformations AllianceInformations { get; set; }
		public Byte Aggressable { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			AllianceInformations.Serialize(writer);
			writer.WriteByte(Aggressable);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceInformations = new AllianceInformations();
			AllianceInformations.Deserialize(reader);
			Aggressable = reader.ReadByte();
		}
	}
}
