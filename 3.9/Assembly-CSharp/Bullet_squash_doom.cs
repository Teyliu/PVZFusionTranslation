using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B8 RID: 440
[Token(Token = "0x20001B8")]
public class Bullet_squash_doom : Bullet_squash
{
	// Token: 0x0600078C RID: 1932 RVA: 0x000262F0 File Offset: 0x000244F0
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x8120C0", Offset = "0x8106C0", VA = "0x1808120C0", Slot = "25")]
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

	// Token: 0x0600078D RID: 1933 RVA: 0x00026360 File Offset: 0x00024560
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squash_doom()
	{
	}
}
