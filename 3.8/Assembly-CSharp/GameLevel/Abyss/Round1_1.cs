using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x2000CE7")]
	public class Round1_1 : AbyssLevelData
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x0015E1D4 File Offset: 0x0015C3D4
		[Token(Token = "0x170007C5")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004524")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_1;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x0015E1E4 File Offset: 0x0015C3E4
		[Token(Token = "0x170007C6")]
		public override int MaxWave
		{
			[Token(Token = "0x6004525")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "10")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x0015E1F4 File Offset: 0x0015C3F4
		[Token(Token = "0x170007C7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004526")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x0015E20C File Offset: 0x0015C40C
		[Token(Token = "0x170007C8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004527")]
			[Address(RVA = "0x837110", Offset = "0x835710", VA = "0x180837110", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x0015E244 File Offset: 0x0015C444
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_1()
		{
		}
	}
}
