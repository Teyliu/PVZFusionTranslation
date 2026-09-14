using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Core;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.EventNodes;
using PVPScaryPot;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using ZenGarden;

// Token: 0x0200078F RID: 1935
[Token(Token = "0x200078F")]
public class Mouse : MonoBehaviour
{
	// Token: 0x17000190 RID: 400
	// (get) Token: 0x0600271B RID: 10011 RVA: 0x000D14F8 File Offset: 0x000CF6F8
	[Token(Token = "0x17000190")]
	public Vector2 MousePosition
	{
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x601BE0", Offset = "0x6001E0", VA = "0x180601BE0")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600271C RID: 10012 RVA: 0x000D1510 File Offset: 0x000CF710
	[Token(Token = "0x600271C")]
	[Address(RVA = "0x5F07B0", Offset = "0x5EEDB0", VA = "0x1805F07B0")]
	private void Awake()
	{
		Mouse.Instance = this;
	}

	// Token: 0x0600271D RID: 10013 RVA: 0x000D1524 File Offset: 0x000CF724
	[Token(Token = "0x600271D")]
	[Address(RVA = "0x5FCE20", Offset = "0x5FB420", VA = "0x1805FCE20")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x0600271E RID: 10014 RVA: 0x000D1540 File Offset: 0x000CF740
	[Token(Token = "0x600271E")]
	[Address(RVA = "0x601000", Offset = "0x5FF600", VA = "0x180601000")]
	private void Update()
	{
		this.DrawItemOnMouse();
		this.PlantPreviewUpdate();
		if (Input.GetKeyDownInt((KeyCode)((uint)114)))
		{
			GameObject gameObject = this.preview;
			int num = 0;
			if (gameObject != num)
			{
				GameObject gameObject2 = this.theItemOnMouse;
				int num2 = 0;
				if (gameObject2 != num2)
				{
					Towards towards = this.plantTowards;
					PlantType plantType = this.thePlantTypeOnMouse;
					GameObject gameObject3 = this.preview;
					Towards towards2;
					this.plantTowards = towards2;
					int num3 = 0;
					if (towards2 != Towards.Left)
					{
						gameObject3.transform.rotation = num3;
						Transform transform = this.theItemOnMouse.transform;
					}
					gameObject3.transform.rotation = num3;
					GameObject gameObject4 = this.theItemOnMouse;
					int num4 = 0;
					gameObject4.transform.rotation = num4;
				}
			}
		}
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Camera main2 = Camera.main;
		float z2 = Input.mousePosition.z;
		float num5 = this.mouseX;
		Vector3 vector;
		float y = vector.y;
		this.mouseY = y;
		int num6 = 0;
		int columnNum = Board.Instance.columnNum;
		float num7 = this.mouseX;
		float num8 = this.mouseY;
		this.theMouseColumn = num6;
		Board instance = Board.Instance;
		if (instance.rowNum == 6)
		{
			goto IL_0140;
		}
		if (num8 <= 3.7f)
		{
			int rowNum = instance.rowNum;
			goto IL_0140;
		}
		goto IL_0146;
		IL_0194:
		while (num8 > 1.6f)
		{
		}
		float num10;
		float num9 = num10;
		this.theBoxYofMouse = num9;
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject5 = this.theItemOnMouse;
			int num11 = 0;
			if (!(gameObject5 == num11))
			{
				this.LeftClickWithSomeThing();
			}
			this.LeftClickWithNothing();
			int num12 = this.theMouseRow;
			int num13 = this.theMouseColumn;
			GameObject gameObject6 = this.theItemOnMouse;
			ulong num14;
			MouseClickData mouseClickData = new MouseClickData(num12, num13, gameObject6, num14 != 0UL);
			EventManager.TriggerEvent((GameEvent)((uint)9), mouseClickData);
		}
		bool mouseButtonDown = Input.GetMouseButtonDown(1);
		if (mouseButtonDown)
		{
			this.PutDownItem();
		}
		KeyCode lookPlantData = KeyCodeManager.LookPlantData;
		if (!mouseButtonDown)
		{
			KeyCode checkPlantAlmanac = KeyCodeManager.CheckPlantAlmanac;
			if (mouseButtonDown)
			{
				Camera main3 = Camera.main;
				float z3 = Input.mousePosition.z;
				num10 = num7;
				RaycastHit2D[] array;
				List<Plant> plantsOnMouse = this.GetPlantsOnMouse(array);
				int num15 = 0;
				Plant plant = plantsOnMouse[num15];
				UIMgr.EnterPauseMenu();
				GameAPP.music.Pause();
				GameAPP.musicDrum.Pause();
				GameAPP.prelude.audioSource.Pause();
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num16 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)56), canvasUp, num16 != 0);
				int num17 = 0;
				PlantType thePlantType = plantsOnMouse[num17].thePlantType;
			}
			return;
		}
		Camera main4 = Camera.main;
		float z4 = Input.mousePosition.z;
		RaycastHit2D[] array2;
		List<Plant> plantsOnMouse2 = this.GetPlantsOnMouse(array2);
		int num18 = 0;
		Plant plant2 = plantsOnMouse2[num18];
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		Transform canvasUp2 = GameAPP.canvasUp;
		int num19 = 0;
		BaseMenu baseMenu2 = uimanager2.Push((UIType)((uint)69), canvasUp2, num19 != 0);
		int num20 = 0;
		Plant plant3 = plantsOnMouse2[num20];
		Time.timeScale = (float)0;
		throw new NullReferenceException();
		IL_0140:
		float num21;
		if (num8 <= num21)
		{
			goto IL_0194;
		}
		IL_0146:
		int rowNum2 = instance.rowNum;
		this.theMouseRow = rowNum2;
		float num22 = num21 * 1.35f;
		this.theBoxXofMouse = num22;
		Board instance2 = Board.Instance;
		float boxYFromRow = this.GetBoxYFromRow(rowNum2);
		num9 = this.theBoxXofMouse;
		if (num9 < num7)
		{
			while (num8 > 3.7f)
			{
			}
			goto IL_0194;
		}
		goto IL_0194;
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x000D1888 File Offset: 0x000CFA88
	[Token(Token = "0x600271F")]
	[Address(RVA = "0x5FE5C0", Offset = "0x5FCBC0", VA = "0x1805FE5C0")]
	private void TryToSetPlantByCard()
	{
		int num19;
		for (;;)
		{
			int num = 0;
			CardUI cardUI = this.theCardOnMouse;
			int num2 = 0;
			if (cardUI == num2)
			{
				goto IL_0405;
			}
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			this.PutDownItem();
			PlantType plantType = this.thePlantTypeOnMouse;
			Board board = this.board;
			global::UnityEngine.Object.Destroy(this.theItemOnMouse);
			int num3 = 0;
			if (plantType != PlantType.PresentZombie)
			{
				goto IL_0089;
			}
			if (this.theMouseRow <= 2)
			{
				return;
			}
			int num4 = this.theMouseColumn;
			BoardConfig config = board.config;
			if (num4 < config.redLineColumn)
			{
				goto IL_0089;
			}
			IL_00B1:
			InGameText instance;
			if (this.theMouseRow > 2)
			{
				instance = InGameText.Instance;
				int num5 = 0;
				instance.ShowText("只能放在上半地图", 5f, num5 != 0);
			}
			int num6 = this.theMouseColumn;
			GameObject textHead = instance.textHead;
			InGameText instance2 = InGameText.Instance;
			int num7 = 0;
			instance2.ShowText("你只能在红线左侧放置植物", 3f, num7 != 0);
			uint num8;
			GameAPP.PlaySound((int)num8, 0.5f, 1f);
			int num9 = this.theMouseColumn;
			GameObject textHead2 = instance2.textHead;
			CardUI cardUI2 = this.theCardOnMouse;
			if (cardUI2.thePlantType != PlantType.BigWallNut)
			{
				Board board2 = this.board;
				PlantType thePlantType = cardUI2.thePlantType;
				this.theCardOnMouse.UseOnce();
				this.theCardOnMouse.PutDown();
				InGameText instance3 = InGameText.Instance;
				int num10 = 0;
				instance3.ShowText("你只能在红线左侧放置植物", 3f, num10 != 0);
			}
			int num11 = this.theMouseRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.theMouseColumn, num11);
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				CardUI cardUI3 = this.theCardOnMouse;
				bool flag2;
				while (!flag2)
				{
				}
				this.theCardOnMouse.UseOnce();
				this.theCardOnMouse.PutDown();
				global::UnityEngine.Object.Destroy(this.theItemOnMouse);
				int num12 = 0;
				this.ClearItemOnMouse(num12 != 0);
			}
			if (num3 != 0)
			{
				continue;
			}
			int num13 = 0;
			if (plantType <= PlantType.Cactus)
			{
				continue;
			}
			if (plantType == PlantType.Pumpkin)
			{
				int num14 = 0;
				Plant plant;
				if (!(plant == num14))
				{
					goto IL_0323;
				}
				CreatePlant instance4 = CreatePlant.Instance;
			}
			if (plantType == PlantType.Melonpult || plantType == PlantType.WinterMelon)
			{
				goto IL_0323;
			}
			CreatePlant instance5 = CreatePlant.Instance;
			int num15 = 0;
			Plant plant2;
			if (!(plant2 != num15))
			{
				return;
			}
			Board instance6 = Board.Instance;
			bool flag3;
			if (!flag3)
			{
				goto IL_0323;
			}
			Board instance7 = Board.Instance;
			if (num13 >= instance7.rowNum)
			{
				goto IL_0323;
			}
			CreatePlant instance8 = CreatePlant.Instance;
			uint num16;
			if (num16 == 0U)
			{
				int num17 = 0;
				Plant plant3;
				bool flag4 = plant3 != num17;
				if (flag4)
				{
					plant3.attributeCount = (flag4 ? 1 : 0);
				}
			}
			num13++;
			if (Board.Instance > (ulong)8L)
			{
				break;
			}
			int num18 = 0;
			Plant plant4;
			if (!(plant4 == num18))
			{
				goto IL_0323;
			}
			CreatePlant instance9 = CreatePlant.Instance;
			num19 = 0;
			bool flag5;
			if (flag5)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
			if (num13 != 0)
			{
				continue;
			}
			int num20 = 0;
			bool flag6;
			if (flag6)
			{
				while (num == 0)
				{
				}
				if (num != 0)
				{
				}
				while (num == 0)
				{
				}
				bool flag7;
				if (flag7)
				{
				}
			}
			if (num20 == 0)
			{
				break;
			}
			continue;
			IL_0089:
			if (plantType != PlantType.Present)
			{
				goto IL_00B1;
			}
			int num21 = this.theMouseColumn;
			BoardConfig config2 = board.config;
			if (num21 < config2.redLineColumn)
			{
				goto IL_00B1;
			}
			return;
		}
		Plant plant5;
		if (num19 == 19)
		{
			int num22 = 0;
			if (!(plant5 == num22))
			{
				goto IL_0323;
			}
			CreatePlant instance10 = CreatePlant.Instance;
		}
		while (num19 != 21)
		{
		}
		IL_0323:
		Board instance11 = Board.Instance;
		CreatePlant instance12 = CreatePlant.Instance;
		Board instance13 = Board.Instance;
		int num23 = 0;
		bool flag8;
		if (flag8)
		{
			flag8 = (flag8 ? 1 : 0) - num23 != 0;
		}
		uint num24;
		if (num19 == (int)num24)
		{
			plant5.attributeCount = (flag8 ? 1 : 0);
		}
		CardUI cardUI4 = this.theCardOnMouse;
		if (plant5.thePlantType != PlantType.SuperCherryShooter)
		{
		}
		GameObject gameObject = this.preview;
		if (0 <= gameObject)
		{
		}
		uint num25;
		num25.m_value = gameObject;
		CardUI cardUI5 = this.theCardOnMouse;
		cardUI5.UseOnce();
		cardUI5.PutDown();
		int num26 = 0;
		int thePlantLevel = cardUI5.thePlantLevel;
		ulong num27;
		bool flag9 = plant5.Upgrade(thePlantLevel, num27 != 0UL, num26 != 0);
		int num28 = 0;
		ulong num29;
		bool flag10 = InGameUI.Instance._cardSlotManager.RemoveCard(num28, num29 != 0UL);
		GameObject gameObject2;
		global::UnityEngine.Object.Destroy(gameObject2);
		plant5.imitatless = true;
		List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
		PlantType thePlantType2 = plant5.thePlantType;
		bool flag11 = rogueCards.Remove(thePlantType2);
		while (rogueCards == 0)
		{
		}
		IL_0405:
		ulong num30;
		this.ClearItemOnMouse(num30 != 0UL);
	}

	// Token: 0x06002720 RID: 10016 RVA: 0x000D1CB0 File Offset: 0x000CFEB0
	[Token(Token = "0x6002720")]
	[Address(RVA = "0x5F3600", Offset = "0x5F1C00", VA = "0x1805F3600")]
	public float GetLandY(float x, int theRow)
	{
		Board instance = Board.Instance;
		if (x <= 1.5f)
		{
			return this.GetBoxYFromRow(theRow);
		}
		return this.GetBoxYFromRow(theRow);
	}

	// Token: 0x06002721 RID: 10017 RVA: 0x000D1CE8 File Offset: 0x000CFEE8
	[Token(Token = "0x6002721")]
	[Address(RVA = "0x5F3570", Offset = "0x5F1B70", VA = "0x1805F3570")]
	public int GetColumnFromX(float x)
	{
		return Board.Instance.columnNum;
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x000D1D0C File Offset: 0x000CFF0C
	[Token(Token = "0x6002722")]
	[Address(RVA = "0x5F3D00", Offset = "0x5F2300", VA = "0x1805F3D00")]
	public int GetRowFromY(float x, float y)
	{
		Board instance = Board.Instance;
		if (y <= 3.7f)
		{
			int rowNum;
			if (instance.rowNum != 6)
			{
				if (y > 3.7f)
				{
					return 0;
				}
				rowNum = instance.rowNum;
			}
			return rowNum;
		}
		return 0;
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x000D1D50 File Offset: 0x000CFF50
	[Token(Token = "0x6002723")]
	[Address(RVA = "0x5F34C0", Offset = "0x5F1AC0", VA = "0x1805F34C0")]
	public float GetBoxXFromColumn(int theColumn)
	{
		float num;
		return num;
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x000D1D64 File Offset: 0x000CFF64
	[Token(Token = "0x6002724")]
	[Address(RVA = "0x5F34E0", Offset = "0x5F1AE0", VA = "0x1805F34E0")]
	public float GetBoxYFromRow(int theRow)
	{
		if (Board.Instance.rowNum != 6)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x000D1D8C File Offset: 0x000CFF8C
	[Token(Token = "0x6002725")]
	[Address(RVA = "0x5F23F0", Offset = "0x5F09F0", VA = "0x1805F23F0")]
	private void CreatePlantOnMouse(PlantType theSeedType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector3 vector;
			float z2 = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = base.transform;
			GameObject gameObject;
			this.theItemOnMouse = gameObject;
			this.theItemOnMouse.GetComponent<SpriteRenderer>().sortingLayerName = "up1";
			this.theItemOnMouse.GetComponent<SpriteRenderer>().sortingOrder = 30000;
			return;
		}
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("错误：尝试生成不存在的种植预览！", 3f, num != 0);
		Debug.LogError("尝试生成错误的种植预览");
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x000D1E38 File Offset: 0x000D0038
	[Token(Token = "0x6002726")]
	[Address(RVA = "0x5F26D0", Offset = "0x5F0CD0", VA = "0x1805F26D0")]
	private void CreateZombieOnMouse(ZombieType theZombieType)
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform = base.transform;
		GameObject gameObject;
		this.theItemOnMouse = gameObject;
		Transform transform2 = base.transform;
		GameObject gameObject2;
		this.preview = gameObject2;
		SortingGroup component = this.preview.GetComponent<SortingGroup>();
		int num = component.sortingOrder - 1;
		component.sortingOrder = num;
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x000D1EA4 File Offset: 0x000D00A4
	[Token(Token = "0x6002727")]
	[Address(RVA = "0x5F2C10", Offset = "0x5F1210", VA = "0x1805F2C10")]
	private void DrawItemOnMouse()
	{
		GameObject gameObject = this.theItemOnMouse;
		int num = 0;
		if (gameObject != num)
		{
			bool flag = string.Equals(this.theItemOnMouse.name, "Shovel");
			GameObject gameObject2 = this.theItemOnMouse;
			GameObject gameObject4;
			if (!flag)
			{
				bool flag2 = string.Equals(gameObject2.name, "Hammer");
				GameObject gameObject3 = this.theItemOnMouse;
				if (!flag2)
				{
					int num2 = 0;
					gameObject3.transform.position = num2;
					Transform transform = this.theItemOnMouse.transform;
					Transform transform2 = this.theItemOnMouse.transform;
					return;
				}
				int num3 = 0;
				gameObject.transform.position = num3;
				Transform transform3 = this.theItemOnMouse.transform;
				gameObject4 = this.theItemOnMouse;
				Transform transform4 = gameObject4.transform;
				Vector3 vector;
				float z = vector.z;
			}
			int num4 = 0;
			Transform transform5 = gameObject4.transform;
			transform5.position = num4;
			Vector3 position = transform5.position;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x000D1F94 File Offset: 0x000D0194
	[Token(Token = "0x6002728")]
	[Address(RVA = "0x5F7610", Offset = "0x5F5C10", VA = "0x1805F7610")]
	private void PlantPreviewUpdate()
	{
		GameObject gameObject = this.theItemOnMouse;
		int num = 0;
		if (!(gameObject != num))
		{
			GameObject gameObject2 = this.preview;
			int num2 = 0;
			if (!(gameObject2 != num2))
			{
				goto IL_00A3;
			}
			global::UnityEngine.Object.Destroy(this.preview);
			this.preview = (ulong)0L;
		}
		bool flag = this.theItemOnMouse.CompareTag("Preview");
		GameObject gameObject3 = this.preview;
		while (!flag)
		{
		}
		int num3 = 0;
		if (gameObject3 == num3)
		{
			GameObject gameObject4 = this.theItemOnMouse;
			Transform transform = base.transform;
			GameObject gameObject5 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject4, transform);
			this.preview = gameObject5;
			this.preview.GetComponent<SpriteRenderer>().sortingLayerName = "particle11";
		}
		IL_00A3:
		GameObject gameObject6 = this.preview;
		int num4 = 0;
		if (gameObject6 != num4)
		{
			float num5 = this.mouseY;
			if (this.mouseItemType != MouseItemType.Zombie_preview)
			{
				CreatePlant instance = CreatePlant.Instance;
				PlantType plantType = this.thePlantTypeOnMouse;
				int num6 = this.theMouseRow;
				int num7 = this.theMouseColumn;
				if (instance.CheckBox(num7, num6, plantType))
				{
					GameObject gameObject7 = this.preview;
					int num8 = 0;
					Transform transform2 = gameObject7.transform;
					transform2.position = num8;
					GridSystem gridSystem = this.board.gridSystem;
					int num9 = this.theMouseRow;
					int num10 = this.theMouseColumn;
					if (gridSystem.HasPot(num10, num9))
					{
						Transform transform3 = this.preview.transform;
					}
					int num11 = (int)this.thePlantTypeOnMouse;
					bool flag2;
					Transform transform4;
					if (!flag2)
					{
						Board board = this.board;
						transform4 = this.preview.transform;
					}
					Vector3 position = transform4.position;
				}
			}
			int num12 = 0;
			Transform transform5;
			transform5.position = num12;
		}
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x000D214C File Offset: 0x000D034C
	[Token(Token = "0x6002729")]
	[Address(RVA = "0x5F7CB0", Offset = "0x5F62B0", VA = "0x1805F7CB0")]
	private void PreviewPositionUpdate()
	{
		float num;
		for (;;)
		{
			num = this.mouseY;
			if (this.mouseItemType != MouseItemType.Zombie_preview)
			{
				CreatePlant instance = CreatePlant.Instance;
				PlantType plantType = this.thePlantTypeOnMouse;
				int num2 = this.theMouseRow;
				int num3 = this.theMouseColumn;
				if (instance.CheckBox(num3, num2, plantType))
				{
					GameObject gameObject = this.preview;
					int num4 = 0;
					gameObject.transform.position = num4;
					GridSystem gridSystem = this.board.gridSystem;
					int num5 = this.theMouseRow;
					int num6 = this.theMouseColumn;
					if (gridSystem.HasPot(num6, num5))
					{
						Transform transform = this.preview.transform;
					}
					int num7 = (int)this.thePlantTypeOnMouse;
					bool flag;
					if (flag)
					{
						continue;
					}
					Board board = this.board;
					Vector3 position = this.preview.transform.position;
				}
				Transform transform2 = this.preview.transform;
			}
			int redLineColumn = this.board.config.redLineColumn;
			if (this.theMouseColumn >= redLineColumn || this.theZombieTypeOnMouse == ZombieType.BungiZombie || this.theZombieTypeOnMouse == ZombieType.GoldBungiZombie)
			{
				break;
			}
			int redLineColumn2 = this.board.config.redLineColumn;
			while (this.theMouseColumn >= redLineColumn2)
			{
			}
			Board board2 = this.board;
			Zombie zombie = this.theZombieOnGlove;
			int num8 = 0;
			if (zombie == num8)
			{
				goto Block_7;
			}
		}
		GameObject gameObject2 = this.preview;
		int num9 = 0;
		Transform transform3 = gameObject2.transform;
		int num10 = this.theMouseRow;
		float landY = this.GetLandY(num, num10);
		transform3.position = num9;
		return;
		Block_7:
		Transform transform4 = this.preview.transform;
		BoardConfig config = this.board.config;
		throw new NullReferenceException();
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x000D22DC File Offset: 0x000D04DC
	[Token(Token = "0x600272A")]
	[Address(RVA = "0x5FD650", Offset = "0x5FBC50", VA = "0x1805FD650")]
	private Plant TryRepairPlant()
	{
		ulong num5;
		do
		{
			int num = 0;
			GridSystem gridSystem = Board.Instance.gridSystem;
			int num2 = this.theMouseRow;
			int num3 = this.theMouseColumn;
			List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num5 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x000D2348 File Offset: 0x000D0548
	[Token(Token = "0x600272B")]
	[Address(RVA = "0x5FD070", Offset = "0x5FB670", VA = "0x1805FD070")]
	public Plant TryEatSeashroom(int theColumn, int theRow)
	{
		int num2;
		do
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
			num2 = 0;
			bool flag;
			if (flag)
			{
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
				if (num != 0)
				{
				}
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600272C RID: 10028 RVA: 0x000D2398 File Offset: 0x000D0598
	[Token(Token = "0x600272C")]
	[Address(RVA = "0x5FCE70", Offset = "0x5FB470", VA = "0x1805FCE70")]
	private Plant TryChomperPlant()
	{
		ulong num5;
		do
		{
			int num = 0;
			GridSystem gridSystem = Board.Instance.gridSystem;
			int num2 = this.theMouseRow;
			int num3 = this.theMouseColumn;
			List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
			}
		}
		while (num5 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x0600272D RID: 10029 RVA: 0x000D2400 File Offset: 0x000D0600
	[Token(Token = "0x600272D")]
	[Address(RVA = "0x5FD8A0", Offset = "0x5FBEA0", VA = "0x1805FD8A0")]
	private Plant TrySubmarinePlant()
	{
		int num4;
		do
		{
			int num = 0;
			GridSystem gridSystem = Board.Instance.gridSystem;
			int num2 = this.theMouseRow;
			int num3 = this.theMouseColumn;
			List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
			num4 = 0;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
		}
		while (num4 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x000D246C File Offset: 0x000D066C
	[Token(Token = "0x600272E")]
	[Address(RVA = "0x5FD440", Offset = "0x5FBA40", VA = "0x1805FD440")]
	private Plant TryHamburgerPlant(PlantType thePlantType)
	{
		ulong num5;
		do
		{
			int num = 0;
			GridSystem gridSystem = Board.Instance.gridSystem;
			int num2 = this.theMouseRow;
			int num3 = this.theMouseColumn;
			List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num5 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x0600272F RID: 10031 RVA: 0x000D24DC File Offset: 0x000D06DC
	[Token(Token = "0x600272F")]
	[Address(RVA = "0x5F7470", Offset = "0x5F5A70", VA = "0x1805F7470")]
	public bool MoveZombie(Zombie zombie, float x, int row, bool force = false)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (flag && !global::Lawnf.TravelAdvanced((AdvBuff)((uint)1000)) && !global::Lawnf.TravelAdvanced((AdvBuff)((uint)1003)))
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("无法移动boss类僵尸", 3f, num != 0);
		}
		float landY = this.GetLandY(x, row);
		zombie.theZombieRow = row;
		SortingGroup sortingGroup = zombie.sortingGroup;
		string text = string.Format("zombie{0}", flag);
		sortingGroup.sortingLayerName = text;
		throw new NullReferenceException();
	}

	// Token: 0x06002730 RID: 10032 RVA: 0x000D256C File Offset: 0x000D076C
	[Token(Token = "0x6002730")]
	[Address(RVA = "0x5FFCD0", Offset = "0x5FE2D0", VA = "0x1805FFCD0")]
	private void TryToSetZombieByCard()
	{
		InGameText instance;
		Glove instance2;
		Mouse mouse;
		for (;;)
		{
			Board board = this.board;
			int num = this.theMouseRow;
			int num2 = this.theMouseColumn;
			ScaryPotManager.CreateScaryPot(this.theZombieTypeOnMouse, num2, num);
			this.theIZECardOnMouse.PutDown();
			global::UnityEngine.Object.Destroy(this.theItemOnMouse);
			int num3 = 0;
			this.ClearItemOnMouse(num3 != 0);
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			this.PutDownItem();
			BoardConfig config = this.board.config;
			int num4 = this.theMouseColumn;
			if (num4 < config.redLineColumn)
			{
				Zombie zombie = this.theZombieOnGlove;
				int num5 = 0;
				if (zombie == num5 && this.theZombieTypeOnMouse != ZombieType.BungiZombie && this.theZombieTypeOnMouse != ZombieType.GoldBungiZombie)
				{
					BoardConfig config2 = this.board.config;
				}
			}
			int num6 = this.theMouseRow;
			Zombie zombie2 = this.theZombieOnGlove;
			int num7 = 0;
			Glove instance3;
			if (!(zombie2 == num7))
			{
				BoxType boxType = this.theZombieOnGlove.BoxType;
				Board board2 = this.board;
				int num8 = (int)boxType;
				BoxType boxType2 = board2.GetBoxType(num4, num6);
				if (num8 != (int)boxType2)
				{
					int theZombieType = (int)this.theZombieOnGlove.theZombieType;
					bool flag;
					if (!flag)
					{
						return;
					}
				}
				int theZombieType2 = (int)this.theZombieOnGlove.theZombieType;
				bool flag2;
				if (flag2 && !global::Lawnf.TravelAdvanced((AdvBuff)((uint)1000)) && !global::Lawnf.TravelAdvanced((AdvBuff)((uint)1003)))
				{
					break;
				}
				string text = string.Format("zombie{0}", instance);
				global::UnityEngine.Object.Destroy(this.theItemOnMouse);
				int num9 = 0;
				this.ClearItemOnMouse(num9 != 0);
				Board board3 = this.board;
				instance2 = Glove.Instance;
				float gloveCD = global::Lawnf.GetGloveCD();
				instance2.fullCD = gloveCD;
				instance3 = Glove.Instance;
				int num10 = 0;
				instance3.CD = (float)num10;
			}
			mouse = instance2.mouse;
			int num11;
			if (instance3.fullCD == 0f || num11 != 1)
			{
				CreateZombie instance4 = CreateZombie.Instance;
			}
			CreateZombie instance5 = CreateZombie.Instance;
			CreateZombie instance6 = CreateZombie.Instance;
			int num12 = 0;
			Zombie zombie3;
			if (zombie3 != num12)
			{
				goto Block_10;
			}
		}
		instance = InGameText.Instance;
		int num13 = 0;
		instance.ShowText("无法移动boss类僵尸", 3f, num13 != 0);
		return;
		Block_10:
		BoxType boxType3;
		if (boxType3 != BoxType.Water)
		{
			int num14 = global::UnityEngine.Random.Range(22, 24);
		}
		GameAPP.PlaySound(75, 0.5f, 1f);
		if (mouse == (ulong)45L || mouse == (ulong)63L)
		{
			Zombie zombie3;
			zombie3.GetComponent<BungiZombie>().targetColumn = zombie3;
		}
		Sprite plantGlove = instance2.plantGlove;
		Sprite plantGlove2 = instance2.plantGlove;
		if (instance2.plantGlove != 0)
		{
		}
		Sprite plantGlove3 = instance2.plantGlove;
		CreatePlant instance7 = CreatePlant.Instance;
		int num15 = 0;
		Plant plant;
		if (!(plant == num15))
		{
			Sprite plantGlove4 = instance2.plantGlove;
			Sprite plantGlove5 = instance2.plantGlove;
			plant.thePlantAttackInterval = plantGlove5;
			if (mouse != (ulong)60L)
			{
				float num16 = global::UnityEngine.Random.Range(3f, 7f);
			}
			float deltaTime = Time.deltaTime;
			plant.AttributeCountdown = deltaTime;
			Sprite plantGlove6 = instance2.plantGlove;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance8 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002731 RID: 10033 RVA: 0x000D2878 File Offset: 0x000D0A78
	[Token(Token = "0x6002731")]
	[Address(RVA = "0x5FF6E0", Offset = "0x5FDCE0", VA = "0x1805FF6E0")]
	private void TryToSetPlantByGlove()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		this.PutDownItem();
	}

	// Token: 0x06002732 RID: 10034 RVA: 0x000D2AAC File Offset: 0x000D0CAC
	[Token(Token = "0x6002732")]
	[Address(RVA = "0x5F9020", Offset = "0x5F7620", VA = "0x1805F9020")]
	private void SetPlantLevel(Plant plant)
	{
		GardenPlantData data = this.theGardenPlantOnGlove.data;
		plant.theLevel = (int)((ulong)3L);
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		plant.thePlantHealth = typeof(GameAPP).TypeHandle;
		int num = 0;
		plant.thePlantMaxHealth = typeof(GameAPP).TypeHandle;
		if (num == 1)
		{
			plant.theLevel = num;
			GameObject[] itemPrefab2 = GameAPP.itemPrefab;
			plant.thePlantHealth = itemPrefab2;
			plant.thePlantMaxHealth = itemPrefab2;
		}
		if (num == 2)
		{
			plant.theLevel = num;
			GameObject[] itemPrefab3 = GameAPP.itemPrefab;
			int num2 = 0;
			plant.thePlantHealth = typeof(GameAPP).TypeHandle;
			int num3 = 0;
			plant.thePlantMaxHealth = typeof(GameAPP).TypeHandle;
			plant.ModifyDamage((PlantDamageAdder)((uint)2), 1f, num2 != 0, num3);
		}
		int num4 = 0;
		GameObject levelIcon = plant.levelIcon;
		int num5 = 0;
		if (levelIcon == num5)
		{
			int num6 = 0;
			if (num4 != num6)
			{
				Transform axis = plant.axis;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				GameObject gameObject;
				plant.levelIcon = gameObject;
				Transform transform = plant.levelIcon.transform;
				Transform transform2 = plant.transform;
				transform.parentInternal = transform2;
			}
		}
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x000D2BB8 File Offset: 0x000D0DB8
	[Token(Token = "0x6002733")]
	[Address(RVA = "0x5F2880", Offset = "0x5F0E80", VA = "0x1805F2880")]
	private bool DisassemblePlant(Plant plant)
	{
		Board board = this.board;
		bool flag = global::Lawnf.TravelAdvanced((AdvBuff)((uint)1014));
		bool developerMode = GameAPP.developerMode;
		bool flag2 = global::Lawnf.TravelAdvanced((AdvBuff)((uint)1014));
		if ((uint)1 != 0U)
		{
			PlantType firstParent = plant.firstParent;
			PlantType secondParent = plant.secondParent;
			if (firstParent == PlantType.Nothing || secondParent == PlantType.Nothing)
			{
				int thePlantType = (int)plant.thePlantType;
				bool flag3;
				if (flag3)
				{
				}
				ulong num;
				if (num == (ulong)(-1L))
				{
					goto IL_008E;
				}
			}
			if (this.board.theSun < 500 && !developerMode)
			{
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("拆解需要500阳光", 5f, num2 != 0);
			}
		}
		IL_008E:
		Transform axis = plant.axis;
		PlantType thePlantType2 = plant.thePlantType;
		if (thePlantType2 == PlantType.CobCannon)
		{
		}
		if (thePlantType2 == PlantType.SpruceBallista)
		{
		}
		PlantType thePlantType3 = plant.thePlantType;
		if (thePlantType3 == PlantType.CobCannon)
		{
		}
		if (thePlantType3 == PlantType.SpruceBallista)
		{
		}
		plant.Die((Plant.DieReason)((uint)3));
		GameAPP.PlaySound(23, 0.5f, 1f);
		Glove.Instance.fullCD = 10f;
		Board.Instance.UseSun(500f);
		Glove.Instance.fullCD = 20f;
		throw new NullReferenceException();
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x000D2CE0 File Offset: 0x000D0EE0
	[Token(Token = "0x6002734")]
	[Address(RVA = "0x5F0770", Offset = "0x5EED70", VA = "0x1805F0770")]
	private void AdditionCard(PlantType type, Vector2 position, PlantType baseType)
	{
		if ((baseType != PlantType.CobCannon || type == PlantType.Cornpult) && baseType == PlantType.SpruceBallista && type == PlantType.SpruceShooter)
		{
			return;
		}
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x000D2D0C File Offset: 0x000D0F0C
	[Token(Token = "0x6002735")]
	[Address(RVA = "0x5F8150", Offset = "0x5F6750", VA = "0x1805F8150")]
	private void PutDownItem()
	{
		int num = 0;
		int num2 = this.theMouseRow;
		int num3 = this.theMouseColumn;
		GameObject gameObject = this.theItemOnMouse;
		MouseClickData mouseClickData = new MouseClickData(num2, num3, gameObject, num != 0);
		EventManager.TriggerEvent((GameEvent)((uint)9), mouseClickData);
		GameObject gameObject2 = this.theItemOnMouse;
		int num4 = 0;
		if (!(gameObject2 != num4))
		{
			PVPScareyPot instance = PVPScareyPot.Instance;
			int num5 = 0;
			if (instance != num5 && (PVPScareyPot.Instance.rightPutPot ? 1 : 0) != num)
			{
				int num6 = this.theMouseRow;
				int num7 = 0;
				GridItem gridItem = GridItem.SetGridItem(this.theMouseColumn, num6, (GridItemType)((uint)4), (GraveType)num7);
				int randomZombieType = (int)ScaryPotManager.GetRandomZombieType();
			}
			return;
		}
		if (this.theItemOnMouse.CompareTag("Preview") || this.theItemOnMouse.TryGetComponent<InGameTool>(num) || this.theItemOnMouse.TryGetComponent<Bucket>(num))
		{
			CardUI cardUI = this.theCardOnMouse;
			int num8 = 0;
			if (cardUI != num8)
			{
				this.theCardOnMouse.PutDown();
			}
			IZECard izecard = this.theIZECardOnMouse;
			int num9 = 0;
			if (izecard != num9)
			{
				this.theIZECardOnMouse.PutDown();
			}
		}
		global::UnityEngine.Object.Destroy(this.theItemOnMouse);
		int num10 = 0;
		this.ClearItemOnMouse(num10 != 0);
		GameAPP.PlaySound(19, 0.5f, 1f);
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x000D2E4C File Offset: 0x000D104C
	[Token(Token = "0x6002736")]
	[Address(RVA = "0x5F7330", Offset = "0x5F5930", VA = "0x1805F7330")]
	private void MouseClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = this.theItemOnMouse;
			int num = 0;
			if (!(gameObject == num))
			{
				this.LeftClickWithSomeThing();
			}
			this.LeftClickWithNothing();
			int num2 = this.theMouseRow;
			int num3 = this.theMouseColumn;
			GameObject gameObject2 = this.theItemOnMouse;
			ulong num4;
			MouseClickData mouseClickData = new MouseClickData(num2, num3, gameObject2, num4 != 0UL);
			EventManager.TriggerEvent((GameEvent)((uint)9), mouseClickData);
		}
		if (Input.GetMouseButtonDown(1))
		{
			this.PutDownItem();
			return;
		}
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x000D2EC0 File Offset: 0x000D10C0
	[Token(Token = "0x6002737")]
	[Address(RVA = "0x5F6EF0", Offset = "0x5F54F0", VA = "0x1805F6EF0")]
	private void LeftEvent()
	{
		GameObject gameObject = this.theItemOnMouse;
		int num = 0;
		if (!(gameObject == num))
		{
			this.LeftClickWithSomeThing();
		}
		this.LeftClickWithNothing();
		int num2 = this.theMouseRow;
		int num3 = this.theMouseColumn;
		GameObject gameObject2 = this.theItemOnMouse;
		ulong num4;
		MouseClickData mouseClickData = new MouseClickData(num2, num3, gameObject2, num4 != 0UL);
		EventManager.TriggerEvent((GameEvent)((uint)9), mouseClickData);
	}

	// Token: 0x06002738 RID: 10040 RVA: 0x000D2F1C File Offset: 0x000D111C
	[Token(Token = "0x6002738")]
	[Address(RVA = "0x5F4140", Offset = "0x5F2740", VA = "0x1805F4140")]
	private void LeftClickWithNothing()
	{
		int num12;
		do
		{
			int num = 0;
			int num2 = 0;
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector3 vector;
			float z2 = vector.z;
			Vector2 zeroVector = Vector2.zeroVector;
			List<GameObject> list = new List();
			List<IClickable> list2 = new List();
			RaycastHit2D[] array;
			if (num2 < array.Length)
			{
				Collider2D collider2D;
				GameObject gameObject = collider2D.gameObject;
				int size = list._size;
				Collider2D collider2D2;
				if (collider2D2.TryGetComponent<IClickable>(num2))
				{
				}
				num2++;
			}
			Func<IClickable, int> func;
			if (Mouse.<>c.<>9__51_0 == 0)
			{
				Mouse.<>c.<>9__51_0 = func;
			}
			List<IClickable> list3 = Enumerable.ToList<IClickable>(Enumerable.OrderBy<IClickable, int>(list2, func));
			bool flag;
			if (flag)
			{
				num2 += num2;
				num2++;
			}
			if (num2 != 0)
			{
				goto IL_0289;
			}
			int num3 = 0;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (!flag3)
				{
				}
				ZombieBattleManager.Instance.SelectZombie(num2);
			}
			if (num3 != 0)
			{
				goto IL_029B;
			}
			int num4 = 0;
			bool flag4;
			if (flag4)
			{
				bool flag5;
				while (!flag5)
				{
				}
				int theSun = Board.Instance.theSun;
				uint num5;
				GameAPP.PlaySound((int)num5, 0.5f, 1f);
				uint num6;
				GameAPP.PlaySound((int)num6, 0.5f, 1f);
			}
			if (num4 != 0)
			{
				goto IL_02AD;
			}
			int num7 = 0;
			bool flag6;
			if (flag6)
			{
				bool flag7;
				while (!flag7)
				{
				}
				if (num2 == 0 || num2 != 0)
				{
				}
				int theSun2 = Board.Instance.theSun;
				bool flag8 = LevelManager.TryGetLevelData(num7);
				bool flag9;
				if ((!flag8 || !flag8) && !flag9)
				{
					uint num8;
					GameAPP.PlaySound((int)num8, 0.5f, 1f);
					uint num9;
					GameAPP.PlaySound((int)num9, 0.5f, 1f);
				}
			}
			if (num7 != 0)
			{
				goto IL_02C5;
			}
			int num10 = 0;
			bool flag10;
			if (flag10)
			{
				bool flag11;
				while (!flag11)
				{
				}
				float deltaTime = Time.deltaTime;
				while (zeroVector <= deltaTime)
				{
				}
			}
			if (num10 != 0)
			{
				goto IL_02DD;
			}
			int num11 = 0;
			bool flag12;
			if (flag12)
			{
				bool flag13;
				while (!flag13)
				{
				}
				Board instance = Board.Instance;
			}
			if (num11 != 0)
			{
				goto IL_02EF;
			}
			num12 = 0;
			bool flag14;
			if (flag14)
			{
				UpgradeArrow.SetArrow(num);
				bool flag15;
				bool flag16;
				if (flag14 > true && flag15 > true)
				{
					if (flag15)
					{
						goto IL_0274;
					}
					if (GameAPP.itemPrefab == (ulong)1307L)
					{
						flag16 = "{il2cpp field on {'constant311' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(SunStar).TypeHandle;
					}
					while (num != 1317)
					{
					}
					uint num13;
					GameAPP.PlaySound((int)num13, 0.5f, 1f);
					if (flag16 <= true || flag16 > true)
					{
					}
				}
				while (!flag16)
				{
				}
				CreatePlant instance2 = CreatePlant.Instance;
				bool flag17;
				if (flag17 <= true)
				{
				}
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
				Transform transform;
				transform.name = "cannon";
				Quaternion identityQuaternion3 = Quaternion.identityQuaternion;
				Transform transform2;
				transform2.name = "cannon";
				if (GameAPP.config.shootingWithoutGlove)
				{
					Board instance3 = Board.Instance;
				}
				this.board.controledPlant = transform2;
			}
			IL_0274:;
		}
		while (num12 != 0);
		return;
		IL_0289:
		throw new NullReferenceException();
		IL_029B:
		throw new NullReferenceException();
		IL_02AD:
		throw new NullReferenceException();
		IL_02C5:
		throw new NullReferenceException();
		IL_02DD:
		throw new NullReferenceException();
		IL_02EF:
		throw new NullReferenceException();
	}

	// Token: 0x06002739 RID: 10041 RVA: 0x000D32A8 File Offset: 0x000D14A8
	[Token(Token = "0x6002739")]
	[Address(RVA = "0x5F5FE0", Offset = "0x5F45E0", VA = "0x1805F5FE0")]
	private void LeftClickWithSomeThing()
	{
		int num;
		for (;;)
		{
			num = 0;
			if (!this.theItemOnMouse.CompareTag("Preview") && !this.theItemOnMouse.TryGetComponent<InGameTool>(num))
			{
				break;
			}
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector2 zeroVector = Vector2.zeroVector;
			RaycastHit2D[] array;
			if (num >= array.Length)
			{
				goto IL_030F;
			}
			Collider2D collider2D;
			if (collider2D.TryGetComponent<CardUI>(num))
			{
				int num2 = 0;
				DroppedCard droppedCard;
				if (droppedCard == num2)
				{
					goto IL_02F5;
				}
			}
			Collider2D collider2D2;
			bool flag = collider2D2.TryGetComponent<Plant>(num);
			if (!flag)
			{
				goto IL_02F1;
			}
			if (flag <= true)
			{
				goto IL_0294;
			}
			if (flag)
			{
				goto Block_12;
			}
		}
		bool flag2 = string.Equals(this.theItemOnMouse.name, "cannon");
		if (!flag2)
		{
			if (!this.theItemOnMouse.TryGetComponent<Bucket>(num) || this.mouseX > -6f)
			{
			}
			if (this.mouseItemType != MouseItemType.Bean)
			{
				return;
			}
			Camera main2 = Camera.main;
			float z2 = Input.mousePosition.z;
			RaycastHit2D[] array2;
			List<Plant> plantsOnMouse = this.GetPlantsOnMouse(array2);
			ulong num3;
			this.ClearItemOnMouse(num3 != 0UL);
			Money instance = Money.Instance;
			int num4 = 0;
			if (!(instance != num4))
			{
				return;
			}
			Money instance2 = Money.Instance;
			int num5 = 0;
			Plant plant = plantsOnMouse[num5];
			instance2.ReinforcePlant(plant);
		}
		if (this.mouseX > -6.5f)
		{
			Plant plant2 = this.cannonPlant;
			int num6 = 0;
			if (plant2 != num6)
			{
				Plant plant3 = this.cannonPlant;
				Camera main3 = Camera.main;
				float z3 = Input.mousePosition.z;
				Vector3 vector;
				float z4 = vector.z;
				plant3.cannonTarget.z = z4;
			}
		}
		ulong num7;
		this.ClearItemOnMouse(num7 != 0UL);
		return;
		Block_12:
		Plant plant4 = this.thePlantOnGlove;
		int num8 = 0;
		bool flag3;
		if (!(plant4 != num8) || this.thePlantOnGlove.thePlantType != PlantType.UltimateJalaNut || !flag3)
		{
			goto IL_02F1;
		}
		Plant plant5 = this.thePlantOnGlove;
		int num9 = 0;
		plant5.Die((Plant.DieReason)num9);
		ulong num10;
		this.ClearItemOnMouse(num10 != 0UL);
		if ("{il2cpp field on Plant.Die, offset 0xFFFFFFFFFFFFFFF8}" != typeof(UltimateExplodeCannon).TypeHandle)
		{
			goto IL_02F1;
		}
		Plant plant6 = this.thePlantOnGlove;
		int num11 = 0;
		if (!(plant6 != num11) || !this.thePlantOnGlove.TryGetComponent<GatlingPea>(num))
		{
			goto IL_02F1;
		}
		ulong num12;
		this.ClearItemOnMouse(num12 != 0UL);
		uint num13;
		GameAPP.PlaySound((int)num13, 0.5f, 1f);
		IL_0294:
		DroppedCard droppedCard2;
		if (droppedCard2 == (ulong)220L)
		{
			Plant plant7 = this.thePlantOnGlove;
			int num14 = 0;
			if (!(plant7 != num14))
			{
				goto IL_02F1;
			}
			PlantType thePlantType = this.thePlantOnGlove.thePlantType;
		}
		bool flag4;
		if (flag4)
		{
			Plant plant8 = this.thePlantOnGlove;
			int num15 = 0;
			if (plant8 != num15)
			{
				PlantType thePlantType2 = this.thePlantOnGlove.thePlantType;
				bool flag5;
				if (flag5)
				{
					goto IL_02FB;
				}
			}
		}
		IL_02F1:
		num++;
		IL_02F5:
		this.PutDownItem();
		IL_02FB:
		Plant plant9 = this.thePlantOnGlove;
		int num16 = 0;
		plant9.Die((Plant.DieReason)num16);
		IL_030F:
		Plant plant10 = this.thePlantOnGlove;
		int num17 = 0;
		if (plant10 == num17)
		{
			GardenPlant gardenPlant = this.theGardenPlantOnGlove;
			int num18 = 0;
			if (gardenPlant == num18)
			{
				if (this.mouseItemType != MouseItemType.Plant_preview)
				{
					this.TryToSetZombieByCard();
				}
				this.TryToSetPlantByCard();
			}
		}
		this.TryToSetPlantByGlove();
		throw new NullReferenceException();
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x000D3620 File Offset: 0x000D1820
	[Token(Token = "0x600273A")]
	[Address(RVA = "0x5F84F0", Offset = "0x5F6AF0", VA = "0x1805F84F0")]
	private void ReinforcePlant()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		RaycastHit2D[] array;
		List<Plant> plantsOnMouse = this.GetPlantsOnMouse(array);
		this.ClearItemOnMouse(true);
		Money instance = Money.Instance;
		int num = 0;
		if (instance != num)
		{
			int num2 = 0;
			Money instance2 = Money.Instance;
			Plant plant = plantsOnMouse[num2];
			instance2.ReinforcePlant(plant);
		}
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x000D368C File Offset: 0x000D188C
	[Token(Token = "0x600273B")]
	[Address(RVA = "0x5F30B0", Offset = "0x5F16B0", VA = "0x1805F30B0")]
	private void FixedUpdate()
	{
		int num2;
		int num4;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				if (this.thePlantTypeOnMouse != PlantType.Nothing)
				{
					Board board = this.board;
					PlantType plantType = this.thePlantTypeOnMouse;
					bool flag2;
					if (!flag2 || flag2)
					{
					}
				}
			}
			if (num2 != 0)
			{
				goto IL_007F;
			}
			num4 = 0;
			bool flag3;
			if (flag3)
			{
			}
		}
		while (num4 != 0);
		int num5 = 0;
		if (num2 != num5)
		{
		}
		return;
		IL_007F:
		throw new NullReferenceException();
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x000D3720 File Offset: 0x000D1920
	[Token(Token = "0x600273C")]
	[Address(RVA = "0x5F6FF0", Offset = "0x5F55F0", VA = "0x1805F6FF0")]
	private void LightUpPlantUnderMouse()
	{
		GameObject gameObject = this.theItemOnMouse;
		int num = 0;
		if (!gameObject.CompareTag("Preview"))
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			RaycastHit2D[] array;
			List<Plant> plantsOnMouse = this.GetPlantsOnMouse(array);
			Board board = this.board;
			if (num < array.Length)
			{
				Collider2D collider2D;
				if (collider2D.TryGetComponent<GardenPlant>(num))
				{
				}
				num++;
				Plant plant;
				if (plant != 0)
				{
					Plant plant2;
					plant2.SetBrightness(2.4f);
				}
				Plant plant3;
				plant3.alwaysLightUp = true;
			}
		}
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x000D37B4 File Offset: 0x000D19B4
	[Token(Token = "0x600273D")]
	[Address(RVA = "0x5FDB10", Offset = "0x5FC110", VA = "0x1805FDB10")]
	public void TryToPickPlant()
	{
		GameObject gameObject = this.theItemOnMouse;
		int i = 0;
		int num = 0;
		if (gameObject != num)
		{
			gameObject.GetComponent<Glove>().PutDown();
		}
		int num2 = 0;
		this.ClearItemOnMouse(num2 != 0);
		Board instance = Board.Instance;
		if (this.theMouseRow > 2)
		{
			InGameText instance2 = InGameText.Instance;
			int num3 = 0;
			instance2.ShowText("无法抓取下半部分植物", 5f, num3 != 0);
			return;
		}
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		RaycastHit2D[] array;
		List<Plant> plantsOnMouse = this.GetPlantsOnMouse(array);
		Board board = this.board;
		Predicate<Plant> predicate;
		if (Mouse.<>c.<>9__56_0 == 0)
		{
			Mouse.<>c.<>9__56_0 = predicate;
		}
		int num4 = plantsOnMouse.RemoveAll(predicate);
		Predicate<Plant> predicate2;
		if (Mouse.<>c.<>9__56_1 == 0)
		{
			Mouse.<>c.<>9__56_1 = predicate2;
		}
		int num5 = plantsOnMouse.RemoveAll(predicate2);
		if ((Glove.Instance.isZombie ? 1 : 0) == i)
		{
			int num6 = 0;
			GridItem ladder = plantsOnMouse[num6].Ladder;
			int num7 = 0;
			if (!(ladder != num7))
			{
				int num8 = 0;
				if ((plantsOnMouse[num8].dieMeansLose ? 1 : 0) != i)
				{
					Board board2 = this.board;
					InGameText instance3 = InGameText.Instance;
				}
				int num9 = 0;
				Plant plant = plantsOnMouse[num9];
				this.thePlantOnGlove = plant;
				int num10 = 0;
				PlantType thePlantType = plantsOnMouse[num10].thePlantType;
				int num11 = 0;
				this.thePlantTypeOnMouse = thePlantType;
				PlantType previewType = plantsOnMouse[num11].PreviewType;
				uint num12;
				GameAPP.PlaySound((int)num12, 0.5f, 1f);
			}
			InGameText instance4 = InGameText.Instance;
		}
		Board board3 = this.board;
		while (i >= array.Length)
		{
		}
		int num13 = 0;
		Collider2D collider2D;
		if (collider2D.TryGetComponent<GardenPlant>(num13))
		{
			Board board4 = this.board;
			int theLimPlantCount = board4.theLimPlantCount;
			if (board4.theCurrentPlantCount >= theLimPlantCount)
			{
				goto IL_0213;
			}
			if (board4 == 0)
			{
				this.theGardenPlantOnGlove = board4;
				CancellationTokenSource cancellationTokenSource = board4.m_CancellationTokenSource;
				this.thePlantTypeOnMouse = cancellationTokenSource;
				uint num14;
				GameAPP.PlaySound((int)num14, 0.5f, 1f);
				i++;
			}
			InGameText instance5 = InGameText.Instance;
			string text = string.Format("距离植物休息完毕还有{0}秒", instance5);
			int num15 = 0;
			instance5.ShowText(text, 3f, num15 != 0);
		}
		i++;
		IL_0213:
		InGameText instance6 = InGameText.Instance;
		Board board5 = this.board;
		Board board6 = this.board;
		string text2 = string.Format("作战植物已达上限{0}/{1}", instance6, instance6);
		List<Zombie> zombiesOnMouse = this.GetZombiesOnMouse(array);
		Func<Zombie, int> func;
		if (Mouse.<>c.<>9__56_2 == 0)
		{
			Mouse.<>c.<>9__56_2 = func;
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.OrderByDescending<Zombie, int>(zombiesOnMouse, func));
		int num16 = 0;
		Zombie zombie = zombiesOnMouse[num16];
		this.theZombieOnGlove = zombie;
		ZombieType theZombieType = this.theZombieOnGlove.theZombieType;
		this.theZombieTypeOnMouse = theZombieType;
		this.mouseItemType = (MouseItemType)((ulong)2L);
		this.CreateZombieOnMouse(theZombieType);
		throw new NullReferenceException();
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x000D3A6C File Offset: 0x000D1C6C
	[Token(Token = "0x600273E")]
	[Address(RVA = "0x5F36B0", Offset = "0x5F1CB0", VA = "0x1805F36B0")]
	public List<Plant> GetPlantsOnMouse(RaycastHit2D[] hits)
	{
		int num = 0;
		HashSet<Plant> hashSet = new HashSet();
		if (num < hits.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Plant>(num))
			{
				Collider2D collider2D2;
				LayerMask contactCaptureLayers = collider2D2.contactCaptureLayers;
				int mask = contactCaptureLayers.m_Mask;
				if (contactCaptureLayers == 0)
				{
					Board instance = Board.Instance;
					if (instance > (ulong)251L)
					{
						if (instance == (ulong)255L || instance == (ulong)361L)
						{
							goto IL_00A3;
						}
						if (instance != (ulong)1179L)
						{
							goto IL_0091;
						}
					}
					if (instance == (ulong)222L)
					{
					}
					if (instance == (ulong)239L || instance == (ulong)251L)
					{
						goto IL_00A3;
					}
					IL_0091:
					if (this.mouseItemType == MouseItemType.Bean)
					{
						bool flag = hashSet.Add(num);
					}
				}
			}
			IL_00A3:
			num++;
		}
		List<Plant> list = Enumerable.ToList<Plant>(hashSet);
		Func<Plant, int> func;
		if (Mouse.<>c.<>9__57_0 == 0)
		{
			Mouse.<>c.<>9__57_0 = func;
		}
		IOrderedEnumerable<Plant> orderedEnumerable = Enumerable.OrderByDescending<Plant, int>(hashSet, func);
		Func<Plant, bool> func2;
		if (Mouse.<>c.<>9__57_1 == 0)
		{
			Mouse.<>c.<>9__57_1 = func2;
		}
		IOrderedEnumerable<Plant> orderedEnumerable2 = Enumerable.ThenByDescending<Plant, bool>(orderedEnumerable, func2);
		Func<Plant, bool> func3;
		if (Mouse.<>c.<>9__57_2 == 0)
		{
			Mouse.<>c.<>9__57_2 = func3;
		}
		IOrderedEnumerable<Plant> orderedEnumerable3 = Enumerable.ThenByDescending<Plant, bool>(orderedEnumerable2, func3);
		Func<Plant, bool> func4;
		if (Mouse.<>c.<>9__57_3 == 0)
		{
			Mouse.<>c.<>9__57_3 = func4;
		}
		return Enumerable.ToList<Plant>(Enumerable.ThenByDescending<Plant, bool>(orderedEnumerable3, func4));
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x000D3BA4 File Offset: 0x000D1DA4
	[Token(Token = "0x600273F")]
	[Address(RVA = "0x5F3E30", Offset = "0x5F2430", VA = "0x1805F3E30")]
	private List<Zombie> GetZombiesOnMouse(RaycastHit2D[] hits)
	{
		int num = 0;
		List<Zombie> list = new List();
		if (num < hits.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num))
			{
			}
			num++;
		}
		Func<Zombie, bool> func;
		if (Mouse.<>c.<>9__58_0 == 0)
		{
			Mouse.<>c.<>9__58_0 = func;
		}
		return Enumerable.ToList<Zombie>(Enumerable.OrderByDescending<Zombie, bool>(list, func));
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x000D3C04 File Offset: 0x000D1E04
	[Token(Token = "0x6002740")]
	[Address(RVA = "0x5F2100", Offset = "0x5F0700", VA = "0x1805F2100")]
	public void ClickOnCard(CardUI card)
	{
		this.mouseItemType = (MouseItemType)((ulong)1L);
		Board instance = Board.Instance;
		int theSeedCost = card.theSeedCost;
		bool flag;
		if (!flag || !flag)
		{
			bool flag2 = this.ClickCard(card);
			if (!flag2)
			{
				if (card.isAvailable == flag2)
				{
					GameAPP.PlaySound(26, 0.5f, 1f);
				}
				else
				{
					if (!flag2)
					{
						this.mouseItemType = (MouseItemType)((ulong)0L);
						return;
					}
					this.theCardOnMouse = 0;
					this.thePlantTypeOnMouse = PlantType.Peashooter;
					GameAPP.PlaySound(25, 0.5f, 1f);
					return;
				}
			}
		}
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x000D3C90 File Offset: 0x000D1E90
	[Token(Token = "0x6002741")]
	[Address(RVA = "0x5F22C0", Offset = "0x5F08C0", VA = "0x1805F22C0")]
	public void ClickZombieCard(IZECard card)
	{
		this.mouseItemType = (MouseItemType)((ulong)2L);
		Board instance = Board.Instance;
		int theSeedCost = card.theSeedCost;
		bool flag = card.PickUp();
		this.theIZECardOnMouse = card;
		ZombieType theZombieType = card.theZombieType;
		this.theZombieTypeOnMouse = theZombieType;
		this.CreateZombieOnMouse(theZombieType);
		GameAPP.PlaySound(25, 0.5f, 1f);
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x000D3D00 File Offset: 0x000D1F00
	[Token(Token = "0x6002742")]
	[Address(RVA = "0x5F1690", Offset = "0x5EFC90", VA = "0x1805F1690")]
	public void ClearItemOnMouse(bool clearItem = false)
	{
		if (clearItem)
		{
			global::UnityEngine.Object.Destroy(this.theItemOnMouse);
		}
		int num = 0;
		this.plantTowards = (Towards)((ulong)1L);
		this.theIZECardOnMouse = num;
		this.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
		this.theZombieTypeOnMouse = (ZombieType)((ulong)4294967295L);
		this.theItemOnMouse = num;
		this.theCardOnMouse = num;
		this.thePlantOnGlove = num;
		this.theZombieOnGlove = num;
		this.theGardenPlantOnGlove = num;
		this.cannonPlant = num;
		this.mouseItemType = (MouseItemType)num;
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x000D3D80 File Offset: 0x000D1F80
	[Token(Token = "0x6002743")]
	[Address(RVA = "0x5F4090", Offset = "0x5F2690", VA = "0x1805F4090")]
	private bool HammerClick(CardUI card)
	{
		PlantType thePlantType = card.thePlantType;
		if (thePlantType == PlantType.CherryBomb || thePlantType == PlantType.IceShroom || thePlantType != PlantType.Jalapeno)
		{
		}
		Hammer instance = Hammer.Instance;
		PlantType thePlantType2 = card.thePlantType;
		if (instance.SwitchType(thePlantType2))
		{
			Board board = this.board;
		}
		return true;
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x000D3DCC File Offset: 0x000D1FCC
	[Token(Token = "0x6002744")]
	[Address(RVA = "0x5F1780", Offset = "0x5EFD80", VA = "0x1805F1780")]
	private bool ClickCard(CardUI card)
	{
		Plant plant;
		int num9;
		for (;;)
		{
			GodManager instance = GodManager.Instance;
			int num = 0;
			if (!(instance != num))
			{
				int theBoardLevel = GameAPP.theBoardLevel;
				if (theBoardLevel <= 118)
				{
					goto IL_0159;
				}
				if (theBoardLevel > 131)
				{
					if (theBoardLevel > 159)
					{
						if (theBoardLevel == 165)
						{
							goto IL_018D;
						}
						if (theBoardLevel != 170)
						{
							goto IL_01C5;
						}
						bool flag = ShootingData.Shooting8(card);
					}
					PlantType thePlantType = card.thePlantType;
					if ((thePlantType <= PlantType.SunNut || thePlantType != PlantType.HypnoNut) && thePlantType != PlantType.CherryNut && thePlantType != PlantType.SunNut)
					{
						goto IL_01C5;
					}
					Board board = this.board;
					int theSeedCost = card.theSeedCost;
					int theSun = board.theSun;
					board.theSun = theSun;
					BallLauncher launcher = BrickManager.Instance.launcher;
					PlantType thePlantType2 = card.thePlantType;
					launcher.CreateNewBall(thePlantType2);
					if (launcher != (ulong)159L)
					{
						goto IL_01C5;
					}
					bool flag2 = ShootingData.Shooting7(card);
				}
				if (theBoardLevel > 124)
				{
					if (theBoardLevel == 130)
					{
						bool flag3 = ShootingData.Shooting6(card);
					}
					if (theBoardLevel != 131)
					{
						goto IL_01C5;
					}
					bool flag4 = ShootingData.Chess(card);
				}
				if (theBoardLevel == 121)
				{
					bool flag5 = this.Shooting5(card);
				}
				if (this == (ulong)124L)
				{
					PlantType thePlantType3 = card.thePlantType;
					if (thePlantType3 == PlantType.CherryBomb || thePlantType3 == PlantType.IceShroom || thePlantType3 == PlantType.Jalapeno)
					{
						Hammer instance2 = Hammer.Instance;
						PlantType thePlantType4 = card.thePlantType;
						if (instance2.SwitchType(thePlantType4))
						{
							Board board2 = this.board;
							goto IL_0159;
						}
						continue;
					}
				}
				IL_01C5:
				if (card.thePlantType == PlantType.AbyssSwordStar)
				{
					AbyssSwordStar instance3 = AbyssSwordStar.Instance;
					int num2 = 0;
					if (instance3 != num2)
					{
						uint num3;
						GameAPP.PlaySound((int)num3, 0.5f, 1f);
						InGameText instance4 = InGameText.Instance;
						int num4 = 0;
						instance4.ShowText("该植物只能存在一个", 3f, num4 != 0);
					}
				}
				CardUI p_card = card.p_card;
				int num5 = 0;
				if (!(p_card != num5) || !card.p_card.isAvailable)
				{
					continue;
				}
				Plant p_plant = card.p_plant;
				int num6 = 0;
				if (p_plant != num6)
				{
					if (card.p_plant.plantTag != (ulong)0L)
					{
						goto IL_02BA;
					}
					CreatePlant instance5 = CreatePlant.Instance;
					CardUI p_card2 = card.p_card;
					CreatePlant instance6 = CreatePlant.Instance;
					int num7 = 0;
					CreateItem instance7 = CreateItem.Instance;
					if (card.thePlantType == PlantType.MelonPot)
					{
						CreateItem instance8 = CreateItem.Instance;
						num7++;
						goto IL_02BA;
					}
					IL_02C7:
					int num8 = 0;
					if (plant != num8)
					{
						break;
					}
					continue;
					IL_02BA:
					CreatePlant instance9 = CreatePlant.Instance;
					num9 = 0;
					goto IL_02C7;
				}
				continue;
				IL_0159:
				if (theBoardLevel > 88)
				{
					if (theBoardLevel > 100)
					{
						if (theBoardLevel == 113)
						{
							this.Shooting4(card);
						}
						bool flag6 = this.BilliardBall2(card);
					}
					if (this == (ulong)98L)
					{
						this.Single(card);
					}
					if (this == (ulong)100L)
					{
						goto IL_018D;
					}
					goto IL_01C5;
				}
				IL_0194:
				if (this > (ulong)73L)
				{
					if (this != (ulong)88L)
					{
						goto IL_01C5;
					}
					this.Shooting1(card);
					this.Shooting2(card);
					this.Shooting3(card);
				}
				this.Shooting1(card);
				this.Shooting2(card);
				goto IL_01C5;
				IL_018D:
				this.Bejeweled1(card);
				goto IL_0194;
			}
			goto IL_0327;
		}
		this.board.UseSun(0.5f);
		Board board3 = this.board;
		CardUI p_card3 = card.p_card;
		if (plant.thePlantType != PlantType.SuperCherryShooter)
		{
			p_card3.CD = (float)num9;
		}
		float fullCD = p_card3.fullCD;
		if (0 <= (int)fullCD)
		{
		}
		p_card3.CD = fullCD;
		IL_0327:
		GodManager.Instance.ClickCard(card);
		throw new NullReferenceException();
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x000D4114 File Offset: 0x000D2314
	[Token(Token = "0x6002745")]
	[Address(RVA = "0x5FB6C0", Offset = "0x5F9CC0", VA = "0x1805FB6C0")]
	private bool Shooting5(CardUI card)
	{
		PlantType thePlantType2;
		for (;;)
		{
			int num = 0;
			PlantType thePlantType = card.thePlantType;
			if (thePlantType <= PlantType.LaserUmbrella)
			{
				goto IL_0095;
			}
			if (thePlantType > PlantType.CaltropNut)
			{
				int num2;
				if (thePlantType == PlantType.SunCabbage)
				{
					num2 = 0;
					Plant[] array;
					if (num2 >= array.Length)
					{
						goto IL_0061;
					}
					num2++;
				}
				int num3;
				if (num2 == 1135)
				{
					num3 = 0;
					Plant[] array2;
					if (num3 >= array2.Length)
					{
						goto IL_0061;
					}
					num3++;
				}
				if (num3 != 1185)
				{
					goto IL_013D;
				}
			}
			IL_0061:
			int i;
			if (thePlantType == PlantType.IceFumeShroom)
			{
				i = 0;
				Plant[] array3;
				while (i >= array3.Length)
				{
				}
				i++;
			}
			if (i != 1046)
			{
				if (i == 1048)
				{
					goto IL_0095;
				}
				goto IL_013D;
			}
			IL_00B4:
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			int num4 = 0;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				thePlantType2 = card.thePlantType;
			}
			if (num4 == 0)
			{
				break;
			}
			continue;
			IL_0095:
			if (thePlantType <= PlantType.Cabbagepult)
			{
				break;
			}
			if (thePlantType == PlantType.Umbrellaleaf)
			{
			}
			if (thePlantType == PlantType.UltimateFume)
			{
			}
			if (thePlantType <= PlantType.SmallPuff)
			{
				goto IL_00B4;
			}
			goto IL_013D;
		}
		int j;
		if (thePlantType2 == PlantType.WallNut)
		{
			j = 0;
			Plant[] array4;
			while (j >= array4.Length)
			{
			}
			j++;
		}
		int k;
		if (j == 7)
		{
			k = 0;
			Plant[] array5;
			while (k >= array5.Length)
			{
			}
			k++;
		}
		if (k == 26)
		{
			int l = 0;
			Plant[] array6;
			while (l >= array6.Length)
			{
			}
			l++;
		}
		IL_013D:
		throw new NullReferenceException();
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x000D4270 File Offset: 0x000D2470
	[Token(Token = "0x6002746")]
	[Address(RVA = "0x5F0D20", Offset = "0x5EF320", VA = "0x1805F0D20")]
	private bool BilliardBall2(CardUI card)
	{
		PlantType thePlantType = card.thePlantType;
		if (thePlantType > PlantType.UltimateStar)
		{
			if (thePlantType == PlantType.ObsidianWallNut)
			{
				BilliardRod billiardRod = BilliardManager.Instance.billiardRod;
				int num = 0;
				if (billiardRod.Upgrade())
				{
					this.board.UseSun((float)num);
				}
				card.disabled = true;
				return true;
			}
			if (thePlantType == PlantType.SuperStar)
			{
				Board board = this.board;
				card.CD = 0f;
				Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[11]).transform;
				Transform transform2 = base.transform;
				transform.parentInternal = transform2;
				return true;
			}
		}
		else
		{
			if (thePlantType == PlantType.StarFruit)
			{
				Board board2 = this.board;
				card.CD = 0f;
				GameObject gameObject = GameAPP.itemPrefab[10];
			}
			Board board3 = this.board;
			GameObject[] itemPrefab = GameAPP.itemPrefab;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x000D4348 File Offset: 0x000D2548
	[Token(Token = "0x6002747")]
	[Address(RVA = "0x5FB020", Offset = "0x5F9620", VA = "0x1805FB020")]
	private void Shooting4(CardUI card)
	{
		PlantType thePlantType2;
		for (;;)
		{
			int num = 0;
			PlantType thePlantType = card.thePlantType;
			int j;
			if (thePlantType > PlantType.DoubleShooter)
			{
				if (thePlantType > PlantType.HypnoDoom)
				{
					int num3;
					if (thePlantType > PlantType.HypnoMagnet)
					{
						int num2;
						if (thePlantType == PlantType.BigGatling)
						{
							num2 = 0;
							Plant[] array;
							if (num2 >= array.Length)
							{
								break;
							}
							num2++;
						}
						if (num2 != 1168)
						{
							break;
						}
						num3 = 0;
						Plant[] array2;
						if (num3 >= array2.Length)
						{
							break;
						}
						num3++;
					}
					if (num3 == 1100)
					{
						break;
					}
					Plant[] array3;
					while (array3 != (ulong)1157L)
					{
					}
				}
				if (thePlantType > PlantType.IceScaredyShroom)
				{
					if (thePlantType == PlantType.ScaredyDoom)
					{
					}
					while (thePlantType != PlantType.HypnoDoom)
					{
					}
				}
				int i;
				if (thePlantType == PlantType.GatlingPea)
				{
					i = 0;
					Plant[] array4;
					while (i >= array4.Length)
					{
					}
					i++;
				}
				while (i != 1038)
				{
				}
				j = 0;
				Plant[] array5;
				while (j >= array5.Length)
				{
				}
				j++;
			}
			if (j <= 9)
			{
				goto IL_016B;
			}
			int l;
			if (j > 930)
			{
				int k;
				if (j == 1024)
				{
					k = 0;
					Plant[] array6;
					while (k >= array6.Length)
					{
					}
					k++;
				}
				while (k != 1030)
				{
				}
				l = 0;
				Plant[] array7;
				while (l >= array7.Length)
				{
				}
				l++;
			}
			if (l == 25)
			{
			}
			l += -924;
			while (l > 6)
			{
			}
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			int num4 = 0;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				thePlantType2 = card.thePlantType;
			}
			if (num4 == 0)
			{
				return;
			}
		}
		return;
		IL_016B:
		int m;
		if (thePlantType2 == PlantType.Peashooter)
		{
			m = 0;
			Plant[] array8;
			while (m >= array8.Length)
			{
			}
			m++;
		}
		if (m == 8)
		{
		}
		while (m != 9)
		{
		}
		int n = 0;
		Plant[] array9;
		while (n >= array9.Length)
		{
		}
		n++;
		throw new NullReferenceException();
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x000D4508 File Offset: 0x000D2708
	[Token(Token = "0x6002748")]
	[Address(RVA = "0x5F0810", Offset = "0x5EEE10", VA = "0x1805F0810")]
	private void Bejeweled1(CardUI card)
	{
		int num2;
		BejeweledManager instance;
		for (;;)
		{
			int num = 0;
			num2 = 0;
			instance = BejeweledManager.Instance;
			PlantType thePlantType = card.thePlantType;
			int num3 = (int)thePlantType;
			if (thePlantType != PlantType.Pit)
			{
				if (num3 == 258)
				{
					break;
				}
				List<List<PlantType>> upgrades = instance.Upgrades;
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					int num4;
					if (num4 > 0)
					{
						int num5 = num4 - 1;
					}
					PlantType plantType;
					if (num4 < (int)plantType)
					{
						int num6 = num4 + 1;
					}
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_00F1;
				}
			}
			List<GridItem> griditemArray = this.board.griditemArray;
			bool flag3;
			if (flag3)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
				this.board.UseSun((float)num2);
			}
			ulong num9;
			if (num9 == (ulong)0L)
			{
				goto Block_7;
			}
		}
		instance.RefrashBejeweldPlant();
		instance.tipTime = 7.5f;
		instance.bejeweledTimer = 5f;
		this.board.UseSun((float)num2);
		return;
		Block_7:
		instance.FillBankOptimized();
		uint num10;
		while (num10 == (uint)(-1))
		{
		}
		List<PlantType> currentPlants = instance.currentPlants;
		int num11;
		if (num11 != -1)
		{
			List<PlantType> currentPlants2 = instance.currentPlants;
		}
		throw new NullReferenceException();
		IL_00F1:
		throw new NullReferenceException();
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x000D4614 File Offset: 0x000D2814
	[Token(Token = "0x6002749")]
	[Address(RVA = "0x5FBCB0", Offset = "0x5FA2B0", VA = "0x1805FBCB0")]
	private void Single(CardUI card)
	{
		Board board = this.board;
		int num = 0;
		int thePlantHealth = board.controledPlant.thePlantHealth;
		PlantType thePlantType = card.thePlantType;
		if (thePlantType > PlantType.DoomShroom)
		{
			if (thePlantType > PlantType.GatlingPea)
			{
				if (thePlantType == PlantType.SplitPea)
				{
					Plant[] array;
					Plant plant = array[0];
					card.theSeedCost = (int)((ulong)3500L);
					plant.attackDamage = (int)((ulong)80L);
					plant.thePlantHealth = (int)((ulong)8000L);
					plant.thePlantAttackInterval = 0.4f;
					float thePlantSpeed = plant.thePlantSpeed;
					plant.thePlantSpeed = thePlantSpeed;
					plant.thePlantMaxHealth = (int)((ulong)8000L);
				}
				if (thePlantType != PlantType.BigGatling)
				{
					goto IL_03E7;
				}
				PlantType thePlantType2 = this.board.controledPlant.thePlantType;
				if (thePlantType2 != PlantType.UltimateGatling && thePlantType2 != PlantType.DoomGatling && thePlantType2 != PlantType.SuperSnowGatling)
				{
					goto IL_03E7;
				}
				Plant controledPlant = this.board.controledPlant;
				CreatePlant instance = CreatePlant.Instance;
				bool flag;
				if (!flag)
				{
					goto IL_03E7;
				}
				card.CD = (float)num;
				card.fullCD = 0.5f;
			}
			if (thePlantType == PlantType.DoubleShooter)
			{
				Plant[] array2;
				Plant plant2 = array2[0];
				card.theSeedCost = (int)((ulong)2000L);
				plant2.thePlantHealth = (int)((ulong)4000L);
				plant2.thePlantMaxHealth = (int)((ulong)4000L);
				plant2.thePlantAttackInterval = 0.4f;
			}
			if (thePlantType != PlantType.GatlingPea)
			{
				goto IL_03E7;
			}
			PlantType thePlantType3 = this.board.controledPlant.thePlantType;
			if (thePlantType3 == PlantType.CherryGatling)
			{
				Plant controledPlant2 = this.board.controledPlant;
				CreatePlant instance2 = CreatePlant.Instance;
				bool flag2;
				if (!flag2)
				{
					goto IL_03E7;
				}
				TravelMgr instance3 = TravelMgr.Instance;
				TravelMgr instance4 = TravelMgr.Instance;
			}
			if (thePlantType3 != PlantType.SnowGatling)
			{
				goto IL_03E7;
			}
			Plant controledPlant3 = this.board.controledPlant;
			CreatePlant instance5 = CreatePlant.Instance;
			bool flag3;
			if (!flag3)
			{
				goto IL_03E7;
			}
		}
		if (thePlantType > PlantType.CherryBomb)
		{
			if (thePlantType == PlantType.IceShroom)
			{
				PlantType thePlantType4 = this.board.controledPlant.thePlantType;
				if (thePlantType4 > PlantType.DoomGatling)
				{
					if (thePlantType4 == PlantType.CherryGatling)
					{
						Plant controledPlant4 = this.board.controledPlant;
						CreatePlant instance6 = CreatePlant.Instance;
						bool flag4;
						if (!flag4)
						{
							goto IL_03E7;
						}
					}
					if (thePlantType4 == PlantType.GatlingPea)
					{
						Plant controledPlant5 = this.board.controledPlant;
						CreatePlant instance7 = CreatePlant.Instance;
						bool flag5;
						if (!flag5)
						{
							goto IL_03E7;
						}
					}
					if (thePlantType4 == PlantType.BigGatling)
					{
						goto IL_0253;
					}
				}
				if (thePlantType4 != PlantType.UltimateGatling && thePlantType4 != PlantType.DoomGatling)
				{
					goto IL_03E7;
				}
				IL_0253:
				Plant controledPlant6 = this.board.controledPlant;
				CreatePlant instance8 = CreatePlant.Instance;
				bool flag6;
				if (!flag6)
				{
					goto IL_03E7;
				}
			}
			if (thePlantType != PlantType.DoomShroom)
			{
				goto IL_03E7;
			}
			PlantType thePlantType5 = this.board.controledPlant.thePlantType;
			if (thePlantType5 != PlantType.UltimateGatling && thePlantType5 != PlantType.BigGatling && thePlantType5 != PlantType.SuperSnowGatling)
			{
				goto IL_03E7;
			}
			Plant controledPlant7 = this.board.controledPlant;
			CreatePlant instance9 = CreatePlant.Instance;
			bool flag7;
			if (!flag7)
			{
				goto IL_03E7;
			}
			TravelMgr instance10 = TravelMgr.Instance;
			card.CD = (float)num;
			card.fullCD = 0.5f;
		}
		if (thePlantType == PlantType.Peashooter)
		{
			Plant[] array3;
			Plant plant3 = array3[0];
			card.theSeedCost = (int)((ulong)850L);
			plant3.thePlantHealth = (int)((ulong)2000L);
			plant3.thePlantMaxHealth = (int)((ulong)2000L);
			plant3.thePlantAttackInterval = 0.4f;
			float num2 = plant3.thePlantSpeed * 1.5f;
			plant3.thePlantSpeed = num2;
			plant3.attackDamage = (int)((ulong)80L);
		}
		if (thePlantType == PlantType.CherryBomb)
		{
			PlantType thePlantType6 = this.board.controledPlant.thePlantType;
			if (thePlantType6 > PlantType.GatlingPea)
			{
				if (thePlantType6 == PlantType.SnowGatling)
				{
					Plant controledPlant8 = this.board.controledPlant;
					CreatePlant instance11 = CreatePlant.Instance;
					bool flag8;
					if (!flag8)
					{
						goto IL_03E7;
					}
				}
				if (thePlantType6 == (PlantType)(-5))
				{
					goto IL_0398;
				}
			}
			if (thePlantType6 != PlantType.DoomGatling)
			{
				goto IL_03C5;
			}
			IL_0398:
			Plant controledPlant9 = this.board.controledPlant;
			CreatePlant instance12 = CreatePlant.Instance;
			bool flag9;
			if (!flag9)
			{
				goto IL_03E7;
			}
			TravelMgr instance13 = TravelMgr.Instance;
			TravelMgr instance14 = TravelMgr.Instance;
			IL_03C5:
			if (thePlantType6 == PlantType.GatlingPea)
			{
				Plant controledPlant10 = this.board.controledPlant;
				CreatePlant instance15 = CreatePlant.Instance;
				bool flag10;
				if (flag10)
				{
				}
			}
		}
		IL_03E7:
		int num3 = 0;
		if (card != num3)
		{
			this.board.controledPlant = num3;
		}
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x000D4A30 File Offset: 0x000D2C30
	[Token(Token = "0x600274A")]
	[Address(RVA = "0x5F9420", Offset = "0x5F7A20", VA = "0x1805F9420")]
	private void Shooting1(CardUI card)
	{
		int num5;
		Plant[] array4;
		for (;;)
		{
			int num = 0;
			PlantType thePlantType = card.thePlantType;
			Plant[] array8;
			if (thePlantType > PlantType.SuperChomper)
			{
				if (thePlantType > PlantType.IceFumeShroom)
				{
					Plant[] array3;
					if (thePlantType > PlantType.ThreeTorch)
					{
						Plant[] array;
						if (thePlantType == PlantType.LanternStar)
						{
							int num2 = 0;
							if (num2 >= array.Length)
							{
								return;
							}
							num2++;
						}
						Plant[] array2;
						if (array == (ulong)1090L)
						{
							int num3 = 0;
							if (num3 >= array2.Length)
							{
								return;
							}
							num3++;
						}
						if (array2 != (ulong)1104L)
						{
							return;
						}
						int num4 = 0;
						if (num4 >= array3.Length)
						{
							return;
						}
						num4++;
					}
					if (array3 == (ulong)1046L)
					{
						num5 = 0;
						if (num5 >= array4.Length)
						{
							return;
						}
						num5++;
					}
					if (num5 != 0)
					{
						if (num5 != 0)
						{
							break;
						}
					}
				}
				Plant[] array6;
				if (thePlantType > PlantType.DoubleShooter)
				{
					Plant[] array5;
					if (thePlantType == PlantType.GatlingPea)
					{
						int i = 0;
						while (i >= array5.Length)
						{
						}
						i++;
					}
					while (array5 != (ulong)1037L)
					{
					}
					int j = 0;
					while (j >= array6.Length)
					{
					}
					j++;
				}
				Plant[] array7;
				if (array6 == (ulong)1017L)
				{
					int k = 0;
					while (k >= array7.Length)
					{
					}
					k++;
				}
				while (array7 != (ulong)1030L)
				{
				}
				int l = 0;
				while (l >= array8.Length)
				{
				}
				l++;
			}
			if (array8 <= (ulong)23L)
			{
				goto IL_01D7;
			}
			if (array8 > (ulong)1005L)
			{
				if (array8 == (ulong)1012L)
				{
				}
				while (array8 != (ulong)1013L)
				{
				}
			}
			int m = 0;
			Plant[] array9;
			while (m >= array9.Length)
			{
			}
			m++;
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			int num6 = 0;
			bool flag;
			if (flag)
			{
				int num7 = 0;
				if (!(num != num7))
				{
					continue;
				}
				PlantType thePlantType2 = card.thePlantType;
			}
			if (num6 == 0)
			{
				return;
			}
		}
		if (num5 == 0 || array4 == (ulong)1L)
		{
		}
		return;
		IL_01D7:
		Plant[] array10;
		Plant[] array11;
		if (array10 > (ulong)9L)
		{
			if (array10 == (ulong)18L)
			{
			}
			while (array10 != (ulong)23L)
			{
			}
			int n = 0;
			while (n >= array11.Length)
			{
			}
			n++;
		}
		int num8;
		Plant[] array12;
		if (array11 == 0)
		{
			num8 = 0;
			while (num8 >= array12.Length)
			{
			}
			num8++;
		}
		if (num8 != 0)
		{
			while (num8 == 0)
			{
			}
			if (num8 != 0)
			{
				while (num8 == 0)
				{
				}
				while (array12 != (ulong)1L)
				{
				}
				int num9 = 0;
				Plant[] array13;
				while (num9 >= array13.Length)
				{
				}
				num9++;
			}
			int num10 = 0;
			Plant[] array14;
			while (num10 >= array14.Length)
			{
			}
			num10++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x000D4CB0 File Offset: 0x000D2EB0
	[Token(Token = "0x600274B")]
	[Address(RVA = "0x5F9E60", Offset = "0x5F8460", VA = "0x1805F9E60")]
	private void Shooting2(CardUI card)
	{
		PlantType thePlantType = card.thePlantType;
		Plant[] array9;
		if (thePlantType > PlantType.EmeraldUmbrella)
		{
			Plant[] array7;
			if (thePlantType > PlantType.IcePuff)
			{
				if (thePlantType == PlantType.TallIceNut)
				{
					int num = 0;
					Plant[] array;
					if (num >= array.Length)
					{
						return;
					}
					num++;
				}
				int num2 = 0;
				Plant[] array2;
				if (num2 >= array2.Length)
				{
					return;
				}
				num2++;
				int num3 = 0;
				Plant[] array3;
				if (num3 >= array3.Length)
				{
					return;
				}
				num3++;
				int num4 = 0;
				Plant[] array4;
				if (num4 >= array4.Length)
				{
					return;
				}
				num4++;
				int num5 = 0;
				Plant[] array5;
				if (num5 >= array5.Length)
				{
					return;
				}
				num5++;
				int num6 = 0;
				Plant[] array6;
				if (num6 >= array6.Length)
				{
					return;
				}
				num6++;
				if (array6 != (ulong)1132L)
				{
					return;
				}
				int num7 = 0;
				if (num7 >= array7.Length)
				{
					return;
				}
				num7++;
			}
			Plant[] array8;
			if (array7 == (ulong)1027L)
			{
				int num8 = 0;
				if (num8 >= array8.Length)
				{
					return;
				}
				num8++;
			}
			if (array8 != (ulong)1035L)
			{
				return;
			}
			int num9 = 0;
			if (num9 >= array9.Length)
			{
				return;
			}
			num9++;
		}
		if (array9 <= (ulong)6L)
		{
			int i = 0;
			Plant[] array10;
			while (i >= array10.Length)
			{
			}
			i++;
			throw new NullReferenceException();
		}
		int num10 = 0;
		Plant[] array11;
		if (num10 < array11.Length)
		{
			num10++;
		}
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x000D4E70 File Offset: 0x000D3070
	[Token(Token = "0x600274C")]
	[Address(RVA = "0x5FA6E0", Offset = "0x5F8CE0", VA = "0x1805FA6E0")]
	private void Shooting3(CardUI card)
	{
		PlantType thePlantType;
		for (;;)
		{
			int num = 0;
			thePlantType = card.thePlantType;
			int m;
			if (thePlantType > PlantType.CherryUltimatePumpkin)
			{
				if (thePlantType > PlantType.DarkThreePeater)
				{
					if (thePlantType > PlantType.IceSpikeRock)
					{
						break;
					}
					if (thePlantType == PlantType.SquashSpike)
					{
						int i = 0;
						Plant[] array;
						while (i >= array.Length)
						{
						}
						i++;
					}
					int j = 0;
					Plant[] array2;
					while (j >= array2.Length)
					{
					}
					j++;
				}
				int k = 0;
				Plant[] array3;
				while (k >= array3.Length)
				{
				}
				k++;
				int l = 0;
				Plant[] array4;
				while (l >= array4.Length)
				{
				}
				l++;
				m = 0;
				Plant[] array5;
				while (m >= array5.Length)
				{
				}
				m++;
			}
			if (m > 1)
			{
				int n = 0;
				Plant[] array6;
				while (n >= array6.Length)
				{
				}
				n++;
				while (n > 5)
				{
				}
				int num2 = 0;
				Plant[] array7;
				while (num2 >= array7.Length)
				{
				}
				num2++;
			}
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				PlantType thePlantType2 = card.thePlantType;
			}
			if (num3 == 0)
			{
				return;
			}
		}
		if (thePlantType == PlantType.CactusPumpkin)
		{
			int num5 = 0;
			Plant[] array8;
			if (num5 >= array8.Length)
			{
				return;
			}
			num5++;
		}
		int num6 = 0;
		Plant[] array9;
		if (num6 < array9.Length)
		{
			num6++;
		}
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x000D5000 File Offset: 0x000D3200
	[Token(Token = "0x600274D")]
	[Address(RVA = "0x600690", Offset = "0x5FEC90", VA = "0x180600690")]
	private Plant[] TurnPlantsToNewPlants(CardUI card, PlantType newType, PlantType nextType)
	{
		List<Plant> list2;
		ulong num4;
		do
		{
			int num = 0;
			List<Plant> list = new List();
			list2 = new List();
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				bool flag2 = num != num2;
				while (!flag2)
				{
				}
				if ((flag2 ? PlantType.SunFlower : PlantType.Peashooter) != card.thePlantType && ((!flag2 && !flag2 && !flag2) || card.thePlantType != PlantType.WallNut))
				{
					while (!flag2)
					{
					}
					while (card.thePlantType != PlantType.Peashooter)
					{
					}
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00C4;
			}
			bool flag3;
			if (flag3)
			{
				CreatePlant instance = CreatePlant.Instance;
				int size = list2._size;
				Plant plant;
				plant.<Team>k__BackingField = plant;
			}
		}
		while (num4 != (ulong)0L);
		return list2.ToArray();
		IL_00C4:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x000D50F0 File Offset: 0x000D32F0
	[Token(Token = "0x600274E")]
	[Address(RVA = "0x5F1230", Offset = "0x5EF830", VA = "0x1805F1230")]
	private void ChangeCost(PlantType theSeedType, CardUI card)
	{
		Board board = this.board;
		if (theSeedType > PlantType.SuperFume)
		{
			if (theSeedType > PlantType.SplitPea)
			{
				if (theSeedType > PlantType.SuperPumpkin)
				{
					if (theSeedType == PlantType.IceCannon)
					{
						goto IL_005F;
					}
					if (theSeedType == PlantType.SuperMelon && card != 0)
					{
						goto IL_0138;
					}
					if (theSeedType != PlantType.MelonCannon)
					{
						return;
					}
					if (card != 0)
					{
						goto IL_0138;
					}
				}
				if (theSeedType == PlantType.SuperStar && card != 0)
				{
					goto IL_018B;
				}
				if (theSeedType != PlantType.SuperPumpkin)
				{
					return;
				}
			}
			IL_005F:
			if (theSeedType > PlantType.SuperTorch)
			{
				if (theSeedType == PlantType.ThreeTorch && card != 0)
				{
					goto IL_018B;
				}
				if (theSeedType == PlantType.IceSpikeRock && card != 0)
				{
					goto IL_0138;
				}
				if (theSeedType != PlantType.SplitPea)
				{
					return;
				}
				if (card != 0)
				{
					card.theSeedCost = (int)((ulong)200L);
					return;
				}
			}
			if (theSeedType != PlantType.ThreeSquash)
			{
				goto IL_00AA;
			}
			card.theSeedCost = (int)((ulong)750L);
			return;
		}
		IL_00AA:
		if (theSeedType > PlantType.SuperChomper)
		{
			if (theSeedType > PlantType.GatlingPea)
			{
				if (theSeedType == PlantType.IceFumeShroom && card != 0)
				{
					goto IL_018B;
				}
				while (theSeedType == PlantType.TallIceNut)
				{
				}
				while (theSeedType != PlantType.SuperFume)
				{
				}
				if (card != 0)
				{
					goto IL_0138;
				}
			}
			while (theSeedType == PlantType.CherryGatling)
			{
			}
			while (theSeedType != PlantType.GatlingPea)
			{
			}
			if (card != 0)
			{
				goto IL_018B;
			}
		}
		if (theSeedType > PlantType.CherryUltimatePumpkin)
		{
			if (theSeedType == PlantType.SuperCherryShooter && card != 0)
			{
				goto IL_0138;
			}
			while (theSeedType == PlantType.SunNut)
			{
			}
		}
		if (theSeedType == PlantType.Melonpult && card != 0)
		{
			goto IL_018B;
		}
		while (board > (ulong)22L)
		{
		}
		if (card != 0)
		{
			card.theSeedCost = (int)((ulong)2000L);
			return;
		}
		if (card != 0)
		{
			card.theSeedCost = (int)((ulong)1500L);
			return;
		}
		if (card != 0)
		{
			card.theSeedCost = (int)((ulong)3000L);
			return;
		}
		IL_0138:
		card.theSeedCost = (int)((ulong)1000L);
		return;
		IL_018B:
		card.theSeedCost = (int)((ulong)300L);
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x000D533C File Offset: 0x000D353C
	[Token(Token = "0x600274F")]
	[Address(RVA = "0x5F0FD0", Offset = "0x5EF5D0", VA = "0x1805F0FD0")]
	private void ChangeCardSprite(PlantType theSeedType, CardUI card)
	{
		Transform transform = card.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		Transform transform2 = card.transform;
		int num2 = 0;
		RectTransform component2 = transform2.GetChild(num2).GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			component.sprite = sprite;
		}
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		int num3 = 0;
		Vector2 sizeDelta2 = component2.sizeDelta;
		component2.sizeDelta = num3;
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000D53C8 File Offset: 0x000D35C8
	[Token(Token = "0x6002750")]
	[Address(RVA = "0x5F86F0", Offset = "0x5F6CF0", VA = "0x1805F86F0")]
	private void ResurrectionPlant(CardUI card)
	{
		Board board;
		PlantType thePlantType;
		for (;;)
		{
			int num = 0;
			board = this.board;
			thePlantType = card.thePlantType;
			if (thePlantType <= PlantType.ThreeSquash)
			{
				goto IL_00AE;
			}
			if (thePlantType > PlantType.CactusPumpkin)
			{
				if (thePlantType > PlantType.SuperPumpkin)
				{
					if (board <= (ulong)8L)
					{
					}
					if (thePlantType == PlantType.MelonCannon)
					{
						goto IL_0127;
					}
					if (thePlantType != PlantType.HypnoNut)
					{
						goto IL_01B7;
					}
				}
				if (thePlantType == PlantType.SplitPea)
				{
					goto IL_01B7;
				}
				if (thePlantType == PlantType.SuperStar)
				{
					goto IL_0127;
				}
				if (thePlantType != PlantType.SuperPumpkin)
				{
					goto IL_01B7;
				}
			}
			if (thePlantType > PlantType.SquashSpike)
			{
				if (thePlantType == PlantType.IceSpikeRock)
				{
					goto IL_00AE;
				}
				if (thePlantType == PlantType.LanternStar)
				{
					goto IL_0127;
				}
				while (thePlantType == PlantType.CactusPumpkin)
				{
				}
			}
			if (board <= (ulong)6L)
			{
			}
			if (thePlantType == PlantType.SquashSpike)
			{
				goto IL_00AE;
			}
			IL_01B7:
			int[] array = new int[Board.Instance.rowNum];
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (!flag)
			{
				goto IL_024A;
			}
			int num2 = 0;
			if (num != num2)
			{
				goto IL_01F2;
			}
			continue;
			IL_00AE:
			if (thePlantType > PlantType.SunNut)
			{
				if (thePlantType > PlantType.CherryGatling)
				{
					if (board <= (ulong)12L)
					{
					}
					if (thePlantType == PlantType.SuperFume || thePlantType != PlantType.ThreeSquash)
					{
						goto IL_01B7;
					}
				}
				if (board <= (ulong)1L)
				{
					goto IL_011D;
				}
				if (thePlantType == PlantType.CherryGatling)
				{
					goto IL_01B7;
				}
			}
			if (thePlantType > PlantType.Melonpult)
			{
				if (board <= (ulong)22L)
				{
				}
				if (thePlantType == PlantType.SuperCherryShooter || thePlantType != PlantType.SunNut)
				{
					goto IL_01B7;
				}
			}
			if (board <= (ulong)17L)
			{
			}
			IL_011D:
			if (board > (ulong)9L)
			{
				goto IL_01B7;
			}
			IL_0127:
			if (thePlantType <= PlantType.GatlingPea)
			{
				goto IL_01F2;
			}
			if (thePlantType > PlantType.SunCabbage)
			{
				if (thePlantType > PlantType.HypnoMagnet)
				{
					if (thePlantType == PlantType.BigGatling || thePlantType == PlantType.SuperGatling)
					{
						goto IL_01B7;
					}
					if (thePlantType == PlantType.LanternUmbrella)
					{
						goto IL_023F;
					}
				}
				if (thePlantType == PlantType.GoldCabbage)
				{
					break;
				}
				if (thePlantType == PlantType.HypnoMagnet)
				{
					goto IL_0233;
				}
			}
			if (thePlantType > PlantType.IceScaredyShroom)
			{
				if (board <= (ulong)6L)
				{
				}
				if (thePlantType == PlantType.LanternMagnet)
				{
					goto IL_0233;
				}
				if (thePlantType == PlantType.SunCabbage)
				{
					break;
				}
			}
			if (thePlantType == PlantType.IceFumeShroom)
			{
				goto IL_024A;
			}
			if (thePlantType == PlantType.IceScaredyShroom)
			{
				goto IL_01B7;
			}
			goto IL_01B7;
		}
		IL_0239:
		while (thePlantType != PlantType.Umbrellaleaf)
		{
		}
		IL_023F:
		while (thePlantType == PlantType.Peashooter)
		{
		}
		while (board > (ulong)6L)
		{
		}
		goto IL_024A;
		IL_01F2:
		if (thePlantType > PlantType.Umbrellaleaf)
		{
			if (thePlantType > PlantType.LaserUmbrella)
			{
				while (thePlantType == PlantType.ScaredyHypno)
				{
				}
				while (board == (ulong)4294967293L)
				{
				}
			}
			if (thePlantType == PlantType.UltimateFume)
			{
				goto IL_024A;
			}
			while (board > (ulong)13L)
			{
			}
		}
		if (thePlantType <= PlantType.ScaredyShroom)
		{
			goto IL_023F;
		}
		if (thePlantType == PlantType.Magnetshroom)
		{
		}
		IL_0233:
		if (thePlantType == PlantType.Cabbagepult)
		{
			goto IL_0239;
		}
		goto IL_0239;
		IL_024A:
		int num3 = 0;
		num3++;
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x000D5654 File Offset: 0x000D3854
	[Token(Token = "0x6002751")]
	[Address(RVA = "0x5F06E0", Offset = "0x5EECE0", VA = "0x1805F06E0")]
	private void AddNewCard(PlantType theSeedType)
	{
		CardUI cardUI;
		bool flag = InGameUI.Instance.AddCardToBank(cardUI, true);
		cardUI.theSeedCost = (int)((ulong)0L);
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000D5680 File Offset: 0x000D3880
	[Token(Token = "0x6002752")]
	[Address(RVA = "0x601BC0", Offset = "0x6001C0", VA = "0x180601BC0")]
	public Mouse()
	{
	}

	// Token: 0x04001597 RID: 5527
	[Token(Token = "0x4001597")]
	public static Mouse Instance;

	// Token: 0x04001598 RID: 5528
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001598")]
	public Renderer r;

	// Token: 0x04001599 RID: 5529
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001599")]
	public int theMouseRow;

	// Token: 0x0400159A RID: 5530
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400159A")]
	public int theMouseColumn;

	// Token: 0x0400159B RID: 5531
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400159B")]
	public float theBoxXofMouse;

	// Token: 0x0400159C RID: 5532
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400159C")]
	public float theBoxYofMouse;

	// Token: 0x0400159D RID: 5533
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400159D")]
	public PlantType thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);

	// Token: 0x0400159E RID: 5534
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400159E")]
	public Towards plantTowards = (Towards)((ulong)1L);

	// Token: 0x0400159F RID: 5535
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400159F")]
	public ZombieType theZombieTypeOnMouse = (ZombieType)((ulong)4294967295L);

	// Token: 0x040015A0 RID: 5536
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40015A0")]
	public GameObject preview;

	// Token: 0x040015A1 RID: 5537
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40015A1")]
	public GameObject theItemOnMouse;

	// Token: 0x040015A2 RID: 5538
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40015A2")]
	public CardUI theCardOnMouse;

	// Token: 0x040015A3 RID: 5539
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40015A3")]
	public MouseItemType mouseItemType;

	// Token: 0x040015A4 RID: 5540
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40015A4")]
	public IZECard theIZECardOnMouse;

	// Token: 0x040015A5 RID: 5541
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015A5")]
	public Plant thePlantOnGlove;

	// Token: 0x040015A6 RID: 5542
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015A6")]
	public Zombie theZombieOnGlove;

	// Token: 0x040015A7 RID: 5543
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40015A7")]
	public GardenPlant theGardenPlantOnGlove;

	// Token: 0x040015A8 RID: 5544
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40015A8")]
	public Plant cannonPlant;

	// Token: 0x040015A9 RID: 5545
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40015A9")]
	private float mouseX;

	// Token: 0x040015AA RID: 5546
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40015AA")]
	private float mouseY;

	// Token: 0x040015AB RID: 5547
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40015AB")]
	private Board board;
}
