using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class TowerData
{
	// Token: 0x0600048F RID: 1167 RVA: 0x000175C4 File Offset: 0x000157C4
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x5E99D0", Offset = "0x5E7FD0", VA = "0x1805E99D0")]
	public static ZombieType GetZombieTypeInRow(int level, int row, ZombieType zombieType)
	{
		if (row == 3)
		{
			if (zombieType == ZombieType.NormalZombie)
			{
				return ZombieType.NormalZombie;
			}
			if (zombieType != ZombieType.NormalZombie)
			{
				if (zombieType == ZombieType.NormalZombie)
				{
					return ZombieType.NormalZombie;
				}
				if (zombieType != ZombieType.NormalZombie && zombieType == ZombieType.FlagZombie)
				{
					return ZombieType.NormalZombie;
				}
			}
		}
		if (row != 2)
		{
			while (row != 6)
			{
			}
		}
		if (zombieType == ZombieType.NormalZombie)
		{
			return ZombieType.NormalZombie;
		}
		while (zombieType == ZombieType.NormalZombie)
		{
		}
		if (zombieType != ZombieType.NormalZombie)
		{
			while (zombieType == ZombieType.NormalZombie)
			{
			}
			while (zombieType != ZombieType.FlagZombie)
			{
			}
			return ZombieType.NormalZombie;
		}
		return ZombieType.NormalZombie;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x0001764C File Offset: 0x0001584C
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x5E9330", Offset = "0x5E7930", VA = "0x1805E9330")]
	public static int GetRow(int level, int wave, ZombieType zombieType)
	{
		int theBoardLevel = GameAPP.theBoardLevel;
		uint num;
		if ((theBoardLevel != 31 && (theBoardLevel == 32 || wave <= 10)) || num == (uint)0)
		{
		}
		if (zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || zombieType != ZombieType.FlagZombie)
		{
		}
		List<int> list = new List();
		List<int> list2 = new List();
		List<int> list3 = Enumerable.ToList<int>(Enumerable.Concat<int>(list, list2));
		bool flag;
		if (zombieType != ZombieType.NormalZombie && (zombieType == ZombieType.NormalZombie || (zombieType != ZombieType.NormalZombie && (zombieType == ZombieType.NormalZombie || zombieType != ZombieType.FlagZombie))) && flag)
		{
			return ListExtensions.GetRandom<int>(list2);
		}
		return 0;
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000176E0 File Offset: 0x000158E0
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x5E92C0", Offset = "0x5E78C0", VA = "0x1805E92C0")]
	public static Towards GetNextTowards(Towards towards, PlantType plantType)
	{
		if (plantType > PlantType.Tower_cherryShooter)
		{
		}
		if (towards == Towards.Right)
		{
		}
		uint num;
		num += (uint)218128019;
		return Towards.Left;
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00017710 File Offset: 0x00015910
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x5E9960", Offset = "0x5E7F60", VA = "0x1805E9960")]
	public static int GetWave(int level)
	{
		if (level - 1 <= 26)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00017728 File Offset: 0x00015928
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x5E9780", Offset = "0x5E7D80", VA = "0x1805E9780")]
	public static string GetTowerMap(int level)
	{
		if (level - 1 <= 26)
		{
			int num = level - 1;
			return "Background/TowerMaps/Tower2";
		}
		return "Background/TowerMaps/Tower1";
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0001778C File Offset: 0x0001598C
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x5EA490", Offset = "0x5E8A90", VA = "0x1805EA490")]
	public static void SetBoxData(Board board, int level)
	{
		int num = 0;
		ulong num2;
		num2 += num2;
		if (num2 == (ulong)1L)
		{
			TowerManager.Instance.musicType = (MusicType)((ulong)6L);
			TowerManager.Instance.musicType = (MusicType)((ulong)4L);
			TowerManager.Instance.musicType = (MusicType)((ulong)2L);
		}
		if (GameAPP.theBoardLevel == 31)
		{
		}
		uint num3;
		if (TowerData.mapData.TryGetValue(num3, num))
		{
			string[] array;
			int length = array.Length;
			board.rowNum = length;
			int stringLength = array[0]._stringLength;
			GridSystem gridSystem = board.gridSystem;
			board.columnNum = stringLength;
			gridSystem.UpdateGrid(stringLength, length);
			if (num < board.columnNum)
			{
				if (num < board.rowNum)
				{
					string text;
					int num4 = int.Parse(text);
					if (num4 != 0)
					{
						if (num4 != 0)
						{
							if (num4 != 0)
							{
								if (num4 != 0 && num4 != 1)
								{
									goto IL_012A;
								}
								BoardGrid grid = board.gridSystem.GetGrid(num, num);
								num++;
								grid.boxType = (BoxType)((ulong)1L);
							}
							board.gridSystem.GetGrid(num, num).boxType = (BoxType)num;
							num++;
						}
						BoardGrid grid2 = board.gridSystem.GetGrid(num, num);
						num++;
						grid2.boxType = (BoxType)num;
					}
					board.gridSystem.GetGrid(num, num).boxType = (BoxType)((ulong)2L);
					IL_012A:
					num++;
				}
				num++;
			}
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000178D4 File Offset: 0x00015AD4
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x5E9A40", Offset = "0x5E8040", VA = "0x1805E9A40")]
	public static List<ZombieType> GetZombieTypes(int level)
	{
		if (level - 1 <= 21)
		{
			int num = level - 1;
			List<ZombieType> list = new List();
			return new List();
		}
		List<ZombieType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		return list2;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x000179BC File Offset: 0x00015BBC
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x5E87B0", Offset = "0x5E6DB0", VA = "0x1805E87B0")]
	public static List<ZombieType> GetEndlessType(SurvivalLevel level, int round)
	{
		List<ZombieType> list = new List();
		if (round - 1 <= 5)
		{
			int num = round - 1;
			uint num2;
			if (global::UnityEngine.Random.Range(0, (int)num2) != 0)
			{
			}
			uint num3;
			if (global::UnityEngine.Random.Range(0, (int)num3) != 0)
			{
			}
			List<ZombieType> list2 = new List();
			int size = list2._size;
			int size2 = list2._size;
			int size3 = list2._size;
			int size4 = list2._size;
			int size5 = list2._size;
			int size6 = list2._size;
			int size7 = list2._size;
			int size8 = list2._size;
			int size9 = list2._size;
			int num4 = list2._size;
			int num5 = global::UnityEngine.Random.Range(0, num4);
			num4 = num5;
			int num6 = list2[num4];
			int size10 = list._size;
			num6 = num5;
			list2.RemoveAt(num6);
		}
		List<ZombieType> list3 = new List();
		int size11 = list3._size;
		int size12 = list3._size;
		int size13 = list3._size;
		int size14 = list3._size;
		int size15 = list3._size;
		int size16 = list3._size;
		int size17 = list3._size;
		int size18 = list3._size;
		int size19 = list3._size;
		int size20 = list3._size;
		int size21 = list3._size;
		int size22 = list3._size;
		int num7 = list3._size;
		int num8 = global::UnityEngine.Random.Range(0, num7);
		num7 = num8;
		int num9 = list3[num7];
		int size23 = list._size;
		num9 = num8;
		list3.RemoveAt(num9);
		return list;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00017B40 File Offset: 0x00015D40
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x5EA890", Offset = "0x5E8E90", VA = "0x1805EA890")]
	public static void SetCamera()
	{
		if (GameAPP.theBoardLevel < 9)
		{
			Transform transform = Camera.main.transform;
			Transform transform2 = Camera.main.transform;
			Vector3 vector;
			float z = vector.z;
			Camera.main.orthographicSize = 6.5f;
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00017B94 File Offset: 0x00015D94
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TowerData()
	{
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00017BA8 File Offset: 0x00015DA8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x5EA9E0", Offset = "0x5E8FE0", VA = "0x1805EA9E0")]
	static TowerData()
	{
		Dictionary<PlantType, ValueTuple<string, string>> dictionary = new Dictionary();
		TowerData.TowerUpgradeDescription = dictionary;
		uint num;
		uint num2;
		uint num3;
		uint num4;
		uint num5;
		uint num6;
		uint num7;
		uint num8;
		uint num9;
		uint num10;
		uint num11;
		uint num12;
		uint num13;
		uint num14;
		uint num15;
		uint num16;
		uint num17;
		uint num18;
		uint num19;
		uint num20;
		uint num21;
		uint num22;
		TowerData.mapData = new Dictionary
		{
			{ num, "0011211100,1012211101,1011112101,1011121101,1000000001" },
			{ num2, "0011121100,1011121101,1012212101,1011121101,1000000001" },
			{ num3, "1110001221,0010101000,1020202011,1020101021,1000100021" },
			{ num4, "1120001121,0010201000,1010201012,1010201012,2000100011" },
			{ num5, "1000000000,1022212221,0000000211,2012210111,1000000211" },
			{ num6, "1000000000,1022212222,0000000221,2022220221,1000000222" },
			{ num7, "0000100022,1220202021,0010000000,2022202021,2000001000" },
			{ num8, "0000200012,2210201022,0020000000,2021202012,1000001000" },
			{ num9, "0000100011,1110101011,0010000000,1011101011,1000001000" },
			{ num10, "12210001221,00120100000,10000221222,20000122222,00220100000,11220002112" },
			{ num11, "22220002122,00210200000,20000222221,20000222221,00220100000,22120002222" },
			{ num12, "10000000002,10122122201,20120000001,10210122221,20120000000,00122221222" },
			{ num13, "20000000002,10122122201,20220000002,10210122121,20220000000,00122221222" },
			{ num14, "22000000002,00000210000,21010220102,12010120101,12020000100,00012222122" },
			{ num15, "12000000002,00000220000,12010120201,22010110102,12020000200,00011221121" },
			{ num16, "12211200000,00000102121,21210102212,00000001211,11220112221,12210000000" },
			{ num17, "22222200000,00000202122,21210202112,00000002111,11210111222,22220000000" },
			{ num18, "11111100000,00000101111,11110101111,00000001111,11110111111,11110000000" },
			{ num19, "0000122212211,2210001200000,1222201102121,2444100002444,1414212221412,4434333333433,3334444444433" },
			{ num20, "0000121212111,2220002200000,1211201102111,2444200002444,1414211111412,4434333333433,3334444444433" },
			{ num21, "0000100020002,1210002000100,4434443444344,3444344434443,0000100010002,2210002000100,4444444444444" },
			{ num22, "0000200010002,2110002000200,4434443444344,3444344434443,0000100010001,2220002000200,4444444444444" }
		};
		TowerData.TowerBuffDescriptions = new Dictionary();
	}

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	public static readonly Dictionary<PlantType, int> UnlockPlantLevel = new Dictionary();

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[TupleElementNames(new string[] { "upgrade1", "upgrade2" })]
	public static readonly Dictionary<PlantType, ValueTuple<string, string>> TowerUpgradeDescription;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	private static readonly Dictionary<int, string> mapData;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	private static Dictionary<TowerBuff, string> TowerBuffDescriptions;
}
