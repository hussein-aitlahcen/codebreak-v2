using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
	{
		public Byte SellType { get; set; }
		public HumanOption[] Options { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(SellType);
			for (var i = 0; i < Options.Length; i++)
			{
				Options[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SellType = reader.ReadByte();
			Options = new HumanOption[reader.ReadShort()];
			for (var i = 0; i < Options.Length; i++)
			{
				(Options[i] = new HumanOption()).Deserialize(reader);
			}
		}
	}
}
