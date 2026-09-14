using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	[Serializable]
	public class LevelComplete : ISerializationCallbackReceiver
	{
		// Token: 0x06003A21 RID: 14881 RVA: 0x00132800 File Offset: 0x00130A00
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x7F09E0", Offset = "0x7EEFE0", VA = "0x1807F09E0", Slot = "4")]
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

		// Token: 0x06003A22 RID: 14882 RVA: 0x00132874 File Offset: 0x00130A74
		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x7F0820", Offset = "0x7EEE20", VA = "0x1807F0820", Slot = "5")]
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

		// Token: 0x06003A23 RID: 14883 RVA: 0x001328C0 File Offset: 0x00130AC0
		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x7F0CE0", Offset = "0x7EF2E0", VA = "0x1807F0CE0")]
		public bool TryGetClearanceRate(LevelType levelType, int levelNumber, [Out] float rate)
		{
			int num = 0;
			if (this.completeDictionary.TryGetValue(num, num))
			{
				return true;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001328EC File Offset: 0x00130AEC
		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x7F0BC0", Offset = "0x7EF1C0", VA = "0x1807F0BC0")]
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

		// Token: 0x06003A25 RID: 14885 RVA: 0x00132940 File Offset: 0x00130B40
		[Token(Token = "0x6003A25")]
		[Address(RVA = "0x7F0770", Offset = "0x7EED70", VA = "0x1807F0770")]
		public void LevelVictory(LevelType levelType, int levelNumber)
		{
			int num = 0;
			if (this.completeDictionary.TryGetValue(num, num))
			{
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00132968 File Offset: 0x00130B68
		[Token(Token = "0x6003A26")]
		[Address(RVA = "0x7F0DC0", Offset = "0x7EF3C0", VA = "0x1807F0DC0")]
		public LevelComplete()
		{
			List<CompleteData> list = new List();
			this.completeDatas = list;
			Dictionary<ValueTuple<LevelType, int>, CompleteData> dictionary = new Dictionary();
			this.completeDictionary = dictionary;
			base..ctor();
		}

		// Token: 0x04002C18 RID: 11288
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C18")]
		[SerializeField]
		private List<CompleteData> completeDatas;

		// Token: 0x04002C19 RID: 11289
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C19")]
		[TupleElementNames(new string[] { "levelType", "levelNumber" })]
		private readonly Dictionary<ValueTuple<LevelType, int>, CompleteData> completeDictionary;
	}
}
