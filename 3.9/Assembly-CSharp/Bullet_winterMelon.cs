using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
public class Bullet_winterMelon : Bullet_melon
{
	// Token: 0x0600080A RID: 2058 RVA: 0x00028B9C File Offset: 0x00026D9C
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x8E2170", Offset = "0x8E0770", VA = "0x1808E2170", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.AttackOtherZombie(num, (MelonSputterType)((uint)4));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00028BEC File Offset: 0x00026DEC
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x8E2260", Offset = "0x8E0860", VA = "0x1808E2260", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		if (zombie == 0)
		{
		}
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)3), fromType, num != 0UL);
		int num2 = 0;
		zombie.AddfreezeLevel(50, num2);
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)4));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00028C64 File Offset: 0x00026E64
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x8E23D0", Offset = "0x8E09D0", VA = "0x1808E23D0")]
	public Bullet_winterMelon()
	{
	}
}
