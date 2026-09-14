using System;
using Cpp2IlInjected;

// Token: 0x0200039D RID: 925
[Token(Token = "0x200039D")]
public class FireSpikeRock : SpikeRock
{
	// Token: 0x06001100 RID: 4352 RVA: 0x00060A54 File Offset: 0x0005EC54
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x488C50", Offset = "0x487250", VA = "0x180488C50", Slot = "72")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		throw new NullReferenceException();
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00060A70 File Offset: 0x0005EC70
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x488C90", Offset = "0x487290", VA = "0x180488C90")]
	public FireSpikeRock()
	{
	}
}
