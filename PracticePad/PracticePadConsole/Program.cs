using System;
using System.Collections.Generic;
using System.Linq;
using PracticePad;
using PracticePad.BattleMap;
using PracticePad.Mocks;

namespace PracticePadConsole
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the thing!");
			Console.WriteLine("---------------------");
			BattleMap map = BattleMap.GetMapForLocation(Location.CoolMap);
			Console.WriteLine("Loading Map: " + Location.CoolMap);
			DrawMap(map);
			/*var chars = PartyMock.GetMockParty();
			foreach (var character in chars.Characters)
				Console.WriteLine(character.Name);*/
			Console.ReadLine();
			for (;;)
			{
				
			}
		}

		public static void DrawMap(BattleMap map)
		{
			for (int j = 0; j <= map.Tiles.Max(y => y.YCoord); j++)
			{
				for (int i = 0; i <= map.Tiles.Max(x => x.XCoord); i++)
				{
				
					var tile = map.Tiles.Where(x => x.XCoord == i).FirstOrDefault(y => y.YCoord == j);
					if (map.SpawnPoints.Where(x => x.XCoord == tile?.XCoord).Any(y => y.YCoord == tile?.YCoord))
						Console.Write("{");
					else if (map.SpawnPoints.Where(x => x.XCoord == (i-1)).Any(y => y.YCoord == j))
						Console.Write("}");
					else
						Console.Write("|");
					Console.Write(tile?.Height.ToString() ?? "X");
				}
				Console.Write("|");
				Console.WriteLine();
			}
				
		}
	}
}