using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019A RID: 410
[Token(Token = "0x200019A")]
public class Bullet_silverMelon : Bullet_melon
{
	// Token: 0x0600072E RID: 1838 RVA: 0x00025168 File Offset: 0x00023368
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x7DFF20", Offset = "0x7DE520", VA = "0x1807DFF20", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)num);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x000251C0 File Offset: 0x000233C0
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x7E0040", Offset = "0x7DE640", VA = "0x1807E0040", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
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

	// Token: 0x06000730 RID: 1840 RVA: 0x00025234 File Offset: 0x00023434
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x7E01B0", Offset = "0x7DE7B0", VA = "0x1807E01B0")]
	public Bullet_silverMelon()
	{
	}
}
