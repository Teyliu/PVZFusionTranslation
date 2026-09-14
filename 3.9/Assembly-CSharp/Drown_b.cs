using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000690 RID: 1680
[Token(Token = "0x2000690")]
public class Drown_b : Drown_a
{
	// Token: 0x06001FFD RID: 8189 RVA: 0x000A9A44 File Offset: 0x000A7C44
	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x5A4640", Offset = "0x5A2C40", VA = "0x1805A4640", Slot = "76")]
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

	// Token: 0x06001FFE RID: 8190 RVA: 0x000A9AE8 File Offset: 0x000A7CE8
	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000A9B24 File Offset: 0x000A7D24
	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x5A45F0", Offset = "0x5A2BF0", VA = "0x1805A45F0")]
	public Drown_b()
	{
	}
}
