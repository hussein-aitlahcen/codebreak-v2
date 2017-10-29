using System;
namespace CodebreakV2.Protocol.Types
{
	public class MonsterInGroupInformations : MonsterInGroupLightInformations
	{
		public EntityLook Look { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Look.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Look = new EntityLook();
			Look.Deserialize(reader);
		}
	}
}
