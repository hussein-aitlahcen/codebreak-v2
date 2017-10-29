using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolListMessage
	{
		public UInt16[] ChosenIdols { get; set; }
		public UInt16[] PartyChosenIdols { get; set; }
		public PartyIdol[] PartyIdols { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ChosenIdols.Length; i++)
			{
				writer.WriteVarShort((Int16)ChosenIdols[i]);
			}
			for (var i = 0; i < PartyChosenIdols.Length; i++)
			{
				writer.WriteVarShort((Int16)PartyChosenIdols[i]);
			}
			for (var i = 0; i < PartyIdols.Length; i++)
			{
				PartyIdols[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ChosenIdols = new UInt16[reader.ReadShort()];
			for (var i = 0; i < ChosenIdols.Length; i++)
			{
				ChosenIdols[i] = (UInt16)reader.ReadVarShort();
			}
			PartyChosenIdols = new UInt16[reader.ReadShort()];
			for (var i = 0; i < PartyChosenIdols.Length; i++)
			{
				PartyChosenIdols[i] = (UInt16)reader.ReadVarShort();
			}
			PartyIdols = new PartyIdol[reader.ReadShort()];
			for (var i = 0; i < PartyIdols.Length; i++)
			{
				(PartyIdols[i] = new PartyIdol()).Deserialize(reader);
			}
		}
	}
}
