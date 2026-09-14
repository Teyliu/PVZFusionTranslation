using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE0 RID: 3296
	[Token(Token = "0x2000CE0")]
	public class Round1_8 : AbyssLevelData
	{
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06004501 RID: 17665 RVA: 0x0015DDA8 File Offset: 0x0015BFA8
		[Token(Token = "0x170007A9")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004501")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_8;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x0015DDB8 File Offset: 0x0015BFB8
		[Token(Token = "0x170007AA")]
		public override int MaxWave
		{
			[Token(Token = "0x6004502")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06004503 RID: 17667 RVA: 0x0015DDC8 File Offset: 0x0015BFC8
		[Token(Token = "0x170007AB")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004503")]
			[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "12")]
			get
			{
				return SceneType.ReversalPool;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x0015DDD8 File Offset: 0x0015BFD8
		[Token(Token = "0x170007AC")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004504")]
			[Address(RVA = "0x837CF0", Offset = "0x8362F0", VA = "0x180837CF0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x0015DE38 File Offset: 0x0015C038
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_8()
		{
		}
	}
}
