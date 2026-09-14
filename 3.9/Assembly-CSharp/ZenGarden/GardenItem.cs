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
	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x2000A62")]
	public class GardenItem : GardenTool
	{
		// Token: 0x060036B7 RID: 14007 RVA: 0x001245C8 File Offset: 0x001227C8
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x7B7580", Offset = "0x7B5B80", VA = "0x1807B7580", Slot = "6")]
		protected override void Update()
		{
			List<ShopItemData> items = GardenUI.Data.inventory.items;
			Func<ShopItemData, bool> func = delegate(ShopItemData a)
			{
				Item item = this.itemType;
				return a.itemType == item;
			};
			int num = Enumerable.Count<ShopItemData>(Enumerable.Where<ShopItemData>(items, func));
			TextMeshProUGUI textMeshProUGUI = this.countTextMesh;
			this.restCount = num;
			string text = string.Format("x{0}", num);
			textMeshProUGUI.text = text;
			Image image = this.icon;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00124638 File Offset: 0x00122838
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x7B7420", Offset = "0x7B5A20", VA = "0x1807B7420", Slot = "4")]
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

		// Token: 0x060036B9 RID: 14009 RVA: 0x001246B8 File Offset: 0x001228B8
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x7B7730", Offset = "0x7B5D30", VA = "0x1807B7730", Slot = "5")]
		public override void Use(GardenPlant plant, [Optional] Vector2 position)
		{
			int num;
			Item item;
			do
			{
				num = 0;
				GardenItem.<>c__DisplayClass7_0 CS$<>8__locals1;
				CS$<>8__locals1.plant = plant;
				item = this.itemType;
				if (item > Item.Phonograph_lv2)
				{
					goto IL_0030;
				}
				List<GardenPlant> gardenPlants = GardenUI.Instance.gardenPlants;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			return;
			IL_0030:
			if (item == Item.SuperFertilizer)
			{
				AnimTool animTool = this.toolPrefab;
				GardenItem.<>c__DisplayClass7_0 CS$<>8__locals1;
				GardenPlant plant2 = CS$<>8__locals1.plant;
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.manager.background.transform;
				Action action = delegate
				{
					GardenPlant plant3 = CS$<>8__locals1.plant;
					GardenPlantData data2 = plant3.data;
					int num3 = 0;
					if (data2.growStage < 2)
					{
						data2.growStage = (int)((ulong)2L);
						GardenPlant.<Grow>d__40 <Grow>d__;
						<Grow>d__.System.IDisposable.Dispose();
						<Grow>d__.<>1__state = num3;
						<Grow>d__.<>4__this = plant3;
						Coroutine coroutine = plant3.StartCoroutine(<Grow>d__);
					}
					GameObject bubble = plant3.Bubble;
					plant3.ready = num3 != 0;
					global::UnityEngine.Object.Destroy(bubble);
					plant3.data.needTool = (GardenToolType)((ulong)1L);
					plant3.data.waterLevel = num3;
					GardenPlantData data3 = plant3.data;
					long currentTime = plant3.CurrentTime;
					uint num5;
					uint num6;
					int num4 = global::UnityEngine.Random.Range((int)num5, (int)num6);
					num4 = (int)((long)num4 + currentTime);
					data3.nextTime = (long)num4;
					plant3.data.love = (int)((ulong)100L);
					plant3.Prize();
					GardenUI.Data.Save("使用了超级肥料");
				};
				AnimTool animTool2;
				animTool2.action = action;
				GameAPP.PlaySound((SoundType)((uint)65), 0.5f, 1f);
			}
			Inventory inventory = GardenUI.Data.inventory;
			Item item2 = this.itemType;
			inventory.UseItem(item2);
			GardenUnifiedData data = GardenUI.Data;
			int num2 = 0;
			data.Save(num2);
			throw new NullReferenceException();
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0012479C File Offset: 0x0012299C
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public GardenItem()
		{
		}

		// Token: 0x04002A34 RID: 10804
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002A34")]
		public Item itemType;

		// Token: 0x04002A35 RID: 10805
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002A35")]
		public TextMeshProUGUI countTextMesh;

		// Token: 0x04002A36 RID: 10806
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002A36")]
		public Image icon;

		// Token: 0x04002A37 RID: 10807
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002A37")]
		private int restCount;

		// Token: 0x04002A38 RID: 10808
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002A38")]
		public AnimTool toolPrefab;

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		private static bool locked;
	}
}
