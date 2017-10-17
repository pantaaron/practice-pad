using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePad
{
	public class Character
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Class Class { get; set; }
		public List<Item> Equipment { get; set; }
		public List<Item> PotionBelt { get; set; }
		public Guid PartyId { get; private set; }

		public Character()
		{
			Id = Guid.NewGuid();
		}

		public void SetParty(Guid partyId)
		{
			PartyId = partyId;
		}
	}

	public enum Class
	{
		Alchemist
	}
}