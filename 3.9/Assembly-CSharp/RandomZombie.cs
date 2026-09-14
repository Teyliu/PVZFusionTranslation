using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F7 RID: 1783
[Token(Token = "0x20006F7")]
public class RandomZombie : NormalZombie
{
	// Token: 0x0600230B RID: 8971 RVA: 0x000B72DC File Offset: 0x000B54DC
	[Token(Token = "0x600230B")]
	[Address(RVA = "0x5CF330", Offset = "0x5CD930", VA = "0x1805CF330", Slot = "64")]
	protected override void FirstArmorFall()
	{
		int num = 0;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Board board = this.board;
		int num2 = 0;
		if (((this.buff ? 1 : 0) == num && (global::UnityEngine.Random.Range(0, 50) != 0 || this.board != 0)) || !Lawnf.UnlockRandomTravelBuff(this.board))
		{
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				if ((zombie.isMindControlled ? 1 : 0) == num)
				{
					Board board2 = this.board;
					BoardEntity boardEntity = board2.boardEntity;
					int theWave = board2.theWave;
					boardEntity.AddWaveZombie(theWave, zombie);
				}
				this.RandomEvent(zombie);
			}
		}
		Transform axis2 = this.axis;
		this.summoned = true;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num4 != 0UL, (float)num2);
		base.Die(2);
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x000B73C0 File Offset: 0x000B55C0
	[Token(Token = "0x600230C")]
	[Address(RVA = "0x5D04F0", Offset = "0x5CEAF0", VA = "0x1805D04F0", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		if (!this.summoned)
		{
		}
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x000B73D8 File Offset: 0x000B55D8
	[Token(Token = "0x600230D")]
	[Address(RVA = "0x5CF5F0", Offset = "0x5CDBF0", VA = "0x1805CF5F0", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int num = base.FirstArmorTakeDamage(theDamage);
		return 0;
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000B73F0 File Offset: 0x000B55F0
	[Token(Token = "0x600230E")]
	[Address(RVA = "0x5D0590", Offset = "0x5CEB90", VA = "0x1805D0590", Slot = "76")]
	protected virtual Zombie SetRandomZombie(Vector3 pos)
	{
		while (!this.board.isEveStarted)
		{
			List<ZombieType> list = new List();
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				while (flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
			}
			ulong num;
			if (num == (ulong)0L)
			{
				int theBoardLevel = GameAPP.theBoardLevel;
				BoxType boxType;
				if (boxType != BoxType.Water)
				{
					if (RandomZombie.<>c.<>9__5_1 != 0)
					{
						goto IL_0091;
					}
					RandomZombie.<>c.<>9__5_1 = delegate(ZombieType z)
					{
						bool flag5;
						return flag5;
					};
				}
				int num2;
				if (RandomZombie.<>c.<>9__5_0 == 0)
				{
					Predicate<ZombieType> predicate = delegate(ZombieType z)
					{
						bool flag6;
						return flag6;
					};
					num2 = 0;
					RandomZombie.<>c.<>9__5_0 = predicate;
				}
				IL_0091:
				int num3 = 0;
				int num4;
				ulong num5;
				return CreateZombie.Instance.SetZombie(num4, (ZombieType)num3, (float)num2, num5 != 0UL);
			}
		}
		float z2 = pos.z;
		throw new NullReferenceException();
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x000B74E4 File Offset: 0x000B56E4
	[Token(Token = "0x600230F")]
	[Address(RVA = "0x5CF610", Offset = "0x5CDC10", VA = "0x1805CF610")]
	private Zombie GetEveZombie(Vector3 pos)
	{
		List<ZombieType> list = new List();
		int size = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		list._size = 1;
		int size7 = list._size;
		list._size = 1;
		int size8 = list._size;
		list._size = 1;
		int size9 = list._size;
		list._size = 1;
		int size10 = list._size;
		list._size = 1;
		int size11 = list._size;
		list._size = 1;
		int size12 = list._size;
		list._size = 1;
		int size13 = list._size;
		list._size = 1;
		int size14 = list._size;
		list._size = 1;
		int size15 = list._size;
		list._size = 1;
		int size16 = list._size;
		list._size = 1;
		int size17 = list._size;
		list._size = 1;
		int size18 = list._size;
		list._size = 1;
		int size19 = list._size;
		list._size = 1;
		int size20 = list._size;
		list._size = 1;
		int size21 = list._size;
		list._size = 1;
		int size22 = list._size;
		list._size = 1;
		int size23 = list._size;
		list._size = 1;
		int size24 = list._size;
		list._size = 1;
		int size25 = list._size;
		list._size = 1;
		int size26 = list._size;
		list._size = 1;
		int size27 = list._size;
		list._size = 1;
		int size28 = list._size;
		list._size = 1;
		int size29 = list._size;
		list._size = 1;
		int size30 = list._size;
		list._size = 1;
		int size31 = list._size;
		list._size = 1;
		int size32 = list._size;
		list._size = 1;
		int size33 = list._size;
		list._size = 1;
		int size34 = list._size;
		list._size = 1;
		int size35 = list._size;
		list._size = 1;
		int size36 = list._size;
		list._size = 1;
		int size37 = list._size;
		list._size = 1;
		int size38 = list._size;
		list._size = 1;
		int size39 = list._size;
		list._size = 1;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		ZombieType zombieType = list[num];
		CreateZombie instance = CreateZombie.Instance;
		CreateZombie instance2 = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2 && zombie.theZombieType == ZombieType.ChickenImp)
		{
			long num3 = zombie.theHealth;
			num3 -= (long)num2;
			zombie.theHealth = num3;
			long num4 = zombie.theMaxHealth;
			num4 -= (long)num2;
			zombie.theMaxHealth = num4;
		}
		return zombie;
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000B77CC File Offset: 0x000B59CC
	[Token(Token = "0x6002310")]
	[Address(RVA = "0x5D0510", Offset = "0x5CEB10", VA = "0x1805D0510", Slot = "77")]
	protected virtual void RandomEvent(Zombie zombie)
	{
		int num = global::UnityEngine.Random.Range(1, 7);
		if (this.board.isEveStarted)
		{
			int num2 = global::UnityEngine.Random.Range(1, 6);
		}
		float num3;
		Lawnf.SetZombieHealth(zombie, num3);
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000B7808 File Offset: 0x000B5A08
	[Token(Token = "0x6002311")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "31")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x000B7818 File Offset: 0x000B5A18
	[Token(Token = "0x6002312")]
	[Address(RVA = "0x59BFF0", Offset = "0x59A5F0", VA = "0x18059BFF0")]
	public RandomZombie()
	{
	}

	// Token: 0x040011F1 RID: 4593
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011F1")]
	private bool summoned;

	// Token: 0x040011F2 RID: 4594
	[FieldOffset(Offset = "0x289")]
	[Token(Token = "0x40011F2")]
	public bool buff;
}
