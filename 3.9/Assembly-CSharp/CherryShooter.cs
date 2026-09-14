using System;
using Cpp2IlInjected;

// Token: 0x020004F9 RID: 1273
[Token(Token = "0x20004F9")]
public class CherryShooter : Shooter
{
	// Token: 0x060017F6 RID: 6134 RVA: 0x00082FB4 File Offset: 0x000811B4
	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x00082FC4 File Offset: 0x000811C4
	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public CherryShooter()
	{
	}
}
