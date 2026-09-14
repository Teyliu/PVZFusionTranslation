using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class PVPRandomManager : MonoBehaviour
{
	// Token: 0x06000442 RID: 1090 RVA: 0x00015B78 File Offset: 0x00013D78
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x5AE5C0", Offset = "0x5ACBC0", VA = "0x1805AE5C0")]
	private void Awake()
	{
		PVPRandomManager.Instance = this;
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00015B8C File Offset: 0x00013D8C
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x5AEDF0", Offset = "0x5AD3F0", VA = "0x1805AEDF0")]
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
		int num6 = 0;
		instance6.ShowText("让僵尸碰到456路的底线\n不要让僵尸碰到123路的底线", 15f, num6 != 0);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00015D08 File Offset: 0x00013F08
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x5AF1B0", Offset = "0x5AD7B0", VA = "0x1805AF1B0")]
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

	// Token: 0x06000445 RID: 1093 RVA: 0x00015DA0 File Offset: 0x00013FA0
	[Token(Token = "0x6000445")]
	[Address(RVA = "0x5AE4D0", Offset = "0x5ACAD0", VA = "0x1805AE4D0")]
	private void AISetZombie()
	{
		Vector2Int random = ListExtensions.GetRandom<Vector2Int>(this.aiZombieGrids);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00015DC8 File Offset: 0x00013FC8
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x5AED00", Offset = "0x5AD300", VA = "0x1805AED00")]
	public void PlayerSetZombie()
	{
		Vector2Int random = ListExtensions.GetRandom<Vector2Int>(this.playerZombieGrids);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00015DF0 File Offset: 0x00013FF0
	[Token(Token = "0x6000447")]
	[Address(RVA = "0x5AE820", Offset = "0x5ACE20", VA = "0x1805AE820")]
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

	// Token: 0x06000448 RID: 1096 RVA: 0x00015E90 File Offset: 0x00014090
	[Token(Token = "0x6000448")]
	[Address(RVA = "0x5ADFB0", Offset = "0x5AC5B0", VA = "0x1805ADFB0")]
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

	// Token: 0x06000449 RID: 1097 RVA: 0x00015F30 File Offset: 0x00014130
	[Token(Token = "0x6000449")]
	[Address(RVA = "0x5AF5D0", Offset = "0x5ADBD0", VA = "0x1805AF5D0")]
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

	// Token: 0x0600044A RID: 1098 RVA: 0x0001601C File Offset: 0x0001421C
	[Token(Token = "0x600044A")]
	[Address(RVA = "0x5AE620", Offset = "0x5ACC20", VA = "0x1805AE620")]
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

	// Token: 0x0600044B RID: 1099 RVA: 0x00016060 File Offset: 0x00014260
	[Token(Token = "0x600044B")]
	[Address(RVA = "0x5AE6F0", Offset = "0x5ACCF0", VA = "0x1805AE6F0")]
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

	// Token: 0x0600044C RID: 1100 RVA: 0x000160D8 File Offset: 0x000142D8
	[Token(Token = "0x600044C")]
	[Address(RVA = "0x5AF850", Offset = "0x5ADE50", VA = "0x1805AF850")]
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

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	public static PVPRandomManager Instance;

	// Token: 0x0400025D RID: 605
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400025D")]
	public Board board;

	// Token: 0x0400025E RID: 606
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400025E")]
	public float sun;

	// Token: 0x0400025F RID: 607
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400025F")]
	public List<TextMeshPro> texts;

	// Token: 0x04000260 RID: 608
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000260")]
	private readonly List<Vector2Int> playerPlantGrids;

	// Token: 0x04000261 RID: 609
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000261")]
	private readonly List<Vector2Int> playerZombieGrids;

	// Token: 0x04000262 RID: 610
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000262")]
	private readonly List<Vector2Int> aiPlantGrids;

	// Token: 0x04000263 RID: 611
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000263")]
	private readonly List<Vector2Int> aiZombieGrids;

	// Token: 0x04000264 RID: 612
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000264")]
	public int p1Health;

	// Token: 0x04000265 RID: 613
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000265")]
	public int p2Health;

	// Token: 0x04000266 RID: 614
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000266")]
	private float speed;

	// Token: 0x04000267 RID: 615
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000267")]
	private float timer;

	// Token: 0x04000268 RID: 616
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000268")]
	private float timerUntilStart;
}
