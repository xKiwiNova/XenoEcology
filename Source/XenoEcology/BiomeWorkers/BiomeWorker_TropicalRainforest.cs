using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001107 RID: 4359
	public class BiomeWorker_TropicalRainforest : BiomeWorker
	{
		// Token: 0x06006802 RID: 26626 RVA: 0x00240AE4 File Offset: 0x0023ECE4
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < 15f)
			{
				return 0f;
			}
			if (tile.rainfall < 2000f)
			{
				return 0f;
			}
			return 28f + (tile.temperature - 20f) * 1.5f + (tile.rainfall - 600f) / 165f;
		}
	}
}