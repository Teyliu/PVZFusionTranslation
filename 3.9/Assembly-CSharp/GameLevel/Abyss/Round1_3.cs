using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C4A RID: 3146
	[Token(Token = "0x2000C4A")]
	public class Round1_3 : AbyssLevelData
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x00158044 File Offset: 0x00156244
		[Token(Token = "0x17000547")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004184")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_3;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x00158054 File Offset: 0x00156254
		[Token(Token = "0x17000548")]
		public override int MaxWave
		{
			[Token(Token = "0x6004185")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x00158064 File Offset: 0x00156264
		[Token(Token = "0x17000549")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004186")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x00158074 File Offset: 0x00156274
		[Token(Token = "0x1700054A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004187")]
			[Address(RVA = "0x87FAB0", Offset = "0x87E0B0", VA = "0x18087FAB0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x001580C4 File Offset: 0x001562C4
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_3()
		{
		}
	}
}
