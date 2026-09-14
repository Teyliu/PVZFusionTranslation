using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D1E RID: 3358
	[Token(Token = "0x2000D1E")]
	public class 魔力升级 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x001621E4 File Offset: 0x001603E4
		[Token(Token = "0x170007E2")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004614")]
			[Address(RVA = "0x850A80", Offset = "0x84F080", VA = "0x180850A80", Slot = "12")]
			get
			{
				return AdvBuff.魔力升级;
			}
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x001621F8 File Offset: 0x001603F8
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x8506D0", Offset = "0x84ECD0", VA = "0x1808506D0", Slot = "13")]
		public override string GetDescription()
		{
			return "魔力升级I：魔法寒冰射手魔力提升为1级";
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x0016220C File Offset: 0x0016040C
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x850700", Offset = "0x84ED00", VA = "0x180850700", Slot = "17")]
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

		// Token: 0x06004617 RID: 17943 RVA: 0x00162260 File Offset: 0x00160460
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x850A40", Offset = "0x84F040", VA = "0x180850A40")]
		public 魔力升级()
		{
		}
	}
}
