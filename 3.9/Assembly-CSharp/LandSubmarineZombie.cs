using System;
using Cpp2IlInjected;

// Token: 0x020006CF RID: 1743
[Token(Token = "0x20006CF")]
public class LandSubmarineZombie : SubmarineZombie
{
	// Token: 0x060021CB RID: 8651 RVA: 0x000B1CE8 File Offset: 0x000AFEE8
	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x5BEBD0", Offset = "0x5BD1D0", VA = "0x1805BEBD0", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		this.beforeDying = true;
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000B1D04 File Offset: 0x000AFF04
	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x5BEC00", Offset = "0x5BD200", VA = "0x1805BEC00")]
	public LandSubmarineZombie()
	{
	}
}
