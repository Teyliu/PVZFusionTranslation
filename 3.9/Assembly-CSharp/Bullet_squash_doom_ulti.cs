using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B9 RID: 441
[Token(Token = "0x20001B9")]
public class Bullet_squash_doom_ulti : Bullet_squash
{
	// Token: 0x0600078E RID: 1934 RVA: 0x00026374 File Offset: 0x00024574
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x812340", Offset = "0x810940", VA = "0x180812340", Slot = "25")]
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

	// Token: 0x0600078F RID: 1935 RVA: 0x000263E4 File Offset: 0x000245E4
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squash_doom_ulti()
	{
	}
}
