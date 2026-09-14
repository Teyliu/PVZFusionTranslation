using System;
using Cpp2IlInjected;

// Token: 0x02000508 RID: 1288
[Token(Token = "0x2000508")]
public class HypnoMelon : Thrower
{
	// Token: 0x06001813 RID: 6163 RVA: 0x000830C4 File Offset: 0x000812C4
	[Token(Token = "0x6001813")]
	[Address(RVA = "0x4CBCF0", Offset = "0x4CA2F0", VA = "0x1804CBCF0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_hypno;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x000830D8 File Offset: 0x000812D8
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public HypnoMelon()
	{
	}
}
