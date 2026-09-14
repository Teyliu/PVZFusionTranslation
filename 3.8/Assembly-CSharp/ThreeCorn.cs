using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058C RID: 1420
[Token(Token = "0x200058C")]
public class ThreeCorn : Cornpult
{
	// Token: 0x06001A3B RID: 6715 RVA: 0x0008D194 File Offset: 0x0008B394
	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x4ED350", Offset = "0x4EB950", VA = "0x1804ED350", Slot = "69")]
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
			Func<Zombie, bool> func;
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(Lawnf.GetZombiesByRows(hashSet, num5 != 0), func));
			int theZombieRow = ListExtensions.GetRandom<Zombie>(list).theZombieRow;
			this.thePlantRow = theZombieRow;
			Bullet bullet5 = base.Shoot1();
			this.thePlantRow = thePlantRow;
		}
		return base.Shoot1();
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x0008D2D4 File Offset: 0x0008B4D4
	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void LowerShoot()
	{
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0008D2E4 File Offset: 0x0008B4E4
	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x4ED7F0", Offset = "0x4EBDF0", VA = "0x1804ED7F0", Slot = "70")]
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
		Func<Zombie, bool> func;
		int theZombieRow = ListExtensions.GetRandom<Zombie>(Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(Lawnf.GetZombiesByRows(hashSet, num5 != 0), func))).theZombieRow;
		this.thePlantRow = theZombieRow;
		Bullet bullet5 = base.Shoot2();
		this.thePlantRow = thePlantRow;
		this.attributeCount = num3;
		return base.Shoot2();
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0008D40C File Offset: 0x0008B60C
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x4ED110", Offset = "0x4EB710", VA = "0x1804ED110", Slot = "14")]
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

	// Token: 0x06001A3F RID: 6719 RVA: 0x0008D474 File Offset: 0x0008B674
	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public ThreeCorn()
	{
	}
}
