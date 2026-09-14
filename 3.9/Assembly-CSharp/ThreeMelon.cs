using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BF RID: 1471
[Token(Token = "0x20005BF")]
public class ThreeMelon : Melonpult
{
	// Token: 0x06001B2C RID: 6956 RVA: 0x000919D0 File Offset: 0x0008FBD0
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x54DD70", Offset = "0x54C370", VA = "0x18054DD70", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int thePlantRow = this.thePlantRow;
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Bullet bullet = base.Shoot1();
		Transform shoot2 = this.shoot;
		Vector3 vector2;
		float z2 = vector2.z;
		int num = thePlantRow - 1;
		Board board = this.board;
		this.thePlantRow = thePlantRow;
		int rowNum = board.rowNum;
		Transform shoot3 = this.shoot;
		Vector3 vector3;
		float z3 = vector3.z;
		Bullet bullet2 = base.Shoot1();
		Transform shoot4 = this.shoot;
		Vector3 vector4;
		float z4 = vector4.z;
		int num2 = thePlantRow + 1;
		this.thePlantRow = num2;
		Bullet bullet3 = base.Shoot1();
		this.thePlantRow = thePlantRow;
		return base.Shoot1();
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00091A7C File Offset: 0x0008FC7C
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x54DB30", Offset = "0x54C130", VA = "0x18054DB30", Slot = "14")]
	protected override bool DetactiveEnermy()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float vision = this.vision;
				if (!base.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00091AE4 File Offset: 0x0008FCE4
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public ThreeMelon()
	{
	}
}
