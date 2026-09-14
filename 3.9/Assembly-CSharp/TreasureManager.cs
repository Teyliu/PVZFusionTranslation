using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200064D RID: 1613
[Token(Token = "0x200064D")]
public class TreasureManager : MonoBehaviour
{
	// Token: 0x06001E78 RID: 7800 RVA: 0x000A213C File Offset: 0x000A033C
	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x594980", Offset = "0x592F80", VA = "0x180594980")]
	private void Awake()
	{
		TreasureManager.Instance = this;
		TreasureDifficulty difficulty = TreasureData.difficulty;
		if (difficulty != TreasureDifficulty.Normal)
		{
			if (difficulty == TreasureDifficulty.Normal)
			{
				this.maxTimer = 900f;
				return;
			}
			if (difficulty == TreasureDifficulty.Normal)
			{
				this.maxTimer = 1200f;
				return;
			}
			if (difficulty == TreasureDifficulty.Normal || difficulty == TreasureDifficulty.Hard)
			{
				this.maxTimer = 1500f;
				return;
			}
		}
		else
		{
			this.maxTimer = 600f;
		}
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x000A2198 File Offset: 0x000A0398
	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x5951B0", Offset = "0x5937B0", VA = "0x1805951B0")]
	private void Start()
	{
		List<TextMeshProUGUI> list = Enumerable.ToList<TextMeshProUGUI>(InGameUI.Instance.evacuate.GetComponentsInChildren<TextMeshProUGUI>());
		this.evaText = list;
		throw new NullReferenceException();
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000A21C8 File Offset: 0x000A03C8
	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x594D20", Offset = "0x593320", VA = "0x180594D20")]
	public void GetCard(TreasureCardData data)
	{
		List<TreasureCardData> list = this.cardData;
		int size = list._size;
		list._size = "多余的卡牌将在关卡胜利后返回仓库\n失败后不会退回！";
		SeedLibrary instance = SeedLibrary.Instance;
		int num = 0;
		CardUI cardUI = instance.SetTreasureCard(data, num);
		int num2 = 0;
		if (!(cardUI == num2))
		{
			List<CardUI> cards = InGameUI.Instance.Cards;
			int maxCardCount = InGameUI.Instance._cardSlotManager._maxCardCount;
			if (this.first)
			{
				this.first = true;
				InGameText instance2 = InGameText.Instance;
			}
		}
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x000A2258 File Offset: 0x000A0458
	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0x595560", Offset = "0x593B60", VA = "0x180595560")]
	private void Update()
	{
		this.TaskUpdate();
		Board board = this.board;
		if (board.theWave == 95)
		{
			board.theWave = (int)((ulong)85L);
		}
		if (this.board.boardStatistics.gameDuration > this.maxTimer && !this.evacuated)
		{
			UIMgr.EnterLoseMenu("撤离超时");
			return;
		}
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x000A22B8 File Offset: 0x000A04B8
	[Token(Token = "0x6001E7C")]
	[Address(RVA = "0x594F40", Offset = "0x593540", VA = "0x180594F40")]
	public void GetTask(TreasureTask.TaskType taskType)
	{
		if (!this.evacuated)
		{
			this.tasks.Clear();
			Queue<TreasureTask> queue = this.tasks;
			TreasureTask treasureTask;
			treasureTask.taskType = taskType;
			treasureTask.manager = this;
			if (taskType != TreasureTask.TaskType.NormalEvacuate)
			{
				if (taskType != TreasureTask.TaskType.NormalEvacuate)
				{
					if (taskType != TreasureTask.TaskType.NormalEvacuate)
					{
						if (taskType != TreasureTask.TaskType.LoseBagEvacuate)
						{
							goto IL_0076;
						}
						CreateZombie instance = CreateZombie.Instance;
						Zombie zombie;
						global::Lawnf.SetZombieHealth(zombie.GetComponent<Zombie>(), 10f);
					}
					treasureTask.timer = 300f;
				}
				treasureTask.timer = 30f;
			}
			treasureTask.timer = 10f;
			IL_0076:
			InGameText instance2 = InGameText.Instance;
			queue.Enqueue(treasureTask);
			this.taskType = taskType;
		}
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000A235C File Offset: 0x000A055C
	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x595250", Offset = "0x593850", VA = "0x180595250")]
	private void TaskUpdate()
	{
		int num;
		ulong num3;
		do
		{
			num = 0;
			Queue<TreasureTask> queue = this.tasks;
			bool flag;
			if (!flag)
			{
				return;
			}
			Queue<TreasureTask> queue2 = this.tasks;
			List<TextMeshProUGUI> list = this.evaText;
			bool flag2;
			if (flag2)
			{
				ulong num2;
				string text = string.Format("即将撤离({0:F0})", num2);
			}
		}
		while (num3 != (ulong)0L);
		int num4 = 0;
		if (num > num4)
		{
			float deltaTime = Time.deltaTime;
			TreasureTask treasureTask = this.tasks.Dequeue();
		}
		Queue<TreasureTask> queue3 = this.tasks;
		Board board = this.board;
		PrizeMgr prizeMgr;
		prizeMgr.Clicked();
		this.evacuated = true;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000A23F4 File Offset: 0x000A05F4
	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x594A50", Offset = "0x593050", VA = "0x180594A50")]
	public void Evacuate()
	{
		TreasureDifficulty difficulty = TreasureData.difficulty;
		if (difficulty == TreasureDifficulty.Normal || difficulty == TreasureDifficulty.Normal || difficulty == TreasureDifficulty.Normal || difficulty == TreasureDifficulty.Normal || difficulty == TreasureDifficulty.Hard)
		{
		}
		BoardStatistics boardStatistics = this.board.boardStatistics;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		BoardStatistics boardStatistics2 = this.board.boardStatistics;
		string text = string.Format("汽车在{0:F0}秒后修理完毕", instance);
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x000A2470 File Offset: 0x000A0670
	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x595630", Offset = "0x593C30", VA = "0x180595630")]
	public TreasureManager()
	{
		List<TreasureCardData> list = new List();
		this.cardData = list;
		List<TextMeshProUGUI> list2 = new List();
		this.evaText = list2;
		Queue<TreasureTask> queue = new Queue();
		this.tasks = queue;
		base..ctor();
	}

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	public static TreasureManager Instance;

	// Token: 0x040010D8 RID: 4312
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010D8")]
	public Board board;

	// Token: 0x040010D9 RID: 4313
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010D9")]
	public float maxTimer = 1200f;

	// Token: 0x040010DA RID: 4314
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40010DA")]
	public bool first;

	// Token: 0x040010DB RID: 4315
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40010DB")]
	public bool evacuated;

	// Token: 0x040010DC RID: 4316
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010DC")]
	public List<TreasureCardData> cardData;

	// Token: 0x040010DD RID: 4317
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010DD")]
	public List<TextMeshProUGUI> evaText;

	// Token: 0x040010DE RID: 4318
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010DE")]
	public TreasureTask.TaskType taskType;

	// Token: 0x040010DF RID: 4319
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010DF")]
	public Queue<TreasureTask> tasks;
}
