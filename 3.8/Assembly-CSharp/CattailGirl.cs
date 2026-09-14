using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CA RID: 1226
[Token(Token = "0x20004CA")]
public class CattailGirl : Shooter
{
	// Token: 0x06001726 RID: 5926 RVA: 0x0007F45C File Offset: 0x0007D65C
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x49DB00", Offset = "0x49C100", VA = "0x18049DB00", Slot = "69")]
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

	// Token: 0x06001727 RID: 5927 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x49DC30", Offset = "0x49C230", VA = "0x18049DC30", Slot = "70")]
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

	// Token: 0x06001728 RID: 5928 RVA: 0x0007F4EC File Offset: 0x0007D6EC
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x49D920", Offset = "0x49BF20", VA = "0x18049D920", Slot = "44")]
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

	// Token: 0x06001729 RID: 5929 RVA: 0x0007F550 File Offset: 0x0007D750
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x49D870", Offset = "0x49BE70", VA = "0x18049D870", Slot = "48")]
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

	// Token: 0x0600172A RID: 5930 RVA: 0x0007F5BC File Offset: 0x0007D7BC
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x49D5D0", Offset = "0x49BBD0", VA = "0x18049D5D0", Slot = "53")]
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

	// Token: 0x0600172B RID: 5931 RVA: 0x0007F63C File Offset: 0x0007D83C
	[Token(Token = "0x600172B")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CattailGirl()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
