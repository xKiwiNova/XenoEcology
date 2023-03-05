using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x020010FE RID: 4350
	public class BiomeWorker_BorealForest : BiomeWorker
	{
		// Token: 0x060067EE RID: 26606 RVA: 0x00240761 File Offset: 0x0023E961
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < -10f)
			{
				return 0f;
			}
			if (tile.rainfall < 600f)
			{
				return 0f;
			}
			return 15f;
		}
	}
}