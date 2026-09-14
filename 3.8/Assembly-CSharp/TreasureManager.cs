using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000618 RID: 1560
[Token(Token = "0x2000618")]
public class TreasureManager : MonoBehaviour
{
	// Token: 0x06001D79 RID: 7545 RVA: 0x0009D690 File Offset: 0x0009B890
	[Token(Token = "0x6001D79")]
	[Address(RVA = "0x5297E0", Offset = "0x527DE0", VA = "0x1805297E0")]
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

	// Token: 0x06001D7A RID: 7546 RVA: 0x0009D6EC File Offset: 0x0009B8EC
	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0x529FD0", Offset = "0x5285D0", VA = "0x180529FD0")]
	private void Start()
	{
		List<TextMeshProUGUI> list = Enumerable.ToList<TextMeshProUGUI>(InGameUI.Instance.evacuate.GetComponentsInChildren<TextMeshProUGUI>());
		this.evaText = list;
		throw new NullReferenceException();
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x0009D71C File Offset: 0x0009B91C
	[Token(Token = "0x6001D7B")]
	[Address(RVA = "0x529B60", Offset = "0x528160", VA = "0x180529B60")]
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
				int num3 = 0;
				instance2.ShowText("多余的卡牌将在关卡胜利后返回仓库\n失败后不会退回！", 5f, num3 != 0);
			}
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x0009D7C0 File Offset: 0x0009B9C0
	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0x52A380", Offset = "0x528980", VA = "0x18052A380")]
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

	// Token: 0x06001D7D RID: 7549 RVA: 0x0009D820 File Offset: 0x0009BA20
	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0x529D70", Offset = "0x528370", VA = "0x180529D70")]
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
			int num = 0;
			instance2.ShowText("即将丢弃背包中的卡牌", 5f, num != 0);
			queue.Enqueue(treasureTask);
			this.taskType = taskType;
		}
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0x52A070", Offset = "0x528670", VA = "0x18052A070")]
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

	// Token: 0x06001D7F RID: 7551 RVA: 0x0009D970 File Offset: 0x0009BB70
	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0x5298B0", Offset = "0x527EB0", VA = "0x1805298B0")]
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
		int num2 = 0;
		instance.ShowText(text, 1f, num2 != 0);
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x0009DA00 File Offset: 0x0009BC00
	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x52A450", Offset = "0x528A50", VA = "0x18052A450")]
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

	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x400100F")]
	public static TreasureManager Instance;

	// Token: 0x04001010 RID: 4112
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001010")]
	public Board board;

	// Token: 0x04001011 RID: 4113
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001011")]
	public float maxTimer = 1200f;

	// Token: 0x04001012 RID: 4114
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001012")]
	public bool first;

	// Token: 0x04001013 RID: 4115
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4001013")]
	public bool evacuated;

	// Token: 0x04001014 RID: 4116
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001014")]
	public List<TreasureCardData> cardData;

	// Token: 0x04001015 RID: 4117
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001015")]
	public List<TextMeshProUGUI> evaText;

	// Token: 0x04001016 RID: 4118
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001016")]
	public TreasureTask.TaskType taskType;

	// Token: 0x04001017 RID: 4119
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001017")]
	public Queue<TreasureTask> tasks;
}
