using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
[Serializable]
public class RogueManager
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001682C File Offset: 0x00014A2C
	[Token(Token = "0x17000093")]
	public static RogueManager Instance
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5E6AC0", Offset = "0x5E50C0", VA = "0x1805E6AC0")]
		get
		{
			RogueManager rogueManager = new RogueManager();
			List<PlantType> list = new List();
			rogueManager.rogueCards = list;
			List<ZombieType> list2 = new List();
			rogueManager.zombies_a = list2;
			List<ZombieType> list3 = new List();
			rogueManager.zombies_b = list3;
			List<ZombieType> list4 = new List();
			rogueManager.zombies_c = list4;
			RogueManager._instance = rogueManager;
			return RogueManager._instance;
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00016880 File Offset: 0x00014A80
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x5E5450", Offset = "0x5E3A50", VA = "0x1805E5450")]
	public void Clear()
	{
		List<ZombieType> list = this.zombies_a;
		int num = 0;
		this.campType = (CampType)num;
		list._size = num;
		this.zombies_b._size = num;
		this.zombies_c._size = num;
		List<PlantType> list2 = this.rogueCards;
		this.boss = (ZombieType)num;
		list2._size = num;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000168D8 File Offset: 0x00014AD8
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x5E6150", Offset = "0x5E4750", VA = "0x1805E6150")]
	public void OnUpdate(Board board)
	{
		ulong num8;
		do
		{
			int num = 0;
			if (this.leaderType != LeaderType.UltimateFume)
			{
				break;
			}
			float num2 = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num2;
			if (0 <= (int)num2)
			{
				break;
			}
			this.timer = 3f;
			List<Zombie> zombieArray = board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				int num4 = 0;
				int num5;
				if (!(num != num4) || board.gridSystem.GetBoxType(num5, num3) != BoxType.Water)
				{
					continue;
				}
				int num6 = 0;
				int num7 = num.System.IConvertible.ToInt32(num6);
			}
		}
		while (num8 != (ulong)0L);
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0001696C File Offset: 0x00014B6C
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x5E63A0", Offset = "0x5E49A0", VA = "0x1805E63A0")]
	public void UpdateBox(int theColumn, int theRow)
	{
		int num4;
		do
		{
			if (0 <= 6)
			{
				Leader_UltimateGatling.UpdateLeaderBonus(theColumn, theRow);
				Leader_UlitmateChomper.UpdateLeaderBonus(theColumn, theRow);
				Leader_SnowGatlingPuff.UpdateLeaderBonus(theColumn, theRow);
				Leader_UltimateCabbage.UpdateSingleBox(theColumn - 1, theRow);
				int num = theColumn + 1;
				Leader_UltimateCabbage.UpdateSingleBox(num, theRow);
				Leader_UltimateCabbage.UpdateSingleBox(theColumn, theRow);
				int num2 = theRow - 1;
				Leader_UltimateCabbage.UpdateSingleBox(theColumn, num2);
				int num3 = theRow + 1;
				Leader_UltimateCabbage.UpdateSingleBox(theColumn, num3);
			}
			this.UpdateCampBonus(theColumn, theRow);
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, theRow);
			num4 = 0;
			bool flag;
			if (flag)
			{
				List<JigsawType> list2 = new List(Board.Instance.gridSystem.GetGrid(theColumn, theRow).jigsaws);
				bool flag2;
				if (!flag2)
				{
				}
			}
		}
		while (num4 != 0);
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00016A30 File Offset: 0x00014C30
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x5E68C0", Offset = "0x5E4EC0", VA = "0x1805E68C0")]
	private void UpdateLeaderBonus(int theColumn, int theRow)
	{
		LeaderType leaderType = this.leaderType;
		if (leaderType <= LeaderType.UltimateTallNut)
		{
			Leader_UltimateGatling.UpdateLeaderBonus(theColumn, theRow);
			return;
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00016A6C File Offset: 0x00014C6C
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x5E6750", Offset = "0x5E4D50", VA = "0x1805E6750")]
	private void UpdateCampBonus(int theColumn, int theRow)
	{
		int num2;
		do
		{
			int num = 0;
			if (this.campType != (CampType)num)
			{
				break;
			}
			num2 = 0;
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, theColumn);
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00016AA0 File Offset: 0x00014CA0
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x5E54E0", Offset = "0x5E3AE0", VA = "0x1805E54E0")]
	public void CrisisManifested(int level, bool refresh = false)
	{
		List<ZombieType> randomZombies = this.GetRandomZombies(level);
		int num = level - 1;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0042;
					}
					int num2 = 0;
					ZombieType zombieType = randomZombies[num2];
					this.boss = zombieType;
				}
				this.zombies_c = randomZombies;
			}
			this.zombies_b = randomZombies;
		}
		this.zombies_a = randomZombies;
		IL_0042:
		if (!refresh)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
		}
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		if (refresh)
		{
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00016B10 File Offset: 0x00014D10
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x5E5E10", Offset = "0x5E4410", VA = "0x1805E5E10")]
	public void InitLevel(Board board)
	{
		if (this.campType == CampType.Land)
		{
			if (this.leaderType != LeaderType.UltimateCabbage)
			{
				if (typeof(CreateMower).TypeHandle == (ulong)8L)
				{
					int num = 0;
					Mower mower = CreateMower._instance.SetMower((MowerType)((uint)3), -6f, num);
					num++;
				}
				int num2 = 0;
				Mower mower2 = CreateMower._instance.SetMower((MowerType)((uint)3), -6f, num2);
				num2++;
				throw new NullReferenceException();
			}
			CreateMower instance = CreateMower._instance;
			Transform transform = instance.SetMower((MowerType)((uint)4), -6f, 3).transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00016BA0 File Offset: 0x00014DA0
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x5E5AC0", Offset = "0x5E40C0", VA = "0x1805E5AC0")]
	public List<ZombieType> GetZombieTypes(int round)
	{
		HashSet<ZombieType> hashSet = new HashSet();
		if (round - 1 <= 11)
		{
			int num = round - 1;
			int num2 = 0;
			bool flag = hashSet.Add(num2);
			return Enumerable.ToList<ZombieType>(hashSet);
		}
		List<ZombieType> list = this.zombies_a;
		LinqUtility.AddRange<ZombieType>(hashSet, list);
		List<ZombieType> list2 = this.zombies_b;
		LinqUtility.AddRange<ZombieType>(hashSet, list2);
		List<ZombieType> list3 = this.zombies_c;
		LinqUtility.AddRange<ZombieType>(hashSet, list3);
		while (round != 16)
		{
		}
		while (this.boss == ZombieType.NormalZombie)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00016C20 File Offset: 0x00014E20
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x5E60D0", Offset = "0x5E46D0", VA = "0x1805E60D0")]
	public void LoadData(SurvivalData survivalData)
	{
		List<ZombieType> zombie_a = survivalData.zombie_a;
		this.zombies_a = zombie_a;
		List<ZombieType> zombie_b = survivalData.zombie_b;
		this.zombies_b = zombie_b;
		List<ZombieType> zombie_c = survivalData.zombie_c;
		this.zombies_c = zombie_c;
		CampType campType = survivalData.campType;
		this.campType = campType;
		LeaderType leaderType = survivalData.leaderType;
		this.leaderType = leaderType;
		ZombieType bossType = survivalData.bossType;
		this.boss = bossType;
		List<PlantType> list = survivalData.rogueCards;
		this.rogueCards = list;
		throw new NullReferenceException();
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00016C9C File Offset: 0x00014E9C
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x5E5680", Offset = "0x5E3C80", VA = "0x1805E5680")]
	private List<ZombieType> GetRandomZombies(int level)
	{
		int num = 0;
		List<ZombieType> list = new List();
		List<ZombieType> list2 = new List();
		int num2 = level - 1;
		if (num2 != 0 && num2 != 0 && num2 != 0)
		{
			if (num2 != 1)
			{
				goto IL_0035;
			}
			List<ZombieType> list3 = new List();
		}
		List<ZombieType> list4 = Enumerable.ToList<ZombieType>(TypeMgr.UltiZombie_level_a);
		IL_0035:
		if (this.campType == (CampType)num)
		{
			Predicate<ZombieType> predicate;
			if (RogueManager.<>c.<>9__20_0 == 0)
			{
				predicate = delegate(ZombieType z)
				{
					bool flag;
					return flag;
				};
				RogueManager.<>c.<>9__20_0 = predicate;
			}
			int num3 = list4.RemoveAll(predicate);
		}
		uint num4;
		if (num4 != (uint)0)
		{
			int num5 = list4._size;
			int num6 = global::UnityEngine.Random.Range(0, num5);
			num5 = num6;
			ZombieType zombieType = list4[num5];
			num5 = num6;
			list4.RemoveAt(num5);
			int size = list2._size;
			num++;
		}
		return list2;
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00016D6C File Offset: 0x00014F6C
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x5E69A0", Offset = "0x5E4FA0", VA = "0x1805E69A0")]
	public RogueManager()
	{
		List<PlantType> list = new List();
		this.rogueCards = list;
		List<ZombieType> list2 = new List();
		this.zombies_a = list2;
		List<ZombieType> list3 = new List();
		this.zombies_b = list3;
		List<ZombieType> list4 = new List();
		this.zombies_c = list4;
		base..ctor();
	}

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000279")]
	private static RogueManager _instance;

	// Token: 0x0400027A RID: 634
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027A")]
	public CampType campType;

	// Token: 0x0400027B RID: 635
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400027B")]
	public LeaderType leaderType;

	// Token: 0x0400027C RID: 636
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027C")]
	public List<PlantType> rogueCards;

	// Token: 0x0400027D RID: 637
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400027D")]
	public List<ZombieType> zombies_a;

	// Token: 0x0400027E RID: 638
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400027E")]
	public List<ZombieType> zombies_b;

	// Token: 0x0400027F RID: 639
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400027F")]
	public List<ZombieType> zombies_c;

	// Token: 0x04000280 RID: 640
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000280")]
	public ZombieType boss;

	// Token: 0x04000281 RID: 641
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000281")]
	private float timer;
}
