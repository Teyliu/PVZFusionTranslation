using System;
using Cpp2IlInjected;

// Token: 0x020004D2 RID: 1234
[Token(Token = "0x20004D2")]
public class CherryShooter : Shooter
{
	// Token: 0x06001743 RID: 5955 RVA: 0x0007FE10 File Offset: 0x0007E010
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x0007FE20 File Offset: 0x0007E020
	[Token(Token = "0x6001744")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CherryShooter()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
