using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
	{
		public EntityLook EntityLook { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			EntityLook.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			EntityLook = new EntityLook();
			EntityLook.Deserialize(reader);
		}
	}
}
