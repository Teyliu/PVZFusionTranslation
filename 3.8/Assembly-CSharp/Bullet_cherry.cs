using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class Bullet_cherry : Bullet
{
	// Token: 0x060005B0 RID: 1456 RVA: 0x0001EADC File Offset: 0x0001CCDC
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x6BF320", Offset = "0x6BD920", VA = "0x1806BF320", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		TimeBomb timeBomb = zombie.timeBomb;
		int num2 = 0;
		if (timeBomb != num2)
		{
			TimeBomb timeBomb2 = zombie.timeBomb;
			int damage2 = this._damage;
			timeBomb2.Charge(damage2);
		}
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)3), (MissionResult)((uint)2)) && global::UnityEngine.Random.Range(0, 6) == 0)
		{
			BoardAction boardAction = this.board.boardAction;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			PlantType fromType2 = this.fromType;
		}
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0001EB98 File Offset: 0x0001CD98
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x6BF110", Offset = "0x6BD710", VA = "0x1806BF110", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x6BF1F0", Offset = "0x6BD7F0", VA = "0x1806BF1F0", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cherry()
	{
	}
}
