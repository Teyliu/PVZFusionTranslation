using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	public class LevelRegistry
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x001376DC File Offset: 0x001358DC
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x001376F0 File Offset: 0x001358F0
		[Token(Token = "0x1700049C")]
		[TupleElementNames(new string[] { "levelType", "levelNumber" })]
		public Dictionary<ValueTuple<LevelType, int>, LevelData> PredefinedLevels
		{
			[Token(Token = "0x6003B67")]
			[Address(RVA = "0x787BE0", Offset = "0x7861E0", VA = "0x180787BE0")]
			get;
			[Token(Token = "0x6003B68")]
			[Address(RVA = "0x787C10", Offset = "0x786210", VA = "0x180787C10")]
			[param: TupleElementNames(new string[] { "levelType", "levelNumber" })]
			private set;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x00137704 File Offset: 0x00135904
		// (set) Token: 0x06003B6A RID: 15210 RVA: 0x00137718 File Offset: 0x00135918
		[Token(Token = "0x1700049D")]
		public Dictionary<ValueTuple<LevelType, int>, LevelData> DynamicLevels
		{
			[Token(Token = "0x6003B69")]
			[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
			get;
			[Token(Token = "0x6003B6A")]
			[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
			private set;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x0013772C File Offset: 0x0013592C
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x7B34C0", Offset = "0x7B1AC0", VA = "0x1807B34C0")]
		public LevelRegistry()
		{
			Dictionary<LevelType, int> dictionary = new Dictionary();
			this.MaxLevelNumbers = dictionary;
			base..ctor();
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary2 = new Dictionary();
			this.PredefinedLevels = dictionary2;
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary3 = new Dictionary();
			this.DynamicLevels = dictionary3;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00137768 File Offset: 0x00135968
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x7B2CE0", Offset = "0x7B12E0", VA = "0x1807B2CE0")]
		public void Clear()
		{
			this.<DynamicLevels>k__BackingField.Clear();
			this.MaxLevelNumbers.Clear();
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00137794 File Offset: 0x00135994
		[Token(Token = "0x6003B6D")]
		[Address(RVA = "0x7B3190", Offset = "0x7B1790", VA = "0x1807B3190")]
		public void RegisterPredefinedLevel(LevelData levelData)
		{
			int levelType = (int)levelData.LevelType;
			int levelNumber = levelData.LevelNumber;
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<PredefinedLevels>k__BackingField;
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x001377C0 File Offset: 0x001359C0
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x7B2F70", Offset = "0x7B1570", VA = "0x1807B2F70")]
		public void RegisterDynamicLevel(LevelData levelData, bool newlevel = false)
		{
			int levelType = (int)levelData.LevelType;
			int levelNumber = levelData.LevelNumber;
			if (newlevel)
			{
				Dictionary<LevelType, int> maxLevelNumbers = this.MaxLevelNumbers;
				LevelType levelType2 = levelData.LevelType;
				bool flag;
				if (!flag)
				{
				}
				ulong num2;
				ulong num = num2 + 1UL;
				int levelType3 = (int)levelData.LevelType;
				Dictionary<LevelType, int> maxLevelNumbers2 = this.MaxLevelNumbers;
				LevelType levelType4 = levelData.LevelType;
				LevelRegistry.LastLevel = (int)num;
				levelData.LevelNumber = (int)num;
			}
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<DynamicLevels>k__BackingField;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00137834 File Offset: 0x00135A34
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x7B3370", Offset = "0x7B1970", VA = "0x1807B3370")]
		public bool TryGetLevel(LevelType levelType, int levelNumber, [Out] LevelData levelData)
		{
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<DynamicLevels>k__BackingField;
			bool flag;
			if (!flag)
			{
				Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary2 = this.<PredefinedLevels>k__BackingField;
				bool flag2;
				if (!flag2)
				{
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00137868 File Offset: 0x00135A68
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x7B32F0", Offset = "0x7B18F0", VA = "0x1807B32F0")]
		public bool TryGetCurrentLevel([Out] LevelData levelData)
		{
			LevelType theBoardType = GameAPP.theBoardType;
			int theBoardLevel = GameAPP.theBoardLevel;
			return this.TryGetLevel(theBoardType, theBoardLevel, levelData);
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x0013788C File Offset: 0x00135A8C
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x7B3260", Offset = "0x7B1860", VA = "0x1807B3260")]
		public bool RemoveLevel(LevelType levelType, int levelNumber)
		{
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<DynamicLevels>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x001378AC File Offset: 0x00135AAC
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x7B2D80", Offset = "0x7B1380", VA = "0x1807B2D80")]
		public List<CustomLevelData> GetAllDynamicLevels()
		{
			List<CustomLevelData> list;
			int num;
			do
			{
				list = new List();
				Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<DynamicLevels>k__BackingField;
				num = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			return list;
		}

		// Token: 0x04002BC0 RID: 11200
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BC0")]
		private Dictionary<LevelType, int> MaxLevelNumbers;

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		public static int LastLevel;
	}
}
