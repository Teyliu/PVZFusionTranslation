using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ZenGarden
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	public class GardenItem : GardenTool
	{
		// Token: 0x06003576 RID: 13686 RVA: 0x0011F4AC File Offset: 0x0011D6AC
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x750BC0", Offset = "0x74F1C0", VA = "0x180750BC0", Slot = "6")]
		protected override void Update()
		{
			Func<ShopItemData, bool> func;
			int num = Enumerable.Count<ShopItemData>(Enumerable.Where<ShopItemData>(GardenUI.Data.inventory.items, func));
			TextMeshProUGUI textMeshProUGUI = this.countTextMesh;
			this.restCount = num;
			string text = string.Format("x{0}", num);
			textMeshProUGUI.text = text;
			Image image = this.icon;
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0011F508 File Offset: 0x0011D708
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x750A60", Offset = "0x74F060", VA = "0x180750A60", Slot = "4")]
		public override void PickUp()
		{
			if (this.restCount > 0)
			{
				GardenUI.Instance.toolOnMouse = this;
				Transform transform = base.transform;
				Transform canvasUp = GameAPP.canvasUp;
				transform.parentInternal = canvasUp;
				Collider2D collider2D = this._collider2D;
				int num = 0;
				collider2D.enabled = num != 0;
				uint num2;
				GameAPP.PlaySound((int)num2, 1f, 1f);
				Transform transform2 = base.transform;
				int num3 = 0;
				ulong num4;
				transform2.GetChild(num3).gameObject.SetActive(num4 != 0UL);
			}
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0011F588 File Offset: 0x0011D788
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x750D70", Offset = "0x74F370", VA = "0x180750D70", Slot = "5")]
		public override void Use(GardenPlant plant, [Optional] Vector2 position)
		{
			ulong num;
			do
			{
				List<GardenPlant> gardenPlants = GardenUI.Instance.gardenPlants;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
			GardenUI._data = GardenData.GetData();
			Inventory inventory = GardenUI._data.inventory;
			GardenUI._data = GardenData.GetData();
			GardenUnifiedData data = GardenUI._data;
			int num2 = 0;
			data.Save(num2);
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0011F5EC File Offset: 0x0011D7EC
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public GardenItem()
		{
		}

		// Token: 0x040028C3 RID: 10435
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40028C3")]
		public Item itemType;

		// Token: 0x040028C4 RID: 10436
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40028C4")]
		public TextMeshProUGUI countTextMesh;

		// Token: 0x040028C5 RID: 10437
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40028C5")]
		public Image icon;

		// Token: 0x040028C6 RID: 10438
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40028C6")]
		private int restCount;

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		private static bool locked;
	}
}
