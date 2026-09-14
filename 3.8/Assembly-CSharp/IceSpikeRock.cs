using System;
using Cpp2IlInjected;

// Token: 0x020003B9 RID: 953
[Token(Token = "0x20003B9")]
public class IceSpikeRock : SpikeRock
{
	// Token: 0x06001178 RID: 4472 RVA: 0x00063184 File Offset: 0x00061384
	[Token(Token = "0x6001178")]
	[Address(RVA = "0x4443B0", Offset = "0x4429B0", VA = "0x1804443B0", Slot = "73")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		int num = 0;
		int num2 = 0;
		zombie.SetCold(15f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(5, num3);
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x000631BC File Offset: 0x000613BC
	[Token(Token = "0x6001179")]
	[Address(RVA = "0x4353F0", Offset = "0x4339F0", VA = "0x1804353F0")]
	public IceSpikeRock()
	{
	}
}
