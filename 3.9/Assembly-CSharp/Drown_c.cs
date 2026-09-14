using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000691 RID: 1681
[Token(Token = "0x2000691")]
public class Drown_c : Drown_b
{
	// Token: 0x06002000 RID: 8192 RVA: 0x000A9B38 File Offset: 0x000A7D38
	[Token(Token = "0x6002000")]
	[Address(RVA = "0x5A49C0", Offset = "0x5A2FC0", VA = "0x1805A49C0", Slot = "76")]
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

	// Token: 0x06002001 RID: 8193 RVA: 0x000A9BCC File Offset: 0x000A7DCC
	[Token(Token = "0x6002001")]
	[Address(RVA = "0x5A45F0", Offset = "0x5A2BF0", VA = "0x1805A45F0")]
	public Drown_c()
	{
	}
}
