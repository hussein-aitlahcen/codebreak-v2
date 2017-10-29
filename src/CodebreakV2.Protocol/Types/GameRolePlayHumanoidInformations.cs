using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
	{
		public HumanInformations HumanoidInfo { get; set; }
		public UInt32 AccountId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			HumanoidInfo.Serialize(writer);
			writer.WriteInt((Int32)AccountId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			HumanoidInfo = new HumanInformations();
			HumanoidInfo.Deserialize(reader);
			AccountId = (UInt32)reader.ReadInt();
		}
	}
}
