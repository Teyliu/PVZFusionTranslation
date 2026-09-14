using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class 魔力升级II : BaseBuff<AdvBuff>
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x00162274 File Offset: 0x00160474
		[Token(Token = "0x170007E3")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x8506C0", Offset = "0x84ECC0", VA = "0x1808506C0", Slot = "12")]
			get
			{
				return AdvBuff.魔力升级II;
			}
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00162288 File Offset: 0x00160488
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x8502D0", Offset = "0x84E8D0", VA = "0x1808502D0", Slot = "13")]
		public override string GetDescription()
		{
			return "魔力升级II：魔法寒冰射手魔力提升为2级";
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x0016229C File Offset: 0x0016049C
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x850300", Offset = "0x84E900", VA = "0x180850300", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num3;
			do
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1022));
				int num = 0;
				List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)5001), board, num != 0);
				int num2 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num2 != 0)
				{
					goto IL_004E;
				}
				num3 = 0;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num3 != 0);
			return;
			IL_004E:
			throw new NullReferenceException();
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00162304 File Offset: 0x00160504
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x850680", Offset = "0x84EC80", VA = "0x180850680")]
		public 魔力升级II()
		{
		}
	}
}
