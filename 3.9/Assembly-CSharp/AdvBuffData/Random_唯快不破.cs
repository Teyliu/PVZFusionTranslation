using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC5 RID: 3525
	[Token(Token = "0x2000DC5")]
	public class Random_唯快不破 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x0016B8FC File Offset: 0x00169AFC
		[Token(Token = "0x17000935")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004945")]
			[Address(RVA = "0x88CE70", Offset = "0x88B470", VA = "0x18088CE70", Slot = "12")]
			get
			{
				return AdvBuff.Random_唯快不破;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x0016B910 File Offset: 0x00169B10
		[Token(Token = "0x17000936")]
		public override string Description
		{
			[Token(Token = "0x6004946")]
			[Address(RVA = "0x8B1740", Offset = "0x8AFD40", VA = "0x1808B1740", Slot = "13")]
			get
			{
				return "唯快不破：将1+x株随机植物的速度增加1倍，x为你当前已拥有植物词条的数量";
			}
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0016B924 File Offset: 0x00169B24
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x8B1580", Offset = "0x8AFB80", VA = "0x1808B1580", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num = 0;
			int size = TravelMgr.Instance.data.advBuffs._size;
			int num2 = TravelMgr.Instance.data.ultiBuffs._size;
			num2++;
			num2 += size;
			if (num < num2)
			{
				Plant random = ListExtensions.GetRandom<Plant>(Lawnf.GetAllPlants());
				float attributeSpeed = random.attributeSpeed;
				num++;
				random.attributeSpeed = attributeSpeed;
				float attackSpeedAdder = random.attackSpeedAdder;
				float thePlantSpeed = random.thePlantSpeed;
				random.attackSpeedAdder = attackSpeedAdder;
				random.thePlantSpeed = thePlantSpeed;
			}
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0016B9C4 File Offset: 0x00169BC4
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x8B1700", Offset = "0x8AFD00", VA = "0x1808B1700")]
		public Random_唯快不破()
		{
		}
	}
}
