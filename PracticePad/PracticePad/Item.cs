using System;
using System.ComponentModel;

namespace PracticePad
{
	public class Item
	{
		public string Name { get; set; }
		public ItemSlot Slot { get; set; }
		public int MaxCount { get; set; }
		public int Value { get; set; }
		public ItemType Type { get; set; }
		public bool IsConsumable { get; set; }
		public bool IsUsable { get; set; }
		public bool IsStackable => MaxCount > 0;

		public Item()
		{
			Name = "NewItem";
			Slot = ItemSlot.Unequippable;
			MaxCount = 0;
			Value = 0;
			Type = ItemType.None;
			IsConsumable = false;
			IsUsable = false;
		}
	}

	public enum ItemSlot
	{
		Head,
		Shoulders,
		Arms,
		Torso,
		Gloves,
		Waist,
		Legs,
		Feet,
		MainHand,
		OffHand,
		Unequippable
	}

	public enum ItemType
	{
		ClothArmor,
		LeatherArmor,
		ChainArmor,
		PlateArmor,
		MainHand,
		OffHand,
		OneHand,
		TwoHand,
		Potion,
		None
	}
}