using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065A RID: 1626
[Token(Token = "0x200065A")]
public class Drown_b : Drown_a
{
	// Token: 0x06001EFB RID: 7931 RVA: 0x000A52C8 File Offset: 0x000A34C8
	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x541EE0", Offset = "0x5404E0", VA = "0x180541EE0", Slot = "74")]
	protected override void AnimThrow()
	{
		List<Plant> list;
		int num;
		ulong num2;
		do
		{
			DrownProjectile drownWeapon = base.GetDrownWeapon();
			list = new List();
			num = 0;
			Board board = this.board;
			if (num >= board.columnNum)
			{
				goto IL_0054;
			}
			int theZombieRow = this.theZombieRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(num, theZombieRow);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
			}
		}
		while (num2 != (ulong)0L);
		num++;
		IL_0054:
		Transform shoot = this.shoot;
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		Plant plant = list[num3];
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x000A536C File Offset: 0x000A356C
	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x000A53A8 File Offset: 0x000A35A8
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x541E90", Offset = "0x540490", VA = "0x180541E90")]
	public Drown_b()
	{
	}
}
