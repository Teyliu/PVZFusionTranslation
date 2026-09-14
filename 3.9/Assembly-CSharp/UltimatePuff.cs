using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020005EC RID: 1516
[Token(Token = "0x20005EC")]
public class UltimatePuff : UltimateMelon
{
	// Token: 0x06001C42 RID: 7234 RVA: 0x00096E30 File Offset: 0x00095030
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x5699C0", Offset = "0x567FC0", VA = "0x1805699C0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__1_ = UltimatePuff.<>c.<>9__1_0;
			if (<>9__1_ == 0)
			{
				UltimatePuff.<>c.<>9__1_0 = (Plant p) => p.thePlantType == PlantType.UltimateSnowGatlingPuff;
			}
			bool flag2 = Enumerable.FirstOrDefault<Plant>(list, <>9__1_);
			return BulletType.Bullet_pea;
		}
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x00096E9C File Offset: 0x0009509C
	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x569850", Offset = "0x567E50", VA = "0x180569850")]
	private bool CheckBuff()
	{
		bool flag;
		if (!flag)
		{
			return flag;
		}
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> func;
		if (UltimatePuff.<>c.<>9__1_0 == 0)
		{
			func = (Plant p) => p.thePlantType == PlantType.UltimateSnowGatlingPuff;
			UltimatePuff.<>c.<>9__1_0 = func;
		}
		return Enumerable.FirstOrDefault<Plant>(list, func);
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x00096EF4 File Offset: 0x000950F4
	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public UltimatePuff()
	{
	}
}
