using System;
using System.IO;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	public class LevelSaver
	{
		// Token: 0x06003B74 RID: 15220 RVA: 0x00137900 File Offset: 0x00135B00
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x5D6590", Offset = "0x5D4B90", VA = "0x1805D6590")]
		public LevelSaver(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x0013791C File Offset: 0x00135B1C
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x7B3650", Offset = "0x7B1C50", VA = "0x1807B3650")]
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
			int num = 0;
			instance.ShowText(text4, 10f, num != 0);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x001379AC File Offset: 0x00135BAC
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x7B37D0", Offset = "0x7B1DD0", VA = "0x1807B37D0")]
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

		// Token: 0x06003B77 RID: 15223 RVA: 0x00137A60 File Offset: 0x00135C60
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x7B35B0", Offset = "0x7B1BB0", VA = "0x1807B35B0")]
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

		// Token: 0x04002BC2 RID: 11202
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BC2")]
		private readonly LevelRegistry registry;
	}
}
