using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
public class Bullet_pea_threeCherry : Bullet
{
	// Token: 0x060006D4 RID: 1748 RVA: 0x000230B8 File Offset: 0x000212B8
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x808A60", Offset = "0x807060", VA = "0x180808A60", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		TimeBomb timeBomb = zombie.timeBomb;
		int num = 0;
		if (!(timeBomb == num))
		{
			TimeBomb timeBomb2 = zombie.timeBomb;
			int damage = this._damage;
			timeBomb2.Charge(damage);
			int num2 = 0;
			int damage2 = this._damage;
			PlantType fromType = this.fromType;
			ulong num3;
			zombie.TakeDamage(damage2, this, (DamageType)num2, fromType, num3 != 0UL);
		}
		this.SetBomb(zombie);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0002313C File Offset: 0x0002133C
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x808980", Offset = "0x806F80", VA = "0x180808980", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00023168 File Offset: 0x00021368
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x808BB0", Offset = "0x8071B0", VA = "0x180808BB0")]
	protected void SetBomb(Zombie zombie)
	{
		Board board = this.board;
		GameObject gameObject = this.bombPrefab;
		Transform transform = board.transform;
		TimeBomb component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<TimeBomb>();
		Transform transform2 = component.transform;
		Collider2D col = zombie.col;
		Transform transform3 = component.transform;
		Transform transform4 = zombie.transform;
		transform3.parentInternal = transform4;
		component.zombie = zombie;
		int damage = this._damage;
		component.damage = damage;
		zombie.timeBomb = component;
		PlantType fromType = this.fromType;
		component.fromType = fromType;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x000231F8 File Offset: 0x000213F8
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea_threeCherry()
	{
	}

	// Token: 0x04000390 RID: 912
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000390")]
	public GameObject bombPrefab;
}
