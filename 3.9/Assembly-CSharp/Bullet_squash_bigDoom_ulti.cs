using System;
using Cpp2IlInjected;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
public class Bullet_squash_bigDoom_ulti : Bullet_squash_doom_ulti
{
	// Token: 0x0600078A RID: 1930 RVA: 0x00026298 File Offset: 0x00024498
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x811FF0", Offset = "0x8105F0", VA = "0x180811FF0", Slot = "22")]
	protected override void HitZombie(Zombie hit)
	{
		base.HitZombie(hit);
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x000262DC File Offset: 0x000244DC
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squash_bigDoom_ulti()
	{
	}
}
