using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace ZenGarden
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	public class GardenTool : MonoBehaviour
	{
		// Token: 0x0600359D RID: 13725 RVA: 0x0012056C File Offset: 0x0011E76C
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x754150", Offset = "0x752750", VA = "0x180754150")]
		private void Awake()
		{
			RectTransform component = base.transform.parent.GetComponent<RectTransform>();
			this.parent = component;
			BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
			this._collider2D = component2;
			RectTransform component3 = base.GetComponent<RectTransform>();
			this.rectTransform = component3;
			throw new NullReferenceException();
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x001205B4 File Offset: 0x0011E7B4
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x754C40", Offset = "0x753240", VA = "0x180754C40")]
		private void Start()
		{
			GardenUI instance = GardenUI.Instance;
			this.manager = instance;
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x001205D0 File Offset: 0x0011E7D0
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x754820", Offset = "0x752E20", VA = "0x180754820")]
		private void InputUpdate()
		{
			if (this._collider2D.enabled)
			{
				GardenPlant plantOnGlove = GardenUI.Instance.plantOnGlove;
				int num = 0;
				if (!(plantOnGlove != num))
				{
					GardenToolType gardenToolType = this.type;
					if (gardenToolType > GardenToolType.WheelBarrow || gardenToolType != GardenToolType.Default)
					{
					}
				}
			}
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00120618 File Offset: 0x0011E818
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x754A00", Offset = "0x753000", VA = "0x180754A00", Slot = "4")]
		public virtual void PickUp()
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
			if (this.type == GardenToolType.WateringCan)
			{
				Transform transform2 = base.transform;
				int num3 = 0;
				ulong num4;
				transform2.GetChild(num3).gameObject.SetActive(num4 != 0UL);
			}
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00120694 File Offset: 0x0011E894
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x754B30", Offset = "0x753130", VA = "0x180754B30")]
		public void PutDown()
		{
			Transform transform = base.transform;
			RectTransform rectTransform = this.parent;
			transform.parentInternal = rectTransform;
			RectTransform rectTransform2 = this.rectTransform;
			this._collider2D.enabled = true;
			GameAPP.PlaySound(20, 1f, 1f);
			if (this.type == GardenToolType.WateringCan)
			{
				Transform transform2 = base.transform;
				int num = 0;
				GameObject gameObject = transform2.GetChild(num).gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
				return;
			}
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00120710 File Offset: 0x0011E910
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x754F50", Offset = "0x753550", VA = "0x180754F50", Slot = "5")]
		public virtual void Use(GardenPlant plant, [Optional] Vector2 position)
		{
			int num;
			GardenTool.<>c__DisplayClass12_0 CS$<>8__locals1;
			float z2;
			AnimTool animTool;
			for (;;)
			{
				num = 0;
				CS$<>8__locals1 = new GardenTool.<>c__DisplayClass12_0();
				CS$<>8__locals1.plant = plant;
				CS$<>8__locals1.<>4__this = this;
				if (this.type <= GardenToolType.MoneySign)
				{
					GardenPlant plant2 = CS$<>8__locals1.plant;
					Vector3 vector;
					float z = vector.z;
					Vector3 vector2;
					z2 = vector2.z;
					UIResourcesLoader uimanager = GameAPP.UIManager;
					BaseMenu baseMenu;
					if (baseMenu == 0)
					{
					}
					IntPtr cachedPtr = baseMenu.m_CachedPtr;
					List<Collider2D> collider2Ds = baseMenu.collider2Ds;
					UnityAction unityAction = delegate
					{
						GardenUI instance2 = GardenUI.Instance;
						GardenTool.<>c__DisplayClass12_0 CS$<>8__locals3 = z2.CS$<>8__locals1;
						List<GardenPlant> gardenPlants2 = instance2.gardenPlants;
						GardenPlant plant4 = CS$<>8__locals3.plant;
						bool flag2 = gardenPlants2.Remove(plant4);
						global::UnityEngine.Object.Destroy(z2.CS$<>8__locals1.plant.gameObject);
						GardenUnifiedData data = GardenUI.Data;
						GardenPlant plant5 = z2.CS$<>8__locals1.plant;
						List<GardenPlantData> allPlants2 = data.allPlants;
						GardenPlantData data2 = plant5.data;
						bool flag3 = allPlants2.Remove(data2);
						GardenUnifiedData data3 = GardenUI.Data;
						string name = global::Lawnf.GetName(z2.CS$<>8__locals1.plant.data.thePlantType);
						string text = "出售植物：" + name;
						data3.Save(text);
						Transform axis = z2.CS$<>8__locals1.plant.axis;
						Vector3 vector3;
						float z3 = vector3.z;
						Vector3 vector4;
						float z4 = vector4.z;
						Transform transform4 = GardenUI.Instance.background.transform;
						if (z2.CS$<>8__locals1.plant.data.love < 100)
						{
							int growStage = z2.CS$<>8__locals1.plant.data.growStage;
							if (growStage != 0)
							{
								if (growStage != 0)
								{
									if (growStage != 1)
									{
										goto IL_0194;
									}
									while (growStage != 1)
									{
									}
								}
								while (growStage != 1)
								{
								}
							}
						}
						GameObject gameObject = Resources.Load<GameObject>("Garden/GardenCoin");
						Quaternion identityQuaternion = Quaternion.identityQuaternion;
						GameObject gameObject2;
						DroppedItem droppedItem = gameObject2.AddComponent<DroppedItem>();
						GardenTool.<>c__DisplayClass12_0 CS$<>8__locals4 = z2.CS$<>8__locals1;
						droppedItem.landY = (float)0;
						Action<DroppedItem> <>9__ = CS$<>8__locals4.<>9__2;
						if (<>9__ == 0)
						{
							Action<DroppedItem> action;
							z2.CS$<>8__locals1.<>9__2 = action;
						}
						droppedItem.onLand = <>9__;
						Action<DroppedItem> action2;
						if (GardenTool.<>c.<>9__12_3 == 0)
						{
							GardenTool.<>c.<>9__12_3 = action2;
						}
						droppedItem.onDeath = action2;
						IL_0194:
						z2.menu.PopMenu();
					};
					GardenPlant gardenPlant = this.manager.plantOnWheel;
					int num2 = 0;
					if (gardenPlant == num2)
					{
						break;
					}
				}
				GardenToolType gardenToolType = this.type;
				GardenUI gardenUI = this.manager;
				Dictionary<GardenToolType, AnimTool> toolAnimPrefabs = GameAPP.resourcesManager.ToolAnimPrefabs;
				bool flag;
				if (flag)
				{
					Transform transform = animTool.transform;
					Transform transform2 = gardenUI.background.transform;
					transform.parentInternal = transform2;
				}
				int num3 = 0;
				if (animTool != num3)
				{
					goto Block_4;
				}
			}
			GardenUI instance = GardenUI.Instance;
			if ((instance.inStore ? 1 : 0) == num)
			{
				IntPtr cachedPtr2 = instance.m_CachedPtr;
				GardenUI gardenUI2 = this.manager;
				IntPtr cachedPtr3 = instance.m_CachedPtr;
				gardenUI2.plantOnWheel = cachedPtr3;
				this.plantOnWheel = cachedPtr3;
				Transform transform3;
				IntPtr cachedPtr4 = transform3.m_CachedPtr;
				List<GardenPlant> gardenPlants = this.manager.gardenPlants;
				List<GardenPlantData> allPlants = GardenUI.Data.allPlants;
				GardenUI.Data.Save("把植物放到手推车上");
			}
			UIResourcesLoader uimanager2 = GameAPP.UIManager;
			BaseMenu baseMenu2;
			if (baseMenu2 == 0)
			{
			}
			List<Collider2D> collider2Ds2 = baseMenu2.collider2Ds;
			UnityAction unityAction2 = delegate
			{
				int num4 = 0;
				InGameText instance3 = InGameText.Instance;
				int num5 = 0;
				instance3.ShowText("余额不足", 3f, num5 != 0);
				GardenUnifiedData data4 = GardenUI.Data;
				PlantType thePlantType = z2.CS$<>8__locals1.plant.data.thePlantType;
				int currentPage = GardenUI.Instance.currentPage;
				bool flag4 = data4.TryAddPlantData(num4, num4, num4);
				if (!flag4)
				{
					InGameText instance4 = InGameText.Instance;
					int num6 = 0;
					instance4.ShowText("购买失败，花园已满", 3f, num6 != 0);
				}
				GardenUnifiedData data5 = GardenUI.Data;
				string name2 = global::Lawnf.GetName(z2.CS$<>8__locals1.plant.data.thePlantType);
				string text2 = "购买植物：" + name2;
				data5.Save(text2);
				z2.CS$<>8__locals1.plant.Die();
				InGameText instance5 = InGameText.Instance;
				num4++;
				num4++;
				num4++;
				int num7;
				int num8;
				int num9;
				string text3 = string.Format("购买成功，植物已放在第{0}页的第{1}行{2}列格子中", num7, num8, num9);
				int num10 = 0;
				instance5.ShowText(text3, 3f, num10 != 0);
				GameAPP.theMoneyCount = GameAPP.theMoneyCount;
				z2.menu.PopMenu();
			};
			return;
			Block_4:
			GardenPlant plant3 = CS$<>8__locals1.plant;
			animTool.plant = plant3;
			throw new NullReferenceException();
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x001208BC File Offset: 0x0011EABC
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x754C90", Offset = "0x753290", VA = "0x180754C90", Slot = "6")]
		protected virtual void Update()
		{
			GardenPlant gardenPlant = this.plantOnWheel;
			int num = 0;
			bool flag = gardenPlant != num;
			int num2 = 0;
			if (flag)
			{
				GardenPlant gardenPlant2 = this.plantOnWheel;
				if ((gardenPlant2.onWheelBarrow ? 1 : 0) == num2)
				{
					this.plantOnWheel = num2;
				}
				Transform transform = gardenPlant2.transform;
				Transform transform2 = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
			GardenTool toolOnMouse = GardenUI.Instance.toolOnMouse;
			int num3 = 0;
			if (toolOnMouse == num3 && (GardenUI.Instance.inStore ? 1 : 0) == num2 && this._collider2D.enabled)
			{
				GardenPlant plantOnGlove = GardenUI.Instance.plantOnGlove;
				int num4 = 0;
				if (!(plantOnGlove != num4))
				{
					GardenToolType gardenToolType = this.type;
					if (gardenToolType <= GardenToolType.WheelBarrow && gardenToolType != GardenToolType.Default)
					{
						this.PickUp();
					}
				}
			}
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00120984 File Offset: 0x0011EB84
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x7543F0", Offset = "0x7529F0", VA = "0x1807543F0")]
		private void CreatePreview(GardenPlant plant)
		{
			int num;
			do
			{
				num = 0;
				GardenPlantData data = plant.data;
				int thePlantColumn = data.thePlantColumn;
				PlantType thePlantType = data.thePlantType;
				Transform transform = this.manager.background.transform;
				GardenPlant gardenPlant;
				GardenPlant component = gardenPlant.GetComponent<GardenPlant>();
				GardenPlantData data2 = plant.data;
				component.data = data2;
				GardenUI gardenUI = this.manager;
				GameObject gameObject = gardenPlant.gameObject;
				gardenUI.plantFollowMouse = gameObject;
				this.manager.plantOnGlove = plant;
				GardenPlantData data3 = plant.data;
				int thePlantColumn2 = data3.thePlantColumn;
				PlantType thePlantType2 = data3.thePlantType;
				Transform transform2 = this.manager.background.transform;
				GardenUI instance = GardenUI.Instance;
				GardenPlant gardenPlant2;
				GameObject gameObject2 = gardenPlant2.gameObject;
				instance.plantPreview = gameObject2;
				GardenPlant component2 = gardenPlant2.GetComponent<GardenPlant>();
				GardenPlantData data4 = plant.data;
				component2.data = data4;
				uint num2;
				gardenPlant2.GetComponent<SortingGroup>().sortingOrder = (int)num2;
				List<GameObject> childs = global::Core.Lawnf.GetChilds(gardenPlant2.transform);
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
				}
			}
			while (num != 0);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x00120A9C File Offset: 0x0011EC9C
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x754970", Offset = "0x752F70", VA = "0x180754970")]
		private void OnMouseEnter()
		{
			GardenTool toolOnMouse = GardenUI.Instance.toolOnMouse;
			int num = 0;
			if (toolOnMouse == num)
			{
				CursorChange.SetClickCursor();
				return;
			}
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00120AD0 File Offset: 0x0011ECD0
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
		private void OnMouseExit()
		{
			CursorChange.SetDefaultCursor();
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x00120AE4 File Offset: 0x0011ECE4
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x754210", Offset = "0x752810", VA = "0x180754210")]
		private AnimTool CreateAnim(GardenToolType gardenToolType, GardenUI manager, Vector2 position)
		{
			Dictionary<GardenToolType, AnimTool> toolAnimPrefabs = GameAPP.resourcesManager.ToolAnimPrefabs;
			bool flag;
			if (!flag)
			{
			}
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			AnimTool animTool;
			Transform transform = animTool.transform;
			Transform transform2 = manager.background.transform;
			transform.parentInternal = transform2;
			throw new NullReferenceException();
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00120B34 File Offset: 0x0011ED34
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public GardenTool()
		{
		}

		// Token: 0x040028F0 RID: 10480
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40028F0")]
		public GardenToolType type;

		// Token: 0x040028F1 RID: 10481
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40028F1")]
		private RectTransform parent;

		// Token: 0x040028F2 RID: 10482
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40028F2")]
		private Collider2D _collider2D;

		// Token: 0x040028F3 RID: 10483
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40028F3")]
		private Vector3 originalPosition;

		// Token: 0x040028F4 RID: 10484
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40028F4")]
		private RectTransform rectTransform;

		// Token: 0x040028F5 RID: 10485
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40028F5")]
		public GardenUI manager;

		// Token: 0x040028F6 RID: 10486
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40028F6")]
		public GardenPlant plantOnWheel;
	}
}
