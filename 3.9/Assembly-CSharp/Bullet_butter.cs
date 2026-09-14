using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000113 RID: 275
[Token(Token = "0x2000113")]
public class Bullet_butter : Bullet_cabbage
{
	// Token: 0x0600055A RID: 1370 RVA: 0x0001C630 File Offset: 0x0001A830
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x6E2770", Offset = "0x6E0D70", VA = "0x1806E2770", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0001C66C File Offset: 0x0001A86C
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x6E2830", Offset = "0x6E0E30", VA = "0x1806E2830", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		zombie.Buttered(4f, true);
		base.Die();
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter()
	{
	}
}
