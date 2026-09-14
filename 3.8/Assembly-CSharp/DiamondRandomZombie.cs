using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000645 RID: 1605
[Token(Token = "0x2000645")]
public class DiamondRandomZombie : RandomZombie
{
	// Token: 0x06001E76 RID: 7798 RVA: 0x000A2DC4 File Offset: 0x000A0FC4
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x53A530", Offset = "0x538B30", VA = "0x18053A530", Slot = "74")]
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

	// Token: 0x06001E77 RID: 7799 RVA: 0x000A2EF4 File Offset: 0x000A10F4
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x53A450", Offset = "0x538A50", VA = "0x18053A450", Slot = "75")]
	protected override void RandomEvent(Zombie zombie)
	{
		int num = global::UnityEngine.Random.Range(4, 7);
		zombie.theHealth = num;
		zombie.theMaxHealth = num;
		zombie.theFirstArmorHealth = num;
		zombie.theFirstArmorMaxHealth = num;
		zombie.theSecondArmorHealth = num;
		zombie.theSecondArmorMaxHealth = num;
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000A2F3C File Offset: 0x000A113C
	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x539A20", Offset = "0x538020", VA = "0x180539A20")]
	public DiamondRandomZombie()
	{
	}

	// Token: 0x04001050 RID: 4176
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001050")]
	public bool leader;
}
