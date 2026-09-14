using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class TestScenario_2111_1001_1123 : MonoBehaviour
{
	// Token: 0x060003E0 RID: 992 RVA: 0x000131F4 File Offset: 0x000113F4
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x4C5980", Offset = "0x4C3F80", VA = "0x1804C5980")]
	[ContextMenu("测试 2111-1001-1123 局面")]
	public void TestScenario()
	{
		Debug.Log("=== 测试局面：2111, 1001, 1123 ===\n");
		Debug.Log("这个局面有两个0，理论上会让周围12个格子都安全\n");
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
		Debug.Log("\n中心3x4区域的数字：");
		string text3;
		string text2 = "" + " " + text3 + " ";
		uint num8;
		num8 += (uint)1;
		while (num8 <= (uint)4)
		{
		}
		Debug.Log(text2);
		uint num9;
		num9 += (uint)1;
		while (num9 <= (uint)3)
		{
		}
		Debug.Log("\n从(1,1)开始测试求解...");
		bool flag;
		if (!flag)
		{
		}
		Debug.Log("✅ 求解器判定：可解");
		Debug.Log("\n从(1,2)开始测试求解...");
		bool flag2;
		if (!flag2)
		{
			Debug.Log("❌ 求解器判定：不可解");
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000132F4 File Offset: 0x000114F4
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x4C5810", Offset = "0x4C3E10", VA = "0x1804C5810")]
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

	// Token: 0x060003E2 RID: 994 RVA: 0x00013360 File Offset: 0x00011560
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x4C5710", Offset = "0x4C3D10", VA = "0x1804C5710")]
	private void PrintCenterNumbers(bool[,] grid)
	{
		int num = this.CountMines(grid, 1, 1);
		string text2;
		string text = "" + " " + text2 + " ";
		while (1UL <= (ulong)4L)
		{
		}
		Debug.Log(text);
		while (1UL <= (ulong)3L)
		{
		}
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x000133A4 File Offset: 0x000115A4
	[Token(Token = "0x60003E3")]
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

	// Token: 0x060003E4 RID: 996 RVA: 0x00013428 File Offset: 0x00011628
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TestScenario_2111_1001_1123()
	{
	}
}
