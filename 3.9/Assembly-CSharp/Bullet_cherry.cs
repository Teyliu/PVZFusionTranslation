using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000130 RID: 304
[Token(Token = "0x2000130")]
public class Bullet_cherry : Bullet
{
	// Token: 0x060005B7 RID: 1463 RVA: 0x0001E2AC File Offset: 0x0001C4AC
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x6EA0E0", Offset = "0x6E86E0", VA = "0x1806EA0E0", Slot = "22")]
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

	// Token: 0x060005B8 RID: 1464 RVA: 0x0001E368 File Offset: 0x0001C568
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x6E9ED0", Offset = "0x6E84D0", VA = "0x1806E9ED0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0001E394 File Offset: 0x0001C594
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x6E9FB0", Offset = "0x6E85B0", VA = "0x1806E9FB0", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cherry()
	{
	}
}
