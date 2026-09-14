using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public class Random_唯快不破 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00161488 File Offset: 0x0015F688
		[Token(Token = "0x170007CF")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x84A860", Offset = "0x848E60", VA = "0x18084A860", Slot = "12")]
			get
			{
				return AdvBuff.Random_唯快不破;
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0016149C File Offset: 0x0015F69C
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x84A670", Offset = "0x848C70", VA = "0x18084A670", Slot = "13")]
		public override string GetDescription()
		{
			return "唯快不破：将1+x株随机植物的速度增加1倍，x为你当前已拥有植物词条的数量";
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001614B0 File Offset: 0x0015F6B0
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0", Slot = "17")]
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

		// Token: 0x060045A7 RID: 17831 RVA: 0x00161550 File Offset: 0x0015F750
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x84A820", Offset = "0x848E20", VA = "0x18084A820")]
		public Random_唯快不破()
		{
		}
	}
}
