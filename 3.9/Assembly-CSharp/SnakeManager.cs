using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
public class SnakeManager : MonoBehaviour
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000480 RID: 1152 RVA: 0x00016DF4 File Offset: 0x00014FF4
	[Token(Token = "0x17000094")]
	private Plant Tail
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x5E86A0", Offset = "0x5E6CA0", VA = "0x1805E86A0")]
		get
		{
			Plant plant = this.head;
			Plant snakeNext = plant.snakeNext;
			int num = 0;
			if (snakeNext != num)
			{
				Plant snakeNext2 = plant.snakeNext;
			}
			return plant;
		}
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00016E2C File Offset: 0x0001502C
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x5E7E20", Offset = "0x5E6420", VA = "0x1805E7E20")]
	private void Start()
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		this.head = plant;
		Plant plant2 = this.head;
		int num = 0;
		bool flag = plant2.Upgrade(3, true, num != 0);
		this.head.dieMeansLose = true;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00016E78 File Offset: 0x00015078
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x5E84B0", Offset = "0x5E6AB0", VA = "0x1805E84B0")]
	private void Update()
	{
		if (!this.board.over)
		{
			if (!this.change)
			{
				if (Lawnf.GetKeyDown((KeyCode)((uint)119)) && this.direction != SnakeManager.Direction.Down)
				{
					this.direction = (SnakeManager.Direction)((ulong)0L);
				}
				if (Lawnf.GetKeyDown((KeyCode)((uint)97)) && this.direction != SnakeManager.Direction.Right)
				{
					this.direction = (SnakeManager.Direction)((ulong)2L);
				}
				if (Lawnf.GetKeyDown((KeyCode)((uint)100)) && this.direction != SnakeManager.Direction.Left)
				{
					this.direction = (SnakeManager.Direction)((ulong)3L);
				}
				if (Lawnf.GetKeyDown((KeyCode)((uint)115)) && this.direction != SnakeManager.Direction.Up)
				{
					this.direction = (SnakeManager.Direction)((ulong)1L);
					this.change = true;
				}
			}
			this.MoveUpdate();
			this.UpdateLines();
			Present present = this.present;
			int num = 0;
			if (present == num && this.restPresent > 0)
			{
				this.SummonUpdate();
				return;
			}
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00016F54 File Offset: 0x00015154
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x5E7CC0", Offset = "0x5E62C0", VA = "0x1805E7CC0")]
	private void MoveUpdate()
	{
		float num = this.moveTimer;
		float deltaTime = Time.deltaTime;
		this.moveTimer = num;
		Plant plant = this.head;
		this.moveTimer = 0.375f;
		Plant plant2 = this.head;
		SnakeManager.Direction direction = this.direction;
		int thePlantColumn = plant.thePlantColumn;
		int thePlantRow = plant2.thePlantRow;
		if (direction != SnakeManager.Direction.Up)
		{
			if (direction != SnakeManager.Direction.Up)
			{
				if (direction != SnakeManager.Direction.Up)
				{
					if (direction != SnakeManager.Direction.Down)
					{
					}
					int columnNum = this.board.columnNum;
					if (thePlantColumn != columnNum)
					{
						int num2 = thePlantColumn + 1;
					}
				}
				if (thePlantColumn != 0)
				{
					int num3 = thePlantColumn - 1;
				}
				int columnNum2 = this.board.columnNum;
			}
			int rowNum = this.board.rowNum;
			if (thePlantRow != rowNum)
			{
				int num4 = thePlantRow + 1;
			}
		}
		if (thePlantRow != 0)
		{
		}
		int rowNum2 = this.board.rowNum;
		this.MoveBox(thePlantColumn, thePlantColumn);
		this.change = false;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00017038 File Offset: 0x00015238
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x5E7AA0", Offset = "0x5E60A0", VA = "0x1805E7AA0")]
	private void MoveSnake(int theColumn, int theRow)
	{
		Plant plant = this.head;
		int num = 0;
		if (plant != num)
		{
			int num2 = plant.thePlantColumn;
			int thePlantRow = plant.thePlantRow;
			num2 -= theColumn;
			num2 = thePlantRow;
			num2 -= theRow;
			this.board.gridSystem.RemovePlant(plant, num2, thePlantRow);
			plant.thePlantColumn = theColumn;
			plant.thePlantRow = theRow;
			GridSystem gridSystem = this.board.gridSystem;
			gridSystem.RemovePlant(plant, theColumn, theColumn);
			Plant snakeNext = plant.snakeNext;
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x000170DC File Offset: 0x000152DC
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x5E83A0", Offset = "0x5E69A0", VA = "0x1805E83A0")]
	private void UpdateLines()
	{
		ulong num;
		do
		{
			List<SnakeManager.SnakeLine> list = this.lines;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00017108 File Offset: 0x00015308
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x5E73C0", Offset = "0x5E59C0", VA = "0x1805E73C0")]
	private void MoveBox(int theColumn, int theRow)
	{
		for (;;)
		{
			int num = 0;
			Present present = this.present;
			int num2 = 0;
			if (present != num2)
			{
				Present present2 = this.present;
				int num3 = 0;
				present2.Die((Plant.DieReason)num3);
				Plant plant = this.head;
				Plant snakeNext = plant.snakeNext;
				int num4 = 0;
				if (snakeNext != num4)
				{
					Plant snakeNext2 = plant.snakeNext;
				}
				int thePlantRow = plant.thePlantRow;
				this.MoveSnake(theColumn, theRow);
				CreatePlant instance = CreatePlant.Instance;
				PlantType plantType = this.GetPlantType();
				int num5 = 0;
				Plant plant2;
				plant2.dieMeansLose = true;
				plant.snakeNext = plant2;
				List<SnakeManager.SnakeLine> list = this.lines;
				SnakeManager.SnakeLine snakeLine;
				snakeLine.plant1 = plant2;
				snakeLine.plant2 = plant;
				GameObject gameObject = Resources.Load<GameObject>("Magnet/MagnetLine");
				Transform transform = Board.Instance.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
				global::UnityEngine.Object.Destroy(gameObject2.GetComponent<MagnetLine>());
				LineRenderer component = gameObject2.GetComponent<LineRenderer>();
				snakeLine.line = component;
				int size = list._size;
				list._size = component;
				snakeLine.plant2 = snakeLine;
				List<Plant> plantArray = this.board.boardEntity.plantArray;
				bool flag;
				if (flag)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
				}
				if (num5 == 0)
				{
					break;
				}
			}
			else
			{
				List<Plant> plants = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
				int num7 = 0;
				bool flag2;
				if (flag2)
				{
					int num8 = 0;
					if (!(num != num8))
					{
						continue;
					}
				}
				if (num7 == 0)
				{
					goto Block_5;
				}
			}
		}
		return;
		Block_5:
		UIMgr.EnterLoseMenu("贪吃蛇撞到了自己");
		throw new NullReferenceException();
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00017294 File Offset: 0x00015494
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x5E7030", Offset = "0x5E5630", VA = "0x1805E7030")]
	private PlantType GetPlantType()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		return list[num];
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x000172F8 File Offset: 0x000154F8
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x5E7280", Offset = "0x5E5880", VA = "0x1805E7280")]
	private Vector2Int GetTargetGrid(int theColumn, int theRow)
	{
		SnakeManager.Direction direction = this.direction;
		if (direction != SnakeManager.Direction.Up)
		{
			if (direction != SnakeManager.Direction.Up)
			{
				if (direction != SnakeManager.Direction.Up)
				{
					if (direction != SnakeManager.Direction.Down)
					{
					}
					int columnNum = this.board.columnNum;
					if (theColumn != columnNum)
					{
						int num = theColumn + 1;
					}
				}
				if (theColumn != 0)
				{
					int num2 = theColumn - 1;
				}
				int columnNum2 = this.board.columnNum;
			}
			int rowNum = this.board.rowNum;
			if (theRow != rowNum)
			{
				int num3 = theRow + 1;
			}
		}
		if (theRow != 0)
		{
			int num4 = theRow - 1;
		}
		int rowNum2 = this.board.rowNum;
		throw new NullReferenceException();
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00017384 File Offset: 0x00015584
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x5E7F10", Offset = "0x5E6510", VA = "0x1805E7F10")]
	private void SummonUpdate()
	{
		List<Vector2Int> list;
		int num3;
		do
		{
			int num = 0;
			float num2 = this.summonTimer;
			float deltaTime = Time.deltaTime;
			this.summonTimer = num2;
			if (0 <= (int)num2)
			{
				return;
			}
			this.summonTimer = 1f;
			list = new List();
			num3 = 0;
			Board board = this.board;
			if (num3 >= board.columnNum)
			{
				goto IL_00AB;
			}
			Board board2 = this.board;
			if (num3 >= board2.rowNum)
			{
				goto IL_00A5;
			}
			List<Plant> plants = board2.gridSystem.GetGrid(num3, num3).plants;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
			}
		}
		while (num3 != 0);
		int num5 = 0;
		ulong num6;
		if (num6 == (ulong)0L)
		{
		}
		num3++;
		IL_00A5:
		num3++;
		IL_00AB:
		int num7 = list._size;
		num7 = global::UnityEngine.Random.Range(0, num7);
		Vector2Int vector2Int = list[num7];
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.GetComponent<Present>().buff = true;
		Collider2D[] components = plant.GetComponents<Collider2D>();
		if (num5 < components.Length)
		{
			global::UnityEngine.Object.Destroy(num5);
			num5++;
		}
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0001749C File Offset: 0x0001569C
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x5E8620", Offset = "0x5E6C20", VA = "0x1805E8620")]
	public SnakeManager()
	{
		List<SnakeManager.SnakeLine> list = new List();
		this.lines = list;
		base..ctor();
	}

	// Token: 0x04000292 RID: 658
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000292")]
	public Board board;

	// Token: 0x04000293 RID: 659
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000293")]
	private Plant head;

	// Token: 0x04000294 RID: 660
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000294")]
	private SnakeManager.Direction direction;

	// Token: 0x04000295 RID: 661
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000295")]
	private float moveTimer;

	// Token: 0x04000296 RID: 662
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000296")]
	private float summonTimer;

	// Token: 0x04000297 RID: 663
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000297")]
	private Present present;

	// Token: 0x04000298 RID: 664
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000298")]
	private int restPresent = (int)((ulong)54L);

	// Token: 0x04000299 RID: 665
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000299")]
	private bool change;

	// Token: 0x0400029A RID: 666
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400029A")]
	private List<SnakeManager.SnakeLine> lines;

	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	private enum Direction
	{
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		Up,
		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		Down,
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		Left,
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		Right
	}

	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public class SnakeLine
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x000174C8 File Offset: 0x000156C8
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x5E6ED0", Offset = "0x5E54D0", VA = "0x1805E6ED0")]
		public SnakeLine(Plant from, Plant to)
		{
			this.plant1 = from;
			this.plant2 = to;
			GameObject gameObject = Resources.Load<GameObject>("Magnet/MagnetLine");
			Transform transform = Board.Instance.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			global::UnityEngine.Object.Destroy(gameObject2.GetComponent<MagnetLine>());
			LineRenderer component = gameObject2.GetComponent<LineRenderer>();
			this.line = component;
			throw new NullReferenceException();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00017528 File Offset: 0x00015728
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x5E6C60", Offset = "0x5E5260", VA = "0x1805E6C60")]
		public void UpdateLine()
		{
			Plant plant = this.plant1;
			Plant plant2 = this.plant2;
			if (plant.thePlantColumn > 1)
			{
			}
			Plant plant3 = this.plant1;
			Plant plant4 = this.plant2;
			int thePlantRow = plant3.thePlantRow;
			LineRenderer lineRenderer = this.line;
			if (thePlantRow > 1)
			{
				int num = 0;
				lineRenderer.enabled = num != 0;
				return;
			}
			ulong num2;
			lineRenderer.enabled = num2 != 0UL;
			throw new NullReferenceException();
		}

		// Token: 0x040002A0 RID: 672
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002A0")]
		public LineRenderer line;

		// Token: 0x040002A1 RID: 673
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002A1")]
		public Plant plant1;

		// Token: 0x040002A2 RID: 674
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002A2")]
		public Plant plant2;
	}
}
