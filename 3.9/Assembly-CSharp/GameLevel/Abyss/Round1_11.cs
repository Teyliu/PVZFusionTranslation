using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class Round1_11 : AbyssLevelData
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x00157B3C File Offset: 0x00155D3C
		[Token(Token = "0x17000527")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600415C")]
			[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_11;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00157B4C File Offset: 0x00155D4C
		[Token(Token = "0x17000528")]
		public override int MaxWave
		{
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x00157B5C File Offset: 0x00155D5C
		[Token(Token = "0x17000529")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00157B6C File Offset: 0x00155D6C
		[Token(Token = "0x1700052A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x87E980", Offset = "0x87CF80", VA = "0x18087E980", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				return list;
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00157BD4 File Offset: 0x00155DD4
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_11()
		{
		}
	}
}
