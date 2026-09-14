using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
public class Bullet_fireMelon : Bullet_melon
{
	// Token: 0x060005EF RID: 1519 RVA: 0x0001FE60 File Offset: 0x0001E060
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x6C2A40", Offset = "0x6C1040", VA = "0x1806C2A40", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.AttackOtherZombie(num, (MelonSputterType)((uint)3));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x6C2B50", Offset = "0x6C1150", VA = "0x1806C2B50", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.SetJalaed();
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)3));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0001FF20 File Offset: 0x0001E120
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x6C2CC0", Offset = "0x6C12C0", VA = "0x1806C2CC0")]
	public Bullet_fireMelon()
	{
	}
}
