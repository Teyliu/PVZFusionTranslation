using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class Bullet_pea_bombCherry : Bullet_pea_threeCherry
{
	// Token: 0x060006C5 RID: 1733 RVA: 0x00022C48 File Offset: 0x00020E48
	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x807AA0", Offset = "0x8060A0", VA = "0x180807AA0", Slot = "22")]
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

	// Token: 0x060006C6 RID: 1734 RVA: 0x00022CDC File Offset: 0x00020EDC
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea_bombCherry()
	{
	}
}
