using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001100 RID: 4352
	public class BiomeWorker_Desert : BiomeWorker
	{
		// Token: 0x060067F2 RID: 26610 RVA: 0x002407F7 File Offset: 0x0023E9F7
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.rainfall >= 600f)
			{
				return 0f;
			}
			return tile.temperature + 0.0001f;
		}
	}
}