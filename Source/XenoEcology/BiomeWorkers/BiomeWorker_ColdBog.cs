using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x020010FF RID: 4351
	public class BiomeWorker_ColdBog : BiomeWorker
	{
		// Token: 0x060067F0 RID: 26608 RVA: 0x0024079C File Offset: 0x0023E99C
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
			if (tile.swampiness < 0.5f)
			{
				return 0f;
			}
			return -tile.temperature + 13f + tile.swampiness * 8f;
		}
	}
}