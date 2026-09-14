using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class Bullet_fireMelon : Bullet_melon
{
	// Token: 0x060005F6 RID: 1526 RVA: 0x0001F648 File Offset: 0x0001D848
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x6ED820", Offset = "0x6EBE20", VA = "0x1806ED820", Slot = "17")]
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

	// Token: 0x060005F7 RID: 1527 RVA: 0x0001F698 File Offset: 0x0001D898
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x6ED930", Offset = "0x6EBF30", VA = "0x1806ED930", Slot = "22")]
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

	// Token: 0x060005F8 RID: 1528 RVA: 0x0001F708 File Offset: 0x0001D908
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x6EDAA0", Offset = "0x6EC0A0", VA = "0x1806EDAA0")]
	public Bullet_fireMelon()
	{
	}
}
