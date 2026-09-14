using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	[Serializable]
	public class ShopDatas
	{
		// Token: 0x060035E3 RID: 13795 RVA: 0x00122B48 File Offset: 0x00120D48
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x75B7D0", Offset = "0x759DD0", VA = "0x18075B7D0")]
		public ShopDatas()
		{
			List<ShopItemData> list = new List();
			this.datas = list;
			base..ctor();
		}

		// Token: 0x04002934 RID: 10548
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002934")]
		public List<ShopItemData> datas;
	}
}
