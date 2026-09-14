using System;
using Cpp2IlInjected;

// Token: 0x0200059A RID: 1434
[Token(Token = "0x200059A")]
public class SquashMelon : Melonpult
{
	// Token: 0x06001A9C RID: 6812 RVA: 0x0008ECA4 File Offset: 0x0008CEA4
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x5444C0", Offset = "0x542AC0", VA = "0x1805444C0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_squashMelon;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public SquashMelon()
	{
	}
}
