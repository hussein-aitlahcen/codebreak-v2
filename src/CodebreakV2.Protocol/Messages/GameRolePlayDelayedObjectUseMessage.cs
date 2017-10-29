using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
	{
		public UInt16 ObjectGID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)ObjectGID);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectGID = (UInt16)reader.ReadVarShort();
		}
	}
}
