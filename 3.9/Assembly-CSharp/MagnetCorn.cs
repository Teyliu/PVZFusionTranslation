using System;
using Cpp2IlInjected;

// Token: 0x02000561 RID: 1377
[Token(Token = "0x2000561")]
public class MagnetCorn : Cornpult
{
	// Token: 0x0600199C RID: 6556 RVA: 0x0008A8E4 File Offset: 0x00088AE4
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x536230", Offset = "0x534830", VA = "0x180536230", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_magnet;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x0008A8F4 File Offset: 0x00088AF4
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x536220", Offset = "0x534820", VA = "0x180536220", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_magnet;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x0008A904 File Offset: 0x00088B04
	[Token(Token = "0x600199E")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public MagnetCorn()
	{
	}
}
