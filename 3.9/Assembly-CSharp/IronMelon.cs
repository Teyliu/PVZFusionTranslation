using System;
using Cpp2IlInjected;

// Token: 0x02000549 RID: 1353
[Token(Token = "0x2000549")]
public class IronMelon : Melonpult
{
	// Token: 0x0600192D RID: 6445 RVA: 0x000886BC File Offset: 0x000868BC
	[Token(Token = "0x600192D")]
	[Address(RVA = "0x52C4D0", Offset = "0x52AAD0", VA = "0x18052C4D0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_iron;
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x000886D0 File Offset: 0x000868D0
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public IronMelon()
	{
	}
}
