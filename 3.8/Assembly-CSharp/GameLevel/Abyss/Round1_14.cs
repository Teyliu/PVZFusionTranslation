using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDA RID: 3290
	[Token(Token = "0x2000CDA")]
	public class Round1_14 : AbyssLevelData
	{
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x0015D990 File Offset: 0x0015BB90
		[Token(Token = "0x17000791")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044E3")]
			[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_14;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0015D9A0 File Offset: 0x0015BBA0
		[Token(Token = "0x17000792")]
		public override int MaxWave
		{
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x0015D9B0 File Offset: 0x0015BBB0
		[Token(Token = "0x17000793")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044E5")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x0015D9C0 File Offset: 0x0015BBC0
		[Token(Token = "0x17000794")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x836AD0", Offset = "0x8350D0", VA = "0x180836AD0", Slot = "20")]
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
				int size8 = list._size;
				return list;
			}
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x0015DA30 File Offset: 0x0015BC30
		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_14()
		{
		}
	}
}
