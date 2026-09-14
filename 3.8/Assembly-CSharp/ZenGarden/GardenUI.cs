using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ZenGarden
{
	// Token: 0x02000A2C RID: 2604
	[Token(Token = "0x2000A2C")]
	public class GardenUI : BaseMenu
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x00120EC4 File Offset: 0x0011F0C4
		[Token(Token = "0x17000240")]
		public static GardenUnifiedData Data
		{
			[Token(Token = "0x60035B1")]
			[Address(RVA = "0x759EC0", Offset = "0x7584C0", VA = "0x180759EC0")]
			get
			{
				GardenUI._data = GardenData.GetData();
				return GardenUI._data;
			}
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00120EE4 File Offset: 0x0011F0E4
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x755B20", Offset = "0x754120", VA = "0x180755B20", Slot = "6")]
		protected override void Awake()
		{
			GardenUI.Instance = this;
			base.Awake();
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00120F00 File Offset: 0x0011F100
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x758AE0", Offset = "0x7570E0", VA = "0x180758AE0")]
		private void OnDestroy()
		{
			global::UnityEngine.Object.Destroy(this.background.gameObject);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00120F24 File Offset: 0x0011F124
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x7591E0", Offset = "0x7577E0", VA = "0x1807591E0")]
		private void Start()
		{
			int num = this.currentPage;
			num++;
			TextMeshProUGUI textMeshProUGUI = this.currentPageText;
			string text = string.Format("第{0}页", num);
			textMeshProUGUI.text = text;
			GameObject gameObject = this.background.gameObject;
			this.GetBoxes(gameObject);
			GardenUnifiedData data = GardenUI.Data;
			int num2 = this.currentPage;
			data.LoadPlants(this, num2);
			SpriteRenderer main = this.background.main;
			this.background.SwitchSceneImmediate(main);
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00120FA8 File Offset: 0x0011F1A8
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x759570", Offset = "0x757B70", VA = "0x180759570")]
		private void Update()
		{
			this.MouseUpdate();
			this.MouseToolUpdate();
			TextMeshProUGUI textMeshProUGUI = this.coinText;
			GardenUnifiedData data = GardenUI.Data;
			throw new NullReferenceException();
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00120FD8 File Offset: 0x0011F1D8
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x756850", Offset = "0x754E50", VA = "0x180756850")]
		private void FixedUpdate()
		{
			int num2;
			do
			{
				int num = 0;
				List<GardenPlant> list = this.gardenPlants;
				num2 = 0;
				bool flag;
				if (flag)
				{
					GameMaterial.SetBrightness(num, 1f);
				}
			}
			while (num2 != 0);
			int num3 = 0;
			bool flag2;
			if (flag2)
			{
			}
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector2 zeroVector = Vector2.zeroVector;
			RaycastHit2D[] array;
			Collider2D collider2D;
			if (num3 < array.Length && !collider2D.TryGetComponent<GardenBox>(num3))
			{
				num3++;
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00121060 File Offset: 0x0011F260
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x756C00", Offset = "0x755200", VA = "0x180756C00")]
		private void GetBoxes(GameObject obj)
		{
			int num;
			do
			{
				num = 0;
				if (obj.TryGetComponent<GardenBox>(num))
				{
					List<GardenBox> list = this.gardenBoxes;
					int num2 = list._size + 1;
					list._size = num2;
				}
				Transform transform = obj.transform;
				int num3 = 0;
				IEnumerator enumerator = transform.GetEnumerator();
				if (num < num3)
				{
					num += num;
					num++;
				}
				if (num < num)
				{
					num += num;
					num++;
				}
				num += 312;
				GameObject gameObject;
				this.GetBoxes(gameObject);
				if (gameObject != 0)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x001210F4 File Offset: 0x0011F2F4
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x757910", Offset = "0x755F10", VA = "0x180757910")]
		private void LightPlant()
		{
			int num = 0;
			this.currentBox = num;
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			if (this.toolOnMouse.type != GardenToolType.WateringCan)
			{
				RaycastHit2D[] array;
				if (num >= array.Length)
				{
					return;
				}
				Collider2D collider2D;
				if (collider2D.TryGetComponent<GardenPlant>(num))
				{
				}
				num++;
			}
			Collider2D[] array2;
			if (num < array2.Length)
			{
				bool flag;
				if (flag)
				{
				}
				num++;
			}
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00121164 File Offset: 0x0011F364
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x7575C0", Offset = "0x755BC0", VA = "0x1807575C0")]
		private void LeftClickWithSomething()
		{
			int i = 0;
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			if (this.toolOnMouse.type != GardenToolType.WateringCan)
			{
				RaycastHit2D[] array;
				if (i < array.Length)
				{
					Collider2D collider2D;
					if (!collider2D.TryGetComponent<GardenPlant>(i))
					{
						i++;
					}
					this.toolOnMouse.PutDown();
					GardenTool gardenTool = this.toolOnMouse;
					int num = 0;
					gardenTool.Use(i, num);
					this.toolOnMouse = i;
					return;
				}
				this.toolOnMouse.PutDown();
			}
			GardenTool gardenTool2 = this.toolOnMouse;
			gardenTool2.PutDown();
			Collider2D[] array2;
			while (i >= array2.Length)
			{
			}
			if (gardenTool2.TryGetComponent<GardenPlant>(i))
			{
				GardenTool gardenTool3 = this.toolOnMouse;
			}
			i++;
			throw new NullReferenceException();
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x0012121C File Offset: 0x0011F41C
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x756F40", Offset = "0x755540", VA = "0x180756F40")]
		private void GetCurrentBox()
		{
			int num = 0;
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				Collider2D collider2D;
				if (!collider2D.TryGetComponent<GardenBox>(num))
				{
					num++;
				}
				this.currentBox = num;
			}
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0012126C File Offset: 0x0011F46C
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x757BF0", Offset = "0x7561F0", VA = "0x180757BF0")]
		private void MouseToolUpdate()
		{
			ulong num5;
			do
			{
				Camera main = Camera.main;
				float z = Input.mousePosition.z;
				Vector3 vector;
				float z2 = vector.z;
				GardenTool gardenTool = this.toolOnMouse;
				int num = 0;
				if (gardenTool != num)
				{
					Transform transform = this.toolOnMouse.transform;
				}
				GardenPlant gardenPlant = this.plantOnGlove;
				int num2 = 0;
				if (gardenPlant != num2)
				{
					Transform transform2 = this.plantFollowMouse.transform;
				}
				GameObject gameObject = this.plantPreview;
				int num3 = 0;
				if (!(gameObject != num3))
				{
					return;
				}
				GardenBox gardenBox = this.currentBox;
				int num4 = 0;
				if (gardenBox == num4)
				{
					goto IL_00D8;
				}
				List<GardenPlant> list = this.gardenPlants;
				bool flag;
				if (flag)
				{
					int row = this.currentBox.row;
					Transform transform3 = this.plantPreview.transform;
				}
			}
			while (num5 != (ulong)0L);
			Vector3 vector2;
			float z3 = vector2.z;
			return;
			IL_00D8:
			throw new NullReferenceException();
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00121378 File Offset: 0x0011F578
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x758040", Offset = "0x756640", VA = "0x180758040")]
		private void MouseUpdate()
		{
			int num = 0;
			if (!Input.GetMouseButtonDown(0))
			{
				uint num2;
				if (Input.GetMouseButtonDown((int)num2))
				{
					GardenTool gardenTool = this.toolOnMouse;
					int num3 = 0;
					if (gardenTool != num3)
					{
						this.toolOnMouse.PutDown();
						this.toolOnMouse = num;
					}
					GardenPlant gardenPlant = this.plantOnGlove;
					int num4 = 0;
					if (gardenPlant != num4)
					{
						GardenPlant gardenPlant2 = this.plantOnGlove;
						this.plantOnGlove = num;
						global::UnityEngine.Object.Destroy(this.plantFollowMouse);
						global::UnityEngine.Object.Destroy(this.plantPreview);
						return;
					}
				}
			}
			else
			{
				GardenTool gardenTool2 = this.toolOnMouse;
				int num5 = 0;
				if (!(gardenTool2 == num5))
				{
					GardenPlant gardenPlant3 = this.plantOnWheel;
					int num6 = 0;
					if (gardenPlant3 != num6 && this.toolOnMouse.TryGetComponent<GardenTool>(num))
					{
						GardenPlant gardenPlant4 = this.plantOnWheel;
						int num7 = 0;
						this.MovePlant(gardenPlant4, num7 != 0);
						return;
					}
					this.LeftClickWithSomething();
					return;
				}
				else
				{
					GardenPlant gardenPlant5 = this.plantOnGlove;
					int num8 = 0;
					if (gardenPlant5 != num8)
					{
						GardenPlant gardenPlant6 = this.plantOnGlove;
						ulong num9;
						this.MovePlant(gardenPlant6, num9 != 0UL);
						return;
					}
					Camera main = Camera.main;
					float z = Input.mousePosition.z;
					GardenPlant gardenPlant3;
					RaycastHit2D[] array;
					if (gardenPlant3 < array.Length)
					{
						bool flag;
						if (!flag || !this.inStore || gardenPlant3.data != (ulong)7L)
						{
						}
						CursorChange.SetClickCursor();
					}
				}
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x001214D8 File Offset: 0x0011F6D8
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x758500", Offset = "0x756B00", VA = "0x180758500")]
		private void MovePlant(GardenPlant plant, bool glove)
		{
			int num3;
			do
			{
				int num = 0;
				GardenBox gardenBox = this.currentBox;
				int num2 = 0;
				if (gardenBox == num2)
				{
					return;
				}
				List<GardenPlant> list = this.gardenPlants;
				num3 = 0;
				bool flag;
				if (flag)
				{
					int row = this.currentBox.row;
					if (!(num != plant))
					{
						continue;
					}
					GardenBox gardenBox2 = this.currentBox;
					int row2 = gardenBox2.row;
					int column = gardenBox2.column;
					this.TryMixPlant(num, plant, column, row2);
				}
			}
			while (num3 != 0);
			Vector3 vector;
			float z = vector.z;
			Transform transform;
			transform.m_CachedPtr = (IntPtr)z;
			string text = string.Format("plant{0}", z);
			Vector3 vector2;
			float z2 = vector2.z;
			List<GardenPlantData> allPlants = GardenUI.Data.allPlants;
			global::UnityEngine.Object.Destroy(transform);
			global::UnityEngine.Object.Destroy(transform);
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			GardenUI.Data.Save("移动植物");
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x001215DC File Offset: 0x0011F7DC
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x7592D0", Offset = "0x7578D0", VA = "0x1807592D0")]
		private void TryMixPlant(GardenPlant plant1, GardenPlant plant2, int theColumn, int theRow)
		{
			int num = 0;
			PlantType thePlantType = plant1.data.thePlantType;
			PlantType thePlantType2 = plant2.data.thePlantType;
			bool flag;
			if (flag)
			{
				GardenPlantData data = plant1.data;
				GardenPlantData data2 = plant2.data;
				plant1.Die();
				plant2.Die();
				List<GardenPlantData> allPlants = GardenUI.Data.allPlants;
				GardenPlantData data3 = plant1.data;
				bool flag2 = allPlants.Remove(data3);
				List<GardenPlantData> allPlants2 = GardenUI.Data.allPlants;
				GardenPlantData data4 = plant2.data;
				bool flag3 = allPlants2.Remove(data4);
				GardenUnifiedData data5 = GardenUI.Data;
				int num2 = this.currentPage;
				GardenPlantData gardenPlantData;
				GardenPlant gardenPlant = gardenPlantData.CreatePlant(this);
				List<GardenPlant> list = this.gardenPlants;
				this.plantOnGlove = num;
				global::UnityEngine.Object.Destroy(this.plantFollowMouse);
				global::UnityEngine.Object.Destroy(this.plantPreview);
				GameAPP.PlaySound(114, 0.5f, 1f);
				GardenUI.Data.Save("融合植物");
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x001216D8 File Offset: 0x0011F8D8
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x757380", Offset = "0x755980", VA = "0x180757380")]
		private void LeftClickWithNothing()
		{
			int num = 0;
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				Collider2D collider2D;
				if (!collider2D.TryGetComponent<GardenTool>(num) || this.inStore)
				{
					num++;
				}
				CursorChange.SetClickCursor();
			}
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00121734 File Offset: 0x0011F934
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x7590B0", Offset = "0x7576B0", VA = "0x1807590B0")]
		private void RightClick()
		{
			GardenTool gardenTool = this.toolOnMouse;
			int num = 0;
			if (gardenTool != num)
			{
				this.toolOnMouse.PutDown();
				this.toolOnMouse = (ulong)0L;
			}
			GardenPlant gardenPlant = this.plantOnGlove;
			int num2 = 0;
			if (gardenPlant != num2)
			{
				GardenPlant gardenPlant2 = this.plantOnGlove;
				this.plantOnGlove = (ulong)0L;
				global::UnityEngine.Object.Destroy(this.plantFollowMouse);
				global::UnityEngine.Object.Destroy(this.plantPreview);
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x001217AC File Offset: 0x0011F9AC
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x7562F0", Offset = "0x7548F0", VA = "0x1807562F0")]
		public void EnterStore()
		{
			if (!this.inStore)
			{
				GardenPlant gardenPlant = this.plantOnWheel;
				int num = 0;
				bool flag = gardenPlant != num;
				if (flag)
				{
					InGameText instance = InGameText.Instance;
					int num2 = 0;
					instance.ShowText("请先将手推车中的植物放下", 10f, num2 != 0);
					throw new NullReferenceException();
				}
				this.inStore = true;
				InGameText instance2 = InGameText.Instance;
				int num3 = 0;
				int num4 = 0;
				instance2.ShowText("使用手推车购买植物", 3f, num4 != 0);
				this.exitStoreButton.SetActive(true);
				this.refreshStoreButton.SetActive(true);
				int size = this.gardenPlants._size;
				int num5 = size - 1;
				if (size > 0)
				{
					this.gardenPlants[num5].Die();
				}
				this.currentPageText.text = "商店";
				PlantType random = ListExtensions.GetRandom<PlantType>(this.GetStorePlants());
				List<GardenPlant> list = this.gardenPlants;
				GardenPlantData gardenPlantData;
				GardenPlant gardenPlant2 = gardenPlantData.CreatePlant(this);
				num3++;
				num3++;
			}
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x001218AC File Offset: 0x0011FAAC
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x758E50", Offset = "0x757450", VA = "0x180758E50")]
		public void RefreshStore()
		{
			int num2;
			do
			{
				int num = 0;
				if ((this.inStore ? 1 : 0) == num)
				{
					return;
				}
				List<GardenPlant> list = Enumerable.ToList<GardenPlant>(this.gardenPlants);
				num2 = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num2 != 0);
			int num3 = 0;
			List<PlantType> list2;
			int random = (int)ListExtensions.GetRandom<PlantType>(list2);
			num3++;
			num3++;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00121904 File Offset: 0x0011FB04
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x757150", Offset = "0x755750", VA = "0x180757150")]
		private List<PlantType> GetStorePlants()
		{
			int num;
			List<PlantType> list;
			bool flag;
			ulong num2;
			do
			{
				num = 0;
				list = Enumerable.ToList<PlantType>(this.StorePlants);
				HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
			}
			while ((flag && TypeMgr.IsPot((PlantType)num)) || num2 != (ulong)0L);
			return list;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00121954 File Offset: 0x0011FB54
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x7565C0", Offset = "0x754BC0", VA = "0x1807565C0")]
		public void ExitStore()
		{
			bool flag;
			ulong num4;
			do
			{
				int num = 0;
				if ((this.inStore ? 1 : 0) == num)
				{
					return;
				}
				this.inStore = num != 0;
				GameObject gameObject = this.exitStoreButton;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
				GameObject gameObject2 = this.refreshStoreButton;
				int num3 = 0;
				gameObject2.SetActive(num3 != 0);
				List<GardenPlant> list = Enumerable.ToList<GardenPlant>(this.gardenPlants);
				if (flag)
				{
				}
			}
			while (num4 != (ulong)0L);
			string text = string.Format("第{0}页", flag);
			GardenUI._data = GardenData.GetData();
			GardenUnifiedData data = GardenUI._data;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x001219E4 File Offset: 0x0011FBE4
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x755C40", Offset = "0x754240", VA = "0x180755C40")]
		[ProButton]
		public void ChangeScene()
		{
			GardenBackground gardenBackground = this.background;
			int num = 0;
			num.Forget();
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00121A10 File Offset: 0x0011FC10
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x758D80", Offset = "0x757380", VA = "0x180758D80", Slot = "13")]
		public override void PushMenuUp(string name)
		{
			GardenPlant gardenPlant = this.plantOnWheel;
			int num = 0;
			if (!(gardenPlant != num))
			{
				base.PushMenuUp(name);
				return;
			}
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("请先将手推车中的植物放下", 10f, num2 != 0);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00121A5C File Offset: 0x0011FC5C
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x755B80", Offset = "0x754180", VA = "0x180755B80", Slot = "12")]
		public override void BackToMainMenu()
		{
			GardenPlant gardenPlant = this.plantOnWheel;
			int num = 0;
			if (!(gardenPlant != num))
			{
				base.BackToMainMenu();
				return;
			}
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("请先将手推车中的植物放下", 10f, num2 != 0);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00121AA8 File Offset: 0x0011FCA8
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x755F20", Offset = "0x754520", VA = "0x180755F20")]
		public void EnterNextPage()
		{
			if (this.currentPage < 63 && !this.inStore)
			{
				int size = this.gardenPlants._size;
				int num = size - 1;
				if (size > 0 && !this.gardenPlants[num].onWheelBarrow)
				{
					this.gardenPlants[num].Die();
				}
				int num2 = this.currentPage;
				TextMeshProUGUI textMeshProUGUI = this.currentPageText;
				num2++;
				this.currentPage = num2;
				num2++;
				string text = string.Format("第{0}页", num2);
				textMeshProUGUI.text = text;
				GardenUI._data = GardenData.GetData();
				GardenUnifiedData data = GardenUI._data;
				int num3 = this.currentPage;
				data.LoadPlants(this, num3);
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00121B68 File Offset: 0x0011FD68
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x755D40", Offset = "0x754340", VA = "0x180755D40")]
		public void EnterLastPage()
		{
			if (this.currentPage > 0 && !this.inStore)
			{
				int size = this.gardenPlants._size;
				int num = size - 1;
				if (size > 0 && !this.gardenPlants[num].onWheelBarrow)
				{
					this.gardenPlants[num].Die();
				}
				int num2 = this.currentPage;
				TextMeshProUGUI textMeshProUGUI = this.currentPageText;
				int num3 = num2 - 1;
				this.currentPage = num3;
				string text = string.Format("第{0}页", num3);
				textMeshProUGUI.text = text;
				GardenUI._data = GardenData.GetData();
				GardenUnifiedData data = GardenUI._data;
				int num4 = this.currentPage;
				data.LoadPlants(this, num4);
			}
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00121C24 File Offset: 0x0011FE24
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x758B50", Offset = "0x757150", VA = "0x180758B50")]
		public void OnTurnPageButtonClicked()
		{
			int num = 0;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			int num2 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)75), num2 != 0);
			ReNameMenu menu;
			if (baseMenu == 0)
			{
				menu = num;
			}
			menu = baseMenu;
			menu.SetTitle("请输入目标页码（1~64）");
			int num3 = this.currentPage;
			ReNameMenu menu2 = menu;
			num3++;
			string text;
			menu2.SetInputText(text);
			UnityEvent clickEvent = menu.activeButton.clickEvent;
			UnityAction unityAction = delegate
			{
				ulong num4;
				if (!int.TryParse(menu.input.m_Text, (int)num4))
				{
					InGameText instance = InGameText.Instance;
					int num5 = 0;
					instance.ShowText("请输入正确的页码（1~64）", 3f, num5 != 0);
					return;
				}
				if (num4 - 1UL > (ulong)63L)
				{
					InGameText instance2 = InGameText.Instance;
					int num6 = 0;
					instance2.ShowText("请输入正确的页码（1~64）", 3f, num6 != 0);
				}
				this.EnterPage((int)num4);
				this.PopMenu();
			};
			clickEvent.AddListener(unityAction);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00121CC8 File Offset: 0x0011FEC8
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x756100", Offset = "0x754700", VA = "0x180756100")]
		public void EnterPage(int page)
		{
			if (page - 1 <= 63)
			{
				int num = page - 1;
				if (this.currentPage != num && !this.inStore)
				{
					int size = this.gardenPlants._size;
					int num2 = size - 1;
					if (size > 0 && !this.gardenPlants[page].onWheelBarrow)
					{
						this.gardenPlants[page].Die();
					}
					TextMeshProUGUI textMeshProUGUI = this.currentPageText;
					string text = string.Format("第{0}页", size);
					textMeshProUGUI.text = text;
					int num3 = page - 1;
					this.currentPage = num3;
					GardenUI._data = GardenData.GetData();
					GardenUnifiedData data = GardenUI._data;
					int num4 = this.currentPage;
					data.LoadPlants(this, num4);
				}
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00121D8C File Offset: 0x0011FF8C
		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x757320", Offset = "0x755920", VA = "0x180757320")]
		public void Help()
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("使用手套可以融合植物，但只能融合长大以后的植物\r\n快捷键123456等为对应左上角的道具", 10f, num != 0);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00121DBC File Offset: 0x0011FFBC
		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x7595E0", Offset = "0x757BE0", VA = "0x1807595E0")]
		public GardenUI()
		{
			List<GardenPlant> list = new List();
			this.gardenPlants = list;
			List<GardenBox> list2 = new List();
			this.gardenBoxes = list2;
			HashSet<PlantType> hashSet = new HashSet();
			bool flag = hashSet.Add((uint)309);
			bool flag2 = hashSet.Add((uint)218);
			bool flag3 = hashSet.Add((uint)986);
			bool flag4 = hashSet.Add((uint)223);
			bool flag5 = hashSet.Add((uint)1342);
			bool flag6 = hashSet.Add((uint)1239);
			bool flag7 = hashSet.Add((uint)1242);
			bool flag8 = hashSet.Add((uint)1234);
			bool flag9 = hashSet.Add((uint)1135);
			bool flag10 = hashSet.Add((uint)1285);
			bool flag11 = hashSet.Add((uint)1139);
			bool flag12 = hashSet.Add((uint)1146);
			bool flag13 = hashSet.Add((uint)1142);
			bool flag14 = hashSet.Add((uint)1144);
			bool flag15 = hashSet.Add((uint)1070);
			bool flag16 = hashSet.Add((uint)1060);
			bool flag17 = hashSet.Add((uint)1027);
			bool flag18 = hashSet.Add((uint)1020);
			bool flag19 = hashSet.Add((uint)1029);
			bool flag20 = hashSet.Add((uint)1159);
			bool flag21 = hashSet.Add((uint)1160);
			bool flag22 = hashSet.Add((uint)1028);
			bool flag23 = hashSet.Add((uint)1096);
			bool flag24 = hashSet.Add((uint)1097);
			bool flag25 = hashSet.Add((uint)1099);
			bool flag26 = hashSet.Add((uint)1095);
			bool flag27 = hashSet.Add((uint)976);
			bool flag28 = hashSet.Add((uint)1098);
			bool flag29 = hashSet.Add((uint)1094);
			bool flag30 = hashSet.Add((uint)1109);
			bool flag31 = hashSet.Add((uint)1129);
			bool flag32 = hashSet.Add((uint)1151);
			bool flag33 = hashSet.Add((uint)245);
			bool flag34 = hashSet.Add((uint)248);
			bool flag35 = hashSet.Add((uint)254);
			bool flag36 = hashSet.Add((uint)253);
			bool flag37 = hashSet.Add((uint)249);
			bool flag38 = hashSet.Add((uint)244);
			bool flag39 = hashSet.Add((uint)1168);
			bool flag40 = hashSet.Add((uint)976);
			bool flag41 = hashSet.Add((uint)242);
			bool flag42 = hashSet.Add((uint)243);
			bool flag43 = hashSet.Add((uint)33);
			bool flag44 = hashSet.Add((uint)926);
			bool flag45 = hashSet.Add((uint)241);
			bool flag46 = hashSet.Add((uint)1188);
			bool flag47 = hashSet.Add((uint)34);
			bool flag48 = hashSet.Add((uint)35);
			bool flag49 = hashSet.Add((uint)300);
			bool flag50 = hashSet.Add((uint)240);
			bool flag51 = hashSet.Add((uint)1210);
			bool flag52 = hashSet.Add((uint)1214);
			bool flag53 = hashSet.Add((uint)1208);
			bool flag54 = hashSet.Add((uint)1211);
			bool flag55 = hashSet.Add((uint)1215);
			bool flag56 = hashSet.Add((uint)235);
			bool flag57 = hashSet.Add((uint)236);
			bool flag58 = hashSet.Add((uint)237);
			bool flag59 = hashSet.Add((uint)238);
			bool flag60 = hashSet.Add((uint)1225);
			bool flag61 = hashSet.Add((uint)1224);
			bool flag62 = hashSet.Add((uint)1223);
			bool flag63 = hashSet.Add((uint)1226);
			bool flag64 = hashSet.Add((uint)1265);
			bool flag65 = hashSet.Add((uint)234);
			bool flag66 = hashSet.Add((uint)1120);
			bool flag67 = hashSet.Add((uint)1247);
			bool flag68 = hashSet.Add((uint)1161);
			bool flag69 = hashSet.Add((uint)1174);
			bool flag70 = hashSet.Add((uint)1132);
			bool flag71 = hashSet.Add((uint)252);
			bool flag72 = hashSet.Add((uint)1067);
			bool flag73 = hashSet.Add((uint)1169);
			bool flag74 = hashSet.Add((uint)1253);
			bool flag75 = hashSet.Add((uint)1252);
			bool flag76 = hashSet.Add((uint)1266);
			bool flag77 = hashSet.Add((uint)1300);
			bool flag78 = hashSet.Add((uint)1316);
			bool flag79 = hashSet.Add((uint)1315);
			bool flag80 = hashSet.Add((uint)301);
			bool flag81 = hashSet.Add((uint)302);
			bool flag82 = hashSet.Add((uint)229);
			bool flag83 = hashSet.Add((uint)1306);
			bool flag84 = hashSet.Add((uint)230);
			bool flag85 = hashSet.Add((uint)231);
			bool flag86 = hashSet.Add((uint)232);
			bool flag87 = hashSet.Add((uint)303);
			bool flag88 = hashSet.Add((uint)304);
			bool flag89 = hashSet.Add((uint)305);
			bool flag90 = hashSet.Add((uint)227);
			bool flag91 = hashSet.Add((uint)1368);
			bool flag92 = hashSet.Add((uint)220);
			bool flag93 = hashSet.Add((uint)306);
			bool flag94 = hashSet.Add((uint)307);
			bool flag95 = hashSet.Add((uint)222);
			bool flag96 = hashSet.Add((uint)308);
			bool flag97 = hashSet.Add((uint)310);
			bool flag98 = hashSet.Add((uint)1443);
			this.StorePlants = hashSet;
			base..ctor();
		}

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		public static GardenUI Instance;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		private static GardenUnifiedData _data;

		// Token: 0x04002900 RID: 10496
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002900")]
		public int currentPage;

		// Token: 0x04002901 RID: 10497
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002901")]
		public bool inStore;

		// Token: 0x04002902 RID: 10498
		[FieldOffset(Offset = "0x45")]
		[Token(Token = "0x4002902")]
		public bool inWorld;

		// Token: 0x04002903 RID: 10499
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002903")]
		public GardenBackground background;

		// Token: 0x04002904 RID: 10500
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002904")]
		public GardenTool toolOnMouse;

		// Token: 0x04002905 RID: 10501
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002905")]
		public GardenPlant plantOnGlove;

		// Token: 0x04002906 RID: 10502
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002906")]
		public GardenPlant plantOnWheel;

		// Token: 0x04002907 RID: 10503
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002907")]
		public GameObject plantFollowMouse;

		// Token: 0x04002908 RID: 10504
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002908")]
		public GameObject plantPreview;

		// Token: 0x04002909 RID: 10505
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002909")]
		public List<GardenPlant> gardenPlants;

		// Token: 0x0400290A RID: 10506
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400290A")]
		public List<GardenBox> gardenBoxes;

		// Token: 0x0400290B RID: 10507
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400290B")]
		public GardenBox currentBox;

		// Token: 0x0400290C RID: 10508
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400290C")]
		public GameObject storeButton;

		// Token: 0x0400290D RID: 10509
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400290D")]
		public GameObject exitStoreButton;

		// Token: 0x0400290E RID: 10510
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400290E")]
		public GameObject refreshStoreButton;

		// Token: 0x0400290F RID: 10511
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400290F")]
		public TextMeshProUGUI currentPageText;

		// Token: 0x04002910 RID: 10512
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002910")]
		[Header("金币相关")]
		public TextMeshProUGUI coinText;

		// Token: 0x04002911 RID: 10513
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002911")]
		public Transform coinTarget;

		// Token: 0x04002912 RID: 10514
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002912")]
		public int coinCount;

		// Token: 0x04002913 RID: 10515
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002913")]
		private readonly HashSet<PlantType> StorePlants;
	}
}
