using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001101 RID: 4353
	public class BiomeWorker_ExtremeDesert : BiomeWorker
	{
		// Token: 0x060067F4 RID: 26612 RVA: 0x00240828 File Offset: 0x0023EA28
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.rainfall >= 340f)
			{
				return 0f;
			}
			return tile.temperature * 2.7f - 13f - tile.rainfall * 0.14f;
		}
	}
}