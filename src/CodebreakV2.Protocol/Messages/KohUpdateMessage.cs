using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class KohUpdateMessage
	{
		public AllianceInformations[] Alliances { get; set; }
		public UInt16[] AllianceNbMembers { get; set; }
		public UInt32[] AllianceRoundWeigth { get; set; }
		public Byte[] AllianceMatchScore { get; set; }
		public BasicAllianceInformations AllianceMapWinner { get; set; }
		public UInt32 AllianceMapWinnerScore { get; set; }
		public UInt32 AllianceMapMyAllianceScore { get; set; }
		public Double NextTickTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Alliances.Length; i++)
			{
				Alliances[i].Serialize(writer);
			}
			for (var i = 0; i < AllianceNbMembers.Length; i++)
			{
				writer.WriteVarShort((Int16)AllianceNbMembers[i]);
			}
			for (var i = 0; i < AllianceRoundWeigth.Length; i++)
			{
				writer.WriteVarInt((Int32)AllianceRoundWeigth[i]);
			}
			for (var i = 0; i < AllianceMatchScore.Length; i++)
			{
				writer.WriteByte(AllianceMatchScore[i]);
			}
			AllianceMapWinner.Serialize(writer);
			writer.WriteVarInt((Int32)AllianceMapWinnerScore);
			writer.WriteVarInt((Int32)AllianceMapMyAllianceScore);
			writer.WriteDouble(NextTickTime);
		}
		public void Deserialize(IDataReader reader)
		{
			Alliances = new AllianceInformations[reader.ReadShort()];
			for (var i = 0; i < Alliances.Length; i++)
			{
				(Alliances[i] = new AllianceInformations()).Deserialize(reader);
			}
			AllianceNbMembers = new UInt16[reader.ReadShort()];
			for (var i = 0; i < AllianceNbMembers.Length; i++)
			{
				AllianceNbMembers[i] = (UInt16)reader.ReadVarShort();
			}
			AllianceRoundWeigth = new UInt32[reader.ReadShort()];
			for (var i = 0; i < AllianceRoundWeigth.Length; i++)
			{
				AllianceRoundWeigth[i] = (UInt32)reader.ReadVarInt();
			}
			AllianceMatchScore = new Byte[reader.ReadShort()];
			for (var i = 0; i < AllianceMatchScore.Length; i++)
			{
				AllianceMatchScore[i] = reader.ReadByte();
			}
			AllianceMapWinner = new BasicAllianceInformations();
			AllianceMapWinner.Deserialize(reader);
			AllianceMapWinnerScore = (UInt32)reader.ReadVarInt();
			AllianceMapMyAllianceScore = (UInt32)reader.ReadVarInt();
			NextTickTime = reader.ReadDouble();
		}
	}
}
