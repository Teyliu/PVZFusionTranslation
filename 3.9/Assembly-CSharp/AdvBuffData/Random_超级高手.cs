using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC3 RID: 3523
	[Token(Token = "0x2000DC3")]
	public class Random_超级高手 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x0016B7CC File Offset: 0x001699CC
		[Token(Token = "0x17000933")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600493E")]
			[Address(RVA = "0x88CF40", Offset = "0x88B540", VA = "0x18088CF40", Slot = "12")]
			get
			{
				return AdvBuff.Random_超级高手;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x0016B7E0 File Offset: 0x001699E0
		[Token(Token = "0x17000934")]
		public override string Description
		{
			[Token(Token = "0x600493F")]
			[Address(RVA = "0x8B2860", Offset = "0x8B0E60", VA = "0x1808B2860", Slot = "13")]
			get
			{
				return "超级高手：将1+x株随机植物升至1级，x为你当前已拥有植物词条的数量";
			}
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x0016B7F4 File Offset: 0x001699F4
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x8B25C0", Offset = "0x8B0BC0", VA = "0x1808B25C0", Slot = "17")]
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
				Func<Plant, bool> <>9__4_ = Random_超级高手.<>c.<>9__4_0;
				if (<>9__4_ == 0)
				{
					Random_超级高手.<>c.<>9__4_0 = (Plant p) => p.theLevel < 1;
				}
				Plant random = ListExtensions.GetRandom<Plant>(Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__4_)));
				int num3 = 0;
				uint num4;
				ulong num5;
				bool flag = random.Upgrade((int)num4, num5 != 0UL, num3 != 0);
				num++;
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x0016B8A0 File Offset: 0x00169AA0
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x8B2820", Offset = "0x8B0E20", VA = "0x1808B2820")]
		public Random_超级高手()
		{
		}
	}
}
