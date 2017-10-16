using System.Collections.Generic;

namespace PracticePad.Mocks
{
	public static class PartyMock
	{
		public static Party GetMockParty()
		{
			return new Party
			{
				Characters = new List<Character>
				{
					new Character
					{
						Name = "Arnie",
						Equipment = new List<Item>
						{
							new Item()
						}
					},
					new Character
					{
						Name = "Bobby",
						Equipment = new List<Item>
						{
							new Item()
						}
					},
					new Character
					{
						Name = "Chuggs",
						Equipment = new List<Item>
						{
							new Item()
						}
					}
				}
			};
		}
	}
}