using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE8 RID: 3560
	[Token(Token = "0x2000DE8")]
	public class 魔力升级II : BaseBuff<AdvBuff>
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x0016C784 File Offset: 0x0016A984
		[Token(Token = "0x1700095F")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049BD")]
			[Address(RVA = "0x8DC1C0", Offset = "0x8DA7C0", VA = "0x1808DC1C0", Slot = "12")]
			get
			{
				return AdvBuff.魔力升级II;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x0016C798 File Offset: 0x0016A998
		[Token(Token = "0x17000960")]
		public override string Description
		{
			[Token(Token = "0x60049BE")]
			[Address(RVA = "0x8DC1D0", Offset = "0x8DA7D0", VA = "0x1808DC1D0", Slot = "13")]
			get
			{
				return "魔力升级II：魔法寒冰射手魔力提升为2级";
			}
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x0016C7AC File Offset: 0x0016A9AC
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x8DBE00", Offset = "0x8DA400", VA = "0x1808DBE00", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num3;
			do
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1021));
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

		// Token: 0x060049C0 RID: 18880 RVA: 0x0016C814 File Offset: 0x0016AA14
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x8DC180", Offset = "0x8DA780", VA = "0x1808DC180")]
		public 魔力升级II()
		{
		}
	}
}
