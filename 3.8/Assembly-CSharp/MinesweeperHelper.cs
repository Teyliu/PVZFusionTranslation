using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public static class MinesweeperHelper
{
	// Token: 0x060003A1 RID: 929 RVA: 0x00011380 File Offset: 0x0000F580
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x4B6F90", Offset = "0x4B5590", VA = "0x1804B6F90")]
	public static int CountSurroundingMines(bool[,] mineGrid, int row, int col)
	{
		if (mineGrid != 0)
		{
			int num = 0;
			int length = MinesweeperHelper.SurroundingOffsets.Length;
			if (num < length)
			{
				num += row;
				int num2;
				int num3;
				if (num < num2 && 0 < num3)
				{
					int num4;
					num4 += mineGrid;
					num++;
				}
				num++;
			}
			return num;
		}
		return 0;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x000113D8 File Offset: 0x0000F5D8
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x4B72C0", Offset = "0x4B58C0", VA = "0x1804B72C0")]
	public static bool IsValidPosition(int row, int col, int rowCount, int colCount)
	{
		return row < rowCount && col < colCount;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000113F4 File Offset: 0x0000F5F4
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x4B70E0", Offset = "0x4B56E0", VA = "0x1804B70E0")]
	public static Vector2Int[] GetSurroundingPositions(int centerRow, int centerCol)
	{
		Vector2Int[] array = new Vector2Int[8];
		int num = 0;
		Vector2Int[] surroundingOffsets = MinesweeperHelper.SurroundingOffsets;
		Vector2Int vector2Int;
		vector2Int += centerCol;
		Vector2Int[] array2 = MinesweeperHelper.SurroundingOffsets;
		array2 += centerRow;
		num++;
		uint num2;
		num2.m_value = vector2Int;
		num2 += (uint)8;
		return array;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00011440 File Offset: 0x0000F640
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x4B72E0", Offset = "0x4B58E0", VA = "0x1804B72E0")]
	public static int ManhattanDistance(Vector2Int a, Vector2Int b)
	{
		return 0;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00011450 File Offset: 0x0000F650
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x4B71E0", Offset = "0x4B57E0", VA = "0x1804B71E0")]
	public static bool IsAdjacent(Vector2Int a, Vector2Int b)
	{
		int num;
		if (num != 0)
		{
		}
		return false;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00011464 File Offset: 0x0000F664
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x4B7390", Offset = "0x4B5990", VA = "0x1804B7390")]
	static MinesweeperHelper()
	{
		Vector2Int[] array = new Vector2Int[8];
		ulong num;
		array[0] = num;
		int num2 = 0;
		array[1] = num2;
		ulong num3;
		array[2] = num3;
		ulong num4;
		array[3] = num4;
		ulong num5;
		array[4] = num5;
		ulong num6;
		array[5] = num6;
		array[6] = num2;
		ulong num7;
		array[7] = num7;
		MinesweeperHelper.SurroundingOffsets = array;
		throw new NullReferenceException();
	}

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	private static readonly Vector2Int[] SurroundingOffsets;
}
