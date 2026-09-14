using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007AC RID: 1964
[Token(Token = "0x20007AC")]
public class ExploreDataManager : MonoBehaviour
{
	// Token: 0x060027CE RID: 10190 RVA: 0x000D2FD8 File Offset: 0x000D11D8
	[Token(Token = "0x60027CE")]
	[Address(RVA = "0x63B9E0", Offset = "0x639FE0", VA = "0x18063B9E0")]
	public static void LoadData()
	{
		ExploreDataManager.levelDataDic.Clear();
		string text = Path.Combine(SaveInfo.GetDataPath(), "LevelData/Explore");
		bool flag = Directory.Exists(text);
		int num = 0;
		if (flag)
		{
			string[] files = Directory.GetFiles(text);
			if (files.Length != num && num < files.Length)
			{
				string text2;
				string text3;
				ExploreDataManager.LoadFile(text2, text3);
				num++;
			}
		}
		TextAsset[] array = Resources.LoadAll<TextAsset>("LevelData/Explore");
		if (num < array.Length)
		{
			string text4;
			ExploreDataManager.LoadFile(text4, text4);
			num++;
		}
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x000D3064 File Offset: 0x000D1264
	[Token(Token = "0x60027CF")]
	[Address(RVA = "0x63BC10", Offset = "0x63A210", VA = "0x18063BC10")]
	private static void LoadFile(string fileName, string jsonData)
	{
		int num = 0;
		LevelData levelData = JsonUtility.FromJson<LevelData>(jsonData);
		Dictionary<PlantType, LevelData> dictionary = ExploreDataManager.levelDataDic;
		PlantType level = levelData.level;
		if (!dictionary.ContainsKey(level))
		{
			Dictionary<PlantType, LevelData> dictionary2 = ExploreDataManager.levelDataDic;
			PlantType level2 = levelData.level;
			dictionary2.Add(level2, levelData);
		}
		string text;
		Debug.LogWarning(text);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		if (num2 != 0)
		{
		}
		if (0 != 0)
		{
			TypeCode typeCode = num.GetTypeCode();
			string text2;
			Debug.LogWarning(text2);
			InGameText instance2 = InGameText.Instance;
			TypeCode typeCode2 = num2.GetTypeCode();
			string text3;
			Debug.LogWarning(text3);
			InGameText instance3 = InGameText.Instance;
			return;
		}
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000D3134 File Offset: 0x000D1334
	[Token(Token = "0x60027D0")]
	[Address(RVA = "0x63B750", Offset = "0x639D50", VA = "0x18063B750")]
	public static LevelData GetLevelData(PlantType thePlantType)
	{
		Dictionary<PlantType, LevelData> dictionary = ExploreDataManager.levelDataDic;
		bool flag;
		if (!flag)
		{
			LevelData levelData = new LevelData();
			List<ZombieType> list = new List();
			levelData.zombiesToAppear = list;
			List<PrePlantData> list2 = new List();
			levelData.prePlant = list2;
			List<PlantType> list3 = new List();
			levelData.usePlant = list3;
			levelData.level = thePlantType;
			levelData.maxWave = (int)((ulong)10L);
			List<ZombieType> list4 = new List();
			int size = list4._size;
			levelData.zombiesToAppear = list4;
			levelData.gloveCD = 10f;
			return levelData;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000D31CC File Offset: 0x000D13CC
	[Token(Token = "0x60027D1")]
	[Address(RVA = "0x63B700", Offset = "0x639D00", VA = "0x18063B700")]
	public static LevelData GetExploreData(int level)
	{
		LevelData levelData;
		return levelData;
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000D31DC File Offset: 0x000D13DC
	[Token(Token = "0x60027D2")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ExploreDataManager()
	{
	}

	// Token: 0x0400151A RID: 5402
	[Token(Token = "0x400151A")]
	public static Dictionary<PlantType, LevelData> levelDataDic = new Dictionary();
}
