using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
public class Bullet_jackboxStar : Bullet_star
{
	// Token: 0x0600064E RID: 1614 RVA: 0x00021814 File Offset: 0x0001FA14
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x6C7F50", Offset = "0x6C6550", VA = "0x1806C7F50", Slot = "25")]
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

	// Token: 0x0600064F RID: 1615 RVA: 0x00021870 File Offset: 0x0001FA70
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x6C7E20", Offset = "0x6C6420", VA = "0x1806C7E20", Slot = "18")]
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

	// Token: 0x06000650 RID: 1616 RVA: 0x000218CC File Offset: 0x0001FACC
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x6BC210", Offset = "0x6BA810", VA = "0x1806BC210")]
	public Bullet_jackboxStar()
	{
	}
}
