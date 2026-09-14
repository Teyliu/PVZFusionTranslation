using System;
using Cpp2IlInjected;

// Token: 0x0200053B RID: 1339
[Token(Token = "0x200053B")]
public class IceCorn : Cornpult
{
	// Token: 0x060018F8 RID: 6392 RVA: 0x00086E58 File Offset: 0x00085058
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x52AC00", Offset = "0x529200", VA = "0x18052AC00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_ice;
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00086E6C File Offset: 0x0008506C
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x52ABF0", Offset = "0x5291F0", VA = "0x18052ABF0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_ice;
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00086E80 File Offset: 0x00085080
	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public IceCorn()
	{
	}
}
