using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BC RID: 1468
[Token(Token = "0x20005BC")]
public class ThreeCabbage : Cabbage
{
	// Token: 0x06001B1B RID: 6939 RVA: 0x00091398 File Offset: 0x0008F598
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x54CC50", Offset = "0x54B250", VA = "0x18054CC50", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_three;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x000913AC File Offset: 0x0008F5AC
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x54CC60", Offset = "0x54B260", VA = "0x18054CC60", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000913C8 File Offset: 0x0008F5C8
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x54CCB0", Offset = "0x54B2B0", VA = "0x18054CCB0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x000913E4 File Offset: 0x0008F5E4
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x54CD10", Offset = "0x54B310", VA = "0x18054CD10", Slot = "68")]
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

	// Token: 0x06001B1F RID: 6943 RVA: 0x000914A0 File Offset: 0x0008F6A0
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x54CA10", Offset = "0x54B010", VA = "0x18054CA10", Slot = "14")]
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

	// Token: 0x06001B20 RID: 6944 RVA: 0x00091508 File Offset: 0x0008F708
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public ThreeCabbage()
	{
	}
}
