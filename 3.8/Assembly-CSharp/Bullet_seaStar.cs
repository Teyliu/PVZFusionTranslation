using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018F RID: 399
[Token(Token = "0x200018F")]
public class Bullet_seaStar : Bullet_star
{
	// Token: 0x06000701 RID: 1793 RVA: 0x000245D8 File Offset: 0x000227D8
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x7DE350", Offset = "0x7DC950", VA = "0x1807DE350", Slot = "25")]
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

	// Token: 0x06000702 RID: 1794 RVA: 0x00024628 File Offset: 0x00022828
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x7DE270", Offset = "0x7DC870", VA = "0x1807DE270", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00024654 File Offset: 0x00022854
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x7DB980", Offset = "0x7D9F80", VA = "0x1807DB980")]
	public Bullet_seaStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
