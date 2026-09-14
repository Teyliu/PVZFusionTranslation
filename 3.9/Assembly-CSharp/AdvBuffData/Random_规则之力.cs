using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC9 RID: 3529
	[Token(Token = "0x2000DC9")]
	public class Random_规则之力 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x0016BAD8 File Offset: 0x00169CD8
		[Token(Token = "0x1700093B")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004953")]
			[Address(RVA = "0x88CBA0", Offset = "0x88B1A0", VA = "0x18088CBA0", Slot = "12")]
			get
			{
				return AdvBuff.Random_规则之力;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x0016BAEC File Offset: 0x00169CEC
		[Token(Token = "0x1700093C")]
		public override string Description
		{
			[Token(Token = "0x6004954")]
			[Address(RVA = "0x8B24E0", Offset = "0x8B0AE0", VA = "0x1808B24E0", Slot = "13")]
			get
			{
				return "规则之力：将全场僵尸击退至底线，然后秒杀全场僵尸";
			}
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x0016BB00 File Offset: 0x00169D00
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x8B22E0", Offset = "0x8B08E0", VA = "0x1808B22E0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num;
			do
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				num = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x0016BB2C File Offset: 0x00169D2C
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x8B24A0", Offset = "0x8B0AA0", VA = "0x1808B24A0")]
		public Random_规则之力()
		{
		}
	}
}
