using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionFollowers : HumanOption
	{
		public IndexedEntityLook[] FollowingCharactersLook { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < FollowingCharactersLook.Length; i++)
			{
				FollowingCharactersLook[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			FollowingCharactersLook = new IndexedEntityLook[reader.ReadShort()];
			for (var i = 0; i < FollowingCharactersLook.Length; i++)
			{
				(FollowingCharactersLook[i] = new IndexedEntityLook()).Deserialize(reader);
			}
		}
	}
}
