using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SetUpdateMessage
	{
		public UInt16 SetId { get; set; }
		public UInt16[] SetObjects { get; set; }
		public ObjectEffect[] SetEffects { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SetId);
			for (var i = 0; i < SetObjects.Length; i++)
			{
				writer.WriteVarShort((Int16)SetObjects[i]);
			}
			for (var i = 0; i < SetEffects.Length; i++)
			{
				SetEffects[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			SetId = (UInt16)reader.ReadVarShort();
			SetObjects = new UInt16[reader.ReadShort()];
			for (var i = 0; i < SetObjects.Length; i++)
			{
				SetObjects[i] = (UInt16)reader.ReadVarShort();
			}
			SetEffects = new ObjectEffect[reader.ReadShort()];
			for (var i = 0; i < SetEffects.Length; i++)
			{
				(SetEffects[i] = new ObjectEffect()).Deserialize(reader);
			}
		}
	}
}
