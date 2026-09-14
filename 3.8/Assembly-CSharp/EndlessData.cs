using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000979 RID: 2425
[Token(Token = "0x2000979")]
public class EndlessData : MonoBehaviour
{
	// Token: 0x060031FF RID: 12799 RVA: 0x001077B0 File Offset: 0x001059B0
	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x6E4410", Offset = "0x6E2A10", VA = "0x1806E4410")]
	[ProButton]
	public void Test()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<ZombieType> sandZombieTypes = EndlessData.GetSandZombieTypes(this.round);
			bool flag;
			if (flag)
			{
				int num2 = EndlessData.SandZombiePool[num];
				string text = string.Format("\n等级：{0}", num2);
				string text2;
				Debug.Log(text2 + text);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x0010780C File Offset: 0x00105A0C
	[Token(Token = "0x6003200")]
	[Address(RVA = "0x6E4170", Offset = "0x6E2770", VA = "0x1806E4170")]
	public static List<ZombieType> GetSandZombieTypes(int round)
	{
		List<ZombieType> list = new List();
		int num = round - 1;
		num += 2;
		uint num2;
		int maxLevel = (int)num2;
		Dictionary<ZombieType, int> sandZombiePool = EndlessData.SandZombiePool;
		Func<KeyValuePair<ZombieType, int>, bool> func = delegate(KeyValuePair<ZombieType, int> a)
		{
			int maxLevel2 = maxLevel;
			bool flag;
			return flag;
		};
		List<KeyValuePair<ZombieType, int>> list2 = Enumerable.ToList<KeyValuePair<ZombieType, int>>(Enumerable.Where<KeyValuePair<ZombieType, int>>(sandZombiePool, func));
		uint num4;
		uint num3 = num4 - 1U;
		if (num4 > (uint)0)
		{
			int num5 = list2._size;
			int num6 = global::UnityEngine.Random.Range(0, num5);
			num5 = num6;
			KeyValuePair<ZombieType, int> keyValuePair = list2[num5];
			int size = list2._size;
			num6 = global::UnityEngine.Random.Range(0, size);
			KeyValuePair<ZombieType, int> keyValuePair2 = list2[num6];
			list2.RemoveAt(num6);
		}
		return list;
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x001078C0 File Offset: 0x00105AC0
	[Token(Token = "0x6003201")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public EndlessData()
	{
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x001078D4 File Offset: 0x00105AD4
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003202")]
	[Address(RVA = "0x6E4660", Offset = "0x6E2C60", VA = "0x1806E4660")]
	static EndlessData()
	{
		Dictionary<ZombieType, int> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, 1);
		dictionary.Add(2, 2);
		dictionary.Add((uint)3, 2);
		dictionary.Add((uint)5, 2);
		dictionary.Add((uint)8, 2);
		dictionary.Add((uint)25, 2);
		dictionary.Add((uint)20, 2);
		dictionary.Add((uint)4, 3);
		dictionary.Add((uint)6, 3);
		dictionary.Add((uint)59, 3);
		dictionary.Add((uint)68, 3);
		dictionary.Add((uint)28, 3);
		dictionary.Add((uint)67, 3);
		dictionary.Add((uint)58, 3);
		dictionary.Add((uint)33, 3);
		dictionary.Add((uint)106, 4);
		dictionary.Add((uint)9, 4);
		dictionary.Add((uint)10, 4);
		dictionary.Add((uint)16, 4);
		dictionary.Add((uint)18, 4);
		dictionary.Add((uint)17, 4);
		dictionary.Add((uint)19, 4);
		dictionary.Add((uint)24, 4);
		dictionary.Add((uint)32, 4);
		dictionary.Add((uint)35, 4);
		dictionary.Add((uint)123, 4);
		dictionary.Add((uint)38, 4);
		dictionary.Add((uint)31, 4);
		dictionary.Add((uint)45, 4);
		dictionary.Add((uint)61, 4);
		dictionary.Add((uint)66, 4);
		dictionary.Add((uint)64, 4);
		dictionary.Add((uint)114, 4);
		dictionary.Add((uint)72, 4);
		dictionary.Add((uint)89, 4);
		dictionary.Add((uint)71, 5);
		dictionary.Add((uint)14, 5);
		dictionary.Add((uint)27, 5);
		dictionary.Add((uint)109, 5);
		dictionary.Add((uint)21, 5);
		dictionary.Add((uint)29, 5);
		dictionary.Add((uint)119, 5);
		dictionary.Add((uint)112, 5);
		dictionary.Add((uint)36, 5);
		dictionary.Add((uint)122, 5);
		dictionary.Add((uint)124, 5);
		dictionary.Add((uint)39, 5);
		dictionary.Add((uint)63, 5);
		dictionary.Add((uint)30, 5);
		dictionary.Add((uint)34, 5);
		dictionary.Add((uint)26, 5);
		dictionary.Add((uint)76, 5);
		dictionary.Add((uint)77, 5);
		dictionary.Add((uint)90, 5);
		dictionary.Add((uint)40, 6);
		dictionary.Add((uint)104, 6);
		dictionary.Add((uint)15, 6);
		dictionary.Add((uint)70, 6);
		EndlessData.SandZombiePool = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04001D00 RID: 7424
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001D00")]
	public int round;

	// Token: 0x04001D01 RID: 7425
	[Token(Token = "0x4001D01")]
	public static readonly Dictionary<ZombieType, int> SandZombiePool;
}
