using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	[Serializable]
	public class Inventory
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x00128550 File Offset: 0x00126750
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x7C1960", Offset = "0x7BFF60", VA = "0x1807C1960")]
		public void AddItem(ShopItemData item)
		{
			int size = this.items._size;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00128570 File Offset: 0x00126770
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x7C1A10", Offset = "0x7C0010", VA = "0x1807C1A10")]
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

		// Token: 0x06003745 RID: 14149 RVA: 0x001285B8 File Offset: 0x001267B8
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x7C1B80", Offset = "0x7C0180", VA = "0x1807C1B80")]
		public Inventory()
		{
			List<ShopItemData> list = new List();
			this.items = list;
			base..ctor();
		}

		// Token: 0x04002AC1 RID: 10945
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AC1")]
		public List<ShopItemData> items;
	}
}
