using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065B RID: 1627
[Token(Token = "0x200065B")]
public class Drown_c : Drown_b
{
	// Token: 0x06001EFE RID: 7934 RVA: 0x000A53BC File Offset: 0x000A35BC
	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x542260", Offset = "0x540860", VA = "0x180542260", Slot = "74")]
	protected override void AnimThrow()
	{
		int num;
		ulong num2;
		do
		{
			num = 0;
			Board board = this.board;
			if (num >= board.columnNum)
			{
				goto IL_0059;
			}
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get1x1Plants(num, theZombieRow);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				DrownProjectile drownWeapon = base.GetDrownWeapon();
				Transform shoot = this.shoot;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != (ulong)0L);
		num++;
		IL_0059:
		DrownProjectile drownWeapon2 = base.GetDrownWeapon();
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x000A5450 File Offset: 0x000A3650
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x541E90", Offset = "0x540490", VA = "0x180541E90")]
	public Drown_c()
	{
	}
}
