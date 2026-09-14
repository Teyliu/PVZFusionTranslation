using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	[Serializable]
	public class ShopDatas
	{
		// Token: 0x06003727 RID: 14119 RVA: 0x00127D68 File Offset: 0x00125F68
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x7C2430", Offset = "0x7C0A30", VA = "0x1807C2430")]
		public ShopDatas()
		{
			List<ShopItemData> list = new List();
			this.datas = list;
			base..ctor();
		}

		// Token: 0x04002AA7 RID: 10919
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AA7")]
		public List<ShopItemData> datas;
	}
}
