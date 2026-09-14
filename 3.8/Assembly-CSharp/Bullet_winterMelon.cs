using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public class Bullet_winterMelon : Bullet_melon
{
	// Token: 0x060007F4 RID: 2036 RVA: 0x00028FDC File Offset: 0x000271DC
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x853490", Offset = "0x851A90", VA = "0x180853490", Slot = "18")]
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

	// Token: 0x060007F5 RID: 2037 RVA: 0x0002902C File Offset: 0x0002722C
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x853580", Offset = "0x851B80", VA = "0x180853580", Slot = "25")]
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

	// Token: 0x060007F6 RID: 2038 RVA: 0x000290A4 File Offset: 0x000272A4
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x8536F0", Offset = "0x851CF0", VA = "0x1808536F0")]
	public Bullet_winterMelon()
	{
	}
}
