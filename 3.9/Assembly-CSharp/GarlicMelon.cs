using System;
using Cpp2IlInjected;

// Token: 0x02000522 RID: 1314
[Token(Token = "0x2000522")]
public class GarlicMelon : Melonpult
{
	// Token: 0x06001892 RID: 6290 RVA: 0x00085390 File Offset: 0x00083590
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x525160", Offset = "0x523760", VA = "0x180525160", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_garlicMelon;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x000853A0 File Offset: 0x000835A0
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public GarlicMelon()
	{
	}
}
