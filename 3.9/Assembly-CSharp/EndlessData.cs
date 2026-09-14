using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009B5 RID: 2485
[Token(Token = "0x20009B5")]
public class EndlessData : MonoBehaviour
{
	// Token: 0x06003333 RID: 13107 RVA: 0x0010C530 File Offset: 0x0010A730
	[Token(Token = "0x6003333")]
	[Address(RVA = "0x7497D0", Offset = "0x747DD0", VA = "0x1807497D0")]
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

	// Token: 0x06003334 RID: 13108 RVA: 0x0010C58C File Offset: 0x0010A78C
	[Token(Token = "0x6003334")]
	[Address(RVA = "0x749530", Offset = "0x747B30", VA = "0x180749530")]
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

	// Token: 0x06003335 RID: 13109 RVA: 0x0010C640 File Offset: 0x0010A840
	[Token(Token = "0x6003335")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public EndlessData()
	{
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x0010C654 File Offset: 0x0010A854
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003336")]
	[Address(RVA = "0x749A20", Offset = "0x748020", VA = "0x180749A20")]
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
		dictionary.Add((uint)91, 4);
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
		dictionary.Add((uint)88, 5);
		dictionary.Add((uint)82, 5);
		dictionary.Add((uint)81, 5);
		dictionary.Add((uint)87, 5);
		dictionary.Add((uint)126, 5);
		dictionary.Add((uint)80, 5);
		dictionary.Add((uint)52, 5);
		dictionary.Add((uint)75, 5);
		dictionary.Add((uint)40, 6);
		dictionary.Add((uint)104, 6);
		dictionary.Add((uint)15, 6);
		dictionary.Add((uint)70, 6);
		EndlessData.SandZombiePool = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04001DF0 RID: 7664
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001DF0")]
	public int round;

	// Token: 0x04001DF1 RID: 7665
	[Token(Token = "0x4001DF1")]
	public static readonly Dictionary<ZombieType, int> SandZombiePool;
}
