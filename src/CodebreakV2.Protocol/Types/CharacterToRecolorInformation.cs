using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterToRecolorInformation : AbstractCharacterToRefurbishInformation
	{
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}
