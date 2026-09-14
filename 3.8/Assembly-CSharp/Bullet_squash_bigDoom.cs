using System;
using Cpp2IlInjected;

// Token: 0x020001AF RID: 431
[Token(Token = "0x20001AF")]
public class Bullet_squash_bigDoom : Bullet_squash_doom
{
	// Token: 0x0600077B RID: 1915 RVA: 0x00026918 File Offset: 0x00024B18
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x7E4900", Offset = "0x7E2F00", VA = "0x1807E4900", Slot = "25")]
	protected override void HitZombie(Zombie hit)
	{
		base.HitZombie(hit);
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0002695C File Offset: 0x00024B5C
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squash_bigDoom()
	{
	}
}
