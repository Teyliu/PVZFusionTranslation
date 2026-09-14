using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
[Serializable]
public class RogueManager
{
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000456 RID: 1110 RVA: 0x00016390 File Offset: 0x00014590
	[Token(Token = "0x17000056")]
	public static RogueManager Instance
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x5B1030", Offset = "0x5AF630", VA = "0x1805B1030")]
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

	// Token: 0x06000457 RID: 1111 RVA: 0x000163E4 File Offset: 0x000145E4
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x5AF9C0", Offset = "0x5ADFC0", VA = "0x1805AF9C0")]
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

	// Token: 0x06000458 RID: 1112 RVA: 0x0001643C File Offset: 0x0001463C
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x5B06C0", Offset = "0x5AECC0", VA = "0x1805B06C0")]
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

	// Token: 0x06000459 RID: 1113 RVA: 0x000164D0 File Offset: 0x000146D0
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x5B0910", Offset = "0x5AEF10", VA = "0x1805B0910")]
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

	// Token: 0x0600045A RID: 1114 RVA: 0x00016594 File Offset: 0x00014794
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x5B0E30", Offset = "0x5AF430", VA = "0x1805B0E30")]
	private void UpdateLeaderBonus(int theColumn, int theRow)
	{
		LeaderType leaderType = this.leaderType;
		if (leaderType <= LeaderType.UltimateTallNut)
		{
			Leader_UltimateGatling.UpdateLeaderBonus(theColumn, theRow);
			return;
		}
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x000165D0 File Offset: 0x000147D0
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x5B0CC0", Offset = "0x5AF2C0", VA = "0x1805B0CC0")]
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

	// Token: 0x0600045C RID: 1116 RVA: 0x00016604 File Offset: 0x00014804
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x5AFA50", Offset = "0x5AE050", VA = "0x1805AFA50")]
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

	// Token: 0x0600045D RID: 1117 RVA: 0x00016674 File Offset: 0x00014874
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x5B0380", Offset = "0x5AE980", VA = "0x1805B0380")]
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

	// Token: 0x0600045E RID: 1118 RVA: 0x00016704 File Offset: 0x00014904
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x5B0030", Offset = "0x5AE630", VA = "0x1805B0030")]
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

	// Token: 0x0600045F RID: 1119 RVA: 0x00016784 File Offset: 0x00014984
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x5B0640", Offset = "0x5AEC40", VA = "0x1805B0640")]
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

	// Token: 0x06000460 RID: 1120 RVA: 0x00016800 File Offset: 0x00014A00
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x5AFBF0", Offset = "0x5AE1F0", VA = "0x1805AFBF0")]
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

	// Token: 0x06000461 RID: 1121 RVA: 0x000168D0 File Offset: 0x00014AD0
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x5B0F10", Offset = "0x5AF510", VA = "0x1805B0F10")]
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

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	private static RogueManager _instance;

	// Token: 0x0400026C RID: 620
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400026C")]
	public CampType campType;

	// Token: 0x0400026D RID: 621
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400026D")]
	public LeaderType leaderType;

	// Token: 0x0400026E RID: 622
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400026E")]
	public List<PlantType> rogueCards;

	// Token: 0x0400026F RID: 623
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400026F")]
	public List<ZombieType> zombies_a;

	// Token: 0x04000270 RID: 624
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000270")]
	public List<ZombieType> zombies_b;

	// Token: 0x04000271 RID: 625
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000271")]
	public List<ZombieType> zombies_c;

	// Token: 0x04000272 RID: 626
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000272")]
	public ZombieType boss;

	// Token: 0x04000273 RID: 627
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000273")]
	private float timer;
}
