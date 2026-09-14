using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010D RID: 269
[Token(Token = "0x200010D")]
public class Bullet_butter : Bullet_cabbage
{
	// Token: 0x06000549 RID: 1353 RVA: 0x0001CCAC File Offset: 0x0001AEAC
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x6B7880", Offset = "0x6B5E80", VA = "0x1806B7880", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x6B7940", Offset = "0x6B5F40", VA = "0x1806B7940", Slot = "25")]
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

	// Token: 0x0600054B RID: 1355 RVA: 0x0001CD4C File Offset: 0x0001AF4C
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter()
	{
	}
}
