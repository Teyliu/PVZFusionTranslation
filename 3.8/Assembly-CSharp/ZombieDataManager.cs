using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x02000741 RID: 1857
[Token(Token = "0x2000741")]
public class ZombieDataManager
{
	// Token: 0x060025CA RID: 9674 RVA: 0x000C7238 File Offset: 0x000C5438
	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x5D2AD0", Offset = "0x5D10D0", VA = "0x1805D2AD0")]
	public static ZombieDataManager.ZombieData GetZombieData(ZombieType zombieType)
	{
		int num = 0;
		Func<ZombieDataManager.ZombieData, bool> func;
		ZombieDataManager.ZombieData zombieData;
		if (!LevelManager.TryGetLevelData(num) || Enumerable.FirstOrDefault<ZombieDataManager.ZombieData>(num, func) == 0)
		{
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
		}
		return zombieData;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000C72A0 File Offset: 0x000C54A0
	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x5D2C90", Offset = "0x5D1290", VA = "0x1805D2C90")]
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

	// Token: 0x060025CC RID: 9676 RVA: 0x000C73F0 File Offset: 0x000C55F0
	[Token(Token = "0x60025CC")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public ZombieDataManager()
	{
	}

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x400132D")]
	public static Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = new Dictionary();

	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	[Serializable]
	public class ZombieData
	{
		// Token: 0x060025CE RID: 9678 RVA: 0x000C741C File Offset: 0x000C561C
		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x5D2FE0", Offset = "0x5D15E0", VA = "0x1805D2FE0")]
		public void LoadData(Zombie zombie)
		{
			int num = this.theAttackDamage;
			zombie.theAttackDamage = num;
			int num2 = this.theMaxHealth;
			zombie.theHealth = num2;
			int num3 = this.theMaxHealth;
			zombie.theMaxHealth = num3;
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

		// Token: 0x060025CF RID: 9679 RVA: 0x000C74A8 File Offset: 0x000C56A8
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ZombieData()
		{
		}

		// Token: 0x0400132E RID: 4910
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400132E")]
		public ZombieType theZombieType;

		// Token: 0x0400132F RID: 4911
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400132F")]
		public int theAttackDamage;

		// Token: 0x04001330 RID: 4912
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001330")]
		public int theMaxHealth;

		// Token: 0x04001331 RID: 4913
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4001331")]
		public int theFirstArmorMaxHealth;

		// Token: 0x04001332 RID: 4914
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001332")]
		public int theSecondArmorMaxHealth;

		// Token: 0x04001333 RID: 4915
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4001333")]
		public int cost;

		// Token: 0x04001334 RID: 4916
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001334")]
		public int summonLevel;

		// Token: 0x04001335 RID: 4917
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4001335")]
		public int summonWeight;

		// Token: 0x04001336 RID: 4918
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001336")]
		public float armor;

		// Token: 0x04001337 RID: 4919
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4001337")]
		public float cd;
	}
}
