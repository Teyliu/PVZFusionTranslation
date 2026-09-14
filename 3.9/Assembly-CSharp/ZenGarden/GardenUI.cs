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
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	public class GardenUI : BaseMenu
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x00126194 File Offset: 0x00124394
		[Token(Token = "0x17000288")]
		public static GardenUnifiedData Data
		{
			[Token(Token = "0x60036F5")]
			[Address(RVA = "0x7C0B20", Offset = "0x7BF120", VA = "0x1807C0B20")]
			get
			{
				GardenUI._data = GardenData.GetData();
				return GardenUI._data;
			}
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x001261B4 File Offset: 0x001243B4
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x7BC6D0", Offset = "0x7BACD0", VA = "0x1807BC6D0", Slot = "6")]
		protected override void Awake()
		{
			GardenUI.Instance = this;
			base.Awake();
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x001261D0 File Offset: 0x001243D0
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x7BF6E0", Offset = "0x7BDCE0", VA = "0x1807BF6E0")]
		private void OnDestroy()
		{
			global::UnityEngine.Object.Destroy(this.background.gameObject);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x001261F4 File Offset: 0x001243F4
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x7BFDF0", Offset = "0x7BE3F0", VA = "0x1807BFDF0")]
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

		// Token: 0x060036F9 RID: 14073 RVA: 0x00126278 File Offset: 0x00124478
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x7C0180", Offset = "0x7BE780", VA = "0x1807C0180")]
		private void Update()
		{
			this.MouseUpdate();
			this.MouseToolUpdate();
			TextMeshProUGUI textMeshProUGUI = this.coinText;
			GardenUnifiedData data = GardenUI.Data;
			throw new NullReferenceException();
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x001262A8 File Offset: 0x001244A8
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x7BD440", Offset = "0x7BBA40", VA = "0x1807BD440")]
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

		// Token: 0x060036FB RID: 14075 RVA: 0x00126330 File Offset: 0x00124530
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x7BD7F0", Offset = "0x7BBDF0", VA = "0x1807BD7F0")]
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

		// Token: 0x060036FC RID: 14076 RVA: 0x001263C4 File Offset: 0x001245C4
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x7BE510", Offset = "0x7BCB10", VA = "0x1807BE510")]
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

		// Token: 0x060036FD RID: 14077 RVA: 0x00126434 File Offset: 0x00124634
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x7BE1C0", Offset = "0x7BC7C0", VA = "0x1807BE1C0")]
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

		// Token: 0x060036FE RID: 14078 RVA: 0x001264EC File Offset: 0x001246EC
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x7BDB30", Offset = "0x7BC130", VA = "0x1807BDB30")]
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

		// Token: 0x060036FF RID: 14079 RVA: 0x0012653C File Offset: 0x0012473C
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x7BE7F0", Offset = "0x7BCDF0", VA = "0x1807BE7F0")]
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

		// Token: 0x06003700 RID: 14080 RVA: 0x00126648 File Offset: 0x00124848
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x7BEC40", Offset = "0x7BD240", VA = "0x1807BEC40")]
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

		// Token: 0x06003701 RID: 14081 RVA: 0x001267A8 File Offset: 0x001249A8
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x7BF100", Offset = "0x7BD700", VA = "0x1807BF100")]
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

		// Token: 0x06003702 RID: 14082 RVA: 0x001268AC File Offset: 0x00124AAC
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x7BFEE0", Offset = "0x7BE4E0", VA = "0x1807BFEE0")]
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

		// Token: 0x06003703 RID: 14083 RVA: 0x001269A8 File Offset: 0x00124BA8
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x7BDF80", Offset = "0x7BC580", VA = "0x1807BDF80")]
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

		// Token: 0x06003704 RID: 14084 RVA: 0x00126A04 File Offset: 0x00124C04
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x7BFCC0", Offset = "0x7BE2C0", VA = "0x1807BFCC0")]
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

		// Token: 0x06003705 RID: 14085 RVA: 0x00126A7C File Offset: 0x00124C7C
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x7BCEB0", Offset = "0x7BB4B0", VA = "0x1807BCEB0")]
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
					throw new NullReferenceException();
				}
				this.inStore = true;
				InGameText instance2 = InGameText.Instance;
				int num2 = 0;
				this.exitStoreButton.SetActive(true);
				this.refreshStoreButton.SetActive(true);
				int size = this.gardenPlants._size;
				int num3 = size - 1;
				if (size > 0)
				{
					this.gardenPlants[num3].Die();
				}
				this.currentPageText.text = "商店";
				PlantType random = ListExtensions.GetRandom<PlantType>(this.GetStorePlants());
				List<GardenPlant> list = this.gardenPlants;
				GardenPlantData gardenPlantData;
				GardenPlant gardenPlant2 = gardenPlantData.CreatePlant(this);
				num2++;
				num2++;
			}
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00126B50 File Offset: 0x00124D50
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x7BFA60", Offset = "0x7BE060", VA = "0x1807BFA60")]
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

		// Token: 0x06003707 RID: 14087 RVA: 0x00126BA8 File Offset: 0x00124DA8
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x7BDD40", Offset = "0x7BC340", VA = "0x1807BDD40")]
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

		// Token: 0x06003708 RID: 14088 RVA: 0x00126BF8 File Offset: 0x00124DF8
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x7BD1B0", Offset = "0x7BB7B0", VA = "0x1807BD1B0")]
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

		// Token: 0x06003709 RID: 14089 RVA: 0x00126C88 File Offset: 0x00124E88
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x7BC800", Offset = "0x7BAE00", VA = "0x1807BC800")]
		[ProButton]
		public void ChangeScene()
		{
			GardenBackground gardenBackground = this.background;
			int num = 0;
			num.Forget();
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00126CB4 File Offset: 0x00124EB4
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x7BF980", Offset = "0x7BDF80", VA = "0x1807BF980", Slot = "13")]
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
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00126CEC File Offset: 0x00124EEC
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x7BC730", Offset = "0x7BAD30", VA = "0x1807BC730", Slot = "12")]
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
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00126D24 File Offset: 0x00124F24
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x7BCAE0", Offset = "0x7BB0E0", VA = "0x1807BCAE0")]
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

		// Token: 0x0600370D RID: 14093 RVA: 0x00126DE4 File Offset: 0x00124FE4
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x7BC900", Offset = "0x7BAF00", VA = "0x1807BC900")]
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

		// Token: 0x0600370E RID: 14094 RVA: 0x00126EA0 File Offset: 0x001250A0
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x7BF750", Offset = "0x7BDD50", VA = "0x1807BF750")]
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
					return;
				}
				if (num4 - 1UL > (ulong)63L)
				{
					InGameText instance2 = InGameText.Instance;
				}
				this.EnterPage((int)num4);
				this.PopMenu();
			};
			clickEvent.AddListener(unityAction);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00126F44 File Offset: 0x00125144
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x7BCCC0", Offset = "0x7BB2C0", VA = "0x1807BCCC0")]
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

		// Token: 0x06003710 RID: 14096 RVA: 0x00127008 File Offset: 0x00125208
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x7BDF10", Offset = "0x7BC510", VA = "0x1807BDF10")]
		public void Help()
		{
			InGameText instance = InGameText.Instance;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00127024 File Offset: 0x00125224
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x7C01F0", Offset = "0x7BE7F0", VA = "0x1807C01F0")]
		public GardenUI()
		{
			List<GardenPlant> list = new List();
			this.gardenPlants = list;
			List<GardenBox> list2 = new List();
			this.gardenBoxes = list2;
			HashSet<PlantType> hashSet = new HashSet();
			bool flag = hashSet.Add((uint)5004);
			bool flag2 = hashSet.Add((uint)309);
			bool flag3 = hashSet.Add((uint)218);
			bool flag4 = hashSet.Add((uint)986);
			bool flag5 = hashSet.Add((uint)223);
			bool flag6 = hashSet.Add((uint)1342);
			bool flag7 = hashSet.Add((uint)1239);
			bool flag8 = hashSet.Add((uint)1242);
			bool flag9 = hashSet.Add((uint)1234);
			bool flag10 = hashSet.Add((uint)1135);
			bool flag11 = hashSet.Add((uint)1285);
			bool flag12 = hashSet.Add((uint)1139);
			bool flag13 = hashSet.Add((uint)1146);
			bool flag14 = hashSet.Add((uint)1142);
			bool flag15 = hashSet.Add((uint)1144);
			bool flag16 = hashSet.Add((uint)1070);
			bool flag17 = hashSet.Add((uint)1060);
			bool flag18 = hashSet.Add((uint)1027);
			bool flag19 = hashSet.Add((uint)1020);
			bool flag20 = hashSet.Add((uint)1029);
			bool flag21 = hashSet.Add((uint)1159);
			bool flag22 = hashSet.Add((uint)1160);
			bool flag23 = hashSet.Add((uint)1028);
			bool flag24 = hashSet.Add((uint)1096);
			bool flag25 = hashSet.Add((uint)1097);
			bool flag26 = hashSet.Add((uint)1099);
			bool flag27 = hashSet.Add((uint)1095);
			bool flag28 = hashSet.Add((uint)976);
			bool flag29 = hashSet.Add((uint)1098);
			bool flag30 = hashSet.Add((uint)1094);
			bool flag31 = hashSet.Add((uint)1109);
			bool flag32 = hashSet.Add((uint)1129);
			bool flag33 = hashSet.Add((uint)1151);
			bool flag34 = hashSet.Add((uint)245);
			bool flag35 = hashSet.Add((uint)248);
			bool flag36 = hashSet.Add((uint)254);
			bool flag37 = hashSet.Add((uint)253);
			bool flag38 = hashSet.Add((uint)249);
			bool flag39 = hashSet.Add((uint)244);
			bool flag40 = hashSet.Add((uint)1168);
			bool flag41 = hashSet.Add((uint)976);
			bool flag42 = hashSet.Add((uint)242);
			bool flag43 = hashSet.Add((uint)243);
			bool flag44 = hashSet.Add((uint)33);
			bool flag45 = hashSet.Add((uint)926);
			bool flag46 = hashSet.Add((uint)241);
			bool flag47 = hashSet.Add((uint)1188);
			bool flag48 = hashSet.Add((uint)34);
			bool flag49 = hashSet.Add((uint)35);
			bool flag50 = hashSet.Add((uint)300);
			bool flag51 = hashSet.Add((uint)240);
			bool flag52 = hashSet.Add((uint)1210);
			bool flag53 = hashSet.Add((uint)1214);
			bool flag54 = hashSet.Add((uint)1208);
			bool flag55 = hashSet.Add((uint)1211);
			bool flag56 = hashSet.Add((uint)1215);
			bool flag57 = hashSet.Add((uint)235);
			bool flag58 = hashSet.Add((uint)236);
			bool flag59 = hashSet.Add((uint)237);
			bool flag60 = hashSet.Add((uint)238);
			bool flag61 = hashSet.Add((uint)1225);
			bool flag62 = hashSet.Add((uint)1224);
			bool flag63 = hashSet.Add((uint)1223);
			bool flag64 = hashSet.Add((uint)1226);
			bool flag65 = hashSet.Add((uint)1265);
			bool flag66 = hashSet.Add((uint)234);
			bool flag67 = hashSet.Add((uint)1120);
			bool flag68 = hashSet.Add((uint)1247);
			bool flag69 = hashSet.Add((uint)1161);
			bool flag70 = hashSet.Add((uint)1174);
			bool flag71 = hashSet.Add((uint)1132);
			bool flag72 = hashSet.Add((uint)252);
			bool flag73 = hashSet.Add((uint)1067);
			bool flag74 = hashSet.Add((uint)1169);
			bool flag75 = hashSet.Add((uint)1253);
			bool flag76 = hashSet.Add((uint)1252);
			bool flag77 = hashSet.Add((uint)1266);
			bool flag78 = hashSet.Add((uint)1300);
			bool flag79 = hashSet.Add((uint)1316);
			bool flag80 = hashSet.Add((uint)1315);
			bool flag81 = hashSet.Add((uint)301);
			bool flag82 = hashSet.Add((uint)302);
			bool flag83 = hashSet.Add((uint)229);
			bool flag84 = hashSet.Add((uint)1306);
			bool flag85 = hashSet.Add((uint)230);
			bool flag86 = hashSet.Add((uint)231);
			bool flag87 = hashSet.Add((uint)232);
			bool flag88 = hashSet.Add((uint)303);
			bool flag89 = hashSet.Add((uint)304);
			bool flag90 = hashSet.Add((uint)305);
			bool flag91 = hashSet.Add((uint)227);
			bool flag92 = hashSet.Add((uint)1368);
			bool flag93 = hashSet.Add((uint)220);
			bool flag94 = hashSet.Add((uint)306);
			bool flag95 = hashSet.Add((uint)307);
			bool flag96 = hashSet.Add((uint)222);
			bool flag97 = hashSet.Add((uint)308);
			bool flag98 = hashSet.Add((uint)310);
			bool flag99 = hashSet.Add((uint)1443);
			bool flag100 = hashSet.Add((uint)1444);
			bool flag101 = hashSet.Add((uint)5003);
			bool flag102 = hashSet.Add((uint)1450);
			this.StorePlants = hashSet;
			base..ctor();
		}

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		public static GardenUI Instance;

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		private static GardenUnifiedData _data;

		// Token: 0x04002A73 RID: 10867
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002A73")]
		public int currentPage;

		// Token: 0x04002A74 RID: 10868
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002A74")]
		public bool inStore;

		// Token: 0x04002A75 RID: 10869
		[FieldOffset(Offset = "0x45")]
		[Token(Token = "0x4002A75")]
		public bool inWorld;

		// Token: 0x04002A76 RID: 10870
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002A76")]
		public GardenBackground background;

		// Token: 0x04002A77 RID: 10871
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002A77")]
		public GardenTool toolOnMouse;

		// Token: 0x04002A78 RID: 10872
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002A78")]
		public GardenPlant plantOnGlove;

		// Token: 0x04002A79 RID: 10873
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002A79")]
		public GardenPlant plantOnWheel;

		// Token: 0x04002A7A RID: 10874
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002A7A")]
		public GameObject plantFollowMouse;

		// Token: 0x04002A7B RID: 10875
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002A7B")]
		public GameObject plantPreview;

		// Token: 0x04002A7C RID: 10876
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002A7C")]
		public List<GardenPlant> gardenPlants;

		// Token: 0x04002A7D RID: 10877
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002A7D")]
		public List<GardenBox> gardenBoxes;

		// Token: 0x04002A7E RID: 10878
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002A7E")]
		public GardenBox currentBox;

		// Token: 0x04002A7F RID: 10879
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002A7F")]
		public GameObject storeButton;

		// Token: 0x04002A80 RID: 10880
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002A80")]
		public GameObject exitStoreButton;

		// Token: 0x04002A81 RID: 10881
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002A81")]
		public GameObject refreshStoreButton;

		// Token: 0x04002A82 RID: 10882
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002A82")]
		public TextMeshProUGUI currentPageText;

		// Token: 0x04002A83 RID: 10883
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002A83")]
		[Header("金币相关")]
		public TextMeshProUGUI coinText;

		// Token: 0x04002A84 RID: 10884
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002A84")]
		public Transform coinTarget;

		// Token: 0x04002A85 RID: 10885
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002A85")]
		public int coinCount;

		// Token: 0x04002A86 RID: 10886
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002A86")]
		private readonly HashSet<PlantType> StorePlants;
	}
}
