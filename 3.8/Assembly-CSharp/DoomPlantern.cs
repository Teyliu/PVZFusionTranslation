using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200037C RID: 892
[Token(Token = "0x200037C")]
public class DoomPlantern : IcePlantern
{
	// Token: 0x06001060 RID: 4192 RVA: 0x0005E03C File Offset: 0x0005C23C
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x4310E0", Offset = "0x42F6E0", VA = "0x1804310E0")]
	public void ChargeByLight(int value)
	{
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x0005E04C File Offset: 0x0005C24C
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x430F50", Offset = "0x42F550", VA = "0x180430F50", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			base.AttributeCountdown = 3f;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x0005E094 File Offset: 0x0005C294
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x431100", Offset = "0x42F700", VA = "0x180431100")]
	public DoomPlantern()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.processedZombie = hashSet;
		base..ctor();
	}
}
