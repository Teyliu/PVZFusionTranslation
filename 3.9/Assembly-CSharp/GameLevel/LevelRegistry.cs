using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2000B60")]
	public class LevelRegistry
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x0013C9CC File Offset: 0x0013ABCC
		// (set) Token: 0x06003CB9 RID: 15545 RVA: 0x0013C9E0 File Offset: 0x0013ABE0
		[Token(Token = "0x170004EC")]
		[TupleElementNames(new string[] { "levelType", "levelNumber" })]
		public Dictionary<ValueTuple<LevelType, int>, LevelData> PredefinedLevels
		{
			[Token(Token = "0x6003CB8")]
			[Address(RVA = "0x7EE610", Offset = "0x7ECC10", VA = "0x1807EE610")]
			get;
			[Token(Token = "0x6003CB9")]
			[Address(RVA = "0x3FB4B0", Offset = "0x3F9AB0", VA = "0x1803FB4B0")]
			[param: TupleElementNames(new string[] { "levelType", "levelNumber" })]
			private set;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06003CBA RID: 15546 RVA: 0x0013C9F4 File Offset: 0x0013ABF4
		// (set) Token: 0x06003CBB RID: 15547 RVA: 0x0013CA08 File Offset: 0x0013AC08
		[Token(Token = "0x170004ED")]
		public Dictionary<ValueTuple<LevelType, int>, LevelData> DynamicLevels
		{
			[Token(Token = "0x6003CBA")]
			[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
			get;
			[Token(Token = "0x6003CBB")]
			[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
			private set;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x0013CA1C File Offset: 0x0013AC1C
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x82EDF0", Offset = "0x82D3F0", VA = "0x18082EDF0")]
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

		// Token: 0x06003CBD RID: 15549 RVA: 0x0013CA58 File Offset: 0x0013AC58
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x82E610", Offset = "0x82CC10", VA = "0x18082E610")]
		public void Clear()
		{
			this.<DynamicLevels>k__BackingField.Clear();
			this.MaxLevelNumbers.Clear();
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x0013CA84 File Offset: 0x0013AC84
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x82EAC0", Offset = "0x82D0C0", VA = "0x18082EAC0")]
		public void RegisterPredefinedLevel(LevelData levelData)
		{
			int levelType = (int)levelData.LevelType;
			int levelNumber = levelData.LevelNumber;
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<PredefinedLevels>k__BackingField;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x0013CAB0 File Offset: 0x0013ACB0
		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x82E8A0", Offset = "0x82CEA0", VA = "0x18082E8A0")]
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

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0013CB24 File Offset: 0x0013AD24
		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x82ECA0", Offset = "0x82D2A0", VA = "0x18082ECA0")]
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

		// Token: 0x06003CC1 RID: 15553 RVA: 0x0013CB58 File Offset: 0x0013AD58
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x82EC20", Offset = "0x82D220", VA = "0x18082EC20")]
		public bool TryGetCurrentLevel([Out] LevelData levelData)
		{
			LevelType theBoardType = GameAPP.theBoardType;
			int theBoardLevel = GameAPP.theBoardLevel;
			return this.TryGetLevel(theBoardType, theBoardLevel, levelData);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x0013CB7C File Offset: 0x0013AD7C
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x82EB90", Offset = "0x82D190", VA = "0x18082EB90")]
		public bool RemoveLevel(LevelType levelType, int levelNumber)
		{
			Dictionary<ValueTuple<LevelType, int>, LevelData> dictionary = this.<DynamicLevels>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x0013CB9C File Offset: 0x0013AD9C
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x82E6B0", Offset = "0x82CCB0", VA = "0x18082E6B0")]
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

		// Token: 0x04002D34 RID: 11572
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D34")]
		private Dictionary<LevelType, int> MaxLevelNumbers;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		public static int LastLevel;
	}
}
