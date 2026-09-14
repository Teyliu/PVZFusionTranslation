using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000176 RID: 374
[Token(Token = "0x2000176")]
public class Bullet_normalSun : Bullet_smallSun
{
	// Token: 0x060006A5 RID: 1701 RVA: 0x00022DF4 File Offset: 0x00020FF4
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x7D9280", Offset = "0x7D7880", VA = "0x1807D9280", Slot = "25")]
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

	// Token: 0x060006A6 RID: 1702 RVA: 0x00022E5C File Offset: 0x0002105C
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_normalSun()
	{
	}
}
