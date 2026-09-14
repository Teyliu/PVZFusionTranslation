using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x2000CFB")]
	public class Random_超级高手 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x00161364 File Offset: 0x0015F564
		[Token(Token = "0x170007CE")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600459D")]
			[Address(RVA = "0x84C350", Offset = "0x84A950", VA = "0x18084C350", Slot = "12")]
			get
			{
				return AdvBuff.Random_超级高手;
			}
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00161378 File Offset: 0x0015F578
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x84C080", Offset = "0x84A680", VA = "0x18084C080", Slot = "13")]
		public override string GetDescription()
		{
			return "超级高手：将1+x株随机植物升至1级，x为你当前已拥有植物词条的数量";
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0016138C File Offset: 0x0015F58C
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x84C0B0", Offset = "0x84A6B0", VA = "0x18084C0B0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num = 0;
			int size = TravelMgr.Instance.data.advBuffs._size;
			int num2 = TravelMgr.Instance.data.ultiBuffs._size;
			num2++;
			num2 += size;
			if (num < num2)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				Func<Plant, bool> <>9__3_ = Random_超级高手.<>c.<>9__3_0;
				if (<>9__3_ == 0)
				{
					Func<Plant, bool> func;
					Random_超级高手.<>c.<>9__3_0 = func;
				}
				Plant random = ListExtensions.GetRandom<Plant>(Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__3_)));
				int num3 = 0;
				uint num4;
				ulong num5;
				bool flag = random.Upgrade((int)num4, num5 != 0UL, num3 != 0);
				num++;
			}
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0016142C File Offset: 0x0015F62C
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x84C310", Offset = "0x84A910", VA = "0x18084C310")]
		public Random_超级高手()
		{
		}
	}
}
