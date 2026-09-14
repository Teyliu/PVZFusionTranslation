using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019E RID: 414
[Token(Token = "0x200019E")]
public class Bullet_silverButter : Bullet_butter
{
	// Token: 0x06000731 RID: 1841 RVA: 0x000247DC File Offset: 0x000229DC
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x80CD00", Offset = "0x80B300", VA = "0x18080CD00", Slot = "17")]
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

	// Token: 0x06000732 RID: 1842 RVA: 0x00024854 File Offset: 0x00022A54
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x80CF00", Offset = "0x80B500", VA = "0x18080CF00", Slot = "22")]
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

	// Token: 0x06000733 RID: 1843 RVA: 0x000248F8 File Offset: 0x00022AF8
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_silverButter()
	{
	}
}
