using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D01 RID: 3329
	[Token(Token = "0x2000D01")]
	public class Random_规则之力 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x00161664 File Offset: 0x0015F864
		[Token(Token = "0x170007D2")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045B2")]
			[Address(RVA = "0x84BF30", Offset = "0x84A530", VA = "0x18084BF30", Slot = "12")]
			get
			{
				return AdvBuff.Random_规则之力;
			}
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00161678 File Offset: 0x0015F878
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x84BD00", Offset = "0x84A300", VA = "0x18084BD00", Slot = "13")]
		public override string GetDescription()
		{
			return "规则之力：将全场僵尸击退至底线，然后秒杀全场僵尸";
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x0016168C File Offset: 0x0015F88C
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x84BD30", Offset = "0x84A330", VA = "0x18084BD30", Slot = "17")]
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

		// Token: 0x060045B5 RID: 17845 RVA: 0x001616B8 File Offset: 0x0015F8B8
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x84BEF0", Offset = "0x84A4F0", VA = "0x18084BEF0")]
		public Random_规则之力()
		{
		}
	}
}
