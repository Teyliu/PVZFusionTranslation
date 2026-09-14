using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ZenGarden
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	public class GardenStoreMenu : BaseMenu
	{
		// Token: 0x0600371F RID: 14111 RVA: 0x00127A44 File Offset: 0x00125C44
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x7BACA0", Offset = "0x7B92A0", VA = "0x1807BACA0")]
		private void Start()
		{
			this.InitGoodsList();
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00127A58 File Offset: 0x00125C58
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x7BACB0", Offset = "0x7B92B0", VA = "0x1807BACB0")]
		private void Update()
		{
			TextMeshProUGUI textMeshProUGUI = this.coinCount;
			GardenUnifiedData data = GardenUI.Data;
			throw new NullReferenceException();
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x00127A7C File Offset: 0x00125C7C
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x7BA3E0", Offset = "0x7B89E0", VA = "0x1807BA3E0")]
		private void InitGoodsList()
		{
			int num3;
			do
			{
				int num = 0;
				GameObject gameObject = this.samplePage;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
				num3 = 0;
				ShopDatas datas = this.GetDatas();
				List<ShopItemData> datas2 = this.GetDatas().datas;
				bool flag;
				if (flag)
				{
					GardenStoreMenu.<>c__DisplayClass6_0 CS$<>8__locals1;
					CS$<>8__locals1.<>4__this = this;
					GameObject gameObject2 = this.samplePage;
					Transform parent = gameObject2.transform.parent;
					GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, parent);
					GardenShopSlot gardenShopSlot = this.goodsPrefab;
					Transform transform = gameObject3.transform;
					GardenShopSlot gardenShopSlot2 = global::UnityEngine.Object.Instantiate<GardenShopSlot>(gardenShopSlot, transform);
					CS$<>8__locals1.shopSlot = gardenShopSlot2;
					string text;
					CS$<>8__locals1.shopSlot.gameObject.name = text;
					CS$<>8__locals1.shopSlot.shopItem = num;
					UnityEvent theEvent_up = CS$<>8__locals1.shopSlot.theEvent_up;
					UnityAction unityAction = delegate
					{
						GardenStoreMenu <>4__this = CS$<>8__locals1.<>4__this;
						GardenShopSlot shopSlot = CS$<>8__locals1.shopSlot;
						<>4__this.PurchaseGoods(shopSlot);
					};
					theEvent_up.AddListener(unityAction);
				}
			}
			while (num3 != 0);
			Transform transform2;
			uint num4;
			ulong num5;
			transform2.parent.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00127BB8 File Offset: 0x00125DB8
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x7BA830", Offset = "0x7B8E30", VA = "0x1807BA830")]
		public void PurchaseGoods(GardenShopSlot slot)
		{
			if (slot._currentHasCount < 90)
			{
				GardenUnifiedData data = GardenUI.Data;
				int cost = slot.shopItem.cost;
				GardenUnifiedData data2 = GardenUI.Data;
				ShopItemData shopItem = slot.shopItem;
				int num = data2.coinCount;
				int num2 = 0;
				data2.coinCount = num;
				int num3 = 0;
				ShopItemData shopItem2 = slot.shopItem;
				if (num3 < shopItem2.countPerBuy)
				{
					GardenUI._data = GardenData.GetData();
					GardenUnifiedData data3 = GardenUI._data;
					ShopItemData shopItem3 = slot.shopItem;
					Inventory inventory = data3.inventory;
					ShopItemData shopItemData = JsonUtility.FromJson<ShopItemData>(JsonUtility.ToJson(shopItem3));
					int size = inventory.items._size;
					num2++;
					num2++;
				}
				GardenUI._data = GardenData.GetData();
				GardenUnifiedData data4 = GardenUI._data;
				int countPerBuy = slot.shopItem.countPerBuy;
				Item itemType = slot.shopItem.itemType;
				string text = string.Format("购买了{0}个{1}", countPerBuy, countPerBuy);
				data4.Save(text);
				InGameText instance = InGameText.Instance;
				int countPerBuy2 = slot.shopItem.countPerBuy;
				slot.CurrentHas = countPerBuy2;
				return;
			}
			InGameText instance2 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00127CF0 File Offset: 0x00125EF0
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x7BA360", Offset = "0x7B8960", VA = "0x1807BA360")]
		private ShopDatas GetDatas()
		{
			return JsonUtility.FromJson<ShopDatas>(Resources.Load<TextAsset>("Garden/Goods").text);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00127D18 File Offset: 0x00125F18
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
		public GardenStoreMenu()
		{
		}

		// Token: 0x04002AA1 RID: 10913
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002AA1")]
		[Header("预制体")]
		public GardenShopSlot goodsPrefab;

		// Token: 0x04002AA2 RID: 10914
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002AA2")]
		public GameObject samplePage;

		// Token: 0x04002AA3 RID: 10915
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002AA3")]
		public TextMeshProUGUI coinCount;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		private const int pageSize = 9;
	}
}
