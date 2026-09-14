using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067B RID: 1659
[Token(Token = "0x200067B")]
public class DiamondRandomZombie : RandomZombie
{
	// Token: 0x06001F78 RID: 8056 RVA: 0x000A7514 File Offset: 0x000A5714
	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x59CB10", Offset = "0x59B110", VA = "0x18059CB10", Slot = "76")]
	protected override Zombie SetRandomZombie(Vector3 pos)
	{
		List<ZombieType> list;
		ulong num2;
		do
		{
			list = new List();
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				bool flag2;
				uint num;
				if (!flag2 || this.leader || !GameAPP.config.leaderInRandom || global::UnityEngine.Random.Range(0, (int)num) == 0)
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
				if (!GameAPP.config.levelZombieInRandom)
				{
					bool flag5;
					while (flag5)
					{
					}
				}
				if (!GameAPP.config.strongUltiZombieInRandom)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		BoxType boxType;
		if (boxType != BoxType.Water)
		{
			if (DiamondRandomZombie.<>c.<>9__1_1 != 0)
			{
				goto IL_00B3;
			}
			DiamondRandomZombie.<>c.<>9__1_1 = delegate(ZombieType z)
			{
				bool flag6;
				return flag6;
			};
		}
		Predicate<ZombieType> predicate;
		if (DiamondRandomZombie.<>c.<>9__1_0 == 0)
		{
			predicate = delegate(ZombieType z)
			{
				bool flag7;
				return flag7;
			};
			DiamondRandomZombie.<>c.<>9__1_0 = predicate;
		}
		IL_00B3:
		int num3 = list.RemoveAll(predicate);
		int num4 = list._size;
		num4 = global::UnityEngine.Random.Range(0, num4);
		ZombieType zombieType = list[num4];
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		return zombie;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x000A7648 File Offset: 0x000A5848
	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x59CA30", Offset = "0x59B030", VA = "0x18059CA30", Slot = "77")]
	protected override void RandomEvent(Zombie zombie)
	{
		int num = global::UnityEngine.Random.Range(4, 7);
		zombie.theHealth = (long)num;
		zombie.theMaxHealth = (long)num;
		zombie.theFirstArmorHealth = num;
		zombie.theFirstArmorMaxHealth = num;
		zombie.theSecondArmorHealth = num;
		zombie.theSecondArmorMaxHealth = num;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000A7690 File Offset: 0x000A5890
	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x59D1E0", Offset = "0x59B7E0", VA = "0x18059D1E0")]
	public DiamondRandomZombie()
	{
	}

	// Token: 0x0400111C RID: 4380
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400111C")]
	public bool leader;
}
