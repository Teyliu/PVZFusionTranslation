using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x2000269")]
public class BoardSpawner
{
	// Token: 0x06000B16 RID: 2838 RVA: 0x0003F2F8 File Offset: 0x0003D4F8
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x931170", Offset = "0x92F770", VA = "0x180931170")]
	public BoardSpawner(Board board)
	{
		Dictionary<int, int> dictionary = new Dictionary();
		this.rowsSpawns = dictionary;
		Dictionary<int, int> dictionary2 = new Dictionary();
		this.mowerSpawns = dictionary2;
		base..ctor();
		this.board = board;
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0003F32C File Offset: 0x0003D52C
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x930660", Offset = "0x92EC60", VA = "0x180930660")]
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
			long totalAllHealth = zombie.TotalAllHealth;
			this.ApplyZombieTypeSpecificEffects(zombie);
			if (zombie.theZombieType == ZombieType.BungiZombie)
			{
			}
			long currentFirstHealth = zombie.CurrentFirstHealth;
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

	// Token: 0x06000B18 RID: 2840 RVA: 0x0003F524 File Offset: 0x0003D724
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x92F570", Offset = "0x92DB70", VA = "0x18092F570")]
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

	// Token: 0x06000B19 RID: 2841 RVA: 0x0003F5BC File Offset: 0x0003D7BC
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x930400", Offset = "0x92EA00", VA = "0x180930400")]
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

	// Token: 0x06000B1A RID: 2842 RVA: 0x0003F614 File Offset: 0x0003D814
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x930350", Offset = "0x92E950", VA = "0x180930350")]
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

	// Token: 0x06000B1B RID: 2843 RVA: 0x0003F644 File Offset: 0x0003D844
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x930160", Offset = "0x92E760", VA = "0x180930160")]
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

	// Token: 0x06000B1C RID: 2844 RVA: 0x0003F6CC File Offset: 0x0003D8CC
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x92F190", Offset = "0x92D790", VA = "0x18092F190")]
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

	// Token: 0x06000B1D RID: 2845 RVA: 0x0003F798 File Offset: 0x0003D998
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x92F7A0", Offset = "0x92DDA0", VA = "0x18092F7A0")]
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

	// Token: 0x06000B1E RID: 2846 RVA: 0x0003F810 File Offset: 0x0003DA10
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x92F9D0", Offset = "0x92DFD0", VA = "0x18092F9D0")]
	private void AwardPointsForTravelZombie(Zombie zombie)
	{
		long totalAllHealth = zombie.TotalAllHealth;
		this.board.GetPoint(1.5f, true);
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0003F83C File Offset: 0x0003DA3C
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x92F900", Offset = "0x92DF00", VA = "0x18092F900")]
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

	// Token: 0x06000B20 RID: 2848 RVA: 0x0003F86C File Offset: 0x0003DA6C
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x92FEB0", Offset = "0x92E4B0", VA = "0x18092FEB0")]
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

	// Token: 0x06000B21 RID: 2849 RVA: 0x0003F8E0 File Offset: 0x0003DAE0
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x92FA30", Offset = "0x92E030", VA = "0x18092FA30")]
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

	// Token: 0x06000B22 RID: 2850 RVA: 0x0003F93C File Offset: 0x0003DB3C
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x9305F0", Offset = "0x92EBF0", VA = "0x1809305F0")]
	public void MowerStart(int row, int wave)
	{
		this.mowerSpawns[row] = wave;
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0003F95C File Offset: 0x0003DB5C
	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x930550", Offset = "0x92EB50", VA = "0x180930550")]
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

	// Token: 0x06000B24 RID: 2852 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x9300A0", Offset = "0x92E6A0", VA = "0x1809300A0")]
	private List<int> GetUnprotectedRows()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = (int a) => this.IsRowProtected(a);
		return Enumerable.ToList<int>(Enumerable.Where<int>(avaliableRows, func));
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x0003F9DC File Offset: 0x0003DBDC
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x92FC70", Offset = "0x92E270", VA = "0x18092FC70")]
	private int GetRandomRow()
	{
		List<int> avaliableRows = this.GetAvaliableRows();
		Func<int, bool> func = (int a) => this.IsRowProtected(a);
		List<int> list = Enumerable.ToList<int>(Enumerable.Where<int>(avaliableRows, func));
		List<int> avaliableRows2 = this.GetAvaliableRows();
		return this.GetRowWithMinSpawns(avaliableRows2);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0003FA20 File Offset: 0x0003DC20
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x92FB30", Offset = "0x92E130", VA = "0x18092FB30")]
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

	// Token: 0x06000B27 RID: 2855 RVA: 0x0003FA7C File Offset: 0x0003DC7C
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x92FD70", Offset = "0x92E370", VA = "0x18092FD70")]
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

	// Token: 0x04000716 RID: 1814
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000716")]
	public Board board;

	// Token: 0x04000717 RID: 1815
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000717")]
	private int theWave;

	// Token: 0x04000718 RID: 1816
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000718")]
	private readonly Dictionary<int, int> rowsSpawns;

	// Token: 0x04000719 RID: 1817
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000719")]
	private readonly Dictionary<int, int> mowerSpawns;
}
