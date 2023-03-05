using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001104 RID: 4356
	public class BiomeWorker_Ocean : BiomeWorker
	{
		// Token: 0x060067FC RID: 26620 RVA: 0x002409DF File Offset: 0x0023EBDF
		public override float GetScore(Tile tile, int tileID)
		{
			if (!tile.WaterCovered)
			{
				return -100f;
			}
			return 0f;
		}
	}
}