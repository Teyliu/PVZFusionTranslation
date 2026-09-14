using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class Bullet_fireStar : Bullet_star
{
	// Token: 0x06000600 RID: 1536 RVA: 0x0002024C File Offset: 0x0001E44C
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x6C2DF0", Offset = "0x6C13F0", VA = "0x1806C2DF0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.FireZombie(zombie, true);
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00020264 File Offset: 0x0001E464
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x6C35F0", Offset = "0x6C1BF0", VA = "0x1806C35F0", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x000202A4 File Offset: 0x0001E4A4
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x6BC210", Offset = "0x6BA810", VA = "0x1806BC210")]
	public Bullet_fireStar()
	{
	}
}
