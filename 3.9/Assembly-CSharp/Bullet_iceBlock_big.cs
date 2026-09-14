using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
public class Bullet_iceBlock_big : Bullet_iceBlock
{
	// Token: 0x06000631 RID: 1585 RVA: 0x00020698 File Offset: 0x0001E898
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x6F0BE0", Offset = "0x6EF1E0", VA = "0x1806F0BE0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.AddfreezeLevel(40, num);
		if (zombie == 0)
		{
		}
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(40, this, (DamageType)((uint)3), fromType, num2 != 0UL);
		int num3 = 0;
		zombie.SetCold(15f, 1, num3 != 0);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x000206FC File Offset: 0x0001E8FC
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_iceBlock_big()
	{
	}
}
