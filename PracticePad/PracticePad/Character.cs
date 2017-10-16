using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePad
{
	internal class Character
	{
		internal string Name { get; set; }
		internal Class Class { get; set; }
		internal List<Item> Equipment { get; set; }
		internal List<Item> PotionBelt { get; set; }
	}

	public enum Class
	{
		Alchemist
	}
}