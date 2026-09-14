using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058B RID: 1419
[Token(Token = "0x200058B")]
public class ThreeCabbage : Cabbage
{
	// Token: 0x06001A35 RID: 6709 RVA: 0x0008D010 File Offset: 0x0008B210
	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x4ECDE0", Offset = "0x4EB3E0", VA = "0x1804ECDE0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_three;
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x0008D024 File Offset: 0x0008B224
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x4ECDF0", Offset = "0x4EB3F0", VA = "0x1804ECDF0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x0008D040 File Offset: 0x0008B240
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x4ECE40", Offset = "0x4EB440", VA = "0x1804ECE40", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x0008D05C File Offset: 0x0008B25C
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x4ECEA0", Offset = "0x4EB4A0", VA = "0x1804ECEA0", Slot = "69")]
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
		Bullet bullet4 = base.Shoot1();
		bullet4.theStatus = (BulletStatus)((ulong)9L);
		return bullet4;
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x0008D118 File Offset: 0x0008B318
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x4ECBA0", Offset = "0x4EB1A0", VA = "0x1804ECBA0", Slot = "14")]
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

	// Token: 0x06001A3A RID: 6714 RVA: 0x0008D180 File Offset: 0x0008B380
	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public ThreeCabbage()
	{
	}
}
