using System.Collections.Generic;

namespace PracticePad.BattleMap
{
	public class BattleMap
	{
		public List<BattleTile> Tiles { get; private set; }
		public List<BattleTile> SpawnPoints { get; set; }
		
		public static BattleMap GetMapForLocation(Location loc)
		{
			switch (loc)
			{
				case Location.CoolMap:
				{
					return GenerateCoolMap();
				}
				default:
				{
					return new BattleMap();
				}
			}
		}

		private static BattleMap GenerateCoolMap()
		{
			return new BattleMap
			{
				Tiles = GenerateDefaultTiles(10, 10),
				SpawnPoints = new List<BattleTile>
				{
					new BattleTile {XCoord = 4, YCoord = 0},
					new BattleTile {XCoord = 5, YCoord = 9}
				}
			};
		}

		private static List<BattleTile> GenerateDefaultTiles(int width, int height)
		{
			List<BattleTile> tiles = new List<BattleTile>();
			for (int i = 0; i < width; i++)
				for (int j = 0; j < height; j++)
					tiles.Add(new BattleTile {XCoord = i, YCoord = j, Height = 0});
			return tiles;
		}
	}

	public enum Location
	{
		CoolMap
	}
}