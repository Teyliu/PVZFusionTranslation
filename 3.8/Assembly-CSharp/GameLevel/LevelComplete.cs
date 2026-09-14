using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2000ABC")]
	[Serializable]
	public class LevelComplete : ISerializationCallbackReceiver
	{
		// Token: 0x060038DD RID: 14557 RVA: 0x0012D5D8 File Offset: 0x0012B7D8
		[Token(Token = "0x60038DD")]
		[Address(RVA = "0x78A370", Offset = "0x788970", VA = "0x18078A370", Slot = "4")]
		public void OnBeforeSerialize()
		{
			int num;
			do
			{
				List<CompleteData> list = this.completeDatas;
				int size = list._size;
				num = 0;
				list._size = num;
				if (size > 0)
				{
				}
				Dictionary<ValueTuple<LevelType, int>, CompleteData> dictionary = this.completeDictionary;
				bool flag;
				if (flag)
				{
					List<CompleteData> list2 = this.completeDatas;
					int num2 = list2._size + 1;
					list2._size = num2;
				}
			}
			while (num != 0);
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0012D64C File Offset: 0x0012B84C
		[Token(Token = "0x60038DE")]
		[Address(RVA = "0x78A1B0", Offset = "0x7887B0", VA = "0x18078A1B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
			int num2;
			do
			{
				int num = 0;
				this.completeDictionary.Clear();
				List<CompleteData> list = this.completeDatas;
				num2 = 0;
				bool flag;
				if (flag)
				{
					this.completeDictionary[num2] = num;
				}
			}
			while (num2 != 0);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0012D698 File Offset: 0x0012B898
		[Token(Token = "0x60038DF")]
		[Address(RVA = "0x78A670", Offset = "0x788C70", VA = "0x18078A670")]
		public bool TryGetClearanceRate(LevelType levelType, int levelNumber, [Out] float rate)
		{
			int num = 0;
			if (this.completeDictionary.TryGetValue(num, num))
			{
				return true;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0012D6C4 File Offset: 0x0012B8C4
		[Token(Token = "0x60038E0")]
		[Address(RVA = "0x78A550", Offset = "0x788B50", VA = "0x18078A550")]
		public void StartLevel(LevelType levelType, int levelNumber)
		{
			int num = 0;
			if (!this.completeDictionary.TryGetValue(num, num))
			{
				CompleteData completeData = new CompleteData();
				completeData.levelType = levelType;
				completeData.levelNumber = levelNumber;
				completeData.startCount = (int)((ulong)1L);
				this.completeDictionary[num] = completeData;
				return;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0012D718 File Offset: 0x0012B918
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x78A100", Offset = "0x788700", VA = "0x18078A100")]
		public void LevelVictory(LevelType levelType, int levelNumber)
		{
			int num = 0;
			if (this.completeDictionary.TryGetValue(num, num))
			{
			}
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0012D740 File Offset: 0x0012B940
		[Token(Token = "0x60038E2")]
		[Address(RVA = "0x78A750", Offset = "0x788D50", VA = "0x18078A750")]
		public LevelComplete()
		{
			List<CompleteData> list = new List();
			this.completeDatas = list;
			Dictionary<ValueTuple<LevelType, int>, CompleteData> dictionary = new Dictionary();
			this.completeDictionary = dictionary;
			base..ctor();
		}

		// Token: 0x04002AA5 RID: 10917
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AA5")]
		[SerializeField]
		private List<CompleteData> completeDatas;

		// Token: 0x04002AA6 RID: 10918
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AA6")]
		[TupleElementNames(new string[] { "levelType", "levelNumber" })]
		private readonly Dictionary<ValueTuple<LevelType, int>, CompleteData> completeDictionary;
	}
}
