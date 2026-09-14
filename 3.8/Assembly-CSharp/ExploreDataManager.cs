using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000773 RID: 1907
[Token(Token = "0x2000773")]
public class ExploreDataManager : MonoBehaviour
{
	// Token: 0x0600269F RID: 9887 RVA: 0x000CDF6C File Offset: 0x000CC16C
	[Token(Token = "0x600269F")]
	[Address(RVA = "0x5D8AF0", Offset = "0x5D70F0", VA = "0x1805D8AF0")]
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

	// Token: 0x060026A0 RID: 9888 RVA: 0x000CDFF8 File Offset: 0x000CC1F8
	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x5D8D20", Offset = "0x5D7320", VA = "0x1805D8D20")]
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
		int num3 = 0;
		instance.ShowText(text, 15f, num3 != 0);
		if (num2 != 0)
		{
		}
		if (0 != 0)
		{
			TypeCode typeCode = num.GetTypeCode();
			string text2;
			Debug.LogWarning(text2);
			InGameText instance2 = InGameText.Instance;
			int num4 = 0;
			instance2.ShowText(text2, 15f, num4 != 0);
			TypeCode typeCode2 = num2.GetTypeCode();
			string text3;
			Debug.LogWarning(text3);
			InGameText instance3 = InGameText.Instance;
			int num5 = 0;
			instance3.ShowText(text3, 15f, num5 != 0);
			return;
		}
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000CE104 File Offset: 0x000CC304
	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x5D8860", Offset = "0x5D6E60", VA = "0x1805D8860")]
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

	// Token: 0x060026A2 RID: 9890 RVA: 0x000CE19C File Offset: 0x000CC39C
	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x5D8810", Offset = "0x5D6E10", VA = "0x1805D8810")]
	public static LevelData GetExploreData(int level)
	{
		LevelData levelData;
		return levelData;
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000CE1AC File Offset: 0x000CC3AC
	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ExploreDataManager()
	{
	}

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x400143E")]
	public static Dictionary<PlantType, LevelData> levelDataDic = new Dictionary();
}
