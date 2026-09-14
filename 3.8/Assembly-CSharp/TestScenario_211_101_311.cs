using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public class TestScenario_211_101_311 : MonoBehaviour
{
	// Token: 0x060003E5 RID: 997 RVA: 0x0001343C File Offset: 0x0001163C
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x4C60B0", Offset = "0x4C46B0", VA = "0x1804C60B0")]
	[ContextMenu("测试 211-101-311 局面")]
	public void TestScenario()
	{
		Debug.Log("=== 测试局面：211, 101, 311 ===\n");
		Debug.Log("地雷分布（*=雷，.=安全）：");
		int num = 0;
		int num2 = 0;
		int num3;
		if (num3 > 0)
		{
			int num4 = 0;
			int num5 = 0;
			int num6;
			if (num6 > 0)
			{
				int num7 = num * num2;
				num7 += num5;
				string text = "" + " * ";
				num4++;
				num5++;
			}
			Debug.Log("");
			num2++;
			num2++;
		}
		Debug.Log("\n中心3x3的数字：");
		string text3;
		string text2 = "" + " " + text3 + " ";
		uint num8;
		num8 += (uint)1;
		while (num8 <= (uint)3)
		{
		}
		Debug.Log(text2);
		uint num9;
		num9 += (uint)1;
		while (num9 <= (uint)3)
		{
		}
		Debug.Log("\n从(2,2)开始测试求解...");
		bool flag;
		if (!flag)
		{
			Debug.Log("❌ 求解器判定：不可解");
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00013518 File Offset: 0x00011718
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x4C5F40", Offset = "0x4C4540", VA = "0x1804C5F40")]
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
			Debug.Log("");
			num++;
			num3++;
		}
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00013584 File Offset: 0x00011784
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x4C5E40", Offset = "0x4C4440", VA = "0x1804C5E40")]
	private void PrintCenterNumbers(bool[,] grid)
	{
		int num = this.CountMines(grid, 1, 1);
		string text2;
		string text = "" + " " + text2 + " ";
		while (1UL <= (ulong)3L)
		{
		}
		Debug.Log(text);
		while (1UL <= (ulong)3L)
		{
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x000135C8 File Offset: 0x000117C8
	[Token(Token = "0x60003E8")]
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

	// Token: 0x060003E9 RID: 1001 RVA: 0x0001364C File Offset: 0x0001184C
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TestScenario_211_101_311()
	{
	}
}
