using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D7 RID: 215
[Token(Token = "0x20000D7")]
public class TestScenario_211_101_311 : MonoBehaviour
{
	// Token: 0x06000400 RID: 1024 RVA: 0x000137C8 File Offset: 0x000119C8
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x505EC0", Offset = "0x5044C0", VA = "0x180505EC0")]
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

	// Token: 0x06000401 RID: 1025 RVA: 0x000138A4 File Offset: 0x00011AA4
	[Token(Token = "0x6000401")]
	[Address(RVA = "0x505D50", Offset = "0x504350", VA = "0x180505D50")]
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

	// Token: 0x06000402 RID: 1026 RVA: 0x00013910 File Offset: 0x00011B10
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x505C50", Offset = "0x504250", VA = "0x180505C50")]
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

	// Token: 0x06000403 RID: 1027 RVA: 0x00013954 File Offset: 0x00011B54
	[Token(Token = "0x6000403")]
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

	// Token: 0x06000404 RID: 1028 RVA: 0x000139D8 File Offset: 0x00011BD8
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TestScenario_211_101_311()
	{
	}
}
