using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;
using UnityEngine;
using ZenGarden;

// Token: 0x020009FB RID: 2555
[Token(Token = "0x20009FB")]
public class UIMgr : MonoBehaviour
{
	// Token: 0x06003469 RID: 13417 RVA: 0x00117AE0 File Offset: 0x00115CE0
	[Token(Token = "0x6003469")]
	[Address(RVA = "0x7450F0", Offset = "0x7436F0", VA = "0x1807450F0")]
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

	// Token: 0x0600346A RID: 13418 RVA: 0x00117D84 File Offset: 0x00115F84
	[Token(Token = "0x600346A")]
	[Address(RVA = "0x747170", Offset = "0x745770", VA = "0x180747170")]
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

	// Token: 0x0600346B RID: 13419 RVA: 0x00118050 File Offset: 0x00116250
	[Token(Token = "0x600346B")]
	[Address(RVA = "0x747C70", Offset = "0x746270", VA = "0x180747C70")]
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

	// Token: 0x0600346C RID: 13420 RVA: 0x001180B0 File Offset: 0x001162B0
	[Token(Token = "0x600346C")]
	[Address(RVA = "0x746120", Offset = "0x744720", VA = "0x180746120")]
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

	// Token: 0x0600346D RID: 13421 RVA: 0x0011816C File Offset: 0x0011636C
	[Token(Token = "0x600346D")]
	[Address(RVA = "0x7468F0", Offset = "0x744EF0", VA = "0x1807468F0")]
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

	// Token: 0x0600346E RID: 13422 RVA: 0x00118228 File Offset: 0x00116428
	[Token(Token = "0x600346E")]
	[Address(RVA = "0x744540", Offset = "0x742B40", VA = "0x180744540")]
	public static void BackToMenu()
	{
		InGameText.Instance.TimeOver();
		if (GameAPP.theBoardType <= LevelType.TowerLevel)
		{
		}
		UIMgr.EnterChallengeMenu();
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x00118314 File Offset: 0x00116514
	[Token(Token = "0x600346F")]
	[Address(RVA = "0x744E20", Offset = "0x743420", VA = "0x180744E20")]
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

	// Token: 0x06003470 RID: 13424 RVA: 0x00118368 File Offset: 0x00116568
	[Token(Token = "0x6003470")]
	[Address(RVA = "0x744F10", Offset = "0x743510", VA = "0x180744F10")]
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

	// Token: 0x06003471 RID: 13425 RVA: 0x001183C0 File Offset: 0x001165C0
	[Token(Token = "0x6003471")]
	[Address(RVA = "0x746F90", Offset = "0x745590", VA = "0x180746F90")]
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

	// Token: 0x06003472 RID: 13426 RVA: 0x00118418 File Offset: 0x00116618
	[Token(Token = "0x6003472")]
	[Address(RVA = "0x747940", Offset = "0x745F40", VA = "0x180747940")]
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

	// Token: 0x06003473 RID: 13427 RVA: 0x00118470 File Offset: 0x00116670
	[Token(Token = "0x6003473")]
	[Address(RVA = "0x747080", Offset = "0x745680", VA = "0x180747080")]
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

	// Token: 0x06003474 RID: 13428 RVA: 0x001184C8 File Offset: 0x001166C8
	[Token(Token = "0x6003474")]
	[Address(RVA = "0x747A30", Offset = "0x746030", VA = "0x180747A30")]
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

	// Token: 0x06003475 RID: 13429 RVA: 0x00118520 File Offset: 0x00116720
	[Token(Token = "0x6003475")]
	[Address(RVA = "0x746EA0", Offset = "0x7454A0", VA = "0x180746EA0")]
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

	// Token: 0x06003476 RID: 13430 RVA: 0x00118578 File Offset: 0x00116778
	[Token(Token = "0x6003476")]
	[Address(RVA = "0x7464F0", Offset = "0x744AF0", VA = "0x1807464F0")]
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

	// Token: 0x06003477 RID: 13431 RVA: 0x001185CC File Offset: 0x001167CC
	[Token(Token = "0x6003477")]
	[Address(RVA = "0x746DB0", Offset = "0x7453B0", VA = "0x180746DB0")]
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

	// Token: 0x06003478 RID: 13432 RVA: 0x00118624 File Offset: 0x00116824
	[Token(Token = "0x6003478")]
	[Address(RVA = "0x748220", Offset = "0x746820", VA = "0x180748220")]
	public static void MenuNormalSettings()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		GameAPP instance = GameAPP.Instance;
		CamaraFollowMouse.Instance.ResetCamera();
	}

	// Token: 0x06003479 RID: 13433 RVA: 0x00118658 File Offset: 0x00116858
	[Token(Token = "0x6003479")]
	[Address(RVA = "0x746CF0", Offset = "0x7452F0", VA = "0x180746CF0")]
	public static void EnterPauseMenu()
	{
		GameAPP.PlaySound(30, 0.5f, 1f);
		Time.timeScale = (float)0;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)16), canvasUp, num != 0);
	}

	// Token: 0x0600347A RID: 13434 RVA: 0x001186A0 File Offset: 0x001168A0
	[Token(Token = "0x600347A")]
	[Address(RVA = "0x7449C0", Offset = "0x742FC0", VA = "0x1807449C0")]
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

	// Token: 0x0600347B RID: 13435 RVA: 0x00118784 File Offset: 0x00116984
	[Token(Token = "0x600347B")]
	[Address(RVA = "0x744350", Offset = "0x742950", VA = "0x180744350")]
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

	// Token: 0x0600347C RID: 13436 RVA: 0x00118800 File Offset: 0x00116A00
	[Token(Token = "0x600347C")]
	[Address(RVA = "0x7465E0", Offset = "0x744BE0", VA = "0x1807465E0")]
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

	// Token: 0x0600347D RID: 13437 RVA: 0x001188D8 File Offset: 0x00116AD8
	[Token(Token = "0x600347D")]
	[Address(RVA = "0x745FA0", Offset = "0x7445A0", VA = "0x180745FA0")]
	public static void EnterHelpMenu()
	{
		Transform transform = Camera.main.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Background/Thanks"));
	}

	// Token: 0x0600347E RID: 13438 RVA: 0x00118914 File Offset: 0x00116B14
	[Token(Token = "0x600347E")]
	[Address(RVA = "0x746C20", Offset = "0x745220", VA = "0x180746C20")]
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

	// Token: 0x0600347F RID: 13439 RVA: 0x00118948 File Offset: 0x00116B48
	[Token(Token = "0x600347F")]
	[Address(RVA = "0x746BA0", Offset = "0x7451A0", VA = "0x180746BA0")]
	public static void EnterOptionMenu()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)4), canvasUp, num != 0);
	}

	// Token: 0x06003480 RID: 13440 RVA: 0x00118978 File Offset: 0x00116B78
	[Token(Token = "0x6003480")]
	[Address(RVA = "0x745000", Offset = "0x743600", VA = "0x180745000")]
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

	// Token: 0x06003481 RID: 13441 RVA: 0x001189D0 File Offset: 0x00116BD0
	[Token(Token = "0x6003481")]
	[Address(RVA = "0x744DA0", Offset = "0x7433A0", VA = "0x180744DA0")]
	public static void EnterAlmanac()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)55), canvasUp, num != 0);
	}

	// Token: 0x06003482 RID: 13442 RVA: 0x00118A00 File Offset: 0x00116C00
	[Token(Token = "0x6003482")]
	[Address(RVA = "0x745C70", Offset = "0x744270", VA = "0x180745C70")]
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

	// Token: 0x06003483 RID: 13443 RVA: 0x00118A74 File Offset: 0x00116C74
	[Token(Token = "0x6003483")]
	[Address(RVA = "0x747B20", Offset = "0x746120", VA = "0x180747B20")]
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

	// Token: 0x06003484 RID: 13444 RVA: 0x00118AD0 File Offset: 0x00116CD0
	[Token(Token = "0x6003484")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UIMgr()
	{
	}
}
