using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010E RID: 270
[Token(Token = "0x200010E")]
public class Bullet_butterMelon : Bullet_melon
{
	// Token: 0x0600054C RID: 1356 RVA: 0x0001CD60 File Offset: 0x0001AF60
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x6B75E0", Offset = "0x6B5BE0", VA = "0x1806B75E0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.AttackOtherZombie(num, (MelonSputterType)((uint)1));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x6B76D0", Offset = "0x6B5CD0", VA = "0x1806B76D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.Buttered(4f, true);
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)1));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001CE24 File Offset: 0x0001B024
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x6B7830", Offset = "0x6B5E30", VA = "0x1806B7830")]
	public Bullet_butterMelon()
	{
	}
}
