using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE7 RID: 3559
	[Token(Token = "0x2000DE7")]
	public class 魔力升级 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x0016C6F4 File Offset: 0x0016A8F4
		[Token(Token = "0x1700095D")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0x8DC580", Offset = "0x8DAB80", VA = "0x1808DC580", Slot = "12")]
			get
			{
				return AdvBuff.魔力升级;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x0016C708 File Offset: 0x0016A908
		[Token(Token = "0x1700095E")]
		public override string Description
		{
			[Token(Token = "0x60049BA")]
			[Address(RVA = "0x8DC590", Offset = "0x8DAB90", VA = "0x1808DC590", Slot = "13")]
			get
			{
				return "魔力升级I：魔法寒冰射手魔力提升为1级";
			}
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x0016C71C File Offset: 0x0016A91C
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x8DC200", Offset = "0x8DA800", VA = "0x1808DC200", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num3;
			do
			{
				int num = 0;
				List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)5001), board, num != 0);
				int num2 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num2 != 0)
				{
					goto IL_003B;
				}
				num3 = 0;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num3 != 0);
			return;
			IL_003B:
			throw new NullReferenceException();
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x0016C770 File Offset: 0x0016A970
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x8DC540", Offset = "0x8DAB40", VA = "0x1808DC540")]
		public 魔力升级()
		{
		}
	}
}
