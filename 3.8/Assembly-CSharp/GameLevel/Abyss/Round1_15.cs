using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class Round1_15 : AbyssLevelData
	{
		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x0015D8DC File Offset: 0x0015BADC
		[Token(Token = "0x1700078D")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_15;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x0015D8EC File Offset: 0x0015BAEC
		[Token(Token = "0x1700078E")]
		public override int MaxWave
		{
			[Token(Token = "0x60044DF")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x0015D8FC File Offset: 0x0015BAFC
		[Token(Token = "0x1700078F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x0015D90C File Offset: 0x0015BB0C
		[Token(Token = "0x17000790")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044E1")]
			[Address(RVA = "0x836DF0", Offset = "0x8353F0", VA = "0x180836DF0", Slot = "20")]
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

		// Token: 0x060044E2 RID: 17634 RVA: 0x0015D97C File Offset: 0x0015BB7C
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_15()
		{
		}
	}
}
