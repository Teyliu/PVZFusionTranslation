using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014E RID: 334
[Token(Token = "0x200014E")]
public class Bullet_iceBlock : Bullet_cabbage
{
	// Token: 0x06000626 RID: 1574 RVA: 0x00020D5C File Offset: 0x0001EF5C
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x6C58B0", Offset = "0x6C3EB0", VA = "0x1806C58B0", Slot = "25")]
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

	// Token: 0x06000627 RID: 1575 RVA: 0x00020DC0 File Offset: 0x0001EFC0
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x6C57D0", Offset = "0x6C3DD0", VA = "0x1806C57D0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00020DEC File Offset: 0x0001EFEC
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_iceBlock()
	{
	}
}
