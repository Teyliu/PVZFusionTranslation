using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	public class LevelLoader
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x0013C260 File Offset: 0x0013A460
		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x639450", Offset = "0x637A50", VA = "0x180639450")]
		public LevelLoader(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0013C27C File Offset: 0x0013A47C
		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x82D1B0", Offset = "0x82B7B0", VA = "0x18082D1B0")]
		public void LoadAllLevels()
		{
			this.LoadPredefinedLevels();
			this.LoadDynamicLevels();
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x0013C298 File Offset: 0x0013A498
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x82D660", Offset = "0x82BC60", VA = "0x18082D660")]
		private void LoadPredefinedLevels()
		{
			int num;
			do
			{
				num = 0;
				if (LevelLoader.<>c.<>9__3_0 == 0)
				{
					LevelLoader.<>c.<>9__3_0 = delegate(Type t)
					{
						if (typeof(LevelData).IsAssignableFrom(t) && !t.IsInterface)
						{
							return t.IsAbstract;
						}
						throw new NullReferenceException();
					};
				}
				IEnumerable<Type> enumerable;
				if (enumerable != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_003B;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_003B;
					}
					goto IL_003F;
					IL_0043:
					this.registry.RegisterPredefinedLevel(num);
					string text;
					Debug.LogError(text);
					goto IL_0058;
					IL_003F:
					object obj;
					obj += obj;
					goto IL_0043;
					IL_003B:
					if (obj == 0)
					{
						goto IL_003F;
					}
					goto IL_0043;
				}
				IL_0058:
				if ("{il2cpp array field local8->}" != (ulong)0L)
				{
				}
				if ("{il2cpp array field local8->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0013C33C File Offset: 0x0013A53C
		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x82D1D0", Offset = "0x82B7D0", VA = "0x18082D1D0")]
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

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0013C3AC File Offset: 0x0013A5AC
		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x82D2F0", Offset = "0x82B8F0", VA = "0x18082D2F0")]
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

		// Token: 0x04002D20 RID: 11552
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D20")]
		private readonly LevelRegistry registry;
	}
}
