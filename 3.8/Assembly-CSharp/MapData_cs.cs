using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.Scene;
using UnityEngine;

// Token: 0x020009B2 RID: 2482
[Token(Token = "0x20009B2")]
public static class MapData_cs
{
	// Token: 0x060032D3 RID: 13011 RVA: 0x0010DCFC File Offset: 0x0010BEFC
	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x703660", Offset = "0x701C60", VA = "0x180703660")]
	public static GameObject GetMap(SceneType sceneType, Board board)
	{
		Dictionary<SceneType, GameObject> backgroundPrefabs = GameAPP.resourcesManager.backgroundPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Transform transform = board.transform;
		GameObject gameObject;
		return gameObject;
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x0010DD2C File Offset: 0x0010BF2C
	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x703ED0", Offset = "0x7024D0", VA = "0x180703ED0")]
	public static SceneType GetTravelSceneType(int round)
	{
		if (round <= 3)
		{
			return SceneType.Day;
		}
		if (round <= 6)
		{
			return SceneType.Day;
		}
		if (round <= 9)
		{
			return SceneType.Day;
		}
		if (round <= 12)
		{
			return SceneType.Day;
		}
		if (round > 15)
		{
			bool flag = round > 18;
			return SceneType.Day;
		}
		return SceneType.Day;
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x0010DD98 File Offset: 0x0010BF98
	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x7038B0", Offset = "0x701EB0", VA = "0x1807038B0")]
	public static SceneType GetRandomTravelSceneType()
	{
		List<SceneType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		return list[num];
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x0010DE24 File Offset: 0x0010C024
	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x703810", Offset = "0x701E10", VA = "0x180703810")]
	public static SceneType GetRandomTravelSceneType(int level)
	{
		SurvivalData survivalData = SaveInfo.Instance.GetSurvivalData(level, -1);
		if (survivalData == 0)
		{
			return MapData_cs.GetRandomTravelSceneType();
		}
		return survivalData.boardData.sceneType;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x0010DE5C File Offset: 0x0010C05C
	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x703CA0", Offset = "0x7022A0", VA = "0x180703CA0")]
	public static SceneType GetRogueSceneType(CampType campType, int level, int round)
	{
		if (level == -1 || SaveInfo.Instance.GetSurvivalData(level, -1) != 0)
		{
		}
		if (campType == CampType.Land)
		{
			if (round > 5)
			{
				return SceneType.Snow_6;
			}
		}
		else if (campType == CampType.Water)
		{
			return SceneType.SnowPool;
		}
		return SceneType.Day_6;
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x0010DEA4 File Offset: 0x0010C0A4
	[Token(Token = "0x60032D8")]
	[Address(RVA = "0x703F20", Offset = "0x702520", VA = "0x180703F20")]
	public static void SceneSettings(Board board, SceneType sceneType)
	{
		for (;;)
		{
			int num = 0;
			uint num2;
			uint num3;
			board.gridSystem.UpdateGrid((int)num2, (int)num3);
			board.boardTag.isRoof = num != 0;
			board.boardTag.isNight = num != 0;
			bool flag;
			if (!flag)
			{
				if (sceneType - SceneType.Night > 39)
				{
					break;
				}
				int num4 = sceneType - SceneType.Night;
				board.theSun = (int)((ulong)150L);
				board.boardTag.isNight = true;
				board.rowNum = (int)((ulong)6L);
				BoxType[] roadType = board.roadType;
				BoxType[] roadType2 = board.roadType;
				int columnCount = board.gridSystem.ColumnCount;
				if (num >= columnCount)
				{
					break;
				}
				uint num5;
				board.gridSystem.GetGrid(num, (int)num5).boxType = (BoxType)((ulong)1L);
				uint num6;
				board.gridSystem.GetGrid(num, (int)num6).boxType = (BoxType)((ulong)1L);
				num++;
				if (board.gridSystem.GetEnumerator() != 0)
				{
				}
				if ("{il2cpp array field local28->}" != (ulong)0L)
				{
				}
				if (num == 0)
				{
					int num7;
					if (num >= num7)
					{
						break;
					}
					BoardGrid boardGrid;
					boardGrid.boxType = (BoxType)((ulong)1L);
					BoardGrid boardGrid2;
					boardGrid2.boxType = (BoxType)((ulong)1L);
					BoardGrid boardGrid3;
					boardGrid3.boxType = (BoxType)((ulong)1L);
					BoardGrid boardGrid4;
					boardGrid4.boxType = (BoxType)((ulong)1L);
					num++;
					if (boardGrid4 != 0)
					{
						boardGrid4.boxType = (BoxType)((ulong)3L);
					}
					if ("{il2cpp array field local48->}" != (ulong)0L)
					{
					}
					if (num == 0)
					{
						if (boardGrid4 != 0)
						{
							boardGrid4.boxType = (BoxType)((ulong)3L);
						}
						if ("{il2cpp array field local54->}" != (ulong)0L)
						{
						}
						if (num == 0)
						{
							break;
						}
					}
				}
			}
		}
		GridSystem gridSystem = board.gridSystem;
		int rowNum = board.rowNum;
		int columnNum = board.columnNum;
		gridSystem.UpdateGrid(columnNum, rowNum);
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x0010E5E4 File Offset: 0x0010C7E4
	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x703D90", Offset = "0x702390", VA = "0x180703D90")]
	public static string GetSceneName(SceneType sceneType)
	{
		Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
		bool flag;
		if (!flag)
		{
			Type typeFromHandle = typeof(SceneType);
			return Enum.GetName(typeFromHandle, typeFromHandle);
		}
		throw new NullReferenceException();
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x0010E61C File Offset: 0x0010C81C
	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x705680", Offset = "0x703C80", VA = "0x180705680")]
	static MapData_cs()
	{
		ulong num2;
		do
		{
			MapData_cs.SnowMaps = new HashSet();
			Dictionary<SceneType, string> dictionary = new Dictionary();
			int num = 0;
			dictionary.Add(num, "白天");
			MapData_cs.SceneName = dictionary;
			MapData_cs.OldToNewMap = new Dictionary();
			Dictionary<SceneType, GameScene> scenes = SceneManager.scenes;
			bool flag;
			if (flag)
			{
				Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060032DB RID: 13019 RVA: 0x0010E688 File Offset: 0x0010C888
	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x703770", Offset = "0x701D70", VA = "0x180703770")]
	public static SceneType GetNewSceneTypeFromOld(SceneType sceneType)
	{
		Dictionary<SceneType, SceneType> oldToNewMap = MapData_cs.OldToNewMap;
		throw new NullReferenceException();
	}

	// Token: 0x04002484 RID: 9348
	[Token(Token = "0x4002484")]
	public static HashSet<SceneType> SnowMaps;

	// Token: 0x04002485 RID: 9349
	[Token(Token = "0x4002485")]
	public static readonly Dictionary<SceneType, string> SceneName;

	// Token: 0x04002486 RID: 9350
	[Token(Token = "0x4002486")]
	private static readonly Dictionary<SceneType, SceneType> OldToNewMap;
}
