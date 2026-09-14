using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ZenGarden
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	public class GardenShopSlot : TheButton
	{
		// Token: 0x06003598 RID: 13720 RVA: 0x0012041C File Offset: 0x0011E61C
		[Token(Token = "0x6003598")]
		[Address(RVA = "0x7534C0", Offset = "0x751AC0", VA = "0x1807534C0")]
		private void Start()
		{
			int num = 0;
			ResourcesManager resourcesManager = GameAPP.resourcesManager;
			ShopItemData shopItemData = this.shopItem;
			Dictionary<Item, Sprite> zenGardenGoodsSprites = resourcesManager.ZenGardenGoodsSprites;
			Item itemType = shopItemData.itemType;
			if (zenGardenGoodsSprites.TryGetValue(itemType, num))
			{
				this.icon.SetIcon(num, 100f, 1f);
			}
			ShopItemData shopItemData2 = this.shopItem;
			ShopItemData shopItemData3 = this.shopItem;
			string description = shopItemData2.description;
			int cost = shopItemData3.cost;
			string text = string.Format("{0}\n价格：{1}", description, shopItemData3);
			this.baseText = text;
			Func<ShopItemData, bool> func;
			int num2 = Enumerable.Count<ShopItemData>(Enumerable.Where<ShopItemData>(GardenUI.Data.inventory.items, func));
			this.CurrentHas = num2;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x001204D4 File Offset: 0x0011E6D4
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x001204E8 File Offset: 0x0011E6E8
		[Token(Token = "0x1700023F")]
		public int CurrentHas
		{
			[Token(Token = "0x6003599")]
			[Address(RVA = "0x7536F0", Offset = "0x751CF0", VA = "0x1807536F0")]
			get
			{
				return this._currentHasCount;
			}
			[Token(Token = "0x600359A")]
			[Address(RVA = "0x753700", Offset = "0x751D00", VA = "0x180753700")]
			set
			{
				TextMeshProUGUI textMeshProUGUI = this.title;
				this._currentHasCount = value;
				string text = this.baseText;
				string text2 = string.Format("\n已持有{0}个", "\n已持有{0}个");
				string text3 = text + text2;
				textMeshProUGUI.text = text3;
			}
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00120530 File Offset: 0x0011E730
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x6031B0", Offset = "0x6017B0", VA = "0x1806031B0")]
		public GardenShopSlot()
		{
		}

		// Token: 0x040028EB RID: 10475
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40028EB")]
		public ShopItemData shopItem;

		// Token: 0x040028EC RID: 10476
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40028EC")]
		public Image icon;

		// Token: 0x040028ED RID: 10477
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40028ED")]
		public TextMeshProUGUI title;

		// Token: 0x040028EE RID: 10478
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40028EE")]
		private string baseText;

		// Token: 0x040028EF RID: 10479
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40028EF")]
		private int _currentHasCount;
	}
}
