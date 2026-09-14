using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000CDC")]
	public class Round1_12 : AbyssLevelData
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x0015DAE0 File Offset: 0x0015BCE0
		[Token(Token = "0x17000799")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044ED")]
			[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_12;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x0015DAF0 File Offset: 0x0015BCF0
		[Token(Token = "0x1700079A")]
		public override int MaxWave
		{
			[Token(Token = "0x60044EE")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x0015DB00 File Offset: 0x0015BD00
		[Token(Token = "0x1700079B")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044EF")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x0015DB10 File Offset: 0x0015BD10
		[Token(Token = "0x1700079C")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044F0")]
			[Address(RVA = "0x8364F0", Offset = "0x834AF0", VA = "0x1808364F0", Slot = "20")]
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
				int size9 = list._size;
				int size10 = list._size;
				return list;
			}
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x0015DB90 File Offset: 0x0015BD90
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_12()
		{
		}
	}
}
