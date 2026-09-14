using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DD3 RID: 3539
	[Token(Token = "0x2000DD3")]
	public class Random_终极时刻 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x0016BEC8 File Offset: 0x0016A0C8
		[Token(Token = "0x17000943")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004973")]
			[Address(RVA = "0x89EAB0", Offset = "0x89D0B0", VA = "0x18089EAB0", Slot = "12")]
			get
			{
				return AdvBuff.Random_终极时刻;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x0016BEDC File Offset: 0x0016A0DC
		[Token(Token = "0x17000944")]
		public override string Description
		{
			[Token(Token = "0x6004974")]
			[Address(RVA = "0x8B1EA0", Offset = "0x8B04A0", VA = "0x1808B1EA0", Slot = "13")]
			get
			{
				return "终极时刻：植物造成的伤害翻倍";
			}
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x0016BEF0 File Offset: 0x0016A0F0
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x8B1CB0", Offset = "0x8B02B0", VA = "0x1808B1CB0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num2;
			do
			{
				int num = 0;
				List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
				bool flag;
				if (flag)
				{
					TravelMgr.Instance.data.AddDamage((PlantType)num, 1f);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x0016BF40 File Offset: 0x0016A140
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x8B1E60", Offset = "0x8B0460", VA = "0x1808B1E60")]
		public Random_终极时刻()
		{
		}
	}
}
