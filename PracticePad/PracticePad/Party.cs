using System;
using System.Collections.Generic;
using System.Xml;

namespace PracticePad
{
	public class Party
	{
		public Guid Id { get; private set; }
		internal List<Character> Characters { get; set; }
		internal List<Item> Inventory { get; set; }

		public Party()
		{
			Id = Guid.NewGuid();
		}
		
		public void AddCharacter(Character character)
		{
			character.SetParty(Id);
			this.Characters.Add(character);
		}
	}
}