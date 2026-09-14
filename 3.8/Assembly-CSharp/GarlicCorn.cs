using System;
using Cpp2IlInjected;

// Token: 0x020004F6 RID: 1270
[Token(Token = "0x20004F6")]
public class GarlicCorn : Cornpult
{
	// Token: 0x060017C6 RID: 6086 RVA: 0x00081AF8 File Offset: 0x0007FCF8
	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x4C8D70", Offset = "0x4C7370", VA = "0x1804C8D70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_garlicKernal;
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x00081B08 File Offset: 0x0007FD08
	[Token(Token = "0x60017C7")]
	[Address(RVA = "0x4C8D60", Offset = "0x4C7360", VA = "0x1804C8D60", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_garlicButter;
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x00081B18 File Offset: 0x0007FD18
	[Token(Token = "0x60017C8")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public GarlicCorn()
	{
	}
}
