using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel.OnLine;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class LevelManager
	{
		// Token: 0x06003CA6 RID: 15526 RVA: 0x0013C4E8 File Offset: 0x0013A6E8
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x82E580", Offset = "0x82CB80", VA = "0x18082E580")]
		static LevelManager()
		{
			LevelManager.Initialize();
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0013C508 File Offset: 0x0013A708
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x82DC70", Offset = "0x82C270", VA = "0x18082DC70")]
		private static void Initialize()
		{
			LevelRegistry levelRegistry = new LevelRegistry();
			Dictionary<LevelType, int> dictionary = new Dictionary();
			levelRegistry.MaxLevelNumbers = dictionary;
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary2 = new Dictionary();
			levelRegistry.<PredefinedLevels>k__BackingField = dictionary2;
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary3 = new Dictionary();
			levelRegistry.<DynamicLevels>k__BackingField = dictionary3;
			LevelManager.registry = levelRegistry;
			LevelRegistry levelRegistry2 = LevelManager.registry;
			LevelLoader levelLoader;
			levelLoader.registry = levelRegistry2;
			LevelManager.loader = levelLoader;
			LevelRegistry levelRegistry3 = LevelManager.registry;
			LevelSaver levelSaver;
			levelSaver.registry = levelRegistry3;
			LevelManager.saver = levelSaver;
			LevelRegistry levelRegistry4 = LevelManager.registry;
			LevelDeleter levelDeleter;
			levelDeleter.registry = levelRegistry4;
			LevelManager.deleter = levelDeleter;
			LevelManager.onlineLoader = new OnlineLevelLoader();
			LevelLoader levelLoader2 = LevelManager.loader;
			levelLoader2.LoadPredefinedLevels();
			levelLoader2.LoadDynamicLevels();
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0013C5B4 File Offset: 0x0013A7B4
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
		public static void Active()
		{
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0013C5C4 File Offset: 0x0013A7C4
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x82E1C0", Offset = "0x82C7C0", VA = "0x18082E1C0")]
		public static void ReLoad()
		{
			LevelManager.registry.Clear();
			LevelManager.loader.LoadDynamicLevels();
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0013C5EC File Offset: 0x0013A7EC
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x82DA90", Offset = "0x82C090", VA = "0x18082DA90")]
		public static void Clear()
		{
			LevelManager.registry.Clear();
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0013C60C File Offset: 0x0013A80C
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x82E4F0", Offset = "0x82CAF0", VA = "0x18082E4F0")]
		public static bool TryGetLevelData(LevelType level, int levelNumber, [Out] LevelData levelData)
		{
			LevelRegistry levelRegistry = LevelManager.registry;
			bool flag;
			return flag;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0013C628 File Offset: 0x0013A828
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x82E420", Offset = "0x82CA20", VA = "0x18082E420")]
		public static bool TryGetLevelData([Out] LevelData levelData)
		{
			LevelRegistry levelRegistry = LevelManager.registry;
			LevelType theBoardType = GameAPP.theBoardType;
			int theBoardLevel = GameAPP.theBoardLevel;
			return levelRegistry.TryGetLevel(theBoardType, theBoardLevel, levelData);
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x0013C658 File Offset: 0x0013A858
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x82DBC0", Offset = "0x82C1C0", VA = "0x18082DBC0")]
		public static List<CustomLevelData> GetAllDynamicLevels()
		{
			return LevelManager.registry.GetAllDynamicLevels();
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0013C678 File Offset: 0x0013A878
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x82E240", Offset = "0x82C840", VA = "0x18082E240")]
		public static void SaveLevelData(SerializedLevelData serializedLevelData)
		{
			LevelSaver levelSaver = LevelManager.saver;
			string text = JsonUtility.ToJson(serializedLevelData, true);
			string levelFolderPath = LevelConstants.LevelFolderPath;
			string text2 = serializedLevelData.name + ".json";
			string text3 = Path.Combine(levelFolderPath, text2);
			if (File.Exists(text3))
			{
				Debug.Log("已经有一个同名文件了，这次会覆盖他");
			}
			levelSaver.UpdateRegistry(serializedLevelData, text3);
			File.WriteAllText(text3, text);
			InGameText instance = InGameText.Instance;
			string text4 = string.Format("已生成关卡文件: {0}", text3);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0013C6FC File Offset: 0x0013A8FC
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x82DAF0", Offset = "0x82C0F0", VA = "0x18082DAF0")]
		public static bool DeleteLevelData(LevelType levelType, int levelNumber, bool file = true)
		{
			if (!file)
			{
				LevelRegistry levelRegistry = LevelManager.registry;
				bool flag;
				return flag;
			}
			LevelDeleter levelDeleter = LevelManager.deleter;
			bool flag2;
			return flag2;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0013C724 File Offset: 0x0013A924
		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x82DC20", Offset = "0x82C220", VA = "0x18082DC20")]
		public static List<OnlineLevelInfo> GetOnlineLevelInfos()
		{
			return LevelManager.onlineLevelInfos;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0013C738 File Offset: 0x0013A938
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x82DFB0", Offset = "0x82C5B0", VA = "0x18082DFB0")]
		public static UniTask<int> LoadOnlineLevelListAsync(bool noKey)
		{
			noKey.m_value = false;
			return default(UniTask<int>);
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x0013C760 File Offset: 0x0013A960
		[Token(Token = "0x6003CB2")]
		[Address(RVA = "0x82E0A0", Offset = "0x82C6A0", VA = "0x18082E0A0")]
		public static UniTask<CustomLevelData> LoadSingleOnlineLevelAsync(string levelId, bool noKey)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x0013C780 File Offset: 0x0013A980
		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public LevelManager()
		{
		}

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		public static LevelRegistry registry;

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		private static LevelLoader loader;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		private static LevelSaver saver;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		private static LevelDeleter deleter;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		private static OnlineLevelLoader onlineLoader;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		public static List<OnlineLevelInfo> onlineLevelInfos = new List();
	}
}
