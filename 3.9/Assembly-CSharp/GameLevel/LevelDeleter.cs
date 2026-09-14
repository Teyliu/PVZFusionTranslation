using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	public class LevelDeleter
	{
		// Token: 0x06003C9A RID: 15514 RVA: 0x0013C118 File Offset: 0x0013A318
		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x639450", Offset = "0x637A50", VA = "0x180639450")]
		public LevelDeleter(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x0013C134 File Offset: 0x0013A334
		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x82CB80", Offset = "0x82B180", VA = "0x18082CB80")]
		public bool DeleteLevel(LevelType levelType, int levelNumber)
		{
			int num = 0;
			if (this.registry.<DynamicLevels>k__BackingField.TryGetValue(num, num) && num != 0 && num != 0)
			{
				string text2;
				string text = Path.Combine(LevelConstants.LevelFolderPath, text2);
				if (File.Exists(text))
				{
					LevelRegistry levelRegistry = this.registry;
					File.Delete(text);
					InGameText instance = InGameText.Instance;
				}
				InGameText instance2 = InGameText.Instance;
				string text3 = string.Format("文件不存在: {0}", text);
				Debug.LogError(string.Format(0, num));
			}
			InGameText instance3 = InGameText.Instance;
			this.ShowAllName();
			throw new NullReferenceException();
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0013C1EC File Offset: 0x0013A3EC
		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x82D070", Offset = "0x82B670", VA = "0x18082D070")]
		private bool TryGetLevelFileName(LevelType levelType, int levelNumber, [Out] string fileName)
		{
			LevelRegistry levelRegistry = this.registry;
			int num = 0;
			if (levelRegistry.<DynamicLevels>k__BackingField.TryGetValue(num, num) && num != 0 && num != 0)
			{
				return true;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0013C228 File Offset: 0x0013A428
		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x82CEE0", Offset = "0x82B4E0", VA = "0x18082CEE0")]
		private void ShowAllName()
		{
			ulong num;
			do
			{
				Dictionary<ValueTuple<LevelType, int>, LevelData> <DynamicLevels>k__BackingField = this.registry.<DynamicLevels>k__BackingField;
				bool flag;
				if (flag)
				{
					Debug.Log(flag);
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x04002D1F RID: 11551
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D1F")]
		private readonly LevelRegistry registry;
	}
}
