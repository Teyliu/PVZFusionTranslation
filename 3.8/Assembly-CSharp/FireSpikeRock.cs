using System;
using Cpp2IlInjected;

// Token: 0x0200038A RID: 906
[Token(Token = "0x200038A")]
public class FireSpikeRock : SpikeRock
{
	// Token: 0x060010A6 RID: 4262 RVA: 0x0005F508 File Offset: 0x0005D708
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x4353B0", Offset = "0x4339B0", VA = "0x1804353B0", Slot = "73")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		throw new NullReferenceException();
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0005F524 File Offset: 0x0005D724
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x4353F0", Offset = "0x4339F0", VA = "0x1804353F0")]
	public FireSpikeRock()
	{
	}
}
