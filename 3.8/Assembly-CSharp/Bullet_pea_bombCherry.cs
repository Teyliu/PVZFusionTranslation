using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
public class Bullet_pea_bombCherry : Bullet_pea_threeCherry
{
	// Token: 0x060006B6 RID: 1718 RVA: 0x00023250 File Offset: 0x00021450
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x7DA0E0", Offset = "0x7D86E0", VA = "0x1807DA0E0", Slot = "25")]
	protected override void HitZombie(Zombie z)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z2 = vector.z;
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				bool flag2;
				if (!flag2)
				{
					int damage = this._damage;
					PlantType fromType = this.fromType;
					num++;
				}
				base.SetBomb(num);
			}
			num++;
		}
		uint num2;
		GameAPP.PlaySound((int)num2, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000232E4 File Offset: 0x000214E4
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea_bombCherry()
	{
	}
}
