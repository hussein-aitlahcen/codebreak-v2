using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractGameActionFightTargetedAbilityMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public Int16 DestinationCellId { get; set; }
		public Byte Critical { get; set; }
		public Boolean SilentCast { get; set; }
		public Boolean VerboseCast { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteDouble(TargetId);
			writer.WriteShort(DestinationCellId);
			writer.WriteByte(Critical);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, SilentCast);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, VerboseCast);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			TargetId = reader.ReadDouble();
			DestinationCellId = reader.ReadShort();
			Critical = reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			SilentCast = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			VerboseCast = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
