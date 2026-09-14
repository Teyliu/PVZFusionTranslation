using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public static class MinesweeperSolver
{
	// Token: 0x060003DD RID: 989 RVA: 0x000122C0 File Offset: 0x000104C0
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x4FCA60", Offset = "0x4FB060", VA = "0x1804FCA60")]
	public static bool IsSolvable(bool[,] mineGrid, int firstRow, int firstCol)
	{
		if (mineGrid != 0)
		{
			int num = 0;
			MinesweeperSolver.GameState gameState;
			int num2;
			gameState.rows = num2;
			int num3;
			gameState.cols = num3;
			gameState.revealed = typeof(int[][]).TypeHandle;
			int rows = gameState.rows;
			int cols = gameState.cols;
			gameState.flagged = cols;
			int rows2 = gameState.rows;
			int cols2 = gameState.cols;
			gameState.revealedNumbers = cols2;
			int num4 = 0;
			if (gameState.rows > num4)
			{
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				if (gameState.cols > num6)
				{
					int[,] revealedNumbers = gameState.revealedNumbers;
					num6++;
					int num8 = num5 * num;
					num8 += num7;
					num7++;
				}
				num4++;
				num5++;
			}
			if (MinesweeperSolver.OpenCell(firstRow, firstCol, gameState, mineGrid))
			{
				MinesweeperSolver.CascadeOpenZeroCells(firstRow, firstCol, gameState, mineGrid);
				int num9 = num3 * num2;
				int num10 = 0;
				num9 += num9;
				num2 = gameState.GetUnrevealedSafeCount(mineGrid);
				int num11;
				if (num10 < num9)
				{
					num10++;
					List<MinesweeperSolver.Constraint> list = MinesweeperSolver.BuildConstraintsFromRevealed(gameState);
					if (MinesweeperSolver.ApplyConstraintPropagation(list, gameState, mineGrid))
					{
					}
					if (MinesweeperSolver.ApplyAdvancedInference(list, gameState, mineGrid))
					{
					}
					if (MinesweeperSolver.ApplyOverlapInference(list, gameState, mineGrid))
					{
					}
					num11 = 0;
					bool flag = MinesweeperSolver.ApplyTrueProbabilityInference(list, gameState, mineGrid);
					int unrevealedSafeCount = gameState.GetUnrevealedSafeCount(mineGrid);
					if (unrevealedSafeCount < num2)
					{
						num2 = unrevealedSafeCount;
					}
					uint num12;
					while (num12 != (uint)0)
					{
					}
				}
				int num13 = 0;
				if (gameState.rows > num13)
				{
					int cols3 = gameState.cols;
					int num14 = 0;
					int rows3 = gameState.rows;
					if (cols3 > 0)
					{
						int num15 = 0;
						int num16 = 0;
						int num17 = num14 * mineGrid;
						num17 += num16;
						bool[,] revealed = gameState.revealed;
						int num18 = num14 * num11;
						num18 += num16;
						num15++;
						num16++;
					}
					num13++;
					num14++;
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00012490 File Offset: 0x00010690
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x4FCF60", Offset = "0x4FB560", VA = "0x1804FCF60")]
	private static bool OpenCell(int row, int col, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		if (row < state.rows && col < state.cols)
		{
			bool[,] revealed = state.revealed;
			int num = row * state;
			num += col;
			int num2 = row * revealed;
			num2 += col;
			int num3 = 0;
			int i = row - 1;
			int num4 = row + 1;
			int num5 = row - 1;
			int j = col + 1;
			int num6 = col - 1;
			int num7 = col - 1;
			j = num7;
			int num8;
			int num9;
			if ((i != row || j != col) && num5 < num8 && j < num9)
			{
				num7 = num5;
				int num10 = num7 * num6;
				num10 += j;
				num3++;
			}
			num6++;
			j++;
			while (j <= j)
			{
			}
			int num11 = col - 1;
			i++;
			int num12 = row + 1;
			num5++;
			while (i <= num12)
			{
			}
			int[,] revealedNumbers = state.revealedNumbers;
			int num13 = row * num5;
			num13 += col;
			revealedNumbers[0] = num3;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060003DF RID: 991 RVA: 0x0001257C File Offset: 0x0001077C
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x4FC310", Offset = "0x4FA910", VA = "0x1804FC310")]
	private static void CascadeOpenZeroCells(int startRow, int startCol, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		int[,] revealedNumbers = state.revealedNumbers;
		int num = startRow * state;
		num += startCol;
		if ("{il2cpp array field local4->}" == (ulong)0L)
		{
			Queue<Vector2Int> queue = new Queue();
			Vector2Int vector2Int = queue.Dequeue();
			int x = vector2Int.m_X;
			int num2 = x - 1;
			if ((startCol != vector2Int || num2 != x) && startCol < state.rows)
			{
				bool[,] revealed = state.revealed;
				bool flag;
				if (flag)
				{
					int[,] revealedNumbers2 = state.revealedNumbers;
					if ("{il2cpp array field local14->}" == (ulong)0L)
					{
					}
				}
			}
			num2++;
			while (startCol <= queue)
			{
			}
		}
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00012600 File Offset: 0x00010800
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x4FBF20", Offset = "0x4FA520", VA = "0x1804FBF20")]
	private static List<MinesweeperSolver.Constraint> BuildConstraintsFromRevealed(MinesweeperSolver.GameState state)
	{
		List<MinesweeperSolver.Constraint> list = new List();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (num2 < state.rows)
		{
			int num4 = 0;
			int num5 = 0;
			if (num4 < state.cols)
			{
				bool[,] revealed = state.revealed;
				int num6;
				num6 += num5;
				int[,] revealedNumbers = state.revealedNumbers;
				int num7;
				num7 += num5;
				int num8 = revealedNumbers[num7];
				uint num10;
				if (num8 > 0)
				{
					List<Vector2Int> list2 = new List();
					int num9 = 0;
					if ((-1 != num || -1 != num5) && -1 < state.rows)
					{
						bool[,] flagged = state.flagged;
						num3 += -1;
						bool[,] revealed2 = state.revealed;
						num3 += -1;
						num9++;
					}
					num3++;
					while (-1 <= 1)
					{
					}
					num8 -= num9;
					MinesweeperSolver.Constraint constraint = new MinesweeperSolver.Constraint(list2, num8);
					num10 += (uint)1;
					num4++;
					num5++;
				}
				num4++;
				num10 += (uint)1;
				num5++;
			}
			num++;
			num3++;
		}
		return list;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000126FC File Offset: 0x000108FC
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x4FA900", Offset = "0x4F8F00", VA = "0x1804FA900")]
	private static bool ApplyConstraintPropagation(List<MinesweeperSolver.Constraint> constraints, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			bool flag;
			if (flag)
			{
				if (flag > false)
				{
					bool flag2;
					if (flag2)
					{
						bool[,] flagged = state.flagged;
						int num3 = num * num;
						num3 += num;
						num3 += num;
					}
					if (num2 != 0)
					{
						goto IL_00B2;
					}
				}
				bool flag3;
				if (flag3)
				{
					bool[,] revealed = state.revealed;
					int num4 = num * num;
					num4 += num;
					bool[,] array = state.revealed;
					num += num;
					int[,] revealedNumbers = state.revealedNumbers;
					array += num;
					while ("{il2cpp array field local28->}" != (ulong)0L)
					{
					}
				}
				if (num2 != 0)
				{
					goto IL_00EE;
				}
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
		IL_00B2:
		throw new IndexOutOfRangeException();
		IL_00EE:
		throw new NullReferenceException();
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00012810 File Offset: 0x00010A10
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x4F9FD0", Offset = "0x4F85D0", VA = "0x1804F9FD0")]
	private static bool ApplyAdvancedInference(List<MinesweeperSolver.Constraint> constraints, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		int num7;
		do
		{
			int num = 0;
			int num2 = 0;
			num2++;
			MinesweeperSolver.Constraint constraint = constraints[num2];
			MinesweeperSolver.Constraint constraint2 = constraints[num2];
			List<Vector2Int> variables = constraint2.variables;
			if (MinesweeperSolver.IsSubset(constraint.variables, variables))
			{
				int sum = constraint2.sum;
				if (constraint.sum == sum)
				{
					List<Vector2Int> variables2 = constraint.variables;
					List<Vector2Int> list = MinesweeperSolver.Difference(constraint2.variables, variables2);
					bool flag;
					if (flag)
					{
						bool[,] revealed = state.revealed;
						int num3 = num * num;
						num3 += num;
						bool[,] revealed2 = state.revealed;
						int[,] revealedNumbers = state.revealedNumbers;
						while ("{il2cpp array field local26->}" != (ulong)0L)
						{
						}
					}
					if (num2 != 0)
					{
						goto IL_0218;
					}
				}
				int sum2 = constraint.sum;
				if (sum2 < constraint2.sum)
				{
					int num4 = constraint2.sum;
					List<Vector2Int> variables3 = constraint.variables;
					List<Vector2Int> list2 = MinesweeperSolver.Difference(constraint2.variables, variables3);
					num4 -= sum2;
					bool flag2;
					if (flag2)
					{
						bool[,] flagged = state.flagged;
						int num5 = num * num;
						num5 += num;
						num5 += num;
					}
					if (num2 != 0)
					{
						goto IL_0242;
					}
				}
			}
			List<Vector2Int> variables4 = constraint.variables;
			if (!MinesweeperSolver.IsSubset(constraint2.variables, variables4))
			{
				break;
			}
			int sum3 = constraint.sum;
			if (constraint2.sum == sum3)
			{
				List<Vector2Int> variables5 = constraint2.variables;
				List<Vector2Int> list3 = MinesweeperSolver.Difference(constraint.variables, variables5);
				bool flag3;
				if (flag3)
				{
					bool[,] revealed3 = state.revealed;
					int num6 = num * num;
					num6 += num;
					bool[,] revealed4 = state.revealed;
					int[,] revealedNumbers2 = state.revealedNumbers;
					while ("{il2cpp array field local60->}" != (ulong)0L)
					{
					}
				}
				if (num2 != 0)
				{
					goto IL_027E;
				}
				num7 = 0;
			}
			int sum4 = constraint2.sum;
			if (sum4 >= constraint.sum)
			{
				break;
			}
			int num8 = constraint.sum;
			List<Vector2Int> variables6 = constraint2.variables;
			List<Vector2Int> list4 = MinesweeperSolver.Difference(constraint.variables, variables6);
			num8 -= sum4;
			bool flag4;
			if (flag4)
			{
				int num9 = num * num;
				num9 += num;
				num9 += num;
			}
		}
		while (num7 != 0);
		throw new NullReferenceException();
		IL_0218:
		throw new IndexOutOfRangeException();
		IL_0242:
		throw new IndexOutOfRangeException();
		IL_027E:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00012AC8 File Offset: 0x00010CC8
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x4FAE60", Offset = "0x4F9460", VA = "0x1804FAE60")]
	private static bool ApplyOverlapInference(List<MinesweeperSolver.Constraint> constraints, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		ulong num7;
		do
		{
			int num = 0;
			MinesweeperSolver.Constraint constraint = constraints[num];
			MinesweeperSolver.Constraint constraint2 = constraints[1];
			List<Vector2Int> variables = constraint2.variables;
			List<Vector2Int> list = MinesweeperSolver.Intersection(constraint.variables, variables);
			List<Vector2Int> list2 = MinesweeperSolver.Difference(constraint.variables, list);
			List<Vector2Int> list3 = MinesweeperSolver.Difference(constraint2.variables, list);
			int sum = constraint.sum;
			int sum2 = constraint2.sum;
			bool flag;
			if (flag)
			{
				bool[,] revealed = state.revealed;
				int num2 = num * num;
				num2 += num;
				bool[,] array = state.revealed;
				num += num;
				int[,] revealedNumbers = state.revealedNumbers;
				array += num;
				while ("{il2cpp array field local31->}" != (ulong)0L)
				{
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0168;
			}
			int sum3 = constraint.sum;
			if (constraint2.sum > sum3)
			{
				int sum4 = constraint2.sum;
				bool flag2;
				if (flag2)
				{
					bool[,] flagged = state.flagged;
					int num4 = num * num;
					num4 += num;
					num4 += num;
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_0192;
				}
			}
			int sum5 = constraint2.sum;
			if (constraint.sum <= sum5)
			{
				break;
			}
			int sum6 = constraint.sum;
			bool flag3;
			if (flag3)
			{
				int num6 = num * num;
				num6 += num;
				num6 += num;
			}
		}
		while (num7 != (ulong)0L);
		int num8;
		num8++;
		throw new NullReferenceException();
		IL_0168:
		throw new IndexOutOfRangeException();
		IL_0192:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00012C94 File Offset: 0x00010E94
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x4FB5C0", Offset = "0x4F9BC0", VA = "0x1804FB5C0")]
	private static bool ApplyTrueProbabilityInference(List<MinesweeperSolver.Constraint> constraints, MinesweeperSolver.GameState state, bool[,] mineGrid)
	{
		List<Vector2Int> list;
		int size;
		int[] array;
		int num4;
		ulong num7;
		do
		{
			int num = 0;
			int num2 = 0;
			HashSet<Vector2Int> hashSet = new HashSet();
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3 = hashSet.Add(num);
				}
				if (num2 != 0)
				{
					goto IL_01C4;
				}
			}
			if (num2 != 0)
			{
				goto IL_01D0;
			}
			int num3 = 0;
			list = Enumerable.ToList<Vector2Int>(hashSet);
			size = list._size;
			array = new int[size];
			Dictionary<Vector2Int, int> dictionary = new Dictionary();
			if (size > 0)
			{
				Vector2Int vector2Int = list[num3];
				dictionary[vector2Int] = num3;
				num3++;
			}
			num4 = 0;
			uint num5;
			if (num4 >= (int)num5)
			{
				goto IL_00DB;
			}
			bool flag4;
			if (flag4)
			{
				int num6 = 0;
				bool flag5;
				if (flag5)
				{
					if (!dictionary.TryGetValue(num, num2))
					{
						continue;
					}
					while (num4 == 1)
					{
					}
					num6++;
				}
				if (num6 != 0)
				{
					goto IL_01D6;
				}
			}
		}
		while (num7 != (ulong)0L);
		int num8 = 0;
		if (size > 0)
		{
			int num9 = 0;
			if (num4 != 1)
			{
			}
			num8++;
			num9++;
		}
		num4++;
		IL_00DB:
		if (size > 0)
		{
			int num10 = 0;
			Vector2Int vector2Int2 = list[num10];
			int num11 = 0;
			Vector2Int vector2Int4;
			if (num11 == array.Length)
			{
				int x = vector2Int2.m_X;
				int x2 = vector2Int2.m_X;
				Vector2Int vector2Int3 = vector2Int2 * x2;
				vector2Int3 += x;
				if (vector2Int3.s_Left == num11)
				{
					int num12 = vector2Int2.m_X;
					int x3 = vector2Int2.m_X;
					vector2Int2 += x3;
					if (vector2Int2.s_Left != num11)
					{
						int x4 = vector2Int2.m_X;
						num12 += x4;
					}
				}
				num11++;
				num11++;
				if (num11 >= size)
				{
					goto IL_01B8;
				}
				vector2Int4 = list[num11];
			}
			while (num11 != size)
			{
			}
			int x5 = vector2Int4.m_X;
			int x6 = vector2Int4.m_X;
			Vector2Int vector2Int5 = vector2Int4 * x6;
			vector2Int5 += x5;
			while (vector2Int5.s_Left != num11)
			{
			}
			int x7 = vector2Int4.m_X;
		}
		IL_01B8:
		throw new NullReferenceException();
		IL_01C4:
		throw new NullReferenceException();
		IL_01D0:
		throw new NullReferenceException();
		IL_01D6:
		throw new NullReferenceException();
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00012E8C File Offset: 0x0001108C
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x4FC5C0", Offset = "0x4FABC0", VA = "0x1804FC5C0")]
	private static int CountSurroundingMines(bool[,] mineGrid, int row, int col)
	{
		int num = 0;
		int i = row - 1;
		int num2 = row + 1;
		int j = col + 1;
		int num3 = col - 1;
		int num4 = col - 1;
		int num5 = row + 1;
		j = num4;
		int num6;
		int num7;
		if ((i != row || j != col) && i < num6 && j < num7)
		{
			uint num9;
			uint num8 = num9 * (uint)i;
			num8 += (uint)j;
			num++;
		}
		num3++;
		j++;
		while (j <= j)
		{
		}
		i++;
		i++;
		while (i <= num5)
		{
		}
		return num;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00012F14 File Offset: 0x00011114
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x4FCE10", Offset = "0x4FB410", VA = "0x1804FCE10")]
	private static bool IsSubset(List<Vector2Int> list1, List<Vector2Int> list2)
	{
		int num;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
		}
		while ((flag && list2.Contains(num)) || num2 != (ulong)0L);
		return true;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00012F4C File Offset: 0x0001114C
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x4FC6E0", Offset = "0x4FACE0", VA = "0x1804FC6E0")]
	private static List<Vector2Int> Difference(List<Vector2Int> list1, List<Vector2Int> list2)
	{
		int num;
		List<Vector2Int> list3;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
			list3 = new List();
		}
		while ((flag && list2.Contains(num)) || num2 != (ulong)0L);
		return list3;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00012F98 File Offset: 0x00011198
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x4FC8A0", Offset = "0x4FAEA0", VA = "0x1804FC8A0")]
	private static List<Vector2Int> Intersection(List<Vector2Int> list1, List<Vector2Int> list2)
	{
		int num;
		List<Vector2Int> list3;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
			list3 = new List();
		}
		while ((flag && !list2.Contains(num)) || num2 != (ulong)0L);
		return list3;
	}

	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	private class Constraint
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x00012FE4 File Offset: 0x000111E4
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x4EEA10", Offset = "0x4ED010", VA = "0x1804EEA10")]
		public Constraint(List<Vector2Int> vars, int s)
		{
			this.variables = vars;
			this.sum = s;
		}

		// Token: 0x04000223 RID: 547
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000223")]
		public List<Vector2Int> variables;

		// Token: 0x04000224 RID: 548
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000224")]
		public int sum;
	}

	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	private class GameState
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x4EF9F0", Offset = "0x4EDFF0", VA = "0x1804EF9F0")]
		public GameState(int r, int c)
		{
			this.rows = r;
			this.cols = c;
			this.revealed = typeof(int[][]).TypeHandle;
			int num = this.rows;
			int num2 = this.cols;
			this.flagged = num2;
			int num3 = this.rows;
			int num4 = this.cols;
			this.revealedNumbers = num4;
			int num5 = 0;
			if (this.rows > num5)
			{
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				if (this.cols > num7)
				{
					int[,] array = this.revealedNumbers;
					num7++;
					int num9;
					num9 += num8;
					num8++;
				}
				num5++;
				num6++;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000130AC File Offset: 0x000112AC
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x4EFB50", Offset = "0x4EE150", VA = "0x1804EFB50")]
		public GameState(MinesweeperSolver.GameState other)
		{
			int num2;
			int num3;
			do
			{
				base..ctor();
				int num = other.rows;
				this.rows = num;
				num2 = other.cols;
				this.cols = num2;
				bool[,] array = other.revealed;
				num3 = 0;
				if (num2 == 0)
				{
					this.revealed = num3;
				}
			}
			while (num2 == 0);
			this.revealed = num2;
			if (num2 != 0)
			{
				bool[,] array2 = other.flagged;
				if (num2 == 0)
				{
					this.flagged = num3;
				}
				if (num3 != 0)
				{
					this.flagged = num3;
					if (num3 != 0)
					{
						int[,] array3 = other.revealedNumbers;
						if (num3 == 0)
						{
							this.revealedNumbers = num3;
						}
						if (num3 != 0)
						{
							this.revealedNumbers = num3;
							if (num3 != 0)
							{
								throw new NullReferenceException();
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00013150 File Offset: 0x00011350
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x4EF900", Offset = "0x4EDF00", VA = "0x1804EF900")]
		public bool IsAllSafeCellsRevealed(bool[,] mineGrid)
		{
			int num = 0;
			if (this.rows > num)
			{
				int num2 = this.cols;
				int num3 = 0;
				int num4 = this.rows;
				if (num2 > 0)
				{
					int num5 = 0;
					int num6 = 0;
					bool[,] array = this.revealed;
					int num7 = num3 * array;
					num7 += num6;
					bool[,] array2 = this.revealed;
					num3 += num6;
					num5++;
					num6++;
				}
				num++;
				num3++;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000131C0 File Offset: 0x000113C0
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4EF810", Offset = "0x4EDE10", VA = "0x1804EF810")]
		public int GetUnrevealedSafeCount(bool[,] mineGrid)
		{
			int num = 0;
			int num2 = 0;
			if (this.rows > num)
			{
				int num3 = this.cols;
				int num4 = 0;
				int num5 = this.rows;
				if (num3 > 0)
				{
					int num6 = 0;
					int num7 = 0;
					int num8 = num4 * this;
					num8 += num7;
					bool[,] array = this.revealed;
					bool[,] array2 = this.revealed;
					int num9 = num4 * array2;
					num9 += num7;
					num++;
					num6++;
					num7++;
				}
				num2++;
				num4++;
			}
			return num;
		}

		// Token: 0x04000225 RID: 549
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000225")]
		public bool[,] revealed;

		// Token: 0x04000226 RID: 550
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000226")]
		public bool[,] flagged;

		// Token: 0x04000227 RID: 551
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000227")]
		public int[,] revealedNumbers;

		// Token: 0x04000228 RID: 552
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000228")]
		public int rows;

		// Token: 0x04000229 RID: 553
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000229")]
		public int cols;
	}
}
