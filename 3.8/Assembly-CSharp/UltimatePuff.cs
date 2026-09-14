using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020005BA RID: 1466
[Token(Token = "0x20005BA")]
public class UltimatePuff : UltimateMelon
{
	// Token: 0x06001B4F RID: 6991 RVA: 0x0009272C File Offset: 0x0009092C
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x5022F0", Offset = "0x5008F0", VA = "0x1805022F0", Slot = "71")]
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
				Func<Plant, bool> func;
				UltimatePuff.<>c.<>9__1_0 = func;
			}
			bool flag2 = Enumerable.FirstOrDefault<Plant>(list, <>9__1_);
			return BulletType.Bullet_pea;
		}
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x00092788 File Offset: 0x00090988
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x502180", Offset = "0x500780", VA = "0x180502180")]
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
			UltimatePuff.<>c.<>9__1_0 = func;
		}
		return Enumerable.FirstOrDefault<Plant>(list, func);
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x000927D0 File Offset: 0x000909D0
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public UltimatePuff()
	{
	}
}
