using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001109 RID: 4361
	public class BiomeWorker_Tundra : BiomeWorker
	{
		// Token: 0x06006806 RID: 26630 RVA: 0x00240BDC File Offset: 0x0023EDDC
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			return -tile.temperature;
		}
	}
}