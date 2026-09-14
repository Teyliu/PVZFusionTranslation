using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058E RID: 1422
[Token(Token = "0x200058E")]
public class ThreeMelon : Melonpult
{
	// Token: 0x06001A46 RID: 6726 RVA: 0x0008D624 File Offset: 0x0008B824
	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x4EF7D0", Offset = "0x4EDDD0", VA = "0x1804EF7D0", Slot = "69")]
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

	// Token: 0x06001A47 RID: 6727 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x4EF590", Offset = "0x4EDB90", VA = "0x1804EF590", Slot = "14")]
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

	// Token: 0x06001A48 RID: 6728 RVA: 0x0008D738 File Offset: 0x0008B938
	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public ThreeMelon()
	{
	}
}
