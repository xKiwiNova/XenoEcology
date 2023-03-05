using System;
using RimWorld.Planet;

namespace RimWorld
{
	// Token: 0x020010FD RID: 4349
	public class BiomeWorker_AridShrubland : BiomeWorker
	{
		// Token: 0x060067EC RID: 26604 RVA: 0x002406E0 File Offset: 0x0023E8E0
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
			if (tile.rainfall < 600f || tile.rainfall >= 2000f)
			{
				return 0f;
			}
			return 22.5f + (tile.temperature - 20f) * 2.2f + (tile.rainfall - 600f) / 100f;
		}
	}
}