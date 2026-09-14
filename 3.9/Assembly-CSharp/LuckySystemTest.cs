using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A41 RID: 2625
[Token(Token = "0x2000A41")]
public class LuckySystemTest : MonoBehaviour
{
	// Token: 0x060035DE RID: 13790 RVA: 0x0011E870 File Offset: 0x0011CA70
	[Token(Token = "0x60035DE")]
	[Address(RVA = "0x79A5A0", Offset = "0x798BA0", VA = "0x18079A5A0")]
	private void Start()
	{
		if (this.runOnStart)
		{
			this.RunAllTests();
			return;
		}
	}

	// Token: 0x060035DF RID: 13791 RVA: 0x0011E890 File Offset: 0x0011CA90
	[Token(Token = "0x60035DF")]
	[Address(RVA = "0x79AE50", Offset = "0x799450", VA = "0x18079AE50")]
	private void Update()
	{
		if (this.enableHotKeys)
		{
			if (Input.GetKeyDownInt(this.runTestKey))
			{
				this.RunAllTests();
			}
			if (Input.GetKeyDownInt(this.runSimulationKey))
			{
				this.RunMonteCarloSimulation();
				return;
			}
		}
	}

	// Token: 0x060035E0 RID: 13792 RVA: 0x0011E8D0 File Offset: 0x0011CAD0
	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x799D30", Offset = "0x798330", VA = "0x180799D30")]
	[ProButton]
	public void RunAllTests()
	{
		Debug.Log("========================================");
		Debug.Log("\ud83e\uddea Lucky系统测试开始");
		Debug.Log("========================================");
		this.TestQualityWeightsCalculation();
		this.TestProbabilityDistribution();
		this.PrintProbabilityTable();
		Debug.Log("========================================");
		Debug.Log("✅ 所有测试完成");
		Debug.Log("========================================");
	}

	// Token: 0x060035E1 RID: 13793 RVA: 0x0011E92C File Offset: 0x0011CB2C
	[Token(Token = "0x60035E1")]
	[Address(RVA = "0x79A8F0", Offset = "0x798EF0", VA = "0x18079A8F0")]
	private void TestQualityWeightsCalculation()
	{
		Debug.Log("\n\ud83d\udcca 测试1：品质权重计算");
		Debug.Log("-------------------------------------------");
		float[] array = new float[] { 0f, 0.5f, 1f, 1.5f, 2f };
		int num = 0;
		if (num < array.Length)
		{
			int num2 = 0;
			Dictionary<int, float> dictionary;
			float num3 = dictionary[num2];
			uint num5;
			float num4 = dictionary[num5];
			uint num7;
			float num6 = dictionary[num7];
			uint num9;
			float num8 = dictionary[num9];
			Debug.Log(string.Format("Lucky = {0:F1}:", dictionary));
			int num10 = 0;
			float num11 = dictionary[num10];
			float num12;
			float num13;
			string text = string.Format("  普通:   {0:F1} (50 × {1:F1})", num12, num13);
			Debug.Log(text);
			uint num15;
			float num14 = dictionary[num15];
			string text2 = string.Format("  银色:   {0:F1} (30 × {1:F1})", text, text);
			Debug.Log(text2);
			uint num17;
			float num16 = dictionary[num17];
			string text3 = string.Format("  金色:   {0:F1} (15 × {1:F1})", text2, text2);
			Debug.Log(text3);
			uint num19;
			float num18 = dictionary[num19];
			Debug.Log(string.Format("  钻石:   {0:F1} (5 × {1:F1})", text3, text3));
			float num20;
			Debug.Log(string.Format("  总权重: {0:F1}", num20));
			float num21;
			float num22;
			Debug.Log(string.Format("  校验:   总权重应该 = 100 + 150 × {0:F1} = {1:F1}", num21, num22));
			num++;
		}
	}

	// Token: 0x060035E2 RID: 13794 RVA: 0x0011EA5C File Offset: 0x0011CC5C
	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x79A5B0", Offset = "0x798BB0", VA = "0x18079A5B0")]
	private void TestProbabilityDistribution()
	{
		Debug.Log("\n\ud83d\udcc8 测试2：概率分布");
		Debug.Log("-------------------------------------------");
		float[] array = new float[] { 0f, 0.5f, 1f, 1.5f, 2f };
		int num = 0;
		if (num < array.Length)
		{
			ValueTuple<float, float, float, float> valueTuple;
			string text = string.Format("Lucky = {0:F1}:", valueTuple);
			Debug.Log(text);
			string text2 = string.Format("  普通概率: {0:F1}%", text);
			Debug.Log(text2);
			string text3 = string.Format("  银色概率: {0:F1}%", text2);
			Debug.Log(text3);
			string text4 = string.Format("  金色概率: {0:F1}%", text3);
			Debug.Log(text4);
			string text5 = string.Format("  钻石概率: {0:F1}%", text4);
			Debug.Log(text5);
			Debug.Log(string.Format("  总计:     {0:F1}% (应该=100%)", text5));
			num++;
		}
	}

	// Token: 0x060035E3 RID: 13795 RVA: 0x0011EB20 File Offset: 0x0011CD20
	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x799E10", Offset = "0x798410", VA = "0x180799E10")]
	[ContextMenu("运行蒙特卡洛模拟")]
	public void RunMonteCarloSimulation()
	{
		Debug.Log("\n\ud83c\udfb2 测试3：蒙特卡洛模拟");
		Debug.Log("-------------------------------------------");
		int num;
		Debug.Log(string.Format("模拟次数: {0}", num));
		float[] array = new float[] { 0f, 0.5f, 1f, 1.5f, 2f };
		int num2 = 0;
		if (num2 < array.Length)
		{
			ValueTuple<int, int, int, int, int, float, float, ValueTuple<float, float>> valueTuple;
			Debug.Log(string.Format("Lucky = {0:F1} (模拟{1}次):", valueTuple, valueTuple));
			int num3;
			float num4;
			Debug.Log(string.Format("  普通: {0} 次 ({1:F1}%)", num3, num4));
			int num5;
			float num6;
			Debug.Log(string.Format("  银色: {0} 次 ({1:F1}%)", num5, num6));
			int num7;
			float num8;
			Debug.Log(string.Format("  金色: {0} 次 ({1:F1}%)", num7, num8));
			int num9;
			float num10;
			Debug.Log(string.Format("  钻石: {0} 次 ({1:F1}%)", num9, num10));
			int num11;
			Debug.Log(string.Format("  总计: {0} 次", num11));
			num2++;
		}
	}

	// Token: 0x060035E4 RID: 13796 RVA: 0x0011EBEC File Offset: 0x0011CDEC
	[Token(Token = "0x60035E4")]
	[Address(RVA = "0x799990", Offset = "0x797F90", VA = "0x180799990")]
	private void PrintProbabilityTable()
	{
		Debug.Log("\n\ud83d\udccb 完整概率表格");
		Debug.Log("-------------------------------------------");
		Debug.Log("Lucky值 | 普通概率 | 银色概率 | 金色概率 | 钻石概率");
		object[] array = new object[5];
		float num;
		if (num != 0f)
		{
		}
		array[0] = num;
		if (num != 0f)
		{
		}
		array[1] = num;
		if (num != 0f)
		{
		}
		array[2] = num;
		if (num != 0f)
		{
		}
		array[3] = num;
		if (num != 0f)
		{
		}
		array[4] = num;
		Debug.Log(string.Format("{0:F2}    | {1:F1}%     | {2:F1}%     | {3:F1}%     | {4:F1}%", array));
	}

	// Token: 0x060035E5 RID: 13797 RVA: 0x0011EC88 File Offset: 0x0011CE88
	[Token(Token = "0x60035E5")]
	[Address(RVA = "0x799850", Offset = "0x797E50", VA = "0x180799850")]
	private Dictionary<int, float> CalculateQualityWeights(float lucky)
	{
		Dictionary<int, float> dictionary = new Dictionary();
		float num = lucky * this.系数1 * 50f;
		float num2 = lucky * this.系数2 * 30f;
		float num3 = lucky * this.系数3;
		float num4 = lucky * this.系数4;
		return dictionary;
	}

	// Token: 0x060035E6 RID: 13798 RVA: 0x0011ECE4 File Offset: 0x0011CEE4
	[Token(Token = "0x60035E6")]
	[Address(RVA = "0x799680", Offset = "0x797C80", VA = "0x180799680")]
	private ValueTuple<float, float, float, float> CalculateProbabilities(float lucky)
	{
		int num = 0;
		Dictionary<int, float> dictionary;
		float num2 = dictionary[num];
		float num3 = dictionary[1];
		float num4 = dictionary[2];
		float num5 = dictionary[3];
		int num6 = 0;
		float num7 = dictionary[num6];
		num2 = dictionary[1];
		num4 = dictionary[2];
		float num8 = dictionary[3];
		throw new NullReferenceException();
	}

	// Token: 0x060035E7 RID: 13799 RVA: 0x0011ED50 File Offset: 0x0011CF50
	[Token(Token = "0x60035E7")]
	[Address(RVA = "0x79A250", Offset = "0x798850", VA = "0x18079A250")]
	private ValueTuple<int, int, int, int, int, float, float, ValueTuple<float, float>> SimulateRandomQuality(float lucky, int count)
	{
		int num = 0;
		Dictionary<int, float> dictionary;
		float num2 = dictionary[num];
		uint num4;
		float num3 = dictionary[num4];
		uint num6;
		float num5 = dictionary[num6];
		uint num8;
		float num7 = dictionary[num8];
		int num9 = 0;
		uint num10;
		global::System.Random random = new global::System.Random((int)num10);
		double num11 = random.NextDouble();
		int num12 = 0;
		int num13 = 0;
		num5 = dictionary[num13];
		if (num5 <= (float)num12)
		{
			uint num15;
			float num14 = dictionary[num15];
			if (num5 <= (float)num12)
			{
				uint num17;
				float num16 = dictionary[num17];
				if (num5 <= (float)num12)
				{
					uint num18;
					if (dictionary[num18] <= num12)
					{
						goto IL_0099;
					}
					num9++;
				}
				num9++;
			}
			num9++;
		}
		num9++;
		IL_0099:
		num9++;
		throw new NullReferenceException();
	}

	// Token: 0x060035E8 RID: 13800 RVA: 0x0011EE10 File Offset: 0x0011D010
	[Token(Token = "0x60035E8")]
	[Address(RVA = "0x79AEA0", Offset = "0x7994A0", VA = "0x18079AEA0")]
	[ContextMenu("验证 Lucky=1.0")]
	public void VerifyLuckyOnePointZero()
	{
		Debug.Log("\n\ud83d\udd0d 验证 Lucky = 1.0");
		Debug.Log("-------------------------------------------");
		Debug.Log("权重计算:");
		float num;
		float num2;
		Debug.Log(string.Format("  普通:   50 × (1 + {0}) = {1}", num, num2));
		float num3;
		float num4;
		Debug.Log(string.Format("  银色:   30 × (1 + {0}) = {1}", num3, num4));
		float num5;
		float num6;
		Debug.Log(string.Format("  金色:   15 × (1 + {0}) = {1}", num5, num6));
		float num7;
		float num8;
		Debug.Log(string.Format("  钻石:   5 × (1 + {0}) = {1}", num7, num8));
		float num9;
		Debug.Log(string.Format("  总权重: {0}", num9));
		Debug.Log("\n概率计算:");
		float num10;
		float num11;
		float num12;
		Debug.Log(string.Format("  普通概率: {0} / {1} × 100 = {2:F1}%", num10, num11, num12));
		float num13;
		float num14;
		float num15;
		Debug.Log(string.Format("  银色概率: {0} / {1} × 100 = {2:F1}%", num13, num14, num15));
		float num16;
		float num17;
		float num18;
		Debug.Log(string.Format("  金色概率: {0} / {1} × 100 = {2:F1}%", num16, num17, num18));
		float num19;
		float num20;
		float num21;
		Debug.Log(string.Format("  钻石概率: {0} / {1} × 100 = {2:F1}%", num19, num20, num21));
		Debug.Log("\n✅ 验证:");
		float num22;
		float num23;
		float num24;
		Debug.Log(string.Format("  金色权重 / 钻石权重 = {0} / {1} = {2:F1}", num22, num23, num24));
		float num25;
		float num26;
		float num27;
		Debug.Log(string.Format("  金色概率 / 钻石概率 = {0:F1}% / {1:F1}% = {2:F1}", num25, num26, num27));
		Debug.Log("  结论: 金色权重和概率都是钻石的3倍 ✅");
	}

	// Token: 0x060035E9 RID: 13801 RVA: 0x0011EF34 File Offset: 0x0011D134
	[Token(Token = "0x60035E9")]
	[Address(RVA = "0x79B440", Offset = "0x799A40", VA = "0x18079B440")]
	public LuckySystemTest()
	{
	}

	// Token: 0x04002954 RID: 10580
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002954")]
	[SerializeField]
	[Header("测试设置")]
	private bool runOnStart;

	// Token: 0x04002955 RID: 10581
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002955")]
	[SerializeField]
	private int simulationCount = (int)((ulong)10000L);

	// Token: 0x04002956 RID: 10582
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002956")]
	[SerializeField]
	[Header("快捷键测试")]
	private bool enableHotKeys = true;

	// Token: 0x04002957 RID: 10583
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002957")]
	[SerializeField]
	private KeyCode runTestKey = (KeyCode)((ulong)116L);

	// Token: 0x04002958 RID: 10584
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002958")]
	[SerializeField]
	private KeyCode runSimulationKey = (KeyCode)((ulong)121L);

	// Token: 0x04002959 RID: 10585
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4002959")]
	public float 系数1;

	// Token: 0x0400295A RID: 10586
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400295A")]
	public float 系数2;

	// Token: 0x0400295B RID: 10587
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400295B")]
	public float 系数3;

	// Token: 0x0400295C RID: 10588
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400295C")]
	public float 系数4;
}
