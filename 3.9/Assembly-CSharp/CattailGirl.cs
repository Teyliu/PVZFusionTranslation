using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004EF RID: 1263
[Token(Token = "0x20004EF")]
public class CattailGirl : Shooter
{
	// Token: 0x060017D4 RID: 6100 RVA: 0x00082408 File Offset: 0x00080608
	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x50D500", Offset = "0x50BB00", VA = "0x18050D500", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00082450 File Offset: 0x00080650
	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x50D630", Offset = "0x50BC30", VA = "0x18050D630", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x00082498 File Offset: 0x00080698
	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x50D320", Offset = "0x50B920", VA = "0x18050D320", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					float vision = this.vision;
					if (this.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x000824FC File Offset: 0x000806FC
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x50D270", Offset = "0x50B870", VA = "0x18050D270", Slot = "47")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (!flag && zombie.isMindControlled == flag)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Snokle_inWater)
			{
				if (theStatus <= ZombieStatus.Miner_digging)
				{
					goto IL_0032;
				}
				if (flag <= true || theStatus == ZombieStatus.Bungi_awake)
				{
					goto IL_0030;
				}
			}
			else if (1UL == (ulong)4294967289L)
			{
				while (zombie != (ulong)5L)
				{
				}
			}
			return true;
		}
		IL_0032:
		while (zombie == (ulong)9L)
		{
		}
		while (zombie == (ulong)12L)
		{
		}
		return true;
		IL_0030:
		goto IL_0032;
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00082568 File Offset: 0x00080768
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x50CFD0", Offset = "0x50B5D0", VA = "0x18050CFD0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num2;
		ulong num4;
		do
		{
			int num = 0;
			if (reason != Plant.DieReason.Default && reason != Plant.DieReason.ByShovel)
			{
				return;
			}
			num2 = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				if (!TypeMgr.IsPumpkin((PlantType)num))
				{
					continue;
				}
			}
		}
		while (num4 != (ulong)0L);
		if (num2 != 0)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x000825E8 File Offset: 0x000807E8
	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public CattailGirl()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
