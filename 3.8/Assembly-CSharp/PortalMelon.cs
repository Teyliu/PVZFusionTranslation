using System;
using Cpp2IlInjected;

// Token: 0x02000547 RID: 1351
[Token(Token = "0x2000547")]
public class PortalMelon : Melonpult
{
	// Token: 0x0600191B RID: 6427 RVA: 0x00087BA4 File Offset: 0x00085DA4
	[Token(Token = "0x600191B")]
	[Address(RVA = "0x4DBBC0", Offset = "0x4DA1C0", VA = "0x1804DBBC0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_portal;
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00087BB8 File Offset: 0x00085DB8
	[Token(Token = "0x600191C")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public PortalMelon()
	{
	}
}
