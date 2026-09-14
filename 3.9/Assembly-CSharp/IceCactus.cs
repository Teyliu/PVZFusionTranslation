using System;
using Cpp2IlInjected;

// Token: 0x02000539 RID: 1337
[Token(Token = "0x2000539")]
public class IceCactus : Cactus
{
	// Token: 0x060018F4 RID: 6388 RVA: 0x00086DB4 File Offset: 0x00084FB4
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x52AA80", Offset = "0x529080", VA = "0x18052AA80", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cactus_ice;
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00086DC8 File Offset: 0x00084FC8
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IceCactus()
	{
	}
}
