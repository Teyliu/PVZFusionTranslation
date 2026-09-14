using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200017C")]
public class Bullet_normalSun : Bullet_smallSun
{
	// Token: 0x060006B0 RID: 1712 RVA: 0x00022744 File Offset: 0x00020944
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x806B10", Offset = "0x805110", VA = "0x180806B10", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x000227AC File Offset: 0x000209AC
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_normalSun()
	{
	}
}
