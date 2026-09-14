using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public class Bullet_goldSquashKelp : Bullet_squashKelp
{
	// Token: 0x0600061E RID: 1566 RVA: 0x00020048 File Offset: 0x0001E248
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x6EF790", Offset = "0x6EDD90", VA = "0x1806EF790", Slot = "25")]
	protected override void AttackZombie()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				Board board = this.board;
				PlantType fromType = this.fromType;
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x000200BC File Offset: 0x0001E2BC
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_goldSquashKelp()
	{
	}
}
