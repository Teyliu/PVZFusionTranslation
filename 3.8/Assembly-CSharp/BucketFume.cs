using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C1 RID: 1217
[Token(Token = "0x20004C1")]
public class BucketFume : FumeShroom
{
	// Token: 0x06001701 RID: 5889 RVA: 0x0007EB04 File Offset: 0x0007CD04
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x49B4E0", Offset = "0x499AE0", VA = "0x18049B4E0", Slot = "74")]
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

	// Token: 0x06001702 RID: 5890 RVA: 0x0007EB5C File Offset: 0x0007CD5C
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x49B5D0", Offset = "0x499BD0", VA = "0x18049B5D0", Slot = "69")]
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

	// Token: 0x06001703 RID: 5891 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x49B750", Offset = "0x499D50", VA = "0x18049B750")]
	public BucketFume()
	{
	}
}
