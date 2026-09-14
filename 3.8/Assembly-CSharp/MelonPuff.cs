using System;
using Cpp2IlInjected;

// Token: 0x02000539 RID: 1337
[Token(Token = "0x2000539")]
public class MelonPuff : Thrower
{
	// Token: 0x060018E2 RID: 6370 RVA: 0x00086EF0 File Offset: 0x000850F0
	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x4D5F80", Offset = "0x4D4580", VA = "0x1804D5F80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_small;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00086F04 File Offset: 0x00085104
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public MelonPuff()
	{
	}
}
