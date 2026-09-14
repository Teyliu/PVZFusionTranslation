using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
public class TestScenario_2111_1001_1123 : MonoBehaviour
{
	// Token: 0x060003FB RID: 1019 RVA: 0x00013580 File Offset: 0x00011780
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x505790", Offset = "0x503D90", VA = "0x180505790")]
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

	// Token: 0x060003FC RID: 1020 RVA: 0x00013680 File Offset: 0x00011880
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x505620", Offset = "0x503C20", VA = "0x180505620")]
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

	// Token: 0x060003FD RID: 1021 RVA: 0x000136EC File Offset: 0x000118EC
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x505520", Offset = "0x503B20", VA = "0x180505520")]
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

	// Token: 0x060003FE RID: 1022 RVA: 0x00013730 File Offset: 0x00011930
	[Token(Token = "0x60003FE")]
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

	// Token: 0x060003FF RID: 1023 RVA: 0x000137B4 File Offset: 0x000119B4
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TestScenario_2111_1001_1123()
	{
	}
}
