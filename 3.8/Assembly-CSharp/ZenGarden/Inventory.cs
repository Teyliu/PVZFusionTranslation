using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	[Serializable]
	public class Inventory
	{
		// Token: 0x060035FF RID: 13823 RVA: 0x001232D4 File Offset: 0x001214D4
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x75AD00", Offset = "0x759300", VA = "0x18075AD00")]
		public void AddItem(ShopItemData item)
		{
			int size = this.items._size;
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x001232F4 File Offset: 0x001214F4
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x75ADB0", Offset = "0x7593B0", VA = "0x18075ADB0")]
		public void UseItem(Item itemType)
		{
			ulong num2;
			do
			{
				int num = 0;
				List<ShopItemData> list = Enumerable.ToList<ShopItemData>(this.items);
				bool flag;
				if (flag)
				{
					bool flag2 = this.items.Remove(num);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x0012333C File Offset: 0x0012153C
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x75AF20", Offset = "0x759520", VA = "0x18075AF20")]
		public Inventory()
		{
			List<ShopItemData> list = new List();
			this.items = list;
			base..ctor();
		}

		// Token: 0x0400294E RID: 10574
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400294E")]
		public List<ShopItemData> items;
	}
}
