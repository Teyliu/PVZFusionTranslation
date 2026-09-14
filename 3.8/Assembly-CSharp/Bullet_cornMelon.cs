using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class Bullet_cornMelon : Bullet_melon
{
	// Token: 0x060005BB RID: 1467 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x6BF5A0", Offset = "0x6BDBA0", VA = "0x1806BF5A0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)num);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0001EE44 File Offset: 0x0001D044
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x6BF690", Offset = "0x6BDC90", VA = "0x1806BF690", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		int num2 = 0;
		base.AttackOtherZombie(zombie, (MelonSputterType)num2);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x6BF7D0", Offset = "0x6BDDD0", VA = "0x1806BF7D0")]
	public Bullet_cornMelon()
	{
	}
}
