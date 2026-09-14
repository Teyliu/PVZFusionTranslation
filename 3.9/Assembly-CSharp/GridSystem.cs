using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200022D RID: 557
[Token(Token = "0x200022D")]
[Serializable]
public class GridSystem : IEnumerable<BoardGrid>, IEnumerable
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0003453C File Offset: 0x0003273C
	[Token(Token = "0x170000B3")]
	public int ColumnCount
	{
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x90E540", Offset = "0x90CB40", VA = "0x18090E540")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			return num;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060009AA RID: 2474 RVA: 0x0003455C File Offset: 0x0003275C
	[Token(Token = "0x170000B4")]
	public int RowCount
	{
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x90E790", Offset = "0x90CD90", VA = "0x18090E790")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			return num;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003457C File Offset: 0x0003277C
	[Token(Token = "0x170000B5")]
	public float ColumnWidth
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x90E570", Offset = "0x90CB70", VA = "0x18090E570")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
			float boxXFromColumn2 = Lawnf.GetBoxXFromColumn(-1);
			return boxXFromColumn;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060009AC RID: 2476 RVA: 0x0003459C File Offset: 0x0003279C
	[Token(Token = "0x170000B6")]
	public float GridMinX
	{
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x90E6A0", Offset = "0x90CCA0", VA = "0x18090E6A0")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
			return Lawnf.GetBoxXFromColumn(-1) * 0.5f;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060009AD RID: 2477 RVA: 0x000345BC File Offset: 0x000327BC
	[Token(Token = "0x170000B7")]
	public float GridMaxX
	{
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x90E5B0", Offset = "0x90CBB0", VA = "0x18090E5B0")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
			BoardGrid[,] array2 = this.grids;
			int num2;
			return Lawnf.GetBoxXFromColumn(num2 - 1) * 0.5f;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060009AE RID: 2478 RVA: 0x00034600 File Offset: 0x00032800
	[Token(Token = "0x170000B8")]
	public float GridMinY
	{
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x90E6E0", Offset = "0x90CCE0", VA = "0x18090E6E0")]
		get
		{
			BoardGrid[,] array = this.grids;
			BoardGrid[,] array2 = this.grids;
			int num;
			int num2;
			float boxYFromRow = Lawnf.GetBoxYFromRow(num, num2);
			BoardGrid[,] array3 = this.grids;
			BoardGrid[,] array4 = this.grids;
			int num3;
			num = num3;
			int num4;
			return Lawnf.GetBoxYFromRow(num - 1, num4) * 0.5f;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060009AF RID: 2479 RVA: 0x00034654 File Offset: 0x00032854
	[Token(Token = "0x170000B9")]
	public float GridMaxY
	{
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x90E620", Offset = "0x90CC20", VA = "0x18090E620")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			float boxYFromRow = Lawnf.GetBoxYFromRow(0, num);
			BoardGrid[,] array2 = this.grids;
			int num2;
			return Lawnf.GetBoxYFromRow(-1, num2) * 0.5f;
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00034694 File Offset: 0x00032894
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x90E370", Offset = "0x90C970", VA = "0x18090E370")]
	public GridSystem()
	{
		this.grids = typeof(List<BoardGrid>).TypeHandle;
		List<BoardGrid> list = new List();
		this.viewable = list;
		this.InitBoxInfo();
		BoardGrid[,] array = this.grids;
		int num2;
		int num = num2;
		int i = num;
		List<BoardGrid> list2 = this.viewable;
		uint num4;
		int j;
		uint num3 = num4 * (uint)j;
		num3 += (uint)i;
		num++;
		i++;
		while (i <= num)
		{
		}
		j++;
		j++;
		while (j <= i)
		{
		}
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x0003471C File Offset: 0x0003291C
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x90E110", Offset = "0x90C710", VA = "0x18090E110")]
	public void UpdateGrid(int columnCount, int rowCount)
	{
		BoardGrid[,] array = this.grids;
		int num;
		this.grids = num;
		this.InitBoxInfo();
		int num2 = 0;
		if (columnCount > 0)
		{
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (rowCount > 0)
			{
				BoardGrid[,] array2 = this.grids;
				num4++;
				num5++;
			}
			num2++;
			num3++;
		}
		List<BoardGrid> list = this.viewable;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		BoardGrid[,] array3 = this.grids;
		int num7;
		int num6 = num7;
		int i = num6;
		List<BoardGrid> list2 = this.viewable;
		uint num9;
		uint num8 = num9 * (uint)columnCount;
		num8 += (uint)i;
		num6++;
		i++;
		while (i <= rowCount)
		{
		}
		int num10;
		num10++;
		while (columnCount <= i)
		{
		}
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x000347E4 File Offset: 0x000329E4
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x90DD30", Offset = "0x90C330", VA = "0x18090DD30")]
	private void InitBoxInfo()
	{
		BoardGrid[,] array = this.grids;
		int num = 0;
		int num2 = 0;
		int num3;
		if (num2 < num3)
		{
			int num4 = 0;
			BoardGrid[,] array2 = this.grids;
			int num5;
			if (num4 < num5)
			{
				BoardGrid boardGrid = new BoardGrid(num, num4);
				BoardGrid[,] array3 = this.grids;
				num4++;
			}
			BoardGrid[,] array4 = this.grids;
			num++;
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00034840 File Offset: 0x00032A40
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x90DC50", Offset = "0x90C250", VA = "0x18090DC50")]
	public bool HasPit(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.pitNum > 0;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00034868 File Offset: 0x00032A68
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x90DBF0", Offset = "0x90C1F0", VA = "0x18090DBF0")]
	public bool HasGrave(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.graveNum > 0;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00034890 File Offset: 0x00032A90
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x90DD00", Offset = "0x90C300", VA = "0x18090DD00")]
	public bool HasPot(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.potNum > 0;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x000348B8 File Offset: 0x00032AB8
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x90DC20", Offset = "0x90C220", VA = "0x18090DC20")]
	public bool HasLily(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.lilyNum > 0;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000348E0 File Offset: 0x00032AE0
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x90DC80", Offset = "0x90C280", VA = "0x18090DC80")]
	public bool HasPlant(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		List<Plant> plants = grid.plants;
		bool flag;
		return flag;
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0003490C File Offset: 0x00032B0C
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x90D8C0", Offset = "0x90BEC0", VA = "0x18090D8C0")]
	public void AddPlant(Plant plant, int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theColumn);
		if (grid != 0)
		{
			List<Plant> plants = grid.plants;
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00034934 File Offset: 0x00032B34
	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x90D950", Offset = "0x90BF50", VA = "0x18090D950")]
	public void AddPlant(Plant plant)
	{
		int thePlantRow = plant.thePlantRow;
		int thePlantColumn = plant.thePlantColumn;
		BoardGrid grid = this.GetGrid(thePlantColumn, thePlantRow);
		if (grid != 0)
		{
			List<Plant> plants = grid.plants;
		}
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0003496C File Offset: 0x00032B6C
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x90DFD0", Offset = "0x90C5D0", VA = "0x18090DFD0")]
	public void RemovePlant(Plant plant, int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theColumn);
		if (grid != 0)
		{
			bool flag = grid.plants.Remove(plant);
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x0003499C File Offset: 0x00032B9C
	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x90E060", Offset = "0x90C660", VA = "0x18090E060")]
	public void RemovePlant(Plant plant)
	{
		int thePlantRow = plant.thePlantRow;
		int thePlantColumn = plant.thePlantColumn;
		BoardGrid grid = this.GetGrid(thePlantColumn, thePlantRow);
		if (grid != 0)
		{
			bool flag = grid.plants.Remove(plant);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x000349D8 File Offset: 0x00032BD8
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x90D8A0", Offset = "0x90BEA0", VA = "0x18090D8A0")]
	public void AddPit(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x000349F0 File Offset: 0x00032BF0
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x90DFB0", Offset = "0x90C5B0", VA = "0x18090DFB0")]
	public void RemovePit(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.pitNum > 0)
		{
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00034A14 File Offset: 0x00032C14
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x90D860", Offset = "0x90BE60", VA = "0x18090D860")]
	public void AddGrave(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00034A2C File Offset: 0x00032C2C
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x90DF70", Offset = "0x90C570", VA = "0x18090DF70")]
	public void RemoveGrave(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.graveNum > 0)
		{
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00034A50 File Offset: 0x00032C50
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x90D9E0", Offset = "0x90BFE0", VA = "0x18090D9E0")]
	public void AddPot(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00034A68 File Offset: 0x00032C68
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x90E0F0", Offset = "0x90C6F0", VA = "0x18090E0F0")]
	public void RemovePot(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.potNum > 0)
		{
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00034A8C File Offset: 0x00032C8C
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x90D880", Offset = "0x90BE80", VA = "0x18090D880")]
	public void AddLily(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00034AA4 File Offset: 0x00032CA4
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x90DF90", Offset = "0x90C590", VA = "0x18090DF90")]
	public void RemoveLily(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.lilyNum > 0)
		{
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00034AC8 File Offset: 0x00032CC8
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x90DAB0", Offset = "0x90C0B0", VA = "0x18090DAB0")]
	public BoardGrid GetGrid(int theColumn, int theRow)
	{
		BoardGrid[,] array = this.grids;
		BoardGrid[,] array2 = this.grids;
		int num2;
		int num = num2 - 1;
		BoardGrid[,] array3 = this.grids;
		BoardGrid[,] array4 = this.grids;
		int num3 = 0;
		int num5;
		int num4 = num5 - 1;
		BoardGrid[,] array5 = this.grids;
		num5 = num;
		int num6 = num5 * num3;
		num6 += num4;
		return array5[num6];
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00034B34 File Offset: 0x00032D34
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x90DA00", Offset = "0x90C000", VA = "0x18090DA00")]
	public BoxType GetBoxType(int theColumn, int theRow)
	{
		return this.GetGrid(theColumn, theRow).boxType;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00034B54 File Offset: 0x00032D54
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x90DBB0", Offset = "0x90C1B0", VA = "0x18090DBB0")]
	public int GetPitNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.pitNum;
		}
		return 0;
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00034B78 File Offset: 0x00032D78
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x90DA90", Offset = "0x90C090", VA = "0x18090DA90")]
	public int GetGraveNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.graveNum;
		}
		return 0;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00034B9C File Offset: 0x00032D9C
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x90DBD0", Offset = "0x90C1D0", VA = "0x18090DBD0")]
	public int GetPotNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.potNum;
		}
		return 0;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00034BC0 File Offset: 0x00032DC0
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x90DB90", Offset = "0x90C190", VA = "0x18090DB90")]
	public int GetLilyNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.lilyNum;
		}
		return 0;
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00034BE4 File Offset: 0x00032DE4
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x90DE20", Offset = "0x90C420", VA = "0x18090DE20")]
	public void OnUpdate()
	{
		BoardGrid[,] array = this.grids;
		int num;
		int i = num;
		int j;
		BoardGrid[,] array2 = array * j;
		array2 += i;
		BoardGrid boardGrid = array[array2];
		if (boardGrid.boxType == BoxType.Water)
		{
			float time = Time.time;
			boardGrid.waterBoxY = time;
		}
		num++;
		i++;
		int num2;
		while (i <= num2)
		{
		}
		j++;
		j++;
		while (j <= i)
		{
		}
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00034C5C File Offset: 0x00032E5C
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x90DE20", Offset = "0x90C420", VA = "0x18090DE20")]
	private void WaterYUpdate()
	{
		BoardGrid[,] array = this.grids;
		int num;
		int i = num;
		int j;
		BoardGrid[,] array2 = array * j;
		array2 += i;
		BoardGrid boardGrid = array[array2];
		if (boardGrid.boxType == BoxType.Water)
		{
			float time = Time.time;
			boardGrid.waterBoxY = time;
		}
		num++;
		i++;
		int num2;
		while (i <= num2)
		{
		}
		j++;
		j++;
		while (j <= i)
		{
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00034CD4 File Offset: 0x00032ED4
	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x90DA20", Offset = "0x90C020", VA = "0x18090DA20", Slot = "4")]
	public IEnumerator<BoardGrid> GetEnumerator()
	{
		GridSystem.<GetEnumerator>d__45 <GetEnumerator>d__;
		<GetEnumerator>d__.System.IDisposable.Dispose();
		<GetEnumerator>d__.<>1__state = (int)((ulong)0L);
		<GetEnumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00034D00 File Offset: 0x00032F00
	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x90DA20", Offset = "0x90C020", VA = "0x18090DA20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		GridSystem.<GetEnumerator>d__45 <GetEnumerator>d__;
		<GetEnumerator>d__.System.IDisposable.Dispose();
		<GetEnumerator>d__.<>1__state = (int)((ulong)0L);
		<GetEnumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x04000503 RID: 1283
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000503")]
	public Board board;

	// Token: 0x04000504 RID: 1284
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000504")]
	public List<BoardGrid> viewable;

	// Token: 0x04000505 RID: 1285
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000505")]
	private BoardGrid[,] grids;
}
