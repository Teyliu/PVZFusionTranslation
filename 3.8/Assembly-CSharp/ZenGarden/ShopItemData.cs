using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	[Serializable]
	public class ShopItemData
	{
		// Token: 0x060035E4 RID: 13796 RVA: 0x00122B68 File Offset: 0x00120D68
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x75B850", Offset = "0x759E50", VA = "0x18075B850")]
		public ShopItemData CreateDeepCopy()
		{
			return JsonUtility.FromJson<ShopItemData>(JsonUtility.ToJson(this));
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00122B80 File Offset: 0x00120D80
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ShopItemData()
		{
		}

		// Token: 0x04002935 RID: 10549
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002935")]
		public Item itemType;

		// Token: 0x04002936 RID: 10550
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002936")]
		public int cost;

		// Token: 0x04002937 RID: 10551
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002937")]
		public int countPerBuy;

		// Token: 0x04002938 RID: 10552
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002938")]
		public string description;
	}
}
