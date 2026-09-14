using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000197 RID: 407
[Token(Token = "0x2000197")]
public class Bullet_silverButter : Bullet_butter
{
	// Token: 0x06000724 RID: 1828 RVA: 0x00024EB0 File Offset: 0x000230B0
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x7DF5C0", Offset = "0x7DDBC0", VA = "0x1807DF5C0", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateItem instance = CreateItem.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		CreateItem instance2 = CreateItem.Instance;
		Transform transform4 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		base.Die();
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00024F28 File Offset: 0x00023128
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x7DF7C0", Offset = "0x7DDDC0", VA = "0x1807DF7C0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateItem instance = CreateItem.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		CreateItem instance2 = CreateItem.Instance;
		Transform transform4 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.Buttered(4f, true);
		base.Die();
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00024FCC File Offset: 0x000231CC
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_silverButter()
	{
	}
}
