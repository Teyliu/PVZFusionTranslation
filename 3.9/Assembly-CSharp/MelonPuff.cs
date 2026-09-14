using System;
using Cpp2IlInjected;

// Token: 0x02000566 RID: 1382
[Token(Token = "0x2000566")]
public class MelonPuff : Thrower
{
	// Token: 0x060019B2 RID: 6578 RVA: 0x0008ABA8 File Offset: 0x00088DA8
	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x536890", Offset = "0x534E90", VA = "0x180536890", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_small;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x0008ABBC File Offset: 0x00088DBC
	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public MelonPuff()
	{
	}
}
