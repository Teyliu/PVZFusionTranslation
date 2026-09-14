using System;
using Cpp2IlInjected;

// Token: 0x02000563 RID: 1379
[Token(Token = "0x2000563")]
public class MagnetMelon : Melonpult
{
	// Token: 0x060019A2 RID: 6562 RVA: 0x0008A9B8 File Offset: 0x00088BB8
	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x536430", Offset = "0x534A30", VA = "0x180536430", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_magnet;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x0008A9CC File Offset: 0x00088BCC
	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public MagnetMelon()
	{
	}
}
