using System;
using Cpp2IlInjected;

// Token: 0x02000533 RID: 1331
[Token(Token = "0x2000533")]
public class HypnoMelon : Thrower
{
	// Token: 0x060018DC RID: 6364 RVA: 0x00086904 File Offset: 0x00084B04
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x528010", Offset = "0x526610", VA = "0x180528010", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_hypno;
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00086918 File Offset: 0x00084B18
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public HypnoMelon()
	{
	}
}
