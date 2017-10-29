using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightMutantInformations : GameFightFighterNamedInformations
	{
		public Byte PowerLevel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PowerLevel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PowerLevel = reader.ReadByte();
		}
	}
}
