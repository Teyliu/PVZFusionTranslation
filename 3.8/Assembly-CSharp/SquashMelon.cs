using System;
using Cpp2IlInjected;

// Token: 0x0200056A RID: 1386
[Token(Token = "0x200056A")]
public class SquashMelon : Melonpult
{
	// Token: 0x060019BC RID: 6588 RVA: 0x0008ABF0 File Offset: 0x00088DF0
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x4E6050", Offset = "0x4E4650", VA = "0x1804E6050", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_squashMelon;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x0008AC04 File Offset: 0x00088E04
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public SquashMelon()
	{
	}
}
