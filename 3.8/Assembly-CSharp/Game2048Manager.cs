using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class Game2048Manager : MonoBehaviour
{
	// Token: 0x06000333 RID: 819 RVA: 0x0000EA84 File Offset: 0x0000CC84
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3C86B0", Offset = "0x3C6CB0", VA = "0x1803C86B0")]
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

	// Token: 0x06000334 RID: 820 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x3C8850", Offset = "0x3C6E50", VA = "0x1803C8850")]
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

	// Token: 0x06000335 RID: 821 RVA: 0x0000EB3C File Offset: 0x0000CD3C
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x3C8440", Offset = "0x3C6A40", VA = "0x1803C8440")]
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

	// Token: 0x06000336 RID: 822 RVA: 0x0000EC08 File Offset: 0x0000CE08
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x3C7E10", Offset = "0x3C6410", VA = "0x1803C7E10")]
	private IEnumerator MoveUpWithAnimation()
	{
		Game2048Manager.<MoveUpWithAnimation>d__10 <MoveUpWithAnimation>d__;
		<MoveUpWithAnimation>d__.System.IDisposable.Dispose();
		<MoveUpWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveUpWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000EC2C File Offset: 0x0000CE2C
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x3C7BA0", Offset = "0x3C61A0", VA = "0x1803C7BA0")]
	private IEnumerator MoveDownWithAnimation()
	{
		Game2048Manager.<MoveDownWithAnimation>d__11 <MoveDownWithAnimation>d__;
		<MoveDownWithAnimation>d__.System.IDisposable.Dispose();
		<MoveDownWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveDownWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000EC50 File Offset: 0x0000CE50
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x3C7C10", Offset = "0x3C6210", VA = "0x1803C7C10")]
	private IEnumerator MoveLeftWithAnimation()
	{
		Game2048Manager.<MoveLeftWithAnimation>d__12 <MoveLeftWithAnimation>d__;
		<MoveLeftWithAnimation>d__.System.IDisposable.Dispose();
		<MoveLeftWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveLeftWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000EC74 File Offset: 0x0000CE74
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x3C7DA0", Offset = "0x3C63A0", VA = "0x1803C7DA0")]
	private IEnumerator MoveRightWithAnimation()
	{
		Game2048Manager.<MoveRightWithAnimation>d__13 <MoveRightWithAnimation>d__;
		<MoveRightWithAnimation>d__.System.IDisposable.Dispose();
		<MoveRightWithAnimation>d__.<>1__state = (int)((ulong)0L);
		<MoveRightWithAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000EC98 File Offset: 0x0000CE98
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x3C7C80", Offset = "0x3C6280", VA = "0x1803C7C80")]
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

	// Token: 0x0600033B RID: 827 RVA: 0x0000ED04 File Offset: 0x0000CF04
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x3C7E80", Offset = "0x3C6480", VA = "0x1803C7E80")]
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

	// Token: 0x0600033C RID: 828 RVA: 0x0000EE20 File Offset: 0x0000D020
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x3C7940", Offset = "0x3C5F40", VA = "0x1803C7940")]
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

	// Token: 0x0600033D RID: 829 RVA: 0x0000EF20 File Offset: 0x0000D120
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x3C76F0", Offset = "0x3C5CF0", VA = "0x1803C76F0")]
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

	// Token: 0x0600033E RID: 830 RVA: 0x0000F050 File Offset: 0x0000D250
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x3C89E0", Offset = "0x3C6FE0", VA = "0x1803C89E0")]
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

	// Token: 0x040001AB RID: 427
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AB")]
	public Board board;

	// Token: 0x040001AC RID: 428
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AC")]
	private int range;

	// Token: 0x040001AD RID: 429
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001AD")]
	private bool over;

	// Token: 0x040001AE RID: 430
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40001AE")]
	private bool stop;

	// Token: 0x040001AF RID: 431
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AF")]
	private readonly float moveSpeed = 15f;

	// Token: 0x040001B0 RID: 432
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001B0")]
	private bool isAnimating;

	// Token: 0x040001B1 RID: 433
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B1")]
	private List<Plant> movingPlants;

	// Token: 0x040001B2 RID: 434
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B2")]
	private readonly List<PlantType> UpgradeRoute;
}
