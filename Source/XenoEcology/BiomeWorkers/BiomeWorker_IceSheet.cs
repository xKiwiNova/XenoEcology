using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x02001102 RID: 4354
	public class BiomeWorker_IceSheet : BiomeWorker
	{
		// Token: 0x060067F6 RID: 26614 RVA: 0x00240875 File Offset: 0x0023EA75
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			return BiomeWorker_IceSheet.PermaIceScore(tile);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x0024088B File Offset: 0x0023EA8B
		public static float PermaIceScore(Tile tile)
		{
			return -20f + -tile.temperature * 2f;
		}
	}
}