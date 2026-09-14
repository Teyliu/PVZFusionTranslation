using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D5 RID: 213
[Token(Token = "0x20000D5")]
public class MinesweeperSolverTest : MonoBehaviour
{
	// Token: 0x060003EE RID: 1006 RVA: 0x00013240 File Offset: 0x00011440
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x4F9890", Offset = "0x4F7E90", VA = "0x1804F9890")]
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

	// Token: 0x060003EF RID: 1007 RVA: 0x00013274 File Offset: 0x00011474
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x4F9810", Offset = "0x4F7E10", VA = "0x1804F9810")]
	[ContextMenu("运行所有测试")]
	public void RunTests()
	{
		Debug.Log("=== 扫雷求解器测试开始 ===\n");
		this.Test_211_101_311_5x5();
		Debug.Log("\n=== 扫雷求解器测试结束 ===");
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x0001329C File Offset: 0x0001149C
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x4F9B50", Offset = "0x4F8150", VA = "0x1804F9B50")]
	private void Test_211_101_311_5x5()
	{
		Debug.Log("测试 1: 211, 101, 311 局面 (5x5地图)");
		bool[,] array = this.CreateGrid1();
		bool[,] array2 = this.CreateGrid2();
		Debug.Log("分布3的地雷网格：");
		this.TestGrid("分布1", array);
		this.TestGrid("分布2", array2);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x000132EC File Offset: 0x000114EC
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x4F90B0", Offset = "0x4F76B0", VA = "0x1804F90B0")]
	private bool[,] CreateGrid1()
	{
		Debug.Log("分布1的地雷网格：");
		return "分布1的地雷网格：";
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00013310 File Offset: 0x00011510
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x4F92C0", Offset = "0x4F78C0", VA = "0x1804F92C0")]
	private bool[,] CreateGrid2()
	{
		Debug.Log("分布2的地雷网格：");
		return "分布2的地雷网格：";
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00013334 File Offset: 0x00011534
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x4F9480", Offset = "0x4F7A80", VA = "0x1804F9480")]
	private bool[,] CreateGrid3()
	{
		Debug.Log("分布3的地雷网格：");
		return "分布3的地雷网格：";
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00013358 File Offset: 0x00011558
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x4F99F0", Offset = "0x4F7FF0", VA = "0x1804F99F0")]
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

	// Token: 0x060003F5 RID: 1013 RVA: 0x000133AC File Offset: 0x000115AC
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x4F9D90", Offset = "0x4F8390", VA = "0x1804F9D90")]
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

	// Token: 0x060003F6 RID: 1014 RVA: 0x0001342C File Offset: 0x0001162C
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x4F95D0", Offset = "0x4F7BD0", VA = "0x1804F95D0")]
	private int GetExpectedNumber(int r, int c)
	{
		return r;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00013444 File Offset: 0x00011644
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x4F8F90", Offset = "0x4F7590", VA = "0x1804F8F90")]
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

	// Token: 0x060003F8 RID: 1016 RVA: 0x000134C8 File Offset: 0x000116C8
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x4F9690", Offset = "0x4F7C90", VA = "0x1804F9690")]
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

	// Token: 0x060003F9 RID: 1017 RVA: 0x00013544 File Offset: 0x00011744
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x4F9920", Offset = "0x4F7F20", VA = "0x1804F9920")]
	[ContextMenu("测试自定义网格")]
	public void TestCustomGrid()
	{
		Debug.Log("测试自定义网格：");
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x0001355C File Offset: 0x0001175C
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x4F9FA0", Offset = "0x4F85A0", VA = "0x1804F9FA0")]
	public MinesweeperSolverTest()
	{
		ulong num;
		this.firstClick = num;
		this.autoTestOnStart = true;
		base..ctor();
	}

	// Token: 0x0400022A RID: 554
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400022A")]
	[Tooltip("是否在启动时自动运行测试")]
	[Header("测试配置")]
	public bool autoTestOnStart;

	// Token: 0x0400022B RID: 555
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400022B")]
	[Tooltip("测试首次点击位置（行，列）")]
	public Vector2Int firstClick;
}
