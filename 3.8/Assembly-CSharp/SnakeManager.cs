using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000E9 RID: 233
[Token(Token = "0x20000E9")]
public class SnakeManager : MonoBehaviour
{
	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x00016958 File Offset: 0x00014B58
	[Token(Token = "0x17000057")]
	private Plant Tail
	{
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5B2C10", Offset = "0x5B1210", VA = "0x1805B2C10")]
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

	// Token: 0x06000466 RID: 1126 RVA: 0x00016990 File Offset: 0x00014B90
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x5B2390", Offset = "0x5B0990", VA = "0x1805B2390")]
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

	// Token: 0x06000467 RID: 1127 RVA: 0x000169DC File Offset: 0x00014BDC
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x5B2A20", Offset = "0x5B1020", VA = "0x1805B2A20")]
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

	// Token: 0x06000468 RID: 1128 RVA: 0x00016AB8 File Offset: 0x00014CB8
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x5B2230", Offset = "0x5B0830", VA = "0x1805B2230")]
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

	// Token: 0x06000469 RID: 1129 RVA: 0x00016B9C File Offset: 0x00014D9C
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x5B2010", Offset = "0x5B0610", VA = "0x1805B2010")]
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

	// Token: 0x0600046A RID: 1130 RVA: 0x00016C40 File Offset: 0x00014E40
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x5B2910", Offset = "0x5B0F10", VA = "0x1805B2910")]
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

	// Token: 0x0600046B RID: 1131 RVA: 0x00016C6C File Offset: 0x00014E6C
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x5B1930", Offset = "0x5AFF30", VA = "0x1805B1930")]
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

	// Token: 0x0600046C RID: 1132 RVA: 0x00016DF8 File Offset: 0x00014FF8
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x5B15A0", Offset = "0x5AFBA0", VA = "0x1805B15A0")]
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

	// Token: 0x0600046D RID: 1133 RVA: 0x00016E5C File Offset: 0x0001505C
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x5B17F0", Offset = "0x5AFDF0", VA = "0x1805B17F0")]
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

	// Token: 0x0600046E RID: 1134 RVA: 0x00016EE8 File Offset: 0x000150E8
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x5B2480", Offset = "0x5B0A80", VA = "0x1805B2480")]
	private void SummonUpdate()
	{
		List<Vector2Int> list;
		int num3;
		int num4;
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
				goto IL_00A9;
			}
			Board board2 = this.board;
			if (num3 >= board2.rowNum)
			{
				goto IL_00A3;
			}
			num4 = 0;
			List<Plant> plants = board2.gridSystem.GetGrid(num3, num3).plants;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
		}
		while (num3 != 0);
		if (num4 == 0)
		{
		}
		num3++;
		IL_00A3:
		num3++;
		IL_00A9:
		int num6 = list._size;
		num6 = global::UnityEngine.Random.Range(0, num6);
		Vector2Int vector2Int = list[num6];
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		Present component = plant.GetComponent<Present>();
		this.present = component;
		this.present.buff = true;
		Collider2D[] components = this.present.GetComponents<Collider2D>();
		if (num3 < components.Length)
		{
			global::UnityEngine.Object.Destroy(num3);
			num3++;
		}
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00017010 File Offset: 0x00015210
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x5B2B90", Offset = "0x5B1190", VA = "0x1805B2B90")]
	public SnakeManager()
	{
		List<SnakeManager.SnakeLine> list = new List();
		this.lines = list;
		base..ctor();
	}

	// Token: 0x04000284 RID: 644
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000284")]
	public Board board;

	// Token: 0x04000285 RID: 645
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000285")]
	private Plant head;

	// Token: 0x04000286 RID: 646
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000286")]
	private SnakeManager.Direction direction;

	// Token: 0x04000287 RID: 647
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000287")]
	private float moveTimer;

	// Token: 0x04000288 RID: 648
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000288")]
	private float summonTimer;

	// Token: 0x04000289 RID: 649
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000289")]
	private Present present;

	// Token: 0x0400028A RID: 650
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400028A")]
	private int restPresent = (int)((ulong)54L);

	// Token: 0x0400028B RID: 651
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400028B")]
	private bool change;

	// Token: 0x0400028C RID: 652
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400028C")]
	private List<SnakeManager.SnakeLine> lines;

	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	private enum Direction
	{
		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		Up,
		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		Down,
		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		Left,
		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		Right
	}

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public class SnakeLine
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x0001703C File Offset: 0x0001523C
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x5B1440", Offset = "0x5AFA40", VA = "0x1805B1440")]
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

		// Token: 0x06000471 RID: 1137 RVA: 0x0001709C File Offset: 0x0001529C
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5B11D0", Offset = "0x5AF7D0", VA = "0x1805B11D0")]
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

		// Token: 0x04000292 RID: 658
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000292")]
		public LineRenderer line;

		// Token: 0x04000293 RID: 659
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000293")]
		public Plant plant1;

		// Token: 0x04000294 RID: 660
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000294")]
		public Plant plant2;
	}
}
