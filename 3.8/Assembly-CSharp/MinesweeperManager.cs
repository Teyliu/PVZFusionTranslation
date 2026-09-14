using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public class MinesweeperManager : MonoBehaviour
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060003A7 RID: 935 RVA: 0x000114CC File Offset: 0x0000F6CC
	// (set) Token: 0x060003A8 RID: 936 RVA: 0x000114E0 File Offset: 0x0000F6E0
	[Token(Token = "0x17000050")]
	public static MinesweeperManager Instance
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4B9810", Offset = "0x4B7E10", VA = "0x1804B9810")]
		get;
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4B9860", Offset = "0x4B7E60", VA = "0x1804B9860")]
		private set;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x000114F4 File Offset: 0x0000F6F4
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x4B7510", Offset = "0x4B5B10", VA = "0x1804B7510")]
	private void Awake()
	{
		MinesweeperManager.<Instance>k__BackingField = this;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00011508 File Offset: 0x0000F708
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x4B8E30", Offset = "0x4B7430", VA = "0x1804B8E30")]
	private void Start()
	{
		Board component = base.GetComponent<Board>();
		this.board = component;
		if (this.autoGenerateOnStart)
		{
			Board board = this.board;
			int num = 0;
			if (board != num)
			{
				this.GenerateMinesweeper();
			}
		}
		int num2 = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)7), action, num2 != 0);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00011554 File Offset: 0x0000F754
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x4B9510", Offset = "0x4B7B10", VA = "0x1804B9510")]
	private void Update()
	{
		ulong num2;
		do
		{
			List<TextMeshProUGUI> levelNameText = InGameUI.Instance.levelNameText;
			bool flag;
			if (flag)
			{
				int num = this.totalMines;
				Board board = this.board;
				int plantCount = Lawnf.GetPlantCount((PlantType)((uint)241), board);
				string text = string.Format("总雷数：{0}，当前已标记：{1}", num, plantCount);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060003AC RID: 940 RVA: 0x000115B4 File Offset: 0x0000F7B4
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x4B7640", Offset = "0x4B5C40", VA = "0x1804B7640")]
	private void Click(object obj)
	{
		if (obj != 0)
		{
		}
		PlantType[] numberPlantTypes = MinesweeperManager.NumberPlantTypes;
		bool flag;
		if (flag)
		{
			int num = 0;
			PlantType[] numberPlantTypes2 = MinesweeperManager.NumberPlantTypes;
			if (num < numberPlantTypes2.Length)
			{
				PlantType[] numberPlantTypes3 = MinesweeperManager.NumberPlantTypes;
				num++;
				uint num2;
				num2 += (uint)4;
				if (1 > 0)
				{
				}
			}
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00011600 File Offset: 0x0000F800
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x4B8F40", Offset = "0x4B7540", VA = "0x1804B8F40")]
	private void TryChordReveal(int centerCol, int centerRow, int expectedMines)
	{
		ulong num7;
		do
		{
			List<MinesweeperCell> list = new List();
			int i = centerRow - 1;
			int num = centerRow + 1;
			int num2 = centerCol - 1;
			int j = centerCol + 1;
			int num3 = centerRow + 1;
			j = num2;
			if (i != centerRow || j != centerCol)
			{
				num2 = i;
				num3 = j;
				List<Plant> list2 = Lawnf.Get1x1Plants(num3, num2);
				Func<Plant, bool> <>9__24_ = MinesweeperManager.<>c.<>9__24_0;
				if (<>9__24_ == 0)
				{
					Func<Plant, bool> func;
					MinesweeperManager.<>c.<>9__24_0 = func;
				}
				Plant plant = Enumerable.FirstOrDefault<Plant>(list2, <>9__24_);
				int num4 = 0;
				bool flag = plant != num4;
				int num5 = 0;
				MinesweeperCell minesweeperCell;
				if (!(minesweeperCell != num5) || minesweeperCell.isRevealed || !flag)
				{
				}
			}
			j++;
			while (j <= j)
			{
			}
			int num6 = centerRow + 1;
			i++;
			while (i <= num6)
			{
			}
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (!flag3)
				{
				}
			}
		}
		while (num7 != (ulong)0L);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x000116DC File Offset: 0x0000F8DC
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x4B87E0", Offset = "0x4B6DE0", VA = "0x1804B87E0")]
	private int GetNumberFromPlantType(PlantType plantType)
	{
		int num = 0;
		PlantType[] numberPlantTypes = MinesweeperManager.NumberPlantTypes;
		if (num < numberPlantTypes.Length)
		{
			PlantType[] numberPlantTypes2 = MinesweeperManager.NumberPlantTypes;
			num++;
			uint num2;
			num2 += (uint)4;
		}
		return 0;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00011718 File Offset: 0x0000F918
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x4B8500", Offset = "0x4B6B00", VA = "0x1804B8500")]
	public void GenerateMinesweeper()
	{
		int columnNum;
		int rowNum;
		float num2;
		do
		{
			Board board = this.board;
			int num = 0;
			bool flag = board == num;
			if (flag)
			{
				goto IL_00A3;
			}
			Board board2 = this.board;
			columnNum = board2.columnNum;
			rowNum = board2.rowNum;
			this.potsGrid = flag;
			this.mineGrid = flag;
			this.totalMines = (int)((ulong)0L);
			this.hasGenerated = false;
			this.firstClickRow = (int)((ulong)(-1L));
			GameConfig config = GameAPP.config;
		}
		while (0 <= (int)num2 && num2 <= 1f);
		float num3 = (float)(0 * (int)0.15f);
		int num4 = 0;
		this.mineDensity = num3;
		if (rowNum > 0)
		{
			int num5 = 0;
			if (columnNum > 0)
			{
				this.CreatePotWithoutData(num4, num5);
				num5++;
			}
			num4++;
		}
		return;
		IL_00A3:
		Debug.LogError("[Minesweeper] Board组件未找到！");
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x000117DC File Offset: 0x0000F9DC
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x4B7D50", Offset = "0x4B6350", VA = "0x1804B7D50")]
	private bool[,] GenerateMineGrid(int rows, int cols, int safeRow, int safeCol)
	{
		if (typeof(Math).TypeHandle == (ulong)1L || typeof(Math).TypeHandle != (ulong)1L || typeof(Math).TypeHandle != (ulong)1L)
		{
		}
		List<Vector2Int> list = new List();
		int num = 0;
		if (rows > 0)
		{
			if (cols > 0)
			{
				bool flag;
				if (!flag)
				{
				}
				num++;
			}
			num++;
		}
		int size = list._size;
		Debug.LogWarning(string.Format("[Minesweeper] 可用位置不足：{0} < {1}，减少地雷数量", size, size));
		int size2 = list._size;
		int num2 = list._size;
		num2 = global::UnityEngine.Random.Range(num, num2);
		Vector2Int vector2Int = list[num2];
		Vector2Int vector2Int2 = list[num];
		list[num] = vector2Int;
		list[cols] = vector2Int2;
		num++;
		if (size2 > 0)
		{
			Vector2Int vector2Int3 = list[num];
			int x = vector2Int3.m_X;
			int x2 = vector2Int3.m_X;
			num++;
		}
		return "[Minesweeper] 可用位置不足：{0} < {1}，减少地雷数量";
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000118B0 File Offset: 0x0000FAB0
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x4B89F0", Offset = "0x4B6FF0", VA = "0x1804B89F0")]
	private bool IsInSafeZone(int row, int col, int safeRow, int safeCol)
	{
		if (safeRow > 1)
		{
		}
		return col <= 1;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000118CC File Offset: 0x0000FACC
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x4B7800", Offset = "0x4B5E00", VA = "0x1804B7800")]
	private void CreatePotWithoutData(int row, int col)
	{
		GridItem gridItem;
		if (gridItem == 0)
		{
		}
		int num = 0;
		MinesweeperCell minesweeperCell;
		if (!(gridItem == num))
		{
			if (!gridItem.gameObject.activeInHierarchy)
			{
				ulong num2;
				gridItem.gameObject.SetActive(num2 != 0UL);
			}
			minesweeperCell = gridItem.gameObject.AddComponent<MinesweeperCell>();
			int num3 = 0;
			ulong num4;
			minesweeperCell.Initialize(row, col, num3 != 0, (int)num4);
			ScaryPot[,] array = this.potsGrid;
			IntPtr cachedPtr = minesweeperCell.m_CachedPtr;
			int num5 = (int)((IntPtr)row * cachedPtr);
			num5 += col;
			array[0] = gridItem;
		}
		Debug.LogError(string.Format("[Minesweeper] 创建罐子失败：({0}, {1})", minesweeperCell, minesweeperCell));
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00011964 File Offset: 0x0000FB64
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x4B7A70", Offset = "0x4B6070", VA = "0x1804B7A70")]
	private void CreatePot(int row, int col, bool isMine, int surroundingMines)
	{
		GridItem gridItem;
		if (gridItem == 0)
		{
		}
		int num = 0;
		MinesweeperCell minesweeperCell;
		if (!(gridItem == num))
		{
			if (!gridItem.gameObject.activeInHierarchy)
			{
				ulong num2;
				gridItem.gameObject.SetActive(num2 != 0UL);
			}
			if (!isMine)
			{
			}
			ZombieType zombieType = this.mineZombieType;
			uint num3;
			uint num4;
			num3.m_value = num4;
			minesweeperCell = gridItem.gameObject.AddComponent<MinesweeperCell>();
			ScaryPot[,] array = this.potsGrid;
			IntPtr cachedPtr = minesweeperCell.m_CachedPtr;
			int num5 = (int)((IntPtr)row * cachedPtr);
			num5 += col;
			array[0] = gridItem;
		}
		Debug.LogError(string.Format("[Minesweeper] 创建罐子失败：({0}, {1})", minesweeperCell, minesweeperCell));
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00011A00 File Offset: 0x0000FC00
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x4B88B0", Offset = "0x4B6EB0", VA = "0x1804B88B0")]
	public static PlantType GetPlantTypeForNumber(int number)
	{
		if (number - 1 > 7)
		{
			return PlantType.Nothing;
		}
		PlantType[] numberPlantTypes = MinesweeperManager.NumberPlantTypes;
		int num = number - 1;
		return numberPlantTypes[num];
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00011A2C File Offset: 0x0000FC2C
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x4B8940", Offset = "0x4B6F40", VA = "0x1804B8940")]
	public ScaryPot GetPot(int row, int col)
	{
		if (this.potsGrid != (ulong)0L)
		{
			ScaryPot[,] array = this.potsGrid;
			int num;
			if (row < num)
			{
				ScaryPot[,] array2 = this.potsGrid;
				int num2 = 0;
				if (col < row)
				{
					ScaryPot[,] array3 = this.potsGrid;
					int num3 = row * num2;
					num3 += col;
					return array3[num3];
				}
			}
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00011A8C File Offset: 0x0000FC8C
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x4B8720", Offset = "0x4B6D20", VA = "0x1804B8720")]
	public MinesweeperCell GetCell(int row, int col)
	{
		ScaryPot pot = this.GetPot(row, col);
		int num = 0;
		if (!(pot != num))
		{
		}
		return pot.GetComponent<MinesweeperCell>();
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00011AC0 File Offset: 0x0000FCC0
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x4B8AB0", Offset = "0x4B70B0", VA = "0x1804B8AB0")]
	public void OnCellRevealed(int row, int col, bool isMine)
	{
		if (!this.hasGenerated)
		{
			this.GenerateMinesOnFirstClick(row, col);
		}
		if (isMine)
		{
			if (!this.wined)
			{
				UIMgr.EnterLoseMenu("你踩到了地雷！");
			}
			return;
		}
		int num2;
		int num3;
		int num = num2 * num3;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00011B04 File Offset: 0x0000FD04
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x4B8140", Offset = "0x4B6740", VA = "0x1804B8140")]
	private void GenerateMinesOnFirstClick(int firstRow, int firstCol)
	{
		if (!this.hasGenerated)
		{
			ScaryPot[,] array = this.potsGrid;
			this.firstClickRow = firstRow;
			this.firstClickCol = firstCol;
			ScaryPot[,] array2 = this.potsGrid;
			int num = 0;
			int num2;
			int num3;
			if ((this.enableNoGuessMode ? 1 : 0) == num || this.noGuessMaxAttempts > 0)
			{
				bool[,] array3 = this.GenerateMineGrid(num2, firstCol, firstRow, firstCol);
				this.mineGrid = array3;
				bool[,] array4 = this.mineGrid;
				num3 = 0;
				if (!MinesweeperSolver.IsSolvable(array4, firstRow, firstCol))
				{
					num++;
				}
			}
			this.totalMines = num;
			if (num2 > 0)
			{
				if (firstCol > 0)
				{
					bool[,] array5 = this.mineGrid;
					int num4 = num * num3;
					num4 += num;
					num++;
					num++;
				}
				num++;
				num++;
			}
			int num5;
			int num9;
			if (num2 > 0)
			{
				num5 = 0;
				int num6 = 0;
				if (firstCol > 0)
				{
					bool[,] array6 = this.mineGrid;
					num += num6;
					int num7 = MinesweeperHelper.CountSurroundingMines(array6, num, num5);
					int num8 = num * num;
					num8 += num6;
					num5++;
					num6++;
				}
				num++;
				num++;
				num9 = 0;
			}
			if (num2 > 0)
			{
				if (firstCol > 0)
				{
					bool[,] array7 = this.mineGrid;
					int num10 = num9 * num5;
					int num11 = num9 * num;
					num10 += num9;
					num11 += num9;
					bool flag;
					this.UpdatePotData(num9, num9, flag, num11);
					num9++;
					num9++;
				}
				num9++;
				num9++;
			}
			return;
		}
		Debug.LogWarning("[Minesweeper] 地雷已经生成过了，跳过");
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00011C84 File Offset: 0x0000FE84
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x4B9350", Offset = "0x4B7950", VA = "0x1804B9350")]
	private void UpdatePotData(int row, int col, bool isMine, int surroundingMines)
	{
		ScaryPot[,] array = this.potsGrid;
		int num = row * row;
		num += col;
		ScaryPot scaryPot = array[num];
		int num2 = 0;
		if (!(scaryPot == num2))
		{
			if (!isMine)
			{
				scaryPot.thePlantType = (PlantType)((ulong)(-1L));
				PlantType plantType;
				scaryPot.thePlantType = plantType;
				scaryPot.theZombieType = (ZombieType)((ulong)4294967295L);
			}
			ZombieType zombieType = this.mineZombieType;
			scaryPot.theZombieType = zombieType;
			scaryPot.thePlantType = (PlantType)((ulong)4294967295L);
			ZombieType zombieType2 = this.mineZombieType;
			scaryPot.SetTheSprite(zombieType2);
			MinesweeperCell component = scaryPot.GetComponent<MinesweeperCell>();
			int num3 = 0;
			if (component != num3)
			{
			}
		}
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00011D28 File Offset: 0x0000FF28
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x4B75B0", Offset = "0x4B5BB0", VA = "0x1804B75B0")]
	private void CheckWinCondition()
	{
		ScaryPot[,] array = this.potsGrid;
		ScaryPot[,] array2 = this.potsGrid;
		int num2;
		int num3;
		int num = num2 * num3;
		this.totalSafeCells = num;
		this.board.boardVicotry.Win();
		this.wined = true;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00011D74 File Offset: 0x0000FF74
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x4B8BA0", Offset = "0x4B71A0", VA = "0x1804B8BA0")]
	private void OnGameOver(bool isWin)
	{
		if (!isWin)
		{
			if (this.wined == isWin)
			{
				UIMgr.EnterLoseMenu("你踩到了地雷！");
			}
			return;
		}
		this.board.boardVicotry.Win();
		this.wined = true;
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00011DB8 File Offset: 0x0000FFB8
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x4B8C20", Offset = "0x4B7220", VA = "0x1804B8C20")]
	private void RevealAllMines()
	{
		if (this.potsGrid != (ulong)0L)
		{
			ScaryPot[,] array = this.potsGrid;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4;
			if (num2 < num4)
			{
				int num5 = 0;
				int num6 = 0;
				ScaryPot[,] array2 = this.potsGrid;
				int num7;
				if (num5 < num7)
				{
					bool[,] array3 = this.mineGrid;
					uint num9;
					int num8 = num3 * (int)num9;
					num8 += num6;
					ScaryPot[,] array4 = this.potsGrid;
					int num10 = num3 * (int)num9;
					num10 += num6;
					ScaryPot scaryPot = array4[num10];
					int num11 = 0;
					if (scaryPot != num11)
					{
						int num12;
						int num13;
						Debug.Log(string.Format("[Minesweeper] 地雷位置：({0}, {1})", num12, num13));
					}
					num5++;
					num6++;
				}
				ScaryPot[,] array5 = this.potsGrid;
				num++;
				num3++;
			}
		}
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00011E7C File Offset: 0x0001007C
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x4B97E0", Offset = "0x4B7DE0", VA = "0x1804B97E0")]
	public MinesweeperManager()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00011EC8 File Offset: 0x000100C8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x4B9740", Offset = "0x4B7D40", VA = "0x1804B9740")]
	static MinesweeperManager()
	{
		PlantType[] array = new PlantType[]
		{
			PlantType.WallNut,
			PlantType.CactusNut,
			PlantType.StarNut,
			PlantType.MachineNut,
			PlantType.IceNut,
			PlantType.FireNut,
			PlantType.DoomNut,
			PlantType.SuperMachineNut
		};
		MinesweeperManager.NumberPlantTypes = array;
	}

	// Token: 0x04000204 RID: 516
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000204")]
	[Header("扫雷配置")]
	[Range(0f, 0.5f)]
	[Tooltip("雷密度（0-1之间，例如0.15表示15%的格子是雷）")]
	public float mineDensity = 0.15f;

	// Token: 0x04000205 RID: 517
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000205")]
	[Tooltip("是否启用无猜模式（保证游戏可完全通过逻辑推理解开，无需猜测）")]
	public bool enableNoGuessMode = true;

	// Token: 0x04000206 RID: 518
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000206")]
	[Range(10f, 200f)]
	[Tooltip("无猜模式最大尝试次数（地图越大建议越小，12x24建议30-50次）")]
	public int noGuessMaxAttempts = (int)((ulong)500L);

	// Token: 0x04000207 RID: 519
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000207")]
	[Tooltip("是否在游戏开始时自动生成")]
	public bool autoGenerateOnStart = true;

	// Token: 0x04000208 RID: 520
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000208")]
	[Header("地雷配置")]
	[Tooltip("地雷僵尸类型")]
	public ZombieType mineZombieType = (ZombieType)((ulong)60L);

	// Token: 0x04000209 RID: 521
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000209")]
	public bool[,] mineGrid;

	// Token: 0x0400020A RID: 522
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400020A")]
	private Board board;

	// Token: 0x0400020B RID: 523
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400020B")]
	private ScaryPot[,] potsGrid;

	// Token: 0x0400020C RID: 524
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400020C")]
	private int totalMines;

	// Token: 0x0400020D RID: 525
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400020D")]
	private int revealedSafeCells;

	// Token: 0x0400020E RID: 526
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400020E")]
	private int totalSafeCells;

	// Token: 0x0400020F RID: 527
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400020F")]
	private bool wined;

	// Token: 0x04000210 RID: 528
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4000210")]
	private bool hasGenerated;

	// Token: 0x04000211 RID: 529
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000211")]
	private int firstClickRow = (int)((ulong)(-1L));

	// Token: 0x04000212 RID: 530
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000212")]
	private int firstClickCol;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	public static readonly PlantType[] NumberPlantTypes;
}
