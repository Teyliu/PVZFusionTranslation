using System;
using System.IO;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B61 RID: 2913
	[Token(Token = "0x2000B61")]
	public class LevelSaver
	{
		// Token: 0x06003CC5 RID: 15557 RVA: 0x0013CBF0 File Offset: 0x0013ADF0
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x639450", Offset = "0x637A50", VA = "0x180639450")]
		public LevelSaver(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x0013CC0C File Offset: 0x0013AE0C
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x82EF80", Offset = "0x82D580", VA = "0x18082EF80")]
		public void SaveLevel(SerializedLevelData serializedLevelData)
		{
			string text = JsonUtility.ToJson(serializedLevelData, true);
			string levelFolderPath = LevelConstants.LevelFolderPath;
			string text2 = serializedLevelData.name + ".json";
			string text3 = Path.Combine(levelFolderPath, text2);
			if (File.Exists(text3))
			{
				Debug.Log("已经有一个同名文件了，这次会覆盖他");
			}
			this.UpdateRegistry(serializedLevelData, text3);
			File.WriteAllText(text3, text);
			InGameText instance = InGameText.Instance;
			string text4 = string.Format("已生成关卡文件: {0}", text3);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x0013CC88 File Offset: 0x0013AE88
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x82F110", Offset = "0x82D710", VA = "0x18082F110")]
		private void UpdateRegistry(SerializedLevelData serializedLevelData, string filePath)
		{
			int num = 0;
			int levelNumber = serializedLevelData.levelNumber;
			LevelType levelType = serializedLevelData.levelType;
			CustomLevelData customLevelData = serializedLevelData.BuildLevel();
			if (!this.registry.<DynamicLevels>k__BackingField.TryGetValue(num, num))
			{
				this.registry.<DynamicLevels>k__BackingField.Add(num, customLevelData);
				int count = this.registry.<DynamicLevels>k__BackingField.Count;
			}
			string text2;
			string text = Path.Combine(LevelConstants.LevelFolderPath, text2);
			this.DeleteOldLevel(text);
			this.registry.<DynamicLevels>k__BackingField[num] = customLevelData;
			int count2 = this.registry.<DynamicLevels>k__BackingField.Count;
			Debug.Log(string.Format("在注册表中更新了关卡：{0}，总计{1}关", num, count2));
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x0013CD3C File Offset: 0x0013AF3C
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x82EEE0", Offset = "0x82D4E0", VA = "0x18082EEE0")]
		private void DeleteOldLevel(string path)
		{
			if (File.Exists(path))
			{
				File.Delete(path);
				string text;
				Debug.LogError(text);
				return;
			}
		}

		// Token: 0x04002D36 RID: 11574
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D36")]
		private readonly LevelRegistry registry;
	}
}
