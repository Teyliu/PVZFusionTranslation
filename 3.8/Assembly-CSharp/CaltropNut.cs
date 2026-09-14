using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200035A RID: 858
[Token(Token = "0x200035A")]
public class CaltropNut : WallNut
{
	// Token: 0x06000FB4 RID: 4020 RVA: 0x0005AE24 File Offset: 0x00059024
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x41FCB0", Offset = "0x41E2B0", VA = "0x18041FCB0", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__0_ = CaltropNut.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			Func<Plant, bool> func;
			CaltropNut.<>c.<>9__0_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(list, <>9__0_);
		bool flag = plant;
		return base.GetDamage(damage);
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x0005AE74 File Offset: 0x00059074
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CaltropNut()
	{
	}
}
