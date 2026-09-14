using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x2000CE6")]
	public class Round1_2 : AbyssLevelData
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x0015E140 File Offset: 0x0015C340
		[Token(Token = "0x170007C1")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600451F")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_2;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x0015E150 File Offset: 0x0015C350
		[Token(Token = "0x170007C2")]
		public override int MaxWave
		{
			[Token(Token = "0x6004520")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x0015E160 File Offset: 0x0015C360
		[Token(Token = "0x170007C3")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004521")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x0015E178 File Offset: 0x0015C378
		[Token(Token = "0x170007C4")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004522")]
			[Address(RVA = "0x8371E0", Offset = "0x8357E0", VA = "0x1808371E0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x0015E1C0 File Offset: 0x0015C3C0
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_2()
		{
		}
	}
}
