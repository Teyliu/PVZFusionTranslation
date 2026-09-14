using System;
using Cpp2IlInjected;

// Token: 0x0200051F RID: 1311
[Token(Token = "0x200051F")]
public class JalaCorn : Cornpult
{
	// Token: 0x06001864 RID: 6244 RVA: 0x00084C28 File Offset: 0x00082E28
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x4CFEA0", Offset = "0x4CE4A0", VA = "0x1804CFEA0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_jala;
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00084C3C File Offset: 0x00082E3C
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x4CFE90", Offset = "0x4CE490", VA = "0x1804CFE90", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_jala;
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00084C50 File Offset: 0x00082E50
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public JalaCorn()
	{
	}
}
