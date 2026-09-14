using System;
using Cpp2IlInjected;

// Token: 0x020004D0 RID: 1232
[Token(Token = "0x20004D0")]
public class CherryGatling : Shooter
{
	// Token: 0x0600173E RID: 5950 RVA: 0x0007FD3C File Offset: 0x0007DF3C
	[Token(Token = "0x600173E")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x0007FD4C File Offset: 0x0007DF4C
	[Token(Token = "0x600173F")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CherryGatling()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
