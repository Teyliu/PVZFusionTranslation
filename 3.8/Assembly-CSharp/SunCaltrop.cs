using System;
using Cpp2IlInjected;

// Token: 0x02000437 RID: 1079
[Token(Token = "0x2000437")]
public class SunCaltrop : Caltrop
{
	// Token: 0x060013EA RID: 5098 RVA: 0x0006FA2C File Offset: 0x0006DC2C
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x470180", Offset = "0x46E780", VA = "0x180470180", Slot = "72")]
	protected override void AnimAttack()
	{
		base.AnimAttack();
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0006FA50 File Offset: 0x0006DC50
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public SunCaltrop()
	{
	}
}
