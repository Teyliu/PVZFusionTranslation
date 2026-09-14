using System;
using Cpp2IlInjected;

// Token: 0x02000575 RID: 1397
[Token(Token = "0x2000575")]
public class PortalMelon : Melonpult
{
	// Token: 0x060019F0 RID: 6640 RVA: 0x0008B94C File Offset: 0x00089B4C
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x539340", Offset = "0x537940", VA = "0x180539340", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_portal;
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0008B960 File Offset: 0x00089B60
	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public PortalMelon()
	{
	}
}
