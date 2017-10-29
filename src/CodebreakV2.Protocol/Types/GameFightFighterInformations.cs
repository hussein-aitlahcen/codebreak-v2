using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterInformations : GameContextActorInformations
	{
		public Byte TeamId { get; set; }
		public Byte Wave { get; set; }
		public Boolean Alive { get; set; }
		public GameFightMinimalStats Stats { get; set; }
		public UInt16[] PreviousPositions { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(TeamId);
			writer.WriteByte(Wave);
			writer.WriteBoolean(Alive);
			Stats.Serialize(writer);
			for (var i = 0; i < PreviousPositions.Length; i++)
			{
				writer.WriteVarShort((Int16)PreviousPositions[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TeamId = reader.ReadByte();
			Wave = reader.ReadByte();
			Alive = reader.ReadBoolean();
			Stats = new GameFightMinimalStats();
			Stats.Deserialize(reader);
			PreviousPositions = new UInt16[reader.ReadShort()];
			for (var i = 0; i < PreviousPositions.Length; i++)
			{
				PreviousPositions[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
