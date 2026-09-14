using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;
using UnityEngine;
using ZenGarden;

// Token: 0x02000A37 RID: 2615
[Token(Token = "0x2000A37")]
public class UIMgr : MonoBehaviour
{
	// Token: 0x0600359E RID: 13726 RVA: 0x0011C9E0 File Offset: 0x0011ABE0
	[Token(Token = "0x600359E")]
	[Address(RVA = "0x7ABA20", Offset = "0x7AA020", VA = "0x1807ABA20")]
	public static void EnterGame(LevelType levelType, int levelNumber, int id = -1, [Optional] string name)
	{
		Board board;
		for (;;)
		{
			int num = 0;
			SynergyManager.Instance.ClearAllSynergies();
			EventManager.ClearAllEvents();
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
			uimanager.Pop();
			Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
			CamaraFollowMouse.Instance.ResetCamera();
			Time.timeScale = GameAPP.config.gameSpeed;
			GameAPP.theBoardType = levelType;
			GameAPP.theBoardLevel = levelNumber;
			RogueManager.Instance.Clear();
			if (levelType == LevelType.Challenge)
			{
				if (levelNumber == 63)
				{
					break;
				}
			}
			else if (levelType == LevelType.IZ)
			{
				return;
			}
			bool flag;
			if (flag)
			{
				return;
			}
			GameObject gameObject = new GameObject("Board");
			GameAPP.board = gameObject;
			board = gameObject.AddComponent<Board>();
			bool flag2;
			uint num3;
			if (!flag2)
			{
				if (levelType == LevelType.Survival)
				{
					if (GameAPP.theBoardLevel == 31)
					{
					}
					uint num2;
					if (num2 == (uint)32)
					{
						goto Block_5;
					}
					int sceneType = (int)board.sceneType;
					GameObject gameObject2;
					board.ChangeMap(gameObject2);
				}
				if (num3 == (uint)9)
				{
					GameObject gameObject3 = Resources.Load<GameObject>(TowerData.GetTowerMap(levelNumber));
					Transform transform = board.transform;
					GameObject gameObject4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, transform);
					board.ChangeMap(gameObject4);
				}
			}
			int sceneType2 = (int)board.sceneType;
			GameObject gameObject5;
			board.ChangeMap(gameObject5);
			if (num3 != (uint)1 || levelNumber != 105)
			{
				return;
			}
			TravelMgr instance = TravelMgr.Instance;
			int num4 = 0;
			List<AdvBuff> advancedBuffPool = instance.GetAdvancedBuffPool(num4 != 0);
			bool flag3;
			if (flag3)
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)num);
			}
			ulong num5;
			if (num5 == (ulong)0L)
			{
				goto Block_11;
			}
		}
		GameAPP instance2 = GameAPP.Instance;
		GameObject gameObject6 = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Zuma/Background/Background"));
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Time.timeScale = GameAPP.config.gameSpeed;
		return;
		Block_5:
		uint num6;
		GameObject gameObject7 = Resources.Load<GameObject>(TowerData.GetTowerMap((int)num6));
		Transform transform2 = board.transform;
		GameObject gameObject8 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject7, transform2);
		board.ChangeMap(gameObject8);
		Board.Instance.theCurrentSurvivalRound = (int)((ulong)1L);
		SaveInfo instance3 = SaveInfo.Instance;
		SurvivalData survivalData;
		if (survivalData == 0 || survivalData.boardData.isBoardSaved)
		{
		}
		Board instance4 = Board.Instance;
		board.savedID = 0;
		EndlessShooting endlessShooting = board.AddComponent<EndlessShooting>();
		GameAPP instance5 = GameAPP.Instance;
		InitBoard initBoard = board.AddComponent<InitBoard>();
		return;
		Block_11:
		UltiBuff[] enumValues = global::Core.Lawnf.GetEnumValues<UltiBuff>();
		int num7 = 0;
		int num8 = 0;
		if (num8 < enumValues.Length)
		{
			TravelMgr instance6 = TravelMgr.Instance;
			num7++;
		}
		TravelDebuff[] enumValues2 = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
		int num9 = 0;
		int num10 = 0;
		if (num10 < enumValues2.Length)
		{
			if (enumValues != (ulong)1000L)
			{
				TravelMgr instance7 = TravelMgr.Instance;
			}
			num9++;
		}
		uint num11;
		board.AddLightLevel((int)num11);
		List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x0011CC84 File Offset: 0x0011AE84
	[Token(Token = "0x600359F")]
	[Address(RVA = "0x7ADAA0", Offset = "0x7AC0A0", VA = "0x1807ADAA0")]
	public static void EnterTravelGame(LevelType levelType, int levelNumber)
	{
		uint num;
		SurvivalData survivalData = SaveInfo.Instance.GetSurvivalData(levelNumber, (int)num);
		if (survivalData != 0 && survivalData.boardData.isBoardSaved)
		{
			if (global::Lawnf.RogueLevel())
			{
				RogueManager.Instance.LoadData(survivalData);
			}
			int theCurrentSurvivalRound = survivalData.boardData.theCurrentSurvivalRound;
			TravelMgr.Instance.data.temp_round = theCurrentSurvivalRound;
			TravelMgr instance = TravelMgr.Instance;
			TravelData travelData = survivalData.travelData;
			TravelData data = instance.data;
			ZombieType routeBossType = travelData.routeBossType;
			data.routeBossType = routeBossType;
			TravelMgr instance2 = TravelMgr.Instance;
			TravelData travelData2 = survivalData.travelData;
			TravelData data2 = instance2.data;
			TravelProcess travelProcess = travelData2.travelProcess;
			data2.travelProcess = travelProcess;
		}
		if (TravelMgr.Instance.data.routeBossType == ZombieType.NormalZombie)
		{
			TravelData data3 = TravelMgr.Instance.data;
			ZombieType routeBossType2 = TravelMenu.Config.routeBossType;
			data3.routeBossType = routeBossType2;
			TravelData data4 = TravelMgr.Instance.data;
			TravelDifficulty travelDifficulty = TravelMenu.Config.travelDifficulty;
			data4.travelDifficulty = travelDifficulty;
			TravelData data5 = TravelMgr.Instance.data;
			TravelProcess travelProcess2 = TravelMenu.Config.travelProcess;
			data5.travelProcess = travelProcess2;
		}
		TravelMgr instance3 = TravelMgr.Instance;
		Dictionary<ZombieType, TravelPackage> travelPackages = TravelDictionary.travelPackages;
		ZombieType routeBossType3 = TravelMgr.Instance.data.routeBossType;
		TravelPackage travelPackage = travelPackages[routeBossType3];
		instance3.TravelPackage = travelPackage;
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP instance4 = GameAPP.Instance;
		GameAPP.theBoardType = levelType;
		GameAPP.theBoardLevel = levelNumber;
		GameObject gameObject = new GameObject("Board");
		GameAPP.board = gameObject;
		Board board = gameObject.AddComponent<Board>();
		uint num2;
		if (levelNumber != 40)
		{
			if (levelNumber != 12)
			{
				if (TravelMgr.Instance.data.travelProcess != TravelProcess.Fast)
				{
					SceneType travelSceneType = MapData_cs.GetTravelSceneType((int)num2);
					RogueManager instance5 = RogueManager.Instance;
					if (num2 == (uint)1)
					{
						CampType campType = instance5.campType;
					}
					if (num2 == (uint)1)
					{
						SceneType randomTravelSceneType = MapData_cs.GetRandomTravelSceneType();
					}
					SceneType randomTravelSceneType2 = MapData_cs.GetRandomTravelSceneType(levelNumber);
				}
				SceneType sceneType;
				board.sceneType = sceneType;
				if (TravelMgr.Instance.data.routeBossType != ZombieType.UltimateImpKing)
				{
					goto IL_025E;
				}
				int sceneType2 = (int)board.sceneType;
				SceneType sceneType3;
				board.sceneType = sceneType3;
			}
			TravelMgr instance6 = TravelMgr.Instance;
		}
		IL_025E:
		int sceneType4 = (int)board.sceneType;
		GameObject gameObject2;
		board.ChangeMap(gameObject2);
		SceneType sceneType5 = board.sceneType;
		MapData_cs.SceneSettings(board, sceneType5);
		RogueManager.Instance.InitLevel(board);
		if (num2 == (uint)1)
		{
			board.theCurrentSurvivalRound = (int)num2;
		}
		uint num3;
		SaveMgr.LoadBoard(levelNumber, (int)num3);
		SceneType sceneType6 = board.sceneType;
		InitBoard initBoard = gameObject.AddComponent<InitBoard>();
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x0011CF50 File Offset: 0x0011B150
	[Token(Token = "0x60035A0")]
	[Address(RVA = "0x7AE5A0", Offset = "0x7ACBA0", VA = "0x1807AE5A0")]
	public static SceneType GetSceneType(LevelType theLevelType, int theLevelNumber)
	{
		uint num;
		if (theLevelType <= LevelType.StarAdvanture && typeof(TreasureData).TypeHandle <= (ulong)35L && num <= (uint)174)
		{
			int levelSceneType = (int)TreasureData.levelSceneType;
			uint num2;
			if (num2 <= (uint)31)
			{
				global::LevelData levelData;
				int sceneType = (int)levelData.sceneType;
				ulong num3;
				num3 += num3;
				if (num3 == (ulong)1L)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x0011CFB0 File Offset: 0x0011B1B0
	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x7ACA50", Offset = "0x7AB050", VA = "0x1807ACA50")]
	public static void EnterIZGame(int levelNumber, [Optional] string name, SceneType sceneType = SceneType.IZDay)
	{
		int num = 0;
		EventManager.ClearAllEvents();
		CamaraFollowMouse.Instance.ResetCamera();
		GameAPP instance = GameAPP.Instance;
		GameAPP.theBoardLevel = levelNumber;
		GameAPP.theIZLevelName = name;
		RogueManager.Instance.Clear();
		GameObject gameObject = new GameObject("Board");
		GameAPP.board = gameObject;
		Board board = gameObject.AddComponent<Board>();
		board.boardTag.isIZ = true;
		if (levelNumber == 27)
		{
			int num2 = 0;
			IZData customIZData = InGameUI_IZ.GetCustomIZData();
			if (InGameUI_IZ.GetCustomIZData(num2) == 0)
			{
			}
		}
		if (levelNumber > 12)
		{
		}
		if (LevelManager.TryGetLevelData(num))
		{
		}
		UIResourcesLoader uimanager = GameAPP.UIManager;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		int num3;
		board.sceneType = (SceneType)num3;
		GameObject gameObject2;
		board.ChangeMap(gameObject2);
		GameAPP.theGameStatus = (GameStatus)num;
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x0011D06C File Offset: 0x0011B26C
	[Token(Token = "0x60035A2")]
	[Address(RVA = "0x7AD220", Offset = "0x7AB820", VA = "0x1807AD220")]
	public static void EnterMainMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		CamaraFollowMouse.Instance.ResetCamera();
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP instance = GameAPP.Instance;
		int num = 0;
		instance.PlayMusic((MusicType)num);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		InGameText.Instance.TimeOver();
		Transform canvas = GameAPP.canvas;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform transform = canvas.transform;
		int num3 = 0;
		int num4 = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)num4, transform, num3 != 0);
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x0011D128 File Offset: 0x0011B328
	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x7AAE70", Offset = "0x7A9470", VA = "0x1807AAE70")]
	public static void BackToMenu()
	{
		InGameText.Instance.TimeOver();
		if (GameAPP.theBoardType <= LevelType.TowerLevel)
		{
		}
		UIMgr.EnterChallengeMenu();
	}

	// Token: 0x060035A4 RID: 13732 RVA: 0x0011D214 File Offset: 0x0011B414
	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x7AB750", Offset = "0x7A9D50", VA = "0x1807AB750")]
	public static void EnterChallengeMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)6), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x0011D268 File Offset: 0x0011B468
	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x7AB840", Offset = "0x7A9E40", VA = "0x1807AB840")]
	public static void EnterClassicTravel()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)15), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x0011D2C0 File Offset: 0x0011B4C0
	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x7AD8C0", Offset = "0x7ABEC0", VA = "0x1807AD8C0")]
	public static void EnterTravelAdv()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)12), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x0011D318 File Offset: 0x0011B518
	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x7AE270", Offset = "0x7AC870", VA = "0x1807AE270")]
	public static void EnterTravelGame()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)13), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035A8 RID: 13736 RVA: 0x0011D370 File Offset: 0x0011B570
	[Token(Token = "0x60035A8")]
	[Address(RVA = "0x7AD9B0", Offset = "0x7ABFB0", VA = "0x1807AD9B0")]
	public static void EnterTravelChallenge()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)14), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035A9 RID: 13737 RVA: 0x0011D3C8 File Offset: 0x0011B5C8
	[Token(Token = "0x60035A9")]
	[Address(RVA = "0x7AE360", Offset = "0x7AC960", VA = "0x1807AE360")]
	public static void EnterTreasureMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)44), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035AA RID: 13738 RVA: 0x0011D420 File Offset: 0x0011B620
	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x7AD7D0", Offset = "0x7ABDD0", VA = "0x1807AD7D0")]
	public static void EnterTowerMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)42), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035AB RID: 13739 RVA: 0x0011D478 File Offset: 0x0011B678
	[Token(Token = "0x60035AB")]
	[Address(RVA = "0x7ACE20", Offset = "0x7AB420", VA = "0x1807ACE20")]
	public static void EnterIZMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)7), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x0011D4CC File Offset: 0x0011B6CC
	[Token(Token = "0x60035AC")]
	[Address(RVA = "0x7AD6E0", Offset = "0x7ABCE0", VA = "0x1807AD6E0")]
	public static void EnterSurvivalEMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)9), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x0011D524 File Offset: 0x0011B724
	[Token(Token = "0x60035AD")]
	[Address(RVA = "0x7AEB50", Offset = "0x7AD150", VA = "0x1807AEB50")]
	public static void MenuNormalSettings()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP instance = GameAPP.Instance;
		CamaraFollowMouse.Instance.ResetCamera();
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x0011D558 File Offset: 0x0011B758
	[Token(Token = "0x60035AE")]
	[Address(RVA = "0x7AD620", Offset = "0x7ABC20", VA = "0x1807AD620")]
	public static void EnterPauseMenu()
	{
		GameAPP.PlaySound(30, 0.5f, 1f);
		Time.timeScale = (float)0;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)16), canvasUp, num != 0);
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x0011D5A0 File Offset: 0x0011B7A0
	[Token(Token = "0x60035AF")]
	[Address(RVA = "0x7AB2F0", Offset = "0x7A98F0", VA = "0x1807AB2F0")]
	public static void EVEAuto(int road)
	{
		int num2;
		do
		{
			GameObject gameObject = new GameObject("Board");
			GameAPP.board = gameObject;
			Board board = gameObject.AddComponent<Board>();
			board.boardTag.isIZ = true;
			GameObject gameObject2;
			board.ChangeMap(gameObject2);
			board.sceneType = (SceneType)((ulong)25L);
			board.isEveStarted = true;
			board.isEveStart = true;
			uint num;
			board.AddLightLevel((int)num);
			num2 = 0;
			GameAPP.theGameStatus = (GameStatus)num2;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
			uimanager.Pop();
			Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
			UIResourcesLoader uimanager2 = GameAPP.UIManager;
			UIResourcesLoader uimanager3 = GameAPP.UIManager;
			IZBottomMenu.Instance.EveMode();
			EveManager.Instance.LoadPlants();
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
		EveManager.Instance.SetPlant();
		EveManager.Instance.AutoGame();
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x0011D684 File Offset: 0x0011B884
	[Token(Token = "0x60035B0")]
	[Address(RVA = "0x7AAC80", Offset = "0x7A9280", VA = "0x1807AAC80")]
	public static void BackToGame()
	{
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP.music.UnPause();
		GameAPP.musicDrum.UnPause();
		GameAPP.prelude.audioSource.UnPause();
		InGameUI instance = InGameUI.Instance;
		int num = 0;
		if (instance != num)
		{
			InGameUI.Instance.LowerUI();
			return;
		}
	}

	// Token: 0x060035B1 RID: 13745 RVA: 0x0011D700 File Offset: 0x0011B900
	[Token(Token = "0x60035B1")]
	[Address(RVA = "0x7ACF10", Offset = "0x7AB510", VA = "0x1807ACF10")]
	public static void EnterLoseMenu(string reason = "")
	{
		Board.Instance.boardStatistics.GameOver((GameResult)((uint)2));
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		int num = 0;
		GameAPP.theGameStatus = (GameStatus)((uint)1);
		Time.timeScale = (float)num;
		GameAPP.music.Pause();
		GameAPP.musicDrum.Pause();
		GameAPP.prelude.audioSource.Pause();
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num2 = 0;
		if (uimanager2.Push((UIType)((uint)2), canvasUp, num2 != 0) != 0)
		{
		}
		if (!string.IsNullOrEmpty(reason))
		{
		}
		GameAPP.PlaySound(52, 0.5f, 1f);
		Mouse instance = Mouse.Instance;
		int num3 = 0;
		if (instance != num3)
		{
			global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
		}
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x0011D7D8 File Offset: 0x0011B9D8
	[Token(Token = "0x60035B2")]
	[Address(RVA = "0x7AC8D0", Offset = "0x7AAED0", VA = "0x1807AC8D0")]
	public static void EnterHelpMenu()
	{
		Transform transform = Camera.main.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Background/Thanks"));
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x0011D814 File Offset: 0x0011BA14
	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x7AD550", Offset = "0x7ABB50", VA = "0x1807AD550")]
	public static OtherMenu EnterOtherMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		if (uimanager.Push((UIType)((uint)3), canvas, num != 0) != 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060035B4 RID: 13748 RVA: 0x0011D848 File Offset: 0x0011BA48
	[Token(Token = "0x60035B4")]
	[Address(RVA = "0x7AD4D0", Offset = "0x7ABAD0", VA = "0x1807AD4D0")]
	public static void EnterOptionMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)4), canvasUp, num != 0);
	}

	// Token: 0x060035B5 RID: 13749 RVA: 0x0011D878 File Offset: 0x0011BA78
	[Token(Token = "0x60035B5")]
	[Address(RVA = "0x7AB930", Offset = "0x7A9F30", VA = "0x1807AB930")]
	public static void EnterExploreMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvas = GameAPP.canvas;
		int num = 0;
		BaseMenu baseMenu = uimanager2.Push((UIType)((uint)10), canvas, num != 0);
		UIMgr.MenuNormalSettings();
	}

	// Token: 0x060035B6 RID: 13750 RVA: 0x0011D8D0 File Offset: 0x0011BAD0
	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x7AB6D0", Offset = "0x7A9CD0", VA = "0x1807AB6D0")]
	public static void EnterAlmanac()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)55), canvasUp, num != 0);
	}

	// Token: 0x060035B7 RID: 13751 RVA: 0x0011D900 File Offset: 0x0011BB00
	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x7AC5A0", Offset = "0x7AABA0", VA = "0x1807AC5A0")]
	public static void EnterGarden()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Stack<List<BaseMenu>> menuStack = uimanager.menuStack;
		uimanager.Pop();
		Stack<List<BaseMenu>> menuStack2 = uimanager.menuStack;
		CamaraFollowMouse.Instance.ResetCamera();
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP.theIZLevelName = 0;
		GameAPP instance = GameAPP.Instance;
		global::UnityEngine.Object.Instantiate<GardenBackground>(Resources.Load<GardenBackground>("Garden/Garden")).name = "Garden";
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		throw new NullReferenceException();
	}

	// Token: 0x060035B8 RID: 13752 RVA: 0x0011D974 File Offset: 0x0011BB74
	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x7AE450", Offset = "0x7ACA50", VA = "0x1807AE450")]
	public static void EnterZuma()
	{
		GameAPP.Instance.PlayMusic((MusicType)((uint)13));
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Zuma/Background/Background"));
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)21), canvasUp, num != 0);
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x060035B9 RID: 13753 RVA: 0x0011D9D0 File Offset: 0x0011BBD0
	[Token(Token = "0x60035B9")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UIMgr()
	{
	}
}
