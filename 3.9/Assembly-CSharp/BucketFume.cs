using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E6 RID: 1254
[Token(Token = "0x20004E6")]
public class BucketFume : FumeShroom
{
	// Token: 0x060017AF RID: 6063 RVA: 0x00081A64 File Offset: 0x0007FC64
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x50AE30", Offset = "0x509430", VA = "0x18050AE30", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		GameObject theFirstArmor = zombie.theFirstArmor;
		int num = 0;
		if (!(theFirstArmor != num))
		{
			int attackDamage = this.attackDamage;
			PlantType thePlantType = this.thePlantType;
			ulong num2;
			zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num2 != 0UL);
			return;
		}
		PlantType thePlantType2 = this.thePlantType;
		ulong num3;
		zombie.TakeDamage(num, this, (DamageType)((uint)1), thePlantType2, num3 != 0UL);
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00081ABC File Offset: 0x0007FCBC
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x50AF20", Offset = "0x509520", VA = "0x18050AF20", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00081B14 File Offset: 0x0007FD14
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x50B0A0", Offset = "0x5096A0", VA = "0x18050B0A0")]
	public BucketFume()
	{
	}
}
