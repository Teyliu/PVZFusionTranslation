using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018B RID: 395
[Token(Token = "0x200018B")]
public class Bullet_puffPotato : Bullet
{
	// Token: 0x060006F1 RID: 1777 RVA: 0x00024158 File Offset: 0x00022358
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x7DD140", Offset = "0x7DB740", VA = "0x1807DD140", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x000241A8 File Offset: 0x000223A8
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x7DD060", Offset = "0x7DB660", VA = "0x1807DD060", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x000241D4 File Offset: 0x000223D4
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puffPotato()
	{
	}
}
