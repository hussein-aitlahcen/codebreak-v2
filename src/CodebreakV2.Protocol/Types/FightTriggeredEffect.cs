using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTriggeredEffect : AbstractFightDispellableEffect
	{
		public Int32 Param1 { get; set; }
		public Int32 Param2 { get; set; }
		public Int32 Param3 { get; set; }
		public Int16 Delay { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(Param1);
			writer.WriteInt(Param2);
			writer.WriteInt(Param3);
			writer.WriteShort(Delay);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Param1 = reader.ReadInt();
			Param2 = reader.ReadInt();
			Param3 = reader.ReadInt();
			Delay = reader.ReadShort();
		}
	}
}
