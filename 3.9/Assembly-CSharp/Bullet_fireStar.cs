using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000146 RID: 326
[Token(Token = "0x2000146")]
public class Bullet_fireStar : Bullet_star
{
	// Token: 0x06000607 RID: 1543 RVA: 0x0001FA34 File Offset: 0x0001DC34
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x6EE4B0", Offset = "0x6ECAB0", VA = "0x1806EE4B0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int theZombieRow = zombie.theZombieRow;
		this.theBulletRow = theZombieRow;
		base.FireZombie(zombie, true);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0001FA60 File Offset: 0x0001DC60
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x6EE3D0", Offset = "0x6EC9D0", VA = "0x1806EE3D0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x6E70E0", Offset = "0x6E56E0", VA = "0x1806E70E0")]
	public Bullet_fireStar()
	{
	}
}
