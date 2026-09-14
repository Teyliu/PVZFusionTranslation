using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BD RID: 1469
[Token(Token = "0x20005BD")]
public class ThreeCorn : Cornpult
{
	// Token: 0x06001B21 RID: 6945 RVA: 0x0009151C File Offset: 0x0008F71C
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x54D1C0", Offset = "0x54B7C0", VA = "0x18054D1C0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int thePlantRow = this.thePlantRow;
		Transform shoot = this.shoot;
		Bullet bullet = base.Shoot1();
		Transform shoot2 = this.shoot;
		int num = thePlantRow - 1;
		this.thePlantRow = num;
		Bullet bullet2 = base.Shoot1();
		Board board = this.board;
		this.thePlantRow = thePlantRow;
		int rowNum = board.rowNum;
		Transform shoot3 = this.shoot;
		Bullet bullet3 = base.Shoot1();
		Transform shoot4 = this.shoot;
		int num2 = thePlantRow + 1;
		this.thePlantRow = num2;
		Bullet bullet4 = base.Shoot1();
		int num3 = this.attributeCount;
		num3++;
		this.thePlantRow = thePlantRow;
		this.attributeCount = num3;
		if (num3 > 1)
		{
			HashSet<int> hashSet = new HashSet();
			int thePlantRow2 = this.thePlantRow;
			bool flag = hashSet.Add(thePlantRow2);
			int thePlantRow3 = this.thePlantRow;
			bool flag2 = hashSet.Add(thePlantRow3);
			int num4 = this.thePlantRow;
			num4++;
			bool flag3 = hashSet.Add(num4);
			int num5 = 0;
			List<Zombie> zombiesByRows = Lawnf.GetZombiesByRows(hashSet, num5 != 0);
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				bool flag4 = base.CheckRange(z);
				if (!flag4)
				{
					return flag4;
				}
				return Thrower.ThrowSearchZombie(z);
			};
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(zombiesByRows, func));
			int theZombieRow = ListExtensions.GetRandom<Zombie>(list).theZombieRow;
			this.thePlantRow = theZombieRow;
			Bullet bullet5 = base.Shoot1();
			this.thePlantRow = thePlantRow;
		}
		return base.Shoot1();
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00091670 File Offset: 0x0008F870
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void LowerShoot()
	{
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00091680 File Offset: 0x0008F880
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x54D660", Offset = "0x54BC60", VA = "0x18054D660", Slot = "69")]
	protected override Bullet Shoot2()
	{
		int thePlantRow = this.thePlantRow;
		Transform shoot = this.shoot;
		Bullet bullet = base.Shoot2();
		Transform shoot2 = this.shoot;
		int num = thePlantRow - 1;
		this.thePlantRow = num;
		Bullet bullet2 = base.Shoot2();
		Board board = this.board;
		this.thePlantRow = thePlantRow;
		int rowNum = board.rowNum;
		Transform shoot3 = this.shoot;
		Bullet bullet3 = base.Shoot2();
		Transform shoot4 = this.shoot;
		int num2 = thePlantRow + 1;
		this.thePlantRow = num2;
		Bullet bullet4 = base.Shoot2();
		int num3 = 0;
		this.thePlantRow = thePlantRow;
		HashSet<int> hashSet = new HashSet();
		int thePlantRow2 = this.thePlantRow;
		bool flag = hashSet.Add(thePlantRow2);
		int thePlantRow3 = this.thePlantRow;
		bool flag2 = hashSet.Add(thePlantRow3);
		int num4 = this.thePlantRow;
		num4++;
		bool flag3 = hashSet.Add(num4);
		int num5 = 0;
		List<Zombie> zombiesByRows = Lawnf.GetZombiesByRows(hashSet, num5 != 0);
		Func<Zombie, bool> func = delegate(Zombie z)
		{
			bool flag4 = base.CheckRange(z);
			if (!flag4)
			{
				return flag4;
			}
			return Thrower.ThrowSearchZombie(z);
		};
		int theZombieRow = ListExtensions.GetRandom<Zombie>(Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(zombiesByRows, func))).theZombieRow;
		this.thePlantRow = theZombieRow;
		Bullet bullet5 = base.Shoot2();
		this.thePlantRow = thePlantRow;
		this.attributeCount = num3;
		return base.Shoot2();
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x000917B8 File Offset: 0x0008F9B8
	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x54CF80", Offset = "0x54B580", VA = "0x18054CF80", Slot = "14")]
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

	// Token: 0x06001B25 RID: 6949 RVA: 0x00091820 File Offset: 0x0008FA20
	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public ThreeCorn()
	{
	}
}
