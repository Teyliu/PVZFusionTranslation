using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ZenGarden
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public class GardenStoreMenu : BaseMenu
	{
		// Token: 0x060035DB RID: 13787 RVA: 0x001227F8 File Offset: 0x001209F8
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x7540F0", Offset = "0x7526F0", VA = "0x1807540F0")]
		private void Start()
		{
			this.InitGoodsList();
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0012280C File Offset: 0x00120A0C
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x754100", Offset = "0x752700", VA = "0x180754100")]
		private void Update()
		{
			TextMeshProUGUI textMeshProUGUI = this.coinCount;
			GardenUnifiedData data = GardenUI.Data;
			throw new NullReferenceException();
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00122830 File Offset: 0x00120A30
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x753840", Offset = "0x751E40", VA = "0x180753840")]
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

		// Token: 0x060035DE RID: 13790 RVA: 0x0012296C File Offset: 0x00120B6C
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x753C90", Offset = "0x752290", VA = "0x180753C90")]
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
				int num4 = 0;
				instance.ShowText("购买成功", 3f, num4 != 0);
				int countPerBuy2 = slot.shopItem.countPerBuy;
				slot.CurrentHas = countPerBuy2;
				return;
			}
			InGameText instance2 = InGameText.Instance;
			int num5 = 0;
			instance2.ShowText("持有量已达上限", 3f, num5 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00122AD0 File Offset: 0x00120CD0
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x7537C0", Offset = "0x751DC0", VA = "0x1807537C0")]
		private ShopDatas GetDatas()
		{
			return JsonUtility.FromJson<ShopDatas>(Resources.Load<TextAsset>("Garden/Goods").text);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00122AF8 File Offset: 0x00120CF8
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
		public GardenStoreMenu()
		{
		}

		// Token: 0x0400292E RID: 10542
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400292E")]
		[Header("预制体")]
		public GardenShopSlot goodsPrefab;

		// Token: 0x0400292F RID: 10543
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400292F")]
		public GameObject samplePage;

		// Token: 0x04002930 RID: 10544
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002930")]
		public TextMeshProUGUI coinCount;

		// Token: 0x04002931 RID: 10545
		[Token(Token = "0x4002931")]
		private const int pageSize = 9;
	}
}
