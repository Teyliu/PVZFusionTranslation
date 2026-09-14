using System;
using Cpp2IlInjected;

// Token: 0x02000534 RID: 1332
[Token(Token = "0x2000534")]
public class MagnetCorn : Cornpult
{
	// Token: 0x060018CC RID: 6348 RVA: 0x00086C20 File Offset: 0x00084E20
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x4D5920", Offset = "0x4D3F20", VA = "0x1804D5920", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_magnet;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x00086C30 File Offset: 0x00084E30
	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x4D5910", Offset = "0x4D3F10", VA = "0x1804D5910", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_magnet;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x00086C40 File Offset: 0x00084E40
	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public MagnetCorn()
	{
	}
}
