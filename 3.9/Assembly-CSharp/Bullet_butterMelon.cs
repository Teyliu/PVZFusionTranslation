using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public class Bullet_butterMelon : Bullet_melon
{
	// Token: 0x0600055D RID: 1373 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x6E24D0", Offset = "0x6E0AD0", VA = "0x1806E24D0", Slot = "17")]
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

	// Token: 0x0600055E RID: 1374 RVA: 0x0001C734 File Offset: 0x0001A934
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x6E25C0", Offset = "0x6E0BC0", VA = "0x1806E25C0", Slot = "22")]
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

	// Token: 0x0600055F RID: 1375 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x6E2720", Offset = "0x6E0D20", VA = "0x1806E2720")]
	public Bullet_butterMelon()
	{
	}
}
