using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000180 RID: 384
[Token(Token = "0x2000180")]
public class Bullet_pea_threeCherry : Bullet
{
	// Token: 0x060006C5 RID: 1733 RVA: 0x000236C0 File Offset: 0x000218C0
	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x7DB0A0", Offset = "0x7D96A0", VA = "0x1807DB0A0", Slot = "25")]
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

	// Token: 0x060006C6 RID: 1734 RVA: 0x00023744 File Offset: 0x00021944
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x7DAFC0", Offset = "0x7D95C0", VA = "0x1807DAFC0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00023770 File Offset: 0x00021970
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x7DB1F0", Offset = "0x7D97F0", VA = "0x1807DB1F0")]
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

	// Token: 0x060006C8 RID: 1736 RVA: 0x00023800 File Offset: 0x00021A00
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea_threeCherry()
	{
	}

	// Token: 0x04000387 RID: 903
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000387")]
	public GameObject bombPrefab;
}
