using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000153")]
public class Bullet_iceBlock : Bullet_cabbage
{
	// Token: 0x0600062E RID: 1582 RVA: 0x000205F4 File Offset: 0x0001E7F4
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x6F0AA0", Offset = "0x6EF0A0", VA = "0x1806F0AA0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(40, num);
		if (zombie == 0)
		{
		}
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(40, this, (DamageType)((uint)5), fromType, num2 != 0UL);
		int num3 = 0;
		zombie.SetCold(15f, 1, num3 != 0);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00020658 File Offset: 0x0001E858
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x6F09C0", Offset = "0x6EEFC0", VA = "0x1806F09C0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00020684 File Offset: 0x0001E884
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_iceBlock()
	{
	}
}
