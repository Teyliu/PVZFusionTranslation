using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D0B RID: 3339
	[Token(Token = "0x2000D0B")]
	public class Random_终极时刻 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x00161A64 File Offset: 0x0015FC64
		[Token(Token = "0x170007D6")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x84B2E0", Offset = "0x8498E0", VA = "0x18084B2E0", Slot = "12")]
			get
			{
				return AdvBuff.Random_终极时刻;
			}
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00161A78 File Offset: 0x0015FC78
		[Token(Token = "0x60045D3")]
		[Address(RVA = "0x84B0C0", Offset = "0x8496C0", VA = "0x18084B0C0", Slot = "13")]
		public override string GetDescription()
		{
			return "终极时刻：植物造成的伤害翻倍";
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00161A8C File Offset: 0x0015FC8C
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x84B0F0", Offset = "0x8496F0", VA = "0x18084B0F0", Slot = "17")]
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

		// Token: 0x060045D5 RID: 17877 RVA: 0x00161ADC File Offset: 0x0015FCDC
		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x84B2A0", Offset = "0x8498A0", VA = "0x18084B2A0")]
		public Random_终极时刻()
		{
		}
	}
}
