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
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	public class LevelManager
	{
		// Token: 0x06003B55 RID: 15189 RVA: 0x001371E4 File Offset: 0x001353E4
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x7B2C50", Offset = "0x7B1250", VA = "0x1807B2C50")]
		static LevelManager()
		{
			LevelManager.Initialize();
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00137204 File Offset: 0x00135404
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x7B2350", Offset = "0x7B0950", VA = "0x1807B2350")]
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

		// Token: 0x06003B57 RID: 15191 RVA: 0x001372B0 File Offset: 0x001354B0
		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
		public static void Active()
		{
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x001372C0 File Offset: 0x001354C0
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x7B28A0", Offset = "0x7B0EA0", VA = "0x1807B28A0")]
		public static void ReLoad()
		{
			LevelManager.registry.Clear();
			LevelManager.loader.LoadDynamicLevels();
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x001372E8 File Offset: 0x001354E8
		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x7B2170", Offset = "0x7B0770", VA = "0x1807B2170")]
		public static void Clear()
		{
			LevelManager.registry.Clear();
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00137308 File Offset: 0x00135508
		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x7B2BC0", Offset = "0x7B11C0", VA = "0x1807B2BC0")]
		public static bool TryGetLevelData(LevelType level, int levelNumber, [Out] LevelData levelData)
		{
			LevelRegistry levelRegistry = LevelManager.registry;
			bool flag;
			return flag;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00137324 File Offset: 0x00135524
		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x7B2AF0", Offset = "0x7B10F0", VA = "0x1807B2AF0")]
		public static bool TryGetLevelData([Out] LevelData levelData)
		{
			LevelRegistry levelRegistry = LevelManager.registry;
			LevelType theBoardType = GameAPP.theBoardType;
			int theBoardLevel = GameAPP.theBoardLevel;
			return levelRegistry.TryGetLevel(theBoardType, theBoardLevel, levelData);
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00137354 File Offset: 0x00135554
		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x7B22A0", Offset = "0x7B08A0", VA = "0x1807B22A0")]
		public static List<CustomLevelData> GetAllDynamicLevels()
		{
			return LevelManager.registry.GetAllDynamicLevels();
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00137374 File Offset: 0x00135574
		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x7B2920", Offset = "0x7B0F20", VA = "0x1807B2920")]
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
			int num = 0;
			instance.ShowText(text4, 10f, num != 0);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x0013740C File Offset: 0x0013560C
		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x7B21D0", Offset = "0x7B07D0", VA = "0x1807B21D0")]
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

		// Token: 0x06003B5F RID: 15199 RVA: 0x00137434 File Offset: 0x00135634
		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x7B2300", Offset = "0x7B0900", VA = "0x1807B2300")]
		public static List<OnlineLevelInfo> GetOnlineLevelInfos()
		{
			return LevelManager.onlineLevelInfos;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00137448 File Offset: 0x00135648
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x7B2690", Offset = "0x7B0C90", VA = "0x1807B2690")]
		public static UniTask<int> LoadOnlineLevelListAsync(bool noKey)
		{
			noKey.m_value = false;
			return default(UniTask<int>);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00137470 File Offset: 0x00135670
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x7B2780", Offset = "0x7B0D80", VA = "0x1807B2780")]
		public static UniTask<CustomLevelData> LoadSingleOnlineLevelAsync(string levelId, bool noKey)
		{
			return default(UniTask<CustomLevelData>);
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00137490 File Offset: 0x00135690
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public LevelManager()
		{
		}

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		public static LevelRegistry registry;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		private static LevelLoader loader;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		private static LevelSaver saver;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		private static LevelDeleter deleter;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		private static OnlineLevelLoader onlineLoader;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		public static List<OnlineLevelInfo> onlineLevelInfos = new List();
	}
}
