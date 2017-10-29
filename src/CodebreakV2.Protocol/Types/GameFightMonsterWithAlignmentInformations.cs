using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
	{
		public ActorAlignmentInformations AlignmentInfos { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			AlignmentInfos.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AlignmentInfos = new ActorAlignmentInformations();
			AlignmentInfos.Deserialize(reader);
		}
	}
}
