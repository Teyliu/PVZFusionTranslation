using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class BoardSpawner
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x0003F43C File Offset: 0x0003D63C
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x8A11D0", Offset = "0x89F7D0", VA = "0x1808A11D0")]
	public BoardSpawner(Board board)
	{
		Dictionary<int, int> dictionary = new Dictionary();
		this.rowsSpawns = dictionary;
		Dictionary<int, int> dictionary2 = new Dictionary();
		this.mowerSpawns = dictionary2;
		base..ctor();
		this.board = board;
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0003F470 File Offset: 0x0003D670
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x8A06C0", Offset = "0x89ECC0", VA = "0x1808A06C0")]
	public void SummonZombies(int wave)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			this.theWave = wave;
			this.board.zombieTotalHealth = (float)num2;
			Dictionary<int, List<Zombie>> waveZombies = this.board.boardEntity.waveZombies;
			int num3 = this.theWave;
			if (!waveZombies.ContainsKey(num3))
			{
				Dictionary<int, List<Zombie>> waveZombies2 = this.board.boardEntity.waveZombies;
				int num4 = this.theWave;
				List<Zombie> list = new List();
				waveZombies2.Add(num4, list);
			}
			Board board = this.board;
			uint num5;
			if (global::UnityEngine.Random.Range(0, (int)num5) == 4)
			{
				List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
				int num6 = this.theWave;
				List<ZombieSpawnData> list2 = zombieList[num6];
				ZombieSpawnData zombieSpawnData;
				zombieSpawnData.zombieType = (ZombieType)((ulong)47L);
				zombieSpawnData.row = (int)((ulong)4294967295L);
				int num7 = 0;
				list2[num7] = zombieSpawnData;
			}
			Dictionary<int, int> dictionary = this.mowerSpawns;
			Func<KeyValuePair<int, int>, bool> func = (KeyValuePair<int, int> kvp) => this.theWave > 2;
			List<KeyValuePair<int, int>> list3 = Enumerable.ToList<KeyValuePair<int, int>>(Enumerable.Where<KeyValuePair<int, int>>(dictionary, func));
			bool flag;
			if (flag)
			{
				bool flag2 = this.mowerSpawns.Remove(num);
			}
		}
		while (num2 != 0);
		int num8 = 0;
		List<List<ZombieSpawnData>> zombieList2 = InitZombieList.zombieList;
		List<List<ZombieSpawnData>> zombieList3 = InitZombieList.zombieList;
		List<ZombieSpawnData> list4;
		ZombieType zombieType = list4[num8].zombieType;
		int row = InitZombieList.zombieList[num8][num8].row;
		if (row < "{il2cpp field on {'constant74' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x148}")
		{
		}
		CreateZombie instance = CreateZombie.Instance;
		num2++;
		int num9 = 0;
		Zombie zombie;
		ulong num10;
		if (!(zombie == num9))
		{
			int totalAllHealth = zombie.TotalAllHealth;
			this.ApplyZombieTypeSpecificEffects(zombie);
			if (zombie.theZombieType == ZombieType.BungiZombie)
			{
			}
			int currentFirstHealth = zombie.CurrentFirstHealth;
			Board board2 = this.board;
			num10 += num10;
			num10 += num10;
			float num11;
			if (zombie != num10)
			{
				num11 = global::UnityEngine.Random.Range(0.4f, 0.65f);
			}
			board2.zombieSpawnHealth = (float)num8;
			board2.zombieSpawnHealth = num11;
			num8++;
		}
		Debug.LogWarning(string.Format("错误：尝试在{0}行放置{1}类型的僵尸", num10, num10));
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0003F664 File Offset: 0x0003D864
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x89F5D0", Offset = "0x89DBD0", VA = "0x18089F5D0")]
	private ZombieType AdjustZombieForTerrain(ZombieType originalType, int targetRow)
	{
		Board board = this.board;
		BoxType[] roadType = board.roadType;
		BoxType boxType;
		if (boxType == BoxType.Water)
		{
			Dictionary<ZombieType, ZombieType> amphibiousZombieToWater = TypeMgr.AmphibiousZombieToWater;
			bool flag;
			if (!flag)
			{
				Dictionary<ZombieType, ZombieType> amphibiousZombieToWater2 = TypeMgr.AmphibiousZombieToWater;
				bool flag2;
				if (flag2)
				{
				}
			}
			bool flag3;
			bool flag4;
			if (!flag3 && !flag4 && (ulong)1L == 0UL)
			{
				int randomLandRow = this.GetRandomLandRow();
				targetRow.m_value = randomLandRow;
			}
		}
		if (boxType == BoxType.River)
		{
			bool flag5;
			while (flag5)
			{
			}
		}
		int num;
		if (originalType == ZombieType.DancePolZombie2)
		{
			num = 0;
			int randomLandRow2 = this.GetRandomLandRow();
			targetRow.m_value = randomLandRow2;
		}
		ZombieType zombieType = this.HandleLandTerrain((ZombieType)num, targetRow);
		throw new NullReferenceException();
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0003F6FC File Offset: 0x0003D8FC
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x8A0460", Offset = "0x89EA60", VA = "0x1808A0460")]
	private ZombieType HandleWaterTerrain(ZombieType zombieType, int row)
	{
		Dictionary<ZombieType, ZombieType> amphibiousZombieToWater = TypeMgr.AmphibiousZombieToWater;
		bool flag;
		if (!flag)
		{
			Dictionary<ZombieType, ZombieType> amphibiousZombieToWater2 = TypeMgr.AmphibiousZombieToWater;
			bool flag2;
			if (flag2)
			{
			}
		}
		bool flag3;
		bool flag4;
		if (!flag3 && !flag4 && (ulong)1L == 0UL)
		{
			int randomLandRow = this.GetRandomLandRow();
			row.m_value = randomLandRow;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0003F754 File Offset: 0x0003D954
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x8A03B0", Offset = "0x89E9B0", VA = "0x1808A03B0")]
	private ZombieType HandleRiverTerrain(ZombieType zombieType, int row)
	{
		bool flag;
		if (!flag)
		{
			ZombieType zombieType2;
			return zombieType2;
		}
		int randomLandRow = this.GetRandomLandRow();
		row.m_value = randomLandRow;
		return ZombieType.NormalZombie;
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0003F784 File Offset: 0x0003D984
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x8A01C0", Offset = "0x89E7C0", VA = "0x1808A01C0")]
	private ZombieType HandleLandTerrain(ZombieType zombieType, int row)
	{
		bool flag;
		if (flag)
		{
			Dictionary<ZombieType, ZombieType> amphibiousZombieToWater = TypeMgr.AmphibiousZombieToWater;
			bool flag2;
			if (!flag2)
			{
				List<int> avaliableRows = this.GetAvaliableRows();
				Func<int, bool> func = delegate(int a)
				{
					BoxType[] roadType = this.board.roadType;
					return "{il2cpp array field local3->}" == (ulong)1L;
				};
				IEnumerable<int> enumerable = Enumerable.Where<int>(avaliableRows, func);
				Func<int, bool> func2 = (int a) => this.IsRowProtected(a);
				List<int> list = Enumerable.ToList<int>(Enumerable.Where<int>(enumerable, func2));
				int rowWithMinSpawns = this.GetRowWithMinSpawns(list);
				int randomRow = this.GetRandomRow();
				row.m_value = randomRow;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0003F80C File Offset: 0x0003DA0C
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x89F1F0", Offset = "0x89D7F0", VA = "0x18089F1F0")]
	private void AdjustRowForSpecialZombies(ZombieType zombieType, int row)
	{
		List<IceRoad> iceRoads = this.board.iceRoads;
		List<IceRoad> iceRoads2 = this.board.iceRoads;
		IceRoad iceRoad;
		if (iceRoad == 0)
		{
		}
		int num = this.board.rowNum;
		num -= (int)zombieType;
		row.m_value = num;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0003F8D8 File Offset: 0x0003DAD8
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x89F800", Offset = "0x89DE00", VA = "0x18089F800")]
	private void ApplyGameModeEffects(Zombie zombie, int spawnIndex)
	{
		Board board = this.board;
		if (spawnIndex == 0)
		{
			int num = this.theWave;
			ulong num2;
			num2 += num2;
			long num3 = (long)(num2 * (ulong)((uint)30));
			if ((long)num == num3)
			{
				zombie.SetGold();
				Transform transform = zombie.transform;
				Vector3 vector;
				float z = vector.z;
				Lawnf.SetZombieHealth(zombie, 5f);
				Player player = PlayerShootingManager.Instance.player;
				int num4;
				if (num4 > 0)
				{
					this.board.GetMoney(300f);
				}
			}
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0003F950 File Offset: 0x0003DB50
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x89FA30", Offset = "0x89E030", VA = "0x18089FA30")]
	private void AwardPointsForTravelZombie(Zombie zombie)
	{
		int totalAllHealth = zombie.TotalAllHealth;
		this.board.GetPoint(1.5f, true);
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0003F97C File Offset: 0x0003DB7C
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x89F960", Offset = "0x89DF60", VA = "0x18089F960")]
	private void ApplyZombieTypeSpecificEffects(Zombie zombie)
	{
		if (zombie.theZombieType == ZombieType.BungiZombie)
		{
			Board board = this.board;
			if (global::UnityEngine.Random.Range(0, 10) != 1)
			{
			}
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0003F9AC File Offset: 0x0003DBAC
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x89FF10", Offset = "0x89E510", VA = "0x18089FF10")]
	private int GetRowWithMinSpawns(List<int> availableRows)
	{
		Comparison<int> comparison;
		availableRows.Sort(comparison);
		int num = 0;
		Dictionary<int, int> dictionary = this.rowsSpawns;
		int num2 = availableRows[num];
		int num3 = 0;
		int valueOrDefault = CollectionExtensions.GetValueOrDefault<int, int>(dictionary, num2, num3);
		int minCount = valueOrDefault;
		Func<int, bool> func = delegate(int r)
		{
			BoardSpawner <>4__this = this;
			int num4 = 0;
			return CollectionExtensions.GetValueOrDefault<int, int>(<>4__this.rowsSpawns, r, num4) == minCount;
		};
		return ListExtensions.GetRandom<int>(Enumerable.ToList<int>(Enumerable.Where<int>(availableRows, func)));
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0003FA20 File Offset: 0x0003DC20
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x89FA90", Offset = "0x89E090", VA = "0x18089FA90")]
	private List<int> GetAvaliableRows()
	{
		List<int> list = new List();
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			int size = list._size;
			BoxType[] roadType = board.roadType;
			list._size = board;
			Board board2 = this.board;
			num++;
		}
		return list;
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0003FA7C File Offset: 0x0003DC7C
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x8A0650", Offset = "0x89EC50", VA = "0x1808A0650")]
	public void MowerStart(int row, int wave)
	{
		this.mowerSpawns[row] = wave;
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0003FA9C File Offset: 0x0003DC9C
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x8A05B0", Offset = "0x89EBB0", VA = "0x1808A05B0")]
	private bool IsRowProtected(int row)
	{
		if (this.mowerSpawns.ContainsKey(row))
		{
			int num = this.mowerSpawns[row];
			int num2 = this.theWave;
			num2 -= num;
			return num2 <= 2;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x8A0100", Offset = "0x89E700", VA = "0x1808A0100")]
	private List<int> GetUnprotectedRows()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = (int a) => this.IsRowProtected(a);
		return Enumerable.ToList<int>(Enumerable.Where<int>(avaliableRows, func));
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0003FB1C File Offset: 0x0003DD1C
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x89FCD0", Offset = "0x89E2D0", VA = "0x18089FCD0")]
	private int GetRandomRow()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = (int a) => this.IsRowProtected(a);
		List<int> list = Enumerable.ToList<int>(Enumerable.Where<int>(avaliableRows, func));
		List<int> avaliableRows2 = this.GetAvaliableRows();
		return this.GetRowWithMinSpawns(avaliableRows2);
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0003FB60 File Offset: 0x0003DD60
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x89FB90", Offset = "0x89E190", VA = "0x18089FB90")]
	private int GetRandomLandRow()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = delegate(int a)
		{
			BoxType boxType = this.board.roadType[a];
			if (boxType != BoxType.Water && boxType != BoxType.River && boxType != BoxType.Lava)
			{
				return true;
			}
			throw new NullReferenceException();
		};
		IEnumerable<int> enumerable = Enumerable.Where<int>(avaliableRows, func);
		Func<int, bool> func2 = (int a) => this.IsRowProtected(a);
		List<int> list = Enumerable.ToList<int>(Enumerable.Where<int>(enumerable, func2));
		return this.GetRowWithMinSpawns(list);
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0003FBBC File Offset: 0x0003DDBC
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x89FDD0", Offset = "0x89E3D0", VA = "0x18089FDD0")]
	private int GetRandomWaterRow()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = delegate(int a)
		{
			BoxType[] roadType = this.board.roadType;
			return "{il2cpp array field local3->}" == (ulong)1L;
		};
		IEnumerable<int> enumerable = Enumerable.Where<int>(avaliableRows, func);
		Func<int, bool> func2 = (int a) => this.IsRowProtected(a);
		List<int> list = Enumerable.ToList<int>(Enumerable.Where<int>(enumerable, func2));
		return this.GetRowWithMinSpawns(list);
	}

	// Token: 0x0400070A RID: 1802
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400070A")]
	public Board board;

	// Token: 0x0400070B RID: 1803
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400070B")]
	private int theWave;

	// Token: 0x0400070C RID: 1804
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400070C")]
	private readonly Dictionary<int, int> rowsSpawns;

	// Token: 0x0400070D RID: 1805
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400070D")]
	private readonly Dictionary<int, int> mowerSpawns;
}
