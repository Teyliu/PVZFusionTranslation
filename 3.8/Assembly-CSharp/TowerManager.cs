using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class TowerManager : MonoBehaviour
{
	// Token: 0x06000488 RID: 1160 RVA: 0x00017B14 File Offset: 0x00015D14
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x5B5C30", Offset = "0x5B4230", VA = "0x1805B5C30")]
	private void Awake()
	{
		TowerManager.Instance = this;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00017B28 File Offset: 0x00015D28
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x5B61C0", Offset = "0x5B47C0", VA = "0x1805B61C0")]
	private void Update()
	{
		if (GameAPP.config.difficulty > 4)
		{
			GameAPP.config.difficulty = (int)((ulong)4L);
		}
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00017B58 File Offset: 0x00015D58
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x5B5C90", Offset = "0x5B4290", VA = "0x1805B5C90")]
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
			int currentAllHealth = zombie.CurrentAllHealth;
		}
		num++;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00017C98 File Offset: 0x00015E98
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TowerManager()
	{
	}

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	public static TowerManager Instance;

	// Token: 0x040002AB RID: 683
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002AB")]
	public Board board;

	// Token: 0x040002AC RID: 684
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AC")]
	public MusicType musicType;
}
