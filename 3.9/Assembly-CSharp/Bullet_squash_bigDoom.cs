using System;
using Cpp2IlInjected;

// Token: 0x020001B6 RID: 438
[Token(Token = "0x20001B6")]
public class Bullet_squash_bigDoom : Bullet_squash_doom
{
	// Token: 0x06000788 RID: 1928 RVA: 0x00026240 File Offset: 0x00024440
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x811FF0", Offset = "0x8105F0", VA = "0x180811FF0", Slot = "22")]
	protected override void HitZombie(Zombie hit)
	{
		base.HitZombie(hit);
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00026284 File Offset: 0x00024484
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squash_bigDoom()
	{
	}
}
