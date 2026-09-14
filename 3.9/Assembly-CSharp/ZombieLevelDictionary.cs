using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A3B RID: 2619
[Token(Token = "0x2000A3B")]
public static class ZombieLevelDictionary
{
	// Token: 0x060035C7 RID: 13767 RVA: 0x0011DDA8 File Offset: 0x0011BFA8
	[Token(Token = "0x60035C7")]
	[Address(RVA = "0x7B0F90", Offset = "0x7AF590", VA = "0x1807B0F90")]
	public static Dictionary<int, int> GetZombieLevelProbability(int level)
	{
		if (!ZombieLevelDictionary.ZombieLevelConfigs.ContainsKey(level))
		{
			return ZombieLevelDictionary.ZombieLevelConfigs[15];
		}
		return ZombieLevelDictionary.ZombieLevelConfigs[level];
	}

	// Token: 0x060035C8 RID: 13768 RVA: 0x0011DDE4 File Offset: 0x0011BFE4
	[Token(Token = "0x60035C8")]
	[Address(RVA = "0x7B0AB0", Offset = "0x7AF0B0", VA = "0x1807B0AB0")]
	public static Dictionary<int, int> GetZombieLevelProbabilitySmart(int level)
	{
		Dictionary<int, int> dictionary;
		Dictionary<int, int> dictionary2;
		ulong num3;
		do
		{
			uint num2;
			int num = Math.Min(level, (int)num2);
			dictionary = ZombieLevelDictionary.ZombieLevelConfigs[num];
			dictionary2 = new Dictionary();
			if (level <= 15)
			{
				goto IL_0084;
			}
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
		Func<KeyValuePair<int, int>, bool> func;
		if (ZombieLevelDictionary.<>c.<>9__2_0 == 0)
		{
			func = delegate(KeyValuePair<int, int> x)
			{
				bool flag2;
				return flag2;
			};
			ZombieLevelDictionary.<>c.<>9__2_0 = func;
		}
		IEnumerable<KeyValuePair<int, int>> enumerable = Enumerable.Where<KeyValuePair<int, int>>(dictionary2, func);
		Func<KeyValuePair<int, int>, int> func2;
		if (ZombieLevelDictionary.<>c.<>9__2_1 == 0)
		{
			ZombieLevelDictionary.<>c.<>9__2_1 = func2;
		}
		Func<KeyValuePair<int, int>, int> func3;
		if (ZombieLevelDictionary.<>c.<>9__2_2 == 0)
		{
			ZombieLevelDictionary.<>c.<>9__2_2 = func3;
		}
		return Enumerable.ToDictionary<KeyValuePair<int, int>, int, int>(enumerable, func2, func3);
		IL_0084:
		Dictionary<int, int> dictionary3 = new Dictionary(dictionary);
		throw new NullReferenceException();
	}

	// Token: 0x060035C9 RID: 13769 RVA: 0x0011DE94 File Offset: 0x0011C094
	[Token(Token = "0x60035C9")]
	[Address(RVA = "0x7B0470", Offset = "0x7AEA70", VA = "0x1807B0470")]
	public static int GetRandomZombieLevel(int gameLevel)
	{
		Dictionary<int, int> dictionary;
		for (;;)
		{
			int num = 0;
			if (!ZombieLevelDictionary.ZombieLevelConfigs.ContainsKey(gameLevel))
			{
				Dictionary<int, Dictionary<int, int>> zombieLevelConfigs = ZombieLevelDictionary.ZombieLevelConfigs;
			}
			dictionary = ZombieLevelDictionary.ZombieLevelConfigs[gameLevel];
			int num2 = Enumerable.Sum(dictionary.Values);
			if (num2 > 0)
			{
				int i = global::UnityEngine.Random.Range(0, num2);
				Func<KeyValuePair<int, int>, int> func;
				if (ZombieLevelDictionary.<>c.<>9__3_1 == 0)
				{
					ZombieLevelDictionary.<>c.<>9__3_1 = func;
				}
				IOrderedEnumerable<KeyValuePair<int, int>> orderedEnumerable = Enumerable.OrderBy<KeyValuePair<int, int>, int>(dictionary, func);
				if (num >= func)
				{
					goto IL_0069;
				}
				num += num;
				if (num != func)
				{
					num++;
					goto IL_0069;
				}
				goto IL_008D;
				IL_0095:
				num += 312;
				if (num == 0)
				{
					break;
				}
				continue;
				IL_0069:
				if (num < typeof(IEnumerable<KeyValuePair<int, int>>).TypeHandle)
				{
					num += num;
					num++;
				}
				if (num < num)
				{
					num += num;
					if (num == 0)
					{
						goto IL_0095;
					}
					num++;
				}
				while (i >= num)
				{
				}
				IL_008D:
				num += 312;
				goto IL_0095;
			}
			goto IL_00CA;
		}
		Dictionary<int, int>.KeyCollection keys = dictionary.Keys;
		Func<int, int> func2;
		if (ZombieLevelDictionary.<>c.<>9__3_0 == 0)
		{
			ZombieLevelDictionary.<>c.<>9__3_0 = func2;
		}
		return Enumerable.FirstOrDefault<int>(Enumerable.OrderBy<int, int>(keys, func2));
		IL_00CA:
		throw new NullReferenceException();
	}

	// Token: 0x060035CA RID: 13770 RVA: 0x0011DF80 File Offset: 0x0011C180
	[Token(Token = "0x60035CA")]
	[Address(RVA = "0x7B10A0", Offset = "0x7AF6A0", VA = "0x1807B10A0")]
	public static bool ValidateProbabilityConfigs()
	{
		ulong num2;
		do
		{
			Dictionary<int, Dictionary<int, int>> zombieLevelConfigs = ZombieLevelDictionary.ZombieLevelConfigs;
			bool flag;
			if (flag)
			{
				Dictionary.ValueCollection valueCollection;
				int num = Enumerable.Sum(valueCollection);
				while (num == 100)
				{
				}
				Debug.LogWarning(string.Format("等级 {0} 的概率配置总和为 {1}%，不是100%", num, num));
			}
		}
		while (num2 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060035CB RID: 13771 RVA: 0x0011DFD8 File Offset: 0x0011C1D8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x7B1310", Offset = "0x7AF910", VA = "0x1807B1310")]
	static ZombieLevelDictionary()
	{
		Dictionary<int, Dictionary<int, int>> dictionary = new Dictionary();
		Dictionary<int, int> dictionary2 = new Dictionary();
		dictionary2.Add(1, 100);
		int num = 0;
		dictionary.Add(num, dictionary2);
		dictionary.Add(1, new Dictionary
		{
			{ 1, 80 },
			{ 2, 18 },
			{ 3, 2 }
		});
		dictionary.Add(2, new Dictionary
		{
			{ 1, 55 },
			{ 2, 35 },
			{ 3, 9 },
			{ 4, 1 }
		});
		dictionary.Add(3, new Dictionary
		{
			{ 1, 30 },
			{ 2, 45 },
			{ 3, 20 },
			{ 4, 4 },
			{ 5, 1 }
		});
		Dictionary<int, int> dictionary3 = new Dictionary();
		dictionary3.Add(1, 15);
		dictionary3.Add(2, 35);
		dictionary3.Add(3, 35);
		dictionary3.Add(4, 12);
		dictionary3.Add(5, 3);
		int num2 = 0;
		dictionary3.Add(6, num2);
		dictionary.Add(4, dictionary3);
		dictionary.Add(5, new Dictionary
		{
			{ 1, 5 },
			{ 2, 25 },
			{ 3, 40 },
			{ 4, 22 },
			{ 5, 6 },
			{ 6, 2 }
		});
		Dictionary<int, int> dictionary4 = new Dictionary();
		int num3 = 0;
		dictionary4.Add(1, num3);
		dictionary4.Add(2, 15);
		dictionary4.Add(3, 35);
		dictionary4.Add(4, 30);
		dictionary4.Add(5, 15);
		dictionary4.Add(6, 5);
		dictionary.Add(6, dictionary4);
		Dictionary<int, int> dictionary5 = new Dictionary();
		int num4 = 0;
		dictionary5.Add(1, num4);
		dictionary5.Add(2, 8);
		dictionary5.Add(3, 25);
		dictionary5.Add(4, 35);
		dictionary5.Add(5, 20);
		dictionary5.Add(6, 10);
		dictionary5.Add(7, 2);
		dictionary.Add(7, dictionary5);
		Dictionary<int, int> dictionary6 = new Dictionary();
		int num5 = 0;
		dictionary6.Add(1, num5);
		dictionary6.Add(2, 3);
		dictionary6.Add(3, 15);
		dictionary6.Add(4, 40);
		dictionary6.Add(5, 25);
		dictionary6.Add(6, 12);
		dictionary6.Add(7, 4);
		dictionary6.Add(8, 1);
		dictionary.Add(8, dictionary6);
		Dictionary<int, int> dictionary7 = new Dictionary();
		int num6 = 0;
		dictionary7.Add(1, num6);
		dictionary7.Add(2, 1);
		dictionary7.Add(3, 8);
		dictionary7.Add(4, 30);
		dictionary7.Add(5, 35);
		dictionary7.Add(6, 18);
		dictionary7.Add(7, 6);
		dictionary7.Add(8, 2);
		dictionary.Add(9, dictionary7);
		Dictionary<int, int> dictionary8 = new Dictionary();
		int num7 = 0;
		dictionary8.Add(1, num7);
		int num8 = 0;
		dictionary8.Add(2, num8);
		dictionary8.Add(3, 5);
		dictionary8.Add(4, 20);
		dictionary8.Add(5, 35);
		dictionary8.Add(6, 25);
		dictionary8.Add(7, 10);
		dictionary8.Add(8, 4);
		dictionary8.Add(9, 1);
		dictionary.Add(10, dictionary8);
		Dictionary<int, int> dictionary9 = new Dictionary();
		int num9 = 0;
		dictionary9.Add(1, num9);
		int num10 = 0;
		dictionary9.Add(2, num10);
		dictionary9.Add(3, 3);
		dictionary9.Add(4, 15);
		dictionary9.Add(5, 30);
		dictionary9.Add(6, 30);
		dictionary9.Add(7, 15);
		dictionary9.Add(8, 5);
		dictionary9.Add(9, 2);
		dictionary.Add(11, dictionary9);
		Dictionary<int, int> dictionary10 = new Dictionary();
		int num11 = 0;
		dictionary10.Add(1, num11);
		int num12 = 0;
		dictionary10.Add(2, num12);
		dictionary10.Add(3, 1);
		dictionary10.Add(4, 10);
		dictionary10.Add(5, 25);
		dictionary10.Add(6, 35);
		dictionary10.Add(7, 18);
		dictionary10.Add(8, 7);
		dictionary10.Add(9, 3);
		dictionary10.Add(10, 1);
		dictionary.Add(12, dictionary10);
		Dictionary<int, int> dictionary11 = new Dictionary();
		int num13 = 0;
		dictionary11.Add(1, num13);
		int num14 = 0;
		dictionary11.Add(2, num14);
		int num15 = 0;
		dictionary11.Add(3, num15);
		dictionary11.Add(4, 6);
		dictionary11.Add(5, 20);
		dictionary11.Add(6, 40);
		dictionary11.Add(7, 20);
		dictionary11.Add(8, 10);
		dictionary11.Add(9, 3);
		dictionary11.Add(10, 1);
		dictionary.Add(13, dictionary11);
		Dictionary<int, int> dictionary12 = new Dictionary();
		int num16 = 0;
		dictionary12.Add(1, num16);
		int num17 = 0;
		dictionary12.Add(2, num17);
		int num18 = 0;
		dictionary12.Add(3, num18);
		dictionary12.Add(4, 3);
		dictionary12.Add(5, 15);
		dictionary12.Add(6, 35);
		dictionary12.Add(7, 30);
		dictionary12.Add(8, 12);
		dictionary12.Add(9, 4);
		dictionary12.Add(10, 1);
		dictionary.Add(14, dictionary12);
		Dictionary<int, int> dictionary13 = new Dictionary();
		int num19 = 0;
		dictionary13.Add(1, num19);
		int num20 = 0;
		dictionary13.Add(2, num20);
		int num21 = 0;
		dictionary13.Add(3, num21);
		dictionary13.Add(4, 1);
		dictionary13.Add(5, 10);
		dictionary13.Add(6, 30);
		dictionary13.Add(7, 35);
		dictionary13.Add(8, 15);
		dictionary13.Add(9, 6);
		dictionary13.Add(10, 2);
		dictionary13.Add(11, 1);
		dictionary.Add(15, dictionary13);
		ZombieLevelDictionary.ZombieLevelConfigs = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04002941 RID: 10561
	[Token(Token = "0x4002941")]
	public static Dictionary<int, Dictionary<int, int>> ZombieLevelConfigs;
}
