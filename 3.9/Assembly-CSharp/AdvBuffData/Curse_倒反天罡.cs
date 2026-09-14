using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x2000DE3")]
	public class Curse_倒反天罡 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x0016C4D4 File Offset: 0x0016A6D4
		[Token(Token = "0x17000957")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049A9")]
			[Address(RVA = "0x3F2F10", Offset = "0x3F1510", VA = "0x1803F2F10", Slot = "12")]
			get
			{
				return AdvBuff.Curse_倒反天罡;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x0016C4E8 File Offset: 0x0016A6E8
		[Token(Token = "0x17000958")]
		public override string Description
		{
			[Token(Token = "0x60049AA")]
			[Address(RVA = "0x8CBD80", Offset = "0x8CA380", VA = "0x1808CBD80", Slot = "13")]
			get
			{
				return "倒反天罡：究极植物的倍率降为原来的10%，非究极植物的倍率提高到原来的400%，并获得2倍速度增幅";
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x0016C4FC File Offset: 0x0016A6FC
		[Token(Token = "0x60049AB")]
		[Address(RVA = "0x8CBC70", Offset = "0x8CA270", VA = "0x1808CBC70", Slot = "18")]
		public override void ReinforcePlant(Board board, Plant plant)
		{
			bool flag = Lawnf.IsUltiPlant(plant.thePlantType);
			int num = 0;
			if (!flag)
			{
				plant.ModifyHealth((PlantHealthAdder)((uint)11), 39f, num != 0);
				int num2 = 0;
				int num3 = 0;
				plant.ModifyDamage((PlantDamageAdder)6.9E-44f, 39f, num3 != 0, num2);
				plant.AddSpeed(6.9E-44f);
				return;
			}
			plant.ModifyHealth((PlantHealthAdder)((uint)11), -0.9f, num != 0);
			int num4 = 0;
			int num5 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)49), -0.9f, num5 != 0, num4);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x0016C57C File Offset: 0x0016A77C
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x8CBD40", Offset = "0x8CA340", VA = "0x1808CBD40")]
		public Curse_倒反天罡()
		{
		}
	}
}
