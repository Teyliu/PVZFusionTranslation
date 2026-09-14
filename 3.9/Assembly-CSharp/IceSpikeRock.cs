using System;
using Cpp2IlInjected;

// Token: 0x020003CD RID: 973
[Token(Token = "0x20003CD")]
public class IceSpikeRock : SpikeRock
{
	// Token: 0x060011D4 RID: 4564 RVA: 0x000647A4 File Offset: 0x000629A4
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x496300", Offset = "0x494900", VA = "0x180496300", Slot = "72")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		int num = 0;
		int num2 = 0;
		zombie.SetCold(15f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(5, num3);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x000647DC File Offset: 0x000629DC
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x488C90", Offset = "0x487290", VA = "0x180488C90")]
	public IceSpikeRock()
	{
	}
}
