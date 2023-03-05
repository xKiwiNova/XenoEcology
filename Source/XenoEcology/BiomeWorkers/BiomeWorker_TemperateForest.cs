using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001105 RID: 4357
	public class BiomeWorker_TemperateForest : BiomeWorker
	{
		// Token: 0x060067FE RID: 26622 RVA: 0x002409F4 File Offset: 0x0023EBF4
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
			return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
		}
	}
}