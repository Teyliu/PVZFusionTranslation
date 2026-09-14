using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
public class Bullet_squash_doom : Bullet_squash
{
	// Token: 0x0600077F RID: 1919 RVA: 0x000269C8 File Offset: 0x00024BC8
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x7E49D0", Offset = "0x7E2FD0", VA = "0x1807E49D0", Slot = "27")]
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
					PlantType fromType = this.fromType;
				}
			}
			num++;
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00026A38 File Offset: 0x00024C38
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squash_doom()
	{
	}
}
