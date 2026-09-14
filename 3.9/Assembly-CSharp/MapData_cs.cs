using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.Scene;
using UnityEngine;

// Token: 0x020009EE RID: 2542
[Token(Token = "0x20009EE")]
public static class MapData_cs
{
	// Token: 0x06003407 RID: 13319 RVA: 0x00112D14 File Offset: 0x00110F14
	[Token(Token = "0x6003407")]
	[Address(RVA = "0x768B70", Offset = "0x767170", VA = "0x180768B70")]
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

	// Token: 0x06003408 RID: 13320 RVA: 0x00112D44 File Offset: 0x00110F44
	[Token(Token = "0x6003408")]
	[Address(RVA = "0x7693E0", Offset = "0x7679E0", VA = "0x1807693E0")]
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

	// Token: 0x06003409 RID: 13321 RVA: 0x00112DB0 File Offset: 0x00110FB0
	[Token(Token = "0x6003409")]
	[Address(RVA = "0x768DC0", Offset = "0x7673C0", VA = "0x180768DC0")]
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

	// Token: 0x0600340A RID: 13322 RVA: 0x00112E3C File Offset: 0x0011103C
	[Token(Token = "0x600340A")]
	[Address(RVA = "0x768D20", Offset = "0x767320", VA = "0x180768D20")]
	public static SceneType GetRandomTravelSceneType(int level)
	{
		SurvivalData survivalData = SaveInfo.Instance.GetSurvivalData(level, -1);
		if (survivalData == 0)
		{
			return MapData_cs.GetRandomTravelSceneType();
		}
		return survivalData.boardData.sceneType;
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x00112E74 File Offset: 0x00111074
	[Token(Token = "0x600340B")]
	[Address(RVA = "0x7691B0", Offset = "0x7677B0", VA = "0x1807691B0")]
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

	// Token: 0x0600340C RID: 13324 RVA: 0x00112EBC File Offset: 0x001110BC
	[Token(Token = "0x600340C")]
	[Address(RVA = "0x769430", Offset = "0x767A30", VA = "0x180769430")]
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
					num++;
					BoardGrid boardGrid4;
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

	// Token: 0x0600340D RID: 13325 RVA: 0x001135F4 File Offset: 0x001117F4
	[Token(Token = "0x600340D")]
	[Address(RVA = "0x7692A0", Offset = "0x7678A0", VA = "0x1807692A0")]
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

	// Token: 0x0600340E RID: 13326 RVA: 0x0011362C File Offset: 0x0011182C
	[Token(Token = "0x600340E")]
	[Address(RVA = "0x76AB90", Offset = "0x769190", VA = "0x18076AB90")]
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

	// Token: 0x0600340F RID: 13327 RVA: 0x00113698 File Offset: 0x00111898
	[Token(Token = "0x600340F")]
	[Address(RVA = "0x768C80", Offset = "0x767280", VA = "0x180768C80")]
	public static SceneType GetNewSceneTypeFromOld(SceneType sceneType)
	{
		Dictionary<SceneType, SceneType> oldToNewMap = MapData_cs.OldToNewMap;
		throw new NullReferenceException();
	}

	// Token: 0x04002596 RID: 9622
	[Token(Token = "0x4002596")]
	public static HashSet<SceneType> SnowMaps;

	// Token: 0x04002597 RID: 9623
	[Token(Token = "0x4002597")]
	public static readonly Dictionary<SceneType, string> SceneName;

	// Token: 0x04002598 RID: 9624
	[Token(Token = "0x4002598")]
	private static readonly Dictionary<SceneType, SceneType> OldToNewMap;
}
