using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public class LevelDeleter
	{
		// Token: 0x06003B49 RID: 15177 RVA: 0x00136DDC File Offset: 0x00134FDC
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x5D6590", Offset = "0x5D4B90", VA = "0x1805D6590")]
		public LevelDeleter(LevelRegistry registry)
		{
			this.registry = registry;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00136DF8 File Offset: 0x00134FF8
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x7B1280", Offset = "0x7AF880", VA = "0x1807B1280")]
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
					int num2 = 0;
					instance.ShowText("已删除关卡，请手动刷新关卡列表", 5f, num2 != 0);
				}
				InGameText instance2 = InGameText.Instance;
				string text3 = string.Format("文件不存在: {0}", text);
				int num3 = 0;
				instance2.ShowText(text3, 5f, num3 != 0);
				Debug.LogError(string.Format(0, num));
			}
			InGameText instance3 = InGameText.Instance;
			int num4 = 0;
			instance3.ShowText("无法从注册表获取关卡名称", 5f, num4 != 0);
			this.ShowAllName();
			throw new NullReferenceException();
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00136EF8 File Offset: 0x001350F8
		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x7B1750", Offset = "0x7AFD50", VA = "0x1807B1750")]
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

		// Token: 0x06003B4C RID: 15180 RVA: 0x00136F34 File Offset: 0x00135134
		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x7B15C0", Offset = "0x7AFBC0", VA = "0x1807B15C0")]
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

		// Token: 0x04002BAB RID: 11179
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BAB")]
		private readonly LevelRegistry registry;
	}
}
