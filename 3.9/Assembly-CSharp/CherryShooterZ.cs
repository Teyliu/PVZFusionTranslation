using System;
using Cpp2IlInjected;

// Token: 0x02000674 RID: 1652
[Token(Token = "0x2000674")]
public class CherryShooterZ : PeaShooterZ
{
	// Token: 0x06001F5D RID: 8029 RVA: 0x000A6EBC File Offset: 0x000A50BC
	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "77")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000A6ECC File Offset: 0x000A50CC
	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x59B640", Offset = "0x599C40", VA = "0x18059B640", Slot = "78")]
	protected override int GetBulletDamage()
	{
		int bulletDamage = base.GetBulletDamage();
		return bulletDamage + bulletDamage;
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000A6EE8 File Offset: 0x000A50E8
	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x59B660", Offset = "0x599C60", VA = "0x18059B660")]
	public CherryShooterZ()
	{
	}
}
