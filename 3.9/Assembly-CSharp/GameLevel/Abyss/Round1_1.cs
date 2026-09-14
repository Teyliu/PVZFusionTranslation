using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000C4C")]
	public class Round1_1 : AbyssLevelData
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x0015816C File Offset: 0x0015636C
		[Token(Token = "0x1700054F")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600418E")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_1;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x0015817C File Offset: 0x0015637C
		[Token(Token = "0x17000550")]
		public override int MaxWave
		{
			[Token(Token = "0x600418F")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "10")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x0015818C File Offset: 0x0015638C
		[Token(Token = "0x17000551")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004190")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x001581A4 File Offset: 0x001563A4
		[Token(Token = "0x17000552")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004191")]
			[Address(RVA = "0x87F870", Offset = "0x87DE70", VA = "0x18087F870", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x001581DC File Offset: 0x001563DC
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_1()
		{
		}
	}
}
