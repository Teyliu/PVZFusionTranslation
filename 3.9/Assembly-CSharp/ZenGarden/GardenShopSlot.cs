using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ZenGarden
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	public class GardenShopSlot : TheButton
	{
		// Token: 0x060036DC RID: 14044 RVA: 0x0012571C File Offset: 0x0012391C
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x7BA060", Offset = "0x7B8660", VA = "0x1807BA060")]
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
			List<ShopItemData> items = GardenUI.Data.inventory.items;
			Func<ShopItemData, bool> func = delegate(ShopItemData a)
			{
				Item itemType2 = this.shopItem.itemType;
				return a.itemType == itemType2;
			};
			int num2 = Enumerable.Count<ShopItemData>(Enumerable.Where<ShopItemData>(items, func));
			this.CurrentHas = num2;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x001257E4 File Offset: 0x001239E4
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x001257F8 File Offset: 0x001239F8
		[Token(Token = "0x17000287")]
		public int CurrentHas
		{
			[Token(Token = "0x60036DD")]
			[Address(RVA = "0x7BA290", Offset = "0x7B8890", VA = "0x1807BA290")]
			get
			{
				return this._currentHasCount;
			}
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x7BA2A0", Offset = "0x7B88A0", VA = "0x1807BA2A0")]
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

		// Token: 0x060036DF RID: 14047 RVA: 0x00125840 File Offset: 0x00123A40
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x6669C0", Offset = "0x664FC0", VA = "0x1806669C0")]
		public GardenShopSlot()
		{
		}

		// Token: 0x04002A5E RID: 10846
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002A5E")]
		public ShopItemData shopItem;

		// Token: 0x04002A5F RID: 10847
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002A5F")]
		public Image icon;

		// Token: 0x04002A60 RID: 10848
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002A60")]
		public TextMeshProUGUI title;

		// Token: 0x04002A61 RID: 10849
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002A61")]
		private string baseText;

		// Token: 0x04002A62 RID: 10850
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002A62")]
		private int _currentHasCount;
	}
}
