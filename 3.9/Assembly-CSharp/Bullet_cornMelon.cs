using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
public class Bullet_cornMelon : Bullet_melon
{
	// Token: 0x060005C2 RID: 1474 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x6EA360", Offset = "0x6E8960", VA = "0x1806EA360", Slot = "17")]
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

	// Token: 0x060005C3 RID: 1475 RVA: 0x0001E614 File Offset: 0x0001C814
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x6EA450", Offset = "0x6E8A50", VA = "0x1806EA450", Slot = "22")]
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

	// Token: 0x060005C4 RID: 1476 RVA: 0x0001E680 File Offset: 0x0001C880
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x6EA590", Offset = "0x6E8B90", VA = "0x1806EA590")]
	public Bullet_cornMelon()
	{
	}
}
