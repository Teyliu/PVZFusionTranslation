using System;
using Cpp2IlInjected;

// Token: 0x02000510 RID: 1296
[Token(Token = "0x2000510")]
public class IceCorn : Cornpult
{
	// Token: 0x0600182F RID: 6191 RVA: 0x00083608 File Offset: 0x00081808
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x4CE840", Offset = "0x4CCE40", VA = "0x1804CE840", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_ice;
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x0008361C File Offset: 0x0008181C
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x4CE830", Offset = "0x4CCE30", VA = "0x1804CE830", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_ice;
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00083630 File Offset: 0x00081830
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public IceCorn()
	{
	}
}
