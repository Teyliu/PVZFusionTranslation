using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000ED")]
public class TowerData
{
	// Token: 0x06000474 RID: 1140 RVA: 0x00017138 File Offset: 0x00015338
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x5B3F40", Offset = "0x5B2540", VA = "0x1805B3F40")]
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

	// Token: 0x06000475 RID: 1141 RVA: 0x000171C0 File Offset: 0x000153C0
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x5B38A0", Offset = "0x5B1EA0", VA = "0x1805B38A0")]
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

	// Token: 0x06000476 RID: 1142 RVA: 0x00017254 File Offset: 0x00015454
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x5B3830", Offset = "0x5B1E30", VA = "0x1805B3830")]
	public static Towards GetNextTowards(Towards towards, PlantType plantType)
	{
		if (plantType > PlantType.Tower_cherryShooter)
		{
		}
		if (towards == Towards.Right)
		{
		}
		if (towards == Towards.Right)
		{
		}
		if (towards < Towards.Right)
		{
		}
		int theBoardLevel = GameAPP.theBoardLevel;
		uint num;
		uint num2;
		if ((theBoardLevel == 31 || theBoardLevel != 32) && global::UnityEngine.Random.Range(0, (int)num) == 0 && global::UnityEngine.Random.Range(0, (int)num2) == 0)
		{
			uint num4;
			int num3 = global::UnityEngine.Random.Range(0, (int)num4);
		}
		int num5 = 0;
		uint num7;
		int num6 = global::UnityEngine.Random.Range(num5, (int)num7);
		if (num5 != 1)
		{
		}
		uint num9;
		int num8 = global::UnityEngine.Random.Range(0, (int)num9);
		List<int> list = new List();
		List<int> list2 = new List();
		List<int> list3 = Enumerable.ToList<int>(Enumerable.Concat<int>(list, list2));
		bool flag;
		if (flag)
		{
			int random = ListExtensions.GetRandom<int>(list2);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00017304 File Offset: 0x00015504
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x5B3ED0", Offset = "0x5B24D0", VA = "0x1805B3ED0")]
	public static int GetWave(int level)
	{
		if (level - 1 <= 26)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0001731C File Offset: 0x0001551C
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x5B3CF0", Offset = "0x5B22F0", VA = "0x1805B3CF0")]
	public static string GetTowerMap(int level)
	{
		if (level - 1 <= 26)
		{
			int num = level - 1;
			return "Background/TowerMaps/Tower2";
		}
		return "Background/TowerMaps/Tower1";
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00017380 File Offset: 0x00015580
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x5B4A00", Offset = "0x5B3000", VA = "0x1805B4A00")]
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

	// Token: 0x0600047A RID: 1146 RVA: 0x000174C8 File Offset: 0x000156C8
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x5B3FB0", Offset = "0x5B25B0", VA = "0x1805B3FB0")]
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

	// Token: 0x0600047B RID: 1147 RVA: 0x000175B0 File Offset: 0x000157B0
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x5B2D20", Offset = "0x5B1320", VA = "0x1805B2D20")]
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

	// Token: 0x0600047C RID: 1148 RVA: 0x00017734 File Offset: 0x00015934
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x5B4E00", Offset = "0x5B3400", VA = "0x1805B4E00")]
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

	// Token: 0x0600047D RID: 1149 RVA: 0x00017788 File Offset: 0x00015988
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public TowerData()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0001779C File Offset: 0x0001599C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x5B4F50", Offset = "0x5B3550", VA = "0x1805B4F50")]
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

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	public static readonly Dictionary<PlantType, int> UnlockPlantLevel = new Dictionary();

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[TupleElementNames(new string[] { "upgrade1", "upgrade2" })]
	public static readonly Dictionary<PlantType, ValueTuple<string, string>> TowerUpgradeDescription;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	private static readonly Dictionary<int, string> mapData;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	private static Dictionary<TowerBuff, string> TowerBuffDescriptions;
}
