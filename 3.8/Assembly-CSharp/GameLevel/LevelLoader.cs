using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B19 RID: 2841
	[Token(Token = "0x2000B19")]
	public class LevelLoader
	{
		// Token: 0x06003B4D RID: 15181 RVA: 0x00136F6C File Offset: 0x0013516C
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x5D6590", Offset = "0x5D4B90", VA = "0x1805D6590")]
		public LevelLoader(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00136F88 File Offset: 0x00135188
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x7B1890", Offset = "0x7AFE90", VA = "0x1807B1890")]
		public void LoadAllLevels()
		{
			this.LoadPredefinedLevels();
			this.LoadDynamicLevels();
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00136FA4 File Offset: 0x001351A4
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x7B1D40", Offset = "0x7B0340", VA = "0x1807B1D40")]
		private void LoadPredefinedLevels()
		{
			int num;
			do
			{
				num = 0;
				if (LevelLoader.<>c.<>9__3_0 == 0)
				{
					Func<Type, bool> func;
					LevelLoader.<>c.<>9__3_0 = func;
				}
				IEnumerable<Type> enumerable;
				if (enumerable != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_002C;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_002C;
					}
					goto IL_0030;
					IL_0034:
					this.registry.RegisterPredefinedLevel(num);
					string text;
					Debug.LogError(text);
					goto IL_004A;
					IL_0030:
					object obj;
					obj += obj;
					goto IL_0034;
					IL_002C:
					if (obj == 0)
					{
						goto IL_0030;
					}
					goto IL_0034;
				}
				IL_004A:
				if ("{il2cpp array field local8->}" != (ulong)0L)
				{
				}
				if ("{il2cpp array field local8->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00137038 File Offset: 0x00135238
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x7B18B0", Offset = "0x7AFEB0", VA = "0x1807B18B0")]
		public void LoadDynamicLevels()
		{
			string levelFolderPath = LevelConstants.LevelFolderPath;
			if (Directory.Exists(levelFolderPath))
			{
				string[] files = Directory.GetFiles(levelFolderPath, "*.json");
				if (files.Length != 0)
				{
					int num = 0;
					if (num < files.Length)
					{
						this.LoadLevelFromFile("*.json");
						num++;
						goto IL_0040;
					}
				}
				return;
			}
			IL_0040:
			DirectoryInfo directoryInfo = Directory.CreateDirectory(levelFolderPath);
			Debug.Log(string.Format("创建关卡存档文件夹: {0}", levelFolderPath));
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001370A8 File Offset: 0x001352A8
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x7B19D0", Offset = "0x7AFFD0", VA = "0x1807B19D0")]
		private void LoadLevelFromFile(string filePath)
		{
			SerializedLevelData serializedLevelData = JsonUtility.FromJson<SerializedLevelData>(File.ReadAllText(filePath));
			if (serializedLevelData != 0)
			{
				CustomLevelData customLevelData = serializedLevelData.BuildLevel();
				int levelNumber = serializedLevelData.levelNumber;
				LevelType levelType = serializedLevelData.levelType;
				Dictionary<ValueTuple<LevelType, int>, LevelData> <DynamicLevels>k__BackingField = this.registry.<DynamicLevels>k__BackingField;
				bool flag;
				if (flag)
				{
					LevelType levelType2 = serializedLevelData.levelType;
					int levelNumber2 = serializedLevelData.levelNumber;
					Debug.LogWarning(string.Format("发现重复关卡：{0}-{1}，已覆盖", levelType2, levelType2));
				}
				LevelRegistry levelRegistry = this.registry;
				int num = 0;
				levelRegistry.RegisterDynamicLevel(customLevelData, num != 0);
				string name = customLevelData.Name;
				LevelType levelType3 = customLevelData.LevelType;
				int levelNumber3 = customLevelData.LevelNumber;
				Debug.Log(string.Format("从文件中读取到关卡：{0}，类型:{1}，编号:{2}", name, levelType3, levelNumber3));
				string text;
				Debug.LogWarning(text);
				return;
			}
		}

		// Token: 0x04002BAC RID: 11180
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BAC")]
		private readonly LevelRegistry registry;
	}
}
