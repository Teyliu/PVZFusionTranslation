using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200036A RID: 874
[Token(Token = "0x200036A")]
public class CaltropNut : WallNut
{
	// Token: 0x06001000 RID: 4096 RVA: 0x0005BDB8 File Offset: 0x00059FB8
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x476C00", Offset = "0x475200", VA = "0x180476C00", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__0_ = CaltropNut.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			CaltropNut.<>c.<>9__0_0 = (Plant p) => p.thePlantType == PlantType.CaltropPot;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(list, <>9__0_);
		bool flag = plant;
		return base.GetDamage(damage);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0005BE14 File Offset: 0x0005A014
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CaltropNut()
	{
	}
}
