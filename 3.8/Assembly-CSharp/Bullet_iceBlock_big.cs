using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014F RID: 335
[Token(Token = "0x200014F")]
public class Bullet_iceBlock_big : Bullet_iceBlock
{
	// Token: 0x06000629 RID: 1577 RVA: 0x00020E00 File Offset: 0x0001F000
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x6C59F0", Offset = "0x6C3FF0", VA = "0x1806C59F0", Slot = "25")]
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

	// Token: 0x0600062A RID: 1578 RVA: 0x00020E64 File Offset: 0x0001F064
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_iceBlock_big()
	{
	}
}
