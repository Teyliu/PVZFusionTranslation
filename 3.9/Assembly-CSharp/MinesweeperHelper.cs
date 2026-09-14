using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000CF RID: 207
[Token(Token = "0x20000CF")]
public static class MinesweeperHelper
{
	// Token: 0x060003BC RID: 956 RVA: 0x000116F4 File Offset: 0x0000F8F4
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x4F6650", Offset = "0x4F4C50", VA = "0x1804F6650")]
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

	// Token: 0x060003BD RID: 957 RVA: 0x0001174C File Offset: 0x0000F94C
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x4F6980", Offset = "0x4F4F80", VA = "0x1804F6980")]
	public static bool IsValidPosition(int row, int col, int rowCount, int colCount)
	{
		return row < rowCount && col < colCount;
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00011768 File Offset: 0x0000F968
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x4F67A0", Offset = "0x4F4DA0", VA = "0x1804F67A0")]
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

	// Token: 0x060003BF RID: 959 RVA: 0x000117B4 File Offset: 0x0000F9B4
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x4F69A0", Offset = "0x4F4FA0", VA = "0x1804F69A0")]
	public static int ManhattanDistance(Vector2Int a, Vector2Int b)
	{
		return 0;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x000117C4 File Offset: 0x0000F9C4
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x4F68A0", Offset = "0x4F4EA0", VA = "0x1804F68A0")]
	public static bool IsAdjacent(Vector2Int a, Vector2Int b)
	{
		int num;
		if (num != 0)
		{
		}
		return false;
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x000117D8 File Offset: 0x0000F9D8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x4F6A50", Offset = "0x4F5050", VA = "0x1804F6A50")]
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

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	private static readonly Vector2Int[] SurroundingOffsets;
}
