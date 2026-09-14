using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000228 RID: 552
[Token(Token = "0x2000228")]
[Serializable]
public class GridSystem : IEnumerable<BoardGrid>, IEnumerable
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000993 RID: 2451 RVA: 0x00034734 File Offset: 0x00032934
	[Token(Token = "0x17000076")]
	public int ColumnCount
	{
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x87EA30", Offset = "0x87D030", VA = "0x18087EA30")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			return num;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000994 RID: 2452 RVA: 0x00034754 File Offset: 0x00032954
	[Token(Token = "0x17000077")]
	public int RowCount
	{
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x87EC80", Offset = "0x87D280", VA = "0x18087EC80")]
		get
		{
			BoardGrid[,] array = this.grids;
			int num;
			return num;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000995 RID: 2453 RVA: 0x00034774 File Offset: 0x00032974
	[Token(Token = "0x17000078")]
	public float ColumnWidth
	{
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x87EA60", Offset = "0x87D060", VA = "0x18087EA60")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
			float boxXFromColumn2 = Lawnf.GetBoxXFromColumn(-1);
			return boxXFromColumn;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000996 RID: 2454 RVA: 0x00034794 File Offset: 0x00032994
	[Token(Token = "0x17000079")]
	public float GridMinX
	{
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x87EB90", Offset = "0x87D190", VA = "0x18087EB90")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
			return Lawnf.GetBoxXFromColumn(-1) * 0.5f;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000997 RID: 2455 RVA: 0x000347B4 File Offset: 0x000329B4
	[Token(Token = "0x1700007A")]
	public float GridMaxX
	{
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x87EAA0", Offset = "0x87D0A0", VA = "0x18087EAA0")]
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

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000998 RID: 2456 RVA: 0x000347F8 File Offset: 0x000329F8
	[Token(Token = "0x1700007B")]
	public float GridMinY
	{
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x87EBD0", Offset = "0x87D1D0", VA = "0x18087EBD0")]
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

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000999 RID: 2457 RVA: 0x0003484C File Offset: 0x00032A4C
	[Token(Token = "0x1700007C")]
	public float GridMaxY
	{
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x87EB10", Offset = "0x87D110", VA = "0x18087EB10")]
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

	// Token: 0x0600099A RID: 2458 RVA: 0x0003488C File Offset: 0x00032A8C
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x87E860", Offset = "0x87CE60", VA = "0x18087E860")]
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

	// Token: 0x0600099B RID: 2459 RVA: 0x00034914 File Offset: 0x00032B14
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x87E600", Offset = "0x87CC00", VA = "0x18087E600")]
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

	// Token: 0x0600099C RID: 2460 RVA: 0x000349DC File Offset: 0x00032BDC
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x87E220", Offset = "0x87C820", VA = "0x18087E220")]
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

	// Token: 0x0600099D RID: 2461 RVA: 0x00034A38 File Offset: 0x00032C38
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x87E140", Offset = "0x87C740", VA = "0x18087E140")]
	public bool HasPit(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.pitNum > 0;
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00034A60 File Offset: 0x00032C60
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x87E0E0", Offset = "0x87C6E0", VA = "0x18087E0E0")]
	public bool HasGrave(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.graveNum > 0;
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00034A88 File Offset: 0x00032C88
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x87E1F0", Offset = "0x87C7F0", VA = "0x18087E1F0")]
	public bool HasPot(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.potNum > 0;
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00034AB0 File Offset: 0x00032CB0
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x87E110", Offset = "0x87C710", VA = "0x18087E110")]
	public bool HasLily(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0)
		{
		}
		return grid.lilyNum > 0;
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00034AD8 File Offset: 0x00032CD8
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x87E170", Offset = "0x87C770", VA = "0x18087E170")]
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

	// Token: 0x060009A2 RID: 2466 RVA: 0x00034B04 File Offset: 0x00032D04
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x87DDB0", Offset = "0x87C3B0", VA = "0x18087DDB0")]
	public void AddPlant(Plant plant, int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theColumn);
		if (grid != 0)
		{
			List<Plant> plants = grid.plants;
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00034B2C File Offset: 0x00032D2C
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x87DE40", Offset = "0x87C440", VA = "0x18087DE40")]
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

	// Token: 0x060009A4 RID: 2468 RVA: 0x00034B64 File Offset: 0x00032D64
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x87E4C0", Offset = "0x87CAC0", VA = "0x18087E4C0")]
	public void RemovePlant(Plant plant, int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theColumn);
		if (grid != 0)
		{
			bool flag = grid.plants.Remove(plant);
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00034B94 File Offset: 0x00032D94
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x87E550", Offset = "0x87CB50", VA = "0x18087E550")]
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

	// Token: 0x060009A6 RID: 2470 RVA: 0x00034BD0 File Offset: 0x00032DD0
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x87DD90", Offset = "0x87C390", VA = "0x18087DD90")]
	public void AddPit(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00034BE8 File Offset: 0x00032DE8
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x87E4A0", Offset = "0x87CAA0", VA = "0x18087E4A0")]
	public void RemovePit(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.pitNum > 0)
		{
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00034C0C File Offset: 0x00032E0C
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x87DD50", Offset = "0x87C350", VA = "0x18087DD50")]
	public void AddGrave(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00034C24 File Offset: 0x00032E24
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x87E460", Offset = "0x87CA60", VA = "0x18087E460")]
	public void RemoveGrave(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.graveNum > 0)
		{
		}
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00034C48 File Offset: 0x00032E48
	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x87DED0", Offset = "0x87C4D0", VA = "0x18087DED0")]
	public void AddPot(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00034C60 File Offset: 0x00032E60
	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x87E5E0", Offset = "0x87CBE0", VA = "0x18087E5E0")]
	public void RemovePot(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.potNum > 0)
		{
		}
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00034C84 File Offset: 0x00032E84
	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x87DD70", Offset = "0x87C370", VA = "0x18087DD70")]
	public void AddLily(int theColumn, int theRow)
	{
		if (this.GetGrid(theColumn, theRow) != 0)
		{
		}
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00034C9C File Offset: 0x00032E9C
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x87E480", Offset = "0x87CA80", VA = "0x18087E480")]
	public void RemoveLily(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid == 0 || grid.lilyNum > 0)
		{
		}
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00034CC0 File Offset: 0x00032EC0
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x87DFA0", Offset = "0x87C5A0", VA = "0x18087DFA0")]
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

	// Token: 0x060009AF RID: 2479 RVA: 0x00034D2C File Offset: 0x00032F2C
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x87DEF0", Offset = "0x87C4F0", VA = "0x18087DEF0")]
	public BoxType GetBoxType(int theColumn, int theRow)
	{
		return this.GetGrid(theColumn, theRow).boxType;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00034D4C File Offset: 0x00032F4C
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x87E0A0", Offset = "0x87C6A0", VA = "0x18087E0A0")]
	public int GetPitNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.pitNum;
		}
		return 0;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00034D70 File Offset: 0x00032F70
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x87DF80", Offset = "0x87C580", VA = "0x18087DF80")]
	public int GetGraveNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.graveNum;
		}
		return 0;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00034D94 File Offset: 0x00032F94
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x87E0C0", Offset = "0x87C6C0", VA = "0x18087E0C0")]
	public int GetPotNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.potNum;
		}
		return 0;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00034DB8 File Offset: 0x00032FB8
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x87E080", Offset = "0x87C680", VA = "0x18087E080")]
	public int GetLilyNum(int theColumn, int theRow)
	{
		BoardGrid grid = this.GetGrid(theColumn, theRow);
		if (grid != 0)
		{
			return grid.lilyNum;
		}
		return 0;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00034DDC File Offset: 0x00032FDC
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x87E310", Offset = "0x87C910", VA = "0x18087E310")]
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

	// Token: 0x060009B5 RID: 2485 RVA: 0x00034E54 File Offset: 0x00033054
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x87E310", Offset = "0x87C910", VA = "0x18087E310")]
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

	// Token: 0x060009B6 RID: 2486 RVA: 0x00034ECC File Offset: 0x000330CC
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x87DF10", Offset = "0x87C510", VA = "0x18087DF10", Slot = "4")]
	public IEnumerator<BoardGrid> GetEnumerator()
	{
		GridSystem.<GetEnumerator>d__45 <GetEnumerator>d__;
		<GetEnumerator>d__.System.IDisposable.Dispose();
		<GetEnumerator>d__.<>1__state = (int)((ulong)0L);
		<GetEnumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00034EF8 File Offset: 0x000330F8
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x87DF10", Offset = "0x87C510", VA = "0x18087DF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		GridSystem.<GetEnumerator>d__45 <GetEnumerator>d__;
		<GetEnumerator>d__.System.IDisposable.Dispose();
		<GetEnumerator>d__.<>1__state = (int)((ulong)0L);
		<GetEnumerator>d__.<>4__this = this;
		return null;
	}

	// Token: 0x040004FD RID: 1277
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004FD")]
	public Board board;

	// Token: 0x040004FE RID: 1278
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FE")]
	public List<BoardGrid> viewable;

	// Token: 0x040004FF RID: 1279
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004FF")]
	private BoardGrid[,] grids;
}
