using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class MinesweeperManager : MonoBehaviour
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060003C2 RID: 962 RVA: 0x00011840 File Offset: 0x0000FA40
	// (set) Token: 0x060003C3 RID: 963 RVA: 0x00011854 File Offset: 0x0000FA54
	[Token(Token = "0x1700008D")]
	public static MinesweeperManager Instance
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4F8ED0", Offset = "0x4F74D0", VA = "0x1804F8ED0")]
		get;
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4F8F20", Offset = "0x4F7520", VA = "0x1804F8F20")]
		private set;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00011868 File Offset: 0x0000FA68
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x4F6BD0", Offset = "0x4F51D0", VA = "0x1804F6BD0")]
	private void Awake()
	{
		MinesweeperManager.<Instance>k__BackingField = this;
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x0001187C File Offset: 0x0000FA7C
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x4F84F0", Offset = "0x4F6AF0", VA = "0x1804F84F0")]
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

	// Token: 0x060003C6 RID: 966 RVA: 0x000118C8 File Offset: 0x0000FAC8
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x4F8BD0", Offset = "0x4F71D0", VA = "0x1804F8BD0")]
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

	// Token: 0x060003C7 RID: 967 RVA: 0x00011928 File Offset: 0x0000FB28
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x4F6D00", Offset = "0x4F5300", VA = "0x1804F6D00")]
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

	// Token: 0x060003C8 RID: 968 RVA: 0x00011974 File Offset: 0x0000FB74
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x4F8600", Offset = "0x4F6C00", VA = "0x1804F8600")]
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
					MinesweeperManager.<>c.<>9__24_0 = (Plant p) => p.thePlantType == PlantType.IceBean;
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

	// Token: 0x060003C9 RID: 969 RVA: 0x00011A60 File Offset: 0x0000FC60
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x4F7EA0", Offset = "0x4F64A0", VA = "0x1804F7EA0")]
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

	// Token: 0x060003CA RID: 970 RVA: 0x00011A9C File Offset: 0x0000FC9C
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x4F7BC0", Offset = "0x4F61C0", VA = "0x1804F7BC0")]
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

	// Token: 0x060003CB RID: 971 RVA: 0x00011B60 File Offset: 0x0000FD60
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x4F7410", Offset = "0x4F5A10", VA = "0x1804F7410")]
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

	// Token: 0x060003CC RID: 972 RVA: 0x00011C34 File Offset: 0x0000FE34
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x4F80B0", Offset = "0x4F66B0", VA = "0x1804F80B0")]
	private bool IsInSafeZone(int row, int col, int safeRow, int safeCol)
	{
		if (safeRow > 1)
		{
		}
		return col <= 1;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00011C50 File Offset: 0x0000FE50
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x4F6EC0", Offset = "0x4F54C0", VA = "0x1804F6EC0")]
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

	// Token: 0x060003CE RID: 974 RVA: 0x00011CE8 File Offset: 0x0000FEE8
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x4F7130", Offset = "0x4F5730", VA = "0x1804F7130")]
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

	// Token: 0x060003CF RID: 975 RVA: 0x00011D84 File Offset: 0x0000FF84
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x4F7F70", Offset = "0x4F6570", VA = "0x1804F7F70")]
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

	// Token: 0x060003D0 RID: 976 RVA: 0x00011DB0 File Offset: 0x0000FFB0
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x4F8000", Offset = "0x4F6600", VA = "0x1804F8000")]
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

	// Token: 0x060003D1 RID: 977 RVA: 0x00011E10 File Offset: 0x00010010
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x4F7DE0", Offset = "0x4F63E0", VA = "0x1804F7DE0")]
	public MinesweeperCell GetCell(int row, int col)
	{
		ScaryPot pot = this.GetPot(row, col);
		int num = 0;
		if (!(pot != num))
		{
		}
		return pot.GetComponent<MinesweeperCell>();
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00011E44 File Offset: 0x00010044
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x4F8170", Offset = "0x4F6770", VA = "0x1804F8170")]
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

	// Token: 0x060003D3 RID: 979 RVA: 0x00011E88 File Offset: 0x00010088
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x4F7800", Offset = "0x4F5E00", VA = "0x1804F7800")]
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

	// Token: 0x060003D4 RID: 980 RVA: 0x00012008 File Offset: 0x00010208
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x4F8A10", Offset = "0x4F7010", VA = "0x1804F8A10")]
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

	// Token: 0x060003D5 RID: 981 RVA: 0x000120AC File Offset: 0x000102AC
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x4F6C70", Offset = "0x4F5270", VA = "0x1804F6C70")]
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

	// Token: 0x060003D6 RID: 982 RVA: 0x000120F8 File Offset: 0x000102F8
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x4F8260", Offset = "0x4F6860", VA = "0x1804F8260")]
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

	// Token: 0x060003D7 RID: 983 RVA: 0x0001213C File Offset: 0x0001033C
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x4F82E0", Offset = "0x4F68E0", VA = "0x1804F82E0")]
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

	// Token: 0x060003D8 RID: 984 RVA: 0x00012200 File Offset: 0x00010400
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x4F8EA0", Offset = "0x4F74A0", VA = "0x1804F8EA0")]
	public MinesweeperManager()
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x0001224C File Offset: 0x0001044C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x4F8E00", Offset = "0x4F7400", VA = "0x1804F8E00")]
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

	// Token: 0x04000211 RID: 529
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000211")]
	[Header("扫雷配置")]
	[Tooltip("雷密度（0-1之间，例如0.15表示15%的格子是雷）")]
	[Range(0f, 0.5f)]
	public float mineDensity = 0.15f;

	// Token: 0x04000212 RID: 530
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000212")]
	[Tooltip("是否启用无猜模式（保证游戏可完全通过逻辑推理解开，无需猜测）")]
	public bool enableNoGuessMode = true;

	// Token: 0x04000213 RID: 531
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000213")]
	[Tooltip("无猜模式最大尝试次数（地图越大建议越小，12x24建议30-50次）")]
	[Range(10f, 200f)]
	public int noGuessMaxAttempts = (int)((ulong)500L);

	// Token: 0x04000214 RID: 532
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000214")]
	[Tooltip("是否在游戏开始时自动生成")]
	public bool autoGenerateOnStart = true;

	// Token: 0x04000215 RID: 533
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000215")]
	[Tooltip("地雷僵尸类型")]
	[Header("地雷配置")]
	public ZombieType mineZombieType = (ZombieType)((ulong)60L);

	// Token: 0x04000216 RID: 534
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000216")]
	public bool[,] mineGrid;

	// Token: 0x04000217 RID: 535
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000217")]
	private Board board;

	// Token: 0x04000218 RID: 536
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000218")]
	private ScaryPot[,] potsGrid;

	// Token: 0x04000219 RID: 537
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000219")]
	private int totalMines;

	// Token: 0x0400021A RID: 538
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400021A")]
	private int revealedSafeCells;

	// Token: 0x0400021B RID: 539
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400021B")]
	private int totalSafeCells;

	// Token: 0x0400021C RID: 540
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400021C")]
	private bool wined;

	// Token: 0x0400021D RID: 541
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x400021D")]
	private bool hasGenerated;

	// Token: 0x0400021E RID: 542
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400021E")]
	private int firstClickRow = (int)((ulong)(-1L));

	// Token: 0x0400021F RID: 543
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400021F")]
	private int firstClickCol;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	public static readonly PlantType[] NumberPlantTypes;
}
