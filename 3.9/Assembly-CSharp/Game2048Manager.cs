using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class Game2048Manager : MonoBehaviour
{
	// Token: 0x0600034E RID: 846 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x415480", Offset = "0x413A80", VA = "0x180415480")]
	private void Start()
	{
		Board board = this.board;
		int columnNum = board.columnNum;
		int num = board.rowNum;
		if (num >= columnNum)
		{
			num = columnNum;
		}
		this.range = num;
		int num2 = num - 1;
		board.SetRedLine(num2);
		this.SetPlant();
		this.SetPlant();
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0000EE44 File Offset: 0x0000D044
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x415620", Offset = "0x413C20", VA = "0x180415620")]
	private void Update()
	{
		if (!this.isAnimating && (Lawnf.GetKeyDown((KeyCode)((uint)119)) || Lawnf.GetKeyDown((KeyCode)((uint)115)) || Lawnf.GetKeyDown((KeyCode)((uint)97)) || Lawnf.GetKeyDown((KeyCode)((uint)100))))
		{
			Game2048Manager.<MoveUpWithAnimation>d__10 <MoveUpWithAnimation>d__;
			<MoveUpWithAnimation>d__.System.IDisposable.Dispose();
			<MoveUpWithAnimation>d__.<>1__state = (int)((ulong)0L);
			<MoveUpWithAnimation>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<MoveUpWithAnimation>d__);
		}
		this.PlantPositionUpdate();
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0000EEAC File Offset: 0x0000D0AC
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x415210", Offset = "0x413810", VA = "0x180415210")]
	private void SetPlant()
	{
		List<Vector2Int> list = new List();
		int num = 0;
		if (this.range > num)
		{
			int num2 = 0;
			if (this.range > num2)
			{
				if (!this.board.gridSystem.HasPlant(num, num2))
				{
				}
				num2++;
			}
			num++;
		}
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		Vector2Int vector2Int = list[num3];
		bool flag = global::UnityEngine.Random.Range(0, 10) >= 9;
		CreatePlant instance = CreatePlant.Instance;
		PlantType plantType = this.UpgradeRoute[flag ? 1 : 0];
		Plant plant;
		plant.thePlantHealth = (int)((ulong)4L);
		plant.thePlantMaxHealth = (int)((ulong)4L);
		plant.thePlantHealth = (int)((ulong)2L);
		plant.thePlantMaxHealth = (int)((ulong)2L);
		if (this.IsGameOver())
		{
			UIMgr.EnterLoseMenu("");
		}
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0000EF78 File Offset: 0x0000D178
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x414BE0", Offset = "0x4131E0", VA = "0x180414BE0")]
	private IEnumerator MoveUpWithAnimation()
	{
		Game2048Manager.<MoveUpWithAnimation>d__10 <MoveUpWithAnimation>d__;
		<MoveUpWithAnimation>d__.System.IDisposable.Dispose();
		<MoveUpWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveUpWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0000EF9C File Offset: 0x0000D19C
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x414970", Offset = "0x412F70", VA = "0x180414970")]
	private IEnumerator MoveDownWithAnimation()
	{
		Game2048Manager.<MoveDownWithAnimation>d__11 <MoveDownWithAnimation>d__;
		<MoveDownWithAnimation>d__.System.IDisposable.Dispose();
		<MoveDownWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveDownWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x4149E0", Offset = "0x412FE0", VA = "0x1804149E0")]
	private IEnumerator MoveLeftWithAnimation()
	{
		Game2048Manager.<MoveLeftWithAnimation>d__12 <MoveLeftWithAnimation>d__;
		<MoveLeftWithAnimation>d__.System.IDisposable.Dispose();
		<MoveLeftWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveLeftWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x414B70", Offset = "0x413170", VA = "0x180414B70")]
	private IEnumerator MoveRightWithAnimation()
	{
		Game2048Manager.<MoveRightWithAnimation>d__13 <MoveRightWithAnimation>d__;
		<MoveRightWithAnimation>d__.System.IDisposable.Dispose();
		<MoveRightWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveRightWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0000F008 File Offset: 0x0000D208
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x414A50", Offset = "0x413050", VA = "0x180414A50")]
	private void MovePlantWithAnimation(Plant plant, int newCol, int newRow)
	{
		this.board.gridSystem.RemovePlant(plant);
		plant.thePlantColumn = newCol;
		plant.thePlantRow = newRow;
		Board board = this.board;
		board.gridSystem.AddPlant(plant);
		List<Plant> list = this.movingPlants;
		int size = list._size;
		BoxType boxType = board.roadType[10];
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0000F074 File Offset: 0x0000D274
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x414C50", Offset = "0x413250", VA = "0x180414C50")]
	private void PlantPositionUpdate()
	{
		int num5;
		do
		{
			int num = 0;
			this.stop = true;
			int size = this.movingPlants._size;
			int num2 = 0;
			Plant plant = this.movingPlants[size];
			int num3 = 0;
			if (!(plant == num3))
			{
				Board board = this.board;
				Transform axis = plant.axis;
				float num4 = this.moveSpeed;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				if (num2 > (int)num4 || num4 > 1f)
				{
				}
				Transform axis2 = plant.axis;
			}
			this.movingPlants.RemoveAt(size);
			num5 = 0;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				int num6 = 0;
				if (!(num != num6) || this.movingPlants.Contains(num))
				{
					continue;
				}
				Board board2 = this.board;
				float unscaledDeltaTime2 = Time.unscaledDeltaTime;
				if (num2 > (int)unscaledDeltaTime2 || unscaledDeltaTime2 > 1f)
				{
				}
			}
		}
		while (num5 != 0);
		Vector3 vector;
		bool flag2 = vector.upVector == (ulong)0L;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0000F190 File Offset: 0x0000D390
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x414710", Offset = "0x412D10", VA = "0x180414710")]
	private Plant MixPlant(Plant plant1, Plant plant2)
	{
		int thePlantColumn = plant1.thePlantColumn;
		PlantType thePlantType = plant2.thePlantType;
		if (plant1.thePlantType == thePlantType)
		{
			List<PlantType> upgradeRoute = this.UpgradeRoute;
			int num = 0;
			int num2 = 0;
			int size = upgradeRoute._size;
			if (num2 < size)
			{
				List<PlantType> upgradeRoute2 = this.UpgradeRoute;
				PlantType thePlantType2 = plant1.thePlantType;
				PlantType plantType = upgradeRoute2[num];
				if (thePlantType2 != plantType)
				{
					List<PlantType> upgradeRoute3 = this.UpgradeRoute;
					num++;
				}
				int num3 = 0;
				plant1.Die((Plant.DieReason)num3);
				int num4 = 0;
				plant2.Die((Plant.DieReason)num4);
				List<PlantType> upgradeRoute4 = this.UpgradeRoute;
				CreatePlant instance = CreatePlant.Instance;
				PlantType plantType2 = upgradeRoute4[1];
				int num5 = 0;
				Plant plant3;
				plant3.thePlantHealth = instance;
				plant3.thePlantMaxHealth = instance;
				if ((this.over ? 1 : 0) == num5)
				{
					Board board = this.board;
					this.over = true;
					int num6 = 0;
					Vector2 vector;
					PrizeMgr prizeMgr = Lawnf.SetAward(board, vector, true, num6 != 0);
					this.board.boardTag.disableSummonZombie = true;
				}
				return plant3;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0000F290 File Offset: 0x0000D490
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x4144C0", Offset = "0x412AC0", VA = "0x1804144C0")]
	private bool IsGameOver()
	{
		int num = 0;
		if (this.range > num)
		{
			int num2 = 0;
			if (this.range > num2)
			{
				if (!this.board.gridSystem.HasPlant(num, num2))
				{
					goto IL_011D;
				}
				num2++;
			}
			num++;
		}
		int num3 = 0;
		if (this.range > num3)
		{
			int num4 = 0;
			if (this.range > num4)
			{
				List<Plant> plants = this.board.gridSystem.GetGrid(num3, num4).plants;
				int num5 = 0;
				Plant plant = plants[num5];
				int num6 = this.range;
				if (num3 < num6)
				{
					List<Plant> plants2 = this.board.gridSystem.GetGrid(1, num4).plants;
					int num7 = 0;
					Plant plant2 = plants2[num7];
					PlantType thePlantType = plant.thePlantType;
					if (plant2.thePlantType == thePlantType)
					{
						goto IL_011D;
					}
				}
				int num8 = this.range;
				if (num4 < num8)
				{
					List<Plant> plants3 = this.board.gridSystem.GetGrid(num3, 1).plants;
					int num9 = 0;
					Plant plant3 = plants3[num9];
					PlantType thePlantType2 = plant.thePlantType;
					if (plant3.thePlantType == thePlantType2)
					{
						goto IL_011D;
					}
				}
				num4++;
			}
			num3++;
		}
		Debug.Log("游戏结束！没有可移动的步骤了！");
		return true;
		IL_011D:
		throw new NullReferenceException();
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x4157B0", Offset = "0x413DB0", VA = "0x1804157B0")]
	public Game2048Manager()
	{
		List<Plant> list = new List();
		this.movingPlants = list;
		List<PlantType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		int size3 = list2._size;
		int size4 = list2._size;
		int size5 = list2._size;
		int size6 = list2._size;
		int size7 = list2._size;
		int size8 = list2._size;
		int size9 = list2._size;
		int size10 = list2._size;
		int size11 = list2._size;
		int size12 = list2._size;
		int size13 = list2._size;
		this.UpgradeRoute = list2;
		base..ctor();
	}

	// Token: 0x040001B8 RID: 440
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B8")]
	public Board board;

	// Token: 0x040001B9 RID: 441
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B9")]
	private int range;

	// Token: 0x040001BA RID: 442
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001BA")]
	private bool over;

	// Token: 0x040001BB RID: 443
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40001BB")]
	private bool stop;

	// Token: 0x040001BC RID: 444
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001BC")]
	private readonly float moveSpeed = 15f;

	// Token: 0x040001BD RID: 445
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001BD")]
	private bool isAnimating;

	// Token: 0x040001BE RID: 446
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BE")]
	private List<Plant> movingPlants;

	// Token: 0x040001BF RID: 447
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001BF")]
	private readonly List<PlantType> UpgradeRoute;
}
