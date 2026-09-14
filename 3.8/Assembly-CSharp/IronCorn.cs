using System;
using Cpp2IlInjected;

// Token: 0x0200051B RID: 1307
[Token(Token = "0x200051B")]
public class IronCorn : Cornpult
{
	// Token: 0x0600185B RID: 6235 RVA: 0x00084AF4 File Offset: 0x00082CF4
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x4CFB90", Offset = "0x4CE190", VA = "0x1804CFB90", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_iron;
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00084B04 File Offset: 0x00082D04
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x4CFB80", Offset = "0x4CE180", VA = "0x1804CFB80", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_iron;
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00084B14 File Offset: 0x00082D14
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public IronCorn()
	{
	}
}
