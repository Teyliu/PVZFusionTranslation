using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
public class Bullet_squash_doom_ulti : Bullet_squash
{
	// Token: 0x06000781 RID: 1921 RVA: 0x00026A4C File Offset: 0x00024C4C
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x7E4C50", Offset = "0x7E3250", VA = "0x1807E4C50", Slot = "27")]
	protected override void AttackZombie()
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					Bullet_doom_ulti.ActionOnZombie(num, this);
				}
			}
			num++;
		}
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00026ABC File Offset: 0x00024CBC
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squash_doom_ulti()
	{
	}
}
