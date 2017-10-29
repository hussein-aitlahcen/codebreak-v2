using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanInformations
	{
		public ActorRestrictionsInformations Restrictions { get; set; }
		public Boolean Sex { get; set; }
		public HumanOption[] Options { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Restrictions.Serialize(writer);
			writer.WriteBoolean(Sex);
			for (var i = 0; i < Options.Length; i++)
			{
				Options[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Restrictions = new ActorRestrictionsInformations();
			Restrictions.Deserialize(reader);
			Sex = reader.ReadBoolean();
			Options = new HumanOption[reader.ReadShort()];
			for (var i = 0; i < Options.Length; i++)
			{
				(Options[i] = new HumanOption()).Deserialize(reader);
			}
		}
	}
}
