using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x0200077A RID: 1914
[Token(Token = "0x200077A")]
public class ZombieDataManager
{
	// Token: 0x060026EF RID: 9967 RVA: 0x000CC128 File Offset: 0x000CA328
	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x633EF0", Offset = "0x6324F0", VA = "0x180633EF0")]
	public static ZombieDataManager.ZombieData GetZombieData(ZombieType zombieType)
	{
		int num = 0;
		ZombieDataManager.ZombieData zombieData;
		if (LevelManager.TryGetLevelData(num))
		{
			Func<ZombieDataManager.ZombieData, bool> func = delegate(ZombieDataManager.ZombieData p)
			{
				ZombieType zombieType4 = zombieType;
				return p.theZombieType == zombieType4;
			};
			if (Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(num, func) != 0)
			{
				return zombieData;
			}
		}
		Dictionary<ZombieType, ZombieDataManager.ZombieData> dictionary = ZombieDataManager.zombieDataDic;
		ZombieType zombieType2 = zombieType;
		bool flag;
		if (flag)
		{
			throw new NullReferenceException();
		}
		zombieData = new ZombieDataManager.ZombieData();
		ZombieType zombieType3 = zombieType;
		zombieData.theZombieType = zombieType3;
		return zombieData;
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000CC19C File Offset: 0x000CA39C
	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x6340B0", Offset = "0x6326B0", VA = "0x1806340B0")]
	public static void LoadData()
	{
		string text = Resources.Load<TextAsset>("zombie_data").text;
		char[] array = new char[2];
		array[0] = (char)((ulong)10L);
		array[0] = (char)((ulong)13L);
		uint num;
		string[] array2;
		if (num < (uint)array2.Length)
		{
			ZombieDataManager.ZombieData zombieData = new ZombieDataManager.ZombieData();
			string[] array3;
			int num2 = int.Parse(array3[0]);
			zombieData.theZombieType = (ZombieType)num2;
			int num3 = int.Parse(array3[1]);
			zombieData.theAttackDamage = num3;
			int num4 = int.Parse(array3[2]);
			zombieData.theMaxHealth = num4;
			int num5 = int.Parse(array3[3]);
			zombieData.theFirstArmorMaxHealth = num5;
			int num6 = int.Parse(array3[4]);
			zombieData.theSecondArmorMaxHealth = num6;
			int num7 = int.Parse(array3[5]);
			zombieData.cost = num7;
			int num8 = int.Parse(array3[6]);
			zombieData.summonLevel = num8;
			int num9 = int.Parse(array3[7]);
			zombieData.summonWeight = num9;
			float num10 = float.Parse(array3[8]);
			zombieData.armor = num10;
			Dictionary<ZombieType, ZombieDataManager.ZombieData> dictionary = ZombieDataManager.zombieDataDic;
			ZombieType theZombieType = zombieData.theZombieType;
			dictionary.Add(theZombieType, zombieData);
			num += (uint)1;
		}
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x000CC2EC File Offset: 0x000CA4EC
	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public ZombieDataManager()
	{
	}

	// Token: 0x04001403 RID: 5123
	[Token(Token = "0x4001403")]
	public static Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = new Dictionary();

	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	[Serializable]
	public class ZombieData
	{
		// Token: 0x060026F3 RID: 9971 RVA: 0x000CC318 File Offset: 0x000CA518
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x634400", Offset = "0x632A00", VA = "0x180634400")]
		public void LoadData(Zombie zombie)
		{
			int num = this.theAttackDamage;
			zombie.theAttackDamage = num;
			int num2 = this.theMaxHealth;
			zombie.theHealth = (long)num2;
			int num3 = this.theMaxHealth;
			zombie.theMaxHealth = (long)num3;
			int num4 = this.theFirstArmorMaxHealth;
			zombie.theFirstArmorHealth = num4;
			int num5 = this.theFirstArmorMaxHealth;
			zombie.theFirstArmorMaxHealth = num5;
			int num6 = this.theSecondArmorMaxHealth;
			zombie.theSecondArmorHealth = num6;
			int num7 = this.theSecondArmorMaxHealth;
			zombie.theSecondArmorMaxHealth = num7;
			float num8 = this.armor;
			zombie.theArmor = num8;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000CC3A4 File Offset: 0x000CA5A4
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ZombieData()
		{
		}

		// Token: 0x04001404 RID: 5124
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001404")]
		public ZombieType theZombieType;

		// Token: 0x04001405 RID: 5125
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4001405")]
		public int theAttackDamage;

		// Token: 0x04001406 RID: 5126
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001406")]
		public int theMaxHealth;

		// Token: 0x04001407 RID: 5127
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4001407")]
		public int theFirstArmorMaxHealth;

		// Token: 0x04001408 RID: 5128
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001408")]
		public int theSecondArmorMaxHealth;

		// Token: 0x04001409 RID: 5129
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4001409")]
		public int cost;

		// Token: 0x0400140A RID: 5130
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400140A")]
		public int summonLevel;

		// Token: 0x0400140B RID: 5131
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400140B")]
		public int summonWeight;

		// Token: 0x0400140C RID: 5132
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400140C")]
		public float armor;

		// Token: 0x0400140D RID: 5133
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400140D")]
		public float cd;
	}
}
