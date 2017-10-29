using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharactersListWithModificationsMessage : CharactersListMessage
	{
		public CharacterToRecolorInformation[] CharactersToRecolor { get; set; }
		public Int32[] CharactersToRename { get; set; }
		public Int32[] UnusableCharacters { get; set; }
		public CharacterToRelookInformation[] CharactersToRelook { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < CharactersToRecolor.Length; i++)
			{
				CharactersToRecolor[i].Serialize(writer);
			}
			for (var i = 0; i < CharactersToRename.Length; i++)
			{
				writer.WriteInt(CharactersToRename[i]);
			}
			for (var i = 0; i < UnusableCharacters.Length; i++)
			{
				writer.WriteInt(UnusableCharacters[i]);
			}
			for (var i = 0; i < CharactersToRelook.Length; i++)
			{
				CharactersToRelook[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CharactersToRecolor = new CharacterToRecolorInformation[reader.ReadShort()];
			for (var i = 0; i < CharactersToRecolor.Length; i++)
			{
				(CharactersToRecolor[i] = new CharacterToRecolorInformation()).Deserialize(reader);
			}
			CharactersToRename = new Int32[reader.ReadShort()];
			for (var i = 0; i < CharactersToRename.Length; i++)
			{
				CharactersToRename[i] = reader.ReadInt();
			}
			UnusableCharacters = new Int32[reader.ReadShort()];
			for (var i = 0; i < UnusableCharacters.Length; i++)
			{
				UnusableCharacters[i] = reader.ReadInt();
			}
			CharactersToRelook = new CharacterToRelookInformation[reader.ReadShort()];
			for (var i = 0; i < CharactersToRelook.Length; i++)
			{
				(CharactersToRelook[i] = new CharacterToRelookInformation()).Deserialize(reader);
			}
		}
	}
}
