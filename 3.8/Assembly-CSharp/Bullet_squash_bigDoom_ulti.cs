using System;
using Cpp2IlInjected;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
public class Bullet_squash_bigDoom_ulti : Bullet_squash_doom_ulti
{
	// Token: 0x0600077D RID: 1917 RVA: 0x00026970 File Offset: 0x00024B70
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x7E4900", Offset = "0x7E2F00", VA = "0x1807E4900", Slot = "25")]
	protected override void HitZombie(Zombie hit)
	{
		base.HitZombie(hit);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000269B4 File Offset: 0x00024BB4
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squash_bigDoom_ulti()
	{
	}
}
