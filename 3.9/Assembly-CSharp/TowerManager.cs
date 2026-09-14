using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
public class TowerManager : MonoBehaviour
{
	// Token: 0x060004A3 RID: 1187 RVA: 0x00017F20 File Offset: 0x00016120
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x5EB6C0", Offset = "0x5E9CC0", VA = "0x1805EB6C0")]
	private void Awake()
	{
		TowerManager.Instance = this;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00017F34 File Offset: 0x00016134
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x5EBC50", Offset = "0x5EA250", VA = "0x1805EBC50")]
	private void Update()
	{
		if (GameAPP.config.difficulty > 4)
		{
			GameAPP.config.difficulty = (int)((ulong)4L);
		}
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00017F64 File Offset: 0x00016164
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x5EB720", Offset = "0x5E9D20", VA = "0x1805EB720")]
	public void SummonZombies(int theWave)
	{
		if (!this.board.boardEntity.waveZombies.ContainsKey(theWave))
		{
			Dictionary<int, List<Zombie>> waveZombies = this.board.boardEntity.waveZombies;
			List<Zombie> list = new List();
			waveZombies.Add(theWave, list);
		}
		int num = 0;
		List<ZombieSpawnData> list2 = InitZombieList.zombieList[theWave];
		ZombieType zombieType = InitZombieList.zombieList[theWave][num].zombieType;
		int num2 = GameAPP.theBoardLevel;
		int num3;
		num2 = num3;
		int num4 = GameAPP.theBoardLevel;
		if (typeof(GameAPP).TypeHandle > (ulong)1L || (num2 == 3 && zombieType != ZombieType.NormalZombie && zombieType != ZombieType.NormalZombie && zombieType != ZombieType.NormalZombie && zombieType != ZombieType.NormalZombie))
		{
			num4 += -21;
			if (num4 <= 1 && (num2 == 2 || num2 == 6))
			{
				int num5 = (int)zombieType;
				if (zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || zombieType == ZombieType.NormalZombie || num5 == 1)
				{
				}
			}
		}
		CreateZombie instance = CreateZombie.Instance;
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			if (this.board.theCurrentSurvivalRound > 1)
			{
			}
			Lawnf.SetZombieHealth(zombie, 3f);
			List<Zombie> list3 = this.board.boardEntity.waveZombies[theWave];
			Board board = this.board;
			long currentAllHealth = zombie.CurrentAllHealth;
			int num7 = 0;
			board.zombieTotalHealth = (float)num7;
		}
		num++;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x000180B0 File Offset: 0x000162B0
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TowerManager()
	{
	}

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	public static TowerManager Instance;

	// Token: 0x040002B9 RID: 697
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B9")]
	public Board board;

	// Token: 0x040002BA RID: 698
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002BA")]
	public MusicType musicType;
}
