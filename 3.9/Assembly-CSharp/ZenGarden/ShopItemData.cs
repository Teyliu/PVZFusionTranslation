using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	[Serializable]
	public class ShopItemData
	{
		// Token: 0x06003728 RID: 14120 RVA: 0x00127D88 File Offset: 0x00125F88
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x7C24B0", Offset = "0x7C0AB0", VA = "0x1807C24B0")]
		public ShopItemData CreateDeepCopy()
		{
			return JsonUtility.FromJson<ShopItemData>(JsonUtility.ToJson(this));
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00127DA0 File Offset: 0x00125FA0
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ShopItemData()
		{
		}

		// Token: 0x04002AA8 RID: 10920
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AA8")]
		public Item itemType;

		// Token: 0x04002AA9 RID: 10921
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002AA9")]
		public int cost;

		// Token: 0x04002AAA RID: 10922
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AAA")]
		public int countPerBuy;

		// Token: 0x04002AAB RID: 10923
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AAB")]
		public string description;
	}
}
