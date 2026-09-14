using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class Round1_11 : AbyssLevelData
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x0015DBA4 File Offset: 0x0015BDA4
		[Token(Token = "0x1700079D")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044F2")]
			[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_11;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x0015DBB4 File Offset: 0x0015BDB4
		[Token(Token = "0x1700079E")]
		public override int MaxWave
		{
			[Token(Token = "0x60044F3")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x0015DBC4 File Offset: 0x0015BDC4
		[Token(Token = "0x1700079F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044F4")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x0015DBD4 File Offset: 0x0015BDD4
		[Token(Token = "0x170007A0")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044F5")]
			[Address(RVA = "0x836220", Offset = "0x834820", VA = "0x180836220", Slot = "20")]
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

		// Token: 0x060044F6 RID: 17654 RVA: 0x0015DC3C File Offset: 0x0015BE3C
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_11()
		{
		}
	}
}
