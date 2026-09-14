using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x2000CE5")]
	public class Round1_3 : AbyssLevelData
	{
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x0015E0AC File Offset: 0x0015C2AC
		[Token(Token = "0x170007BD")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600451A")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_3;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x0015E0BC File Offset: 0x0015C2BC
		[Token(Token = "0x170007BE")]
		public override int MaxWave
		{
			[Token(Token = "0x600451B")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x0015E0CC File Offset: 0x0015C2CC
		[Token(Token = "0x170007BF")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600451C")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "12")]
			get
			{
				return SceneType.Day_6;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x0015E0DC File Offset: 0x0015C2DC
		[Token(Token = "0x170007C0")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600451D")]
			[Address(RVA = "0x837350", Offset = "0x835950", VA = "0x180837350", Slot = "20")]
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

		// Token: 0x0600451E RID: 17694 RVA: 0x0015E12C File Offset: 0x0015C32C
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_3()
		{
		}
	}
}
