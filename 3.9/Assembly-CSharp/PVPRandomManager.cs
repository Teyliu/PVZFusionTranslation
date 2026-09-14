using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class PVPRandomManager : MonoBehaviour
{
	// Token: 0x0600045D RID: 1117 RVA: 0x00016008 File Offset: 0x00014208
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x5E4050", Offset = "0x5E2650", VA = "0x1805E4050")]
	private void Awake()
	{
		PVPRandomManager.Instance = this;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0001601C File Offset: 0x0001421C
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x5E4880", Offset = "0x5E2E80", VA = "0x1805E4880")]
	private void Start()
	{
		int num = 0;
		Board instance = Board.Instance;
		this.board = instance;
		InitBoard instance2 = InitBoard.Instance;
		int num2 = 0;
		CardUI cardUI = instance2.CreateCard((PlantType)((uint)256), true, num2 != 0);
		num++;
		cardUI.theSeedCost = (int)((ulong)100L);
		cardUI.fullCD = 7.5f;
		InitBoard instance3 = InitBoard.Instance;
		int num3 = 0;
		CardUI cardUI2 = instance3.CreateCard((PlantType)((uint)250), true, num3 != 0);
		num++;
		cardUI2.theSeedCost = (int)((ulong)100L);
		cardUI2.fullCD = 7.5f;
		InitBoard instance4 = InitBoard.Instance;
		int num4 = 0;
		instance4.CreateCard((FunctionCardType)((uint)16), num4 != 0).theSeedCost = (int)((ulong)100L);
		InitBoard instance5 = InitBoard.Instance;
		int num5 = 0;
		instance5.CreateCard((FunctionCardType)((uint)17), num5 != 0).theSeedCost = (int)((ulong)100L);
		GameAPP.Instance.PlayMusic((MusicType)((uint)2));
		Board board = this.board;
		if (num < board.columnNum)
		{
			Board board2 = this.board;
			if (num < board2.rowNum)
			{
				List<Vector2Int> list = this.playerPlantGrids;
				num++;
			}
			num++;
		}
		this.sun = 500f;
		InGameUI.Instance.LevProgress.SetActive(true);
		InGameUI.Instance.GloveBank.SetActive(true);
		Glove.Instance.fullCD = 20f;
		TravelMgr travelMgr = this.AddComponent<TravelMgr>();
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)18));
		InGameText instance6 = InGameText.Instance;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00016184 File Offset: 0x00014384
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x5E4C40", Offset = "0x5E3240", VA = "0x1805E4C40")]
	private void Update()
	{
		int num;
		do
		{
			List<TextMeshPro> list = this.texts;
			num = 0;
			bool flag;
			if (flag)
			{
				int num2 = this.p1Health;
				int num3 = this.p2Health;
				string text = string.Format("玩家\n{0}/10\n\n\n\n\n电脑\n{1}/10", num2, num2);
			}
		}
		while (num != 0);
		float deltaTime = Time.deltaTime;
		float deltaTime2 = Time.deltaTime;
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x0001621C File Offset: 0x0001441C
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x5E3F60", Offset = "0x5E2560", VA = "0x1805E3F60")]
	private void AISetZombie()
	{
		Vector2Int random = ListExtensions.GetRandom<Vector2Int>(this.aiZombieGrids);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00016244 File Offset: 0x00014444
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x5E4790", Offset = "0x5E2D90", VA = "0x1805E4790")]
	public void PlayerSetZombie()
	{
		Vector2Int random = ListExtensions.GetRandom<Vector2Int>(this.playerZombieGrids);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0001626C File Offset: 0x0001446C
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x5E42B0", Offset = "0x5E28B0", VA = "0x1805E42B0")]
	public bool PlayerSetPlant()
	{
		int num3;
		do
		{
			int num = 0;
			List<Vector2Int> list = new List(this.playerPlantGrids);
			List<Vector2Int> list2 = this.playerPlantGrids;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				List<Plant> list3 = global::Lawnf.Get1x1Plants(num, num);
				bool flag2;
				if (flag2)
				{
					bool flag3;
					if (!flag3)
					{
					}
					bool flag4 = list.Remove(num);
				}
				if (num2 != 0)
				{
					goto IL_0084;
				}
			}
			if (num2 != 0)
			{
				goto IL_008A;
			}
			num3 = 0;
			int x = ListExtensions.GetRandom<Vector2Int>(list).m_X;
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num3 != 0);
		CreatePlant instance = CreatePlant.Instance;
		throw new NullReferenceException();
		IL_0084:
		throw new NullReferenceException();
		IL_008A:
		throw new NullReferenceException();
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x0001630C File Offset: 0x0001450C
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x5E3A40", Offset = "0x5E2040", VA = "0x1805E3A40")]
	private void AISetPlant()
	{
		int num3;
		do
		{
			int num = 0;
			List<Vector2Int> list = new List(this.aiPlantGrids);
			List<Vector2Int> list2 = this.aiPlantGrids;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				List<Plant> list3 = global::Lawnf.Get1x1Plants(num, num);
				bool flag2;
				if (flag2)
				{
					bool flag3;
					if (!flag3)
					{
					}
					while (num != 0)
					{
					}
					bool flag4 = list.Remove(num);
				}
				if (num2 != 0)
				{
					goto IL_0086;
				}
			}
			if (num2 != 0)
			{
				goto IL_008C;
			}
			num3 = 0;
			int x = ListExtensions.GetRandom<Vector2Int>(list).m_X;
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num3 != 0);
		CreatePlant instance = CreatePlant.Instance;
		return;
		IL_0086:
		throw new NullReferenceException();
		IL_008C:
		throw new NullReferenceException();
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x000163AC File Offset: 0x000145AC
	[Token(Token = "0x6000464")]
	[Address(RVA = "0x5E5060", Offset = "0x5E3660", VA = "0x1805E5060")]
	public void ZombieEnterHouse(Zombie zombie)
	{
		float num = this.sun;
		this.sun = num;
		Board board = this.board;
		Board board2 = this.board;
		if (!board2.over)
		{
			board2.over = true;
			Board board3 = this.board;
		}
		Board board4 = this.board;
		uint num2;
		if (num2 < (uint)board4.rowNum)
		{
			BoardAction boardAction = this.board.boardAction;
			Board board5 = this.board;
			num2 += (uint)1;
			Board board6 = this.board;
			if (this.p1Health > 0)
			{
				int num3 = 0;
				BoardAction boardAction2 = this.board.boardAction;
				num3++;
			}
			UIMgr.EnterLoseMenu("");
		}
		BoardConfig config = this.board.config;
		float zombieHealthMultiplier = config.zombieHealthMultiplier;
		config.zombieHealthMultiplier = zombieHealthMultiplier;
		BoardConfig config2 = this.board.config;
		float zombieDamageMultiplier = config2.zombieDamageMultiplier;
		config2.zombieDamageMultiplier = zombieDamageMultiplier;
		throw new NullReferenceException();
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00016498 File Offset: 0x00014698
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x5E40B0", Offset = "0x5E26B0", VA = "0x1805E40B0")]
	private void DamagePlayer1()
	{
		Board board = this.board;
		if (this.p1Health > 0)
		{
			int num = 0;
			BoardAction boardAction = this.board.boardAction;
			num++;
			return;
		}
		UIMgr.EnterLoseMenu("");
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x000164DC File Offset: 0x000146DC
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x5E4180", Offset = "0x5E2780", VA = "0x1805E4180")]
	private void DamagePlayer2()
	{
		Board board2;
		for (;;)
		{
			float num = this.sun;
			this.sun = num;
			Board board = this.board;
			board2 = this.board;
			if (!board2.over)
			{
				break;
			}
			Board board3 = this.board;
			while (3 >= board3.rowNum)
			{
			}
			BoardAction boardAction = this.board.boardAction;
			if (this.board == 0)
			{
				goto Block_2;
			}
		}
		board2.over = true;
		Board board4 = this.board;
		return;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00016554 File Offset: 0x00014754
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x5E52E0", Offset = "0x5E38E0", VA = "0x1805E52E0")]
	public PVPRandomManager()
	{
		List<TextMeshPro> list = new List();
		this.texts = list;
		List<Vector2Int> list2 = new List();
		this.playerPlantGrids = list2;
		List<Vector2Int> list3 = new List();
		this.playerZombieGrids = list3;
		List<Vector2Int> list4 = new List();
		this.aiPlantGrids = list4;
		List<Vector2Int> list5 = new List();
		this.aiZombieGrids = list5;
		this.p1Health = (int)((ulong)10L);
		this.p2Health = (int)((ulong)10L);
		this.speed = 1f;
		this.timerUntilStart = 15f;
		base..ctor();
	}

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	public static PVPRandomManager Instance;

	// Token: 0x0400026B RID: 619
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400026B")]
	public Board board;

	// Token: 0x0400026C RID: 620
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400026C")]
	public float sun;

	// Token: 0x0400026D RID: 621
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400026D")]
	public List<TextMeshPro> texts;

	// Token: 0x0400026E RID: 622
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400026E")]
	private readonly List<Vector2Int> playerPlantGrids;

	// Token: 0x0400026F RID: 623
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400026F")]
	private readonly List<Vector2Int> playerZombieGrids;

	// Token: 0x04000270 RID: 624
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000270")]
	private readonly List<Vector2Int> aiPlantGrids;

	// Token: 0x04000271 RID: 625
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000271")]
	private readonly List<Vector2Int> aiZombieGrids;

	// Token: 0x04000272 RID: 626
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000272")]
	public int p1Health;

	// Token: 0x04000273 RID: 627
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000273")]
	public int p2Health;

	// Token: 0x04000274 RID: 628
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000274")]
	private float speed;

	// Token: 0x04000275 RID: 629
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000275")]
	private float timer;

	// Token: 0x04000276 RID: 630
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000276")]
	private float timerUntilStart;
}
