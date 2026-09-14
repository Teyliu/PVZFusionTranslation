using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x2000CE1")]
	public class Round1_7 : AbyssLevelData
	{
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x0015DE4C File Offset: 0x0015C04C
		[Token(Token = "0x170007AD")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004506")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_7;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x0015DE5C File Offset: 0x0015C05C
		[Token(Token = "0x170007AE")]
		public override int MaxWave
		{
			[Token(Token = "0x6004507")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x0015DE6C File Offset: 0x0015C06C
		[Token(Token = "0x170007AF")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004508")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x0015DE7C File Offset: 0x0015C07C
		[Token(Token = "0x170007B0")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004509")]
			[Address(RVA = "0x837B80", Offset = "0x836180", VA = "0x180837B80", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0015DEC4 File Offset: 0x0015C0C4
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_7()
		{
		}
	}
}
