using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class MinesweeperSolverTest : MonoBehaviour
{
	// Token: 0x060003D3 RID: 979 RVA: 0x00012EB4 File Offset: 0x000110B4
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x4BA1D0", Offset = "0x4B87D0", VA = "0x1804BA1D0")]
	private void Start()
	{
		if (this.autoTestOnStart)
		{
			Debug.Log("=== 扫雷求解器测试开始 ===\n");
			this.Test_211_101_311_5x5();
			Debug.Log("\n=== 扫雷求解器测试结束 ===");
			return;
		}
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00012EE8 File Offset: 0x000110E8
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x4BA150", Offset = "0x4B8750", VA = "0x1804BA150")]
	[ContextMenu("运行所有测试")]
	public void RunTests()
	{
		Debug.Log("=== 扫雷求解器测试开始 ===\n");
		this.Test_211_101_311_5x5();
		Debug.Log("\n=== 扫雷求解器测试结束 ===");
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00012F10 File Offset: 0x00011110
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x4BA490", Offset = "0x4B8A90", VA = "0x1804BA490")]
	private void Test_211_101_311_5x5()
	{
		Debug.Log("测试 1: 211, 101, 311 局面 (5x5地图)");
		bool[,] array = this.CreateGrid1();
		bool[,] array2 = this.CreateGrid2();
		Debug.Log("分布3的地雷网格：");
		this.TestGrid("分布1", array);
		this.TestGrid("分布2", array2);
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00012F60 File Offset: 0x00011160
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x4B99F0", Offset = "0x4B7FF0", VA = "0x1804B99F0")]
	private bool[,] CreateGrid1()
	{
		Debug.Log("分布1的地雷网格：");
		return "分布1的地雷网格：";
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00012F84 File Offset: 0x00011184
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x4B9C00", Offset = "0x4B8200", VA = "0x1804B9C00")]
	private bool[,] CreateGrid2()
	{
		Debug.Log("分布2的地雷网格：");
		return "分布2的地雷网格：";
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00012FA8 File Offset: 0x000111A8
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x4B9DC0", Offset = "0x4B83C0", VA = "0x1804B9DC0")]
	private bool[,] CreateGrid3()
	{
		Debug.Log("分布3的地雷网格：");
		return "分布3的地雷网格：";
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00012FCC File Offset: 0x000111CC
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x4BA330", Offset = "0x4B8930", VA = "0x1804BA330")]
	private void TestGrid(string name, bool[,] grid)
	{
		Debug.Log("\n--- 测试 " + name + " ---");
		Debug.Log("验证中心3x3区域的数字：");
		this.VerifyCenterNumbers(grid);
		if (!MinesweeperSolver.IsSolvable(grid, 1, 1))
		{
		}
		Debug.Log("✅ " + name + ": 求解器判定为【可解】");
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00013020 File Offset: 0x00011220
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x4BA6D0", Offset = "0x4B8CD0", VA = "0x1804BA6D0")]
	private void VerifyCenterNumbers(bool[,] grid)
	{
		int num = 0;
		int num2 = this.CountMines(grid, num, num);
		string text2;
		string text = "" + text2 + " ";
		int expectedNumber = this.GetExpectedNumber(num, num);
		num++;
		string text3 = text + "\n";
		num++;
		Debug.Log("实际数字：\n" + text3);
		if (num == 0)
		{
			Debug.Log("⚠\ufe0f 不匹配目标：211, 101, 311");
			return;
		}
		Debug.Log("✅ 匹配目标：211, 101, 311");
	}

	// Token: 0x060003DB RID: 987 RVA: 0x000130A0 File Offset: 0x000112A0
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x4B9F10", Offset = "0x4B8510", VA = "0x1804B9F10")]
	private int GetExpectedNumber(int r, int c)
	{
		return r;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000130B8 File Offset: 0x000112B8
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x4B98D0", Offset = "0x4B7ED0", VA = "0x1804B98D0")]
	private int CountMines(bool[,] grid, int row, int col)
	{
		int num = 0;
		int i = row - 1;
		int num2 = row + 1;
		int num3 = col - 1;
		int j = col + 1;
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
		j++;
		while (j <= col)
		{
		}
		i++;
		i++;
		while (i <= num5)
		{
		}
		return num;
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0001313C File Offset: 0x0001133C
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x4B9FD0", Offset = "0x4B85D0", VA = "0x1804B9FD0")]
	private void PrintGrid(bool[,] grid)
	{
		int num = 0;
		int num2;
		if (num2 > 0)
		{
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6;
			if (num6 > 0)
			{
				int num7 = num6 * num3;
				num7 += num5;
				string text = "" + " * ";
				num4++;
				num5++;
			}
			string text2 = "" + "\n";
			num++;
			num3++;
		}
		Debug.Log("");
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000131B8 File Offset: 0x000113B8
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x4BA260", Offset = "0x4B8860", VA = "0x1804BA260")]
	[ContextMenu("测试自定义网格")]
	public void TestCustomGrid()
	{
		Debug.Log("测试自定义网格：");
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000131D0 File Offset: 0x000113D0
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x4BA8E0", Offset = "0x4B8EE0", VA = "0x1804BA8E0")]
	public MinesweeperSolverTest()
	{
		ulong num;
		this.firstClick = num;
		this.autoTestOnStart = true;
		base..ctor();
	}

	// Token: 0x0400021D RID: 541
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400021D")]
	[Tooltip("是否在启动时自动运行测试")]
	[Header("测试配置")]
	public bool autoTestOnStart;

	// Token: 0x0400021E RID: 542
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400021E")]
	[Tooltip("测试首次点击位置（行，列）")]
	public Vector2Int firstClick;
}
