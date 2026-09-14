using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
public class Bullet_jackboxStar : Bullet_star
{
	// Token: 0x06000658 RID: 1624 RVA: 0x000211B0 File Offset: 0x0001F3B0
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x6F3780", Offset = "0x6F1D80", VA = "0x1806F3780", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		GameAPP.PlaySound(43, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x0002120C File Offset: 0x0001F40C
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x6F3650", Offset = "0x6F1C50", VA = "0x1806F3650", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		GameAPP.PlaySound(43, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00021268 File Offset: 0x0001F468
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x6E70E0", Offset = "0x6E56E0", VA = "0x1806E70E0")]
	public Bullet_jackboxStar()
	{
	}
}
