using System;
using Cpp2IlInjected;

// Token: 0x02000698 RID: 1688
[Token(Token = "0x2000698")]
public class LandSubmarineZombie : SubmarineZombie
{
	// Token: 0x060020B4 RID: 8372 RVA: 0x000AD0A0 File Offset: 0x000AB2A0
	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x55BE90", Offset = "0x55A490", VA = "0x18055BE90", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.beforeDying = true;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000AD0BC File Offset: 0x000AB2BC
	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x55BEC0", Offset = "0x55A4C0", VA = "0x18055BEC0")]
	public LandSubmarineZombie()
	{
	}
}
