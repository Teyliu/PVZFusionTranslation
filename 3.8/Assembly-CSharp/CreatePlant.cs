using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using Spine.Unity;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using ZenGarden;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
public class CreatePlant : MonoBehaviour
{
	// Token: 0x060008DD RID: 2269 RVA: 0x0002E388 File Offset: 0x0002C588
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x85A450", Offset = "0x858A50", VA = "0x18085A450")]
	private void Awake()
	{
		Board component = base.GetComponent<Board>();
		this.board = component;
		CreatePlant.Instance = this;
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0002E3AC File Offset: 0x0002C5AC
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x862720", Offset = "0x860D20", VA = "0x180862720")]
	public static GardenPlant SetPlantInGarden(int column, int row, PlantType theSeedType, Transform parent, bool preview = false, bool inGarden = true, bool inWorld = false)
	{
		int num;
		uint num2;
		GameObject gameObject2;
		GardenPlant gardenPlant;
		GameObject gameObject3;
		Plant component;
		Transform axis;
		float num4;
		for (;;)
		{
			num = 0;
			num2 -= (uint)column;
			Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
			bool flag;
			if (!flag)
			{
				goto IL_0327;
			}
			List<GardenBox> gardenBoxes = GardenUI.Instance.gardenBoxes;
			bool flag2;
			if (flag2)
			{
				Vector3 vector;
				float z = vector.z;
			}
			if (num == 0)
			{
				int num3 = 0;
				Board instance = Board.Instance;
				bool flag3;
				if (!flag3)
				{
					bool flag4;
					if (!flag4)
					{
						GameObject[] itemPrefab = GameAPP.itemPrefab;
					}
					GameObject[] itemPrefab2 = GameAPP.itemPrefab;
				}
				GameObject gameObject = GameAPP.itemPrefab[50];
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num3, identityQuaternion);
				gardenPlant = gameObject2.AddComponent<GardenPlant>();
				gameObject2.transform.parentInternal = parent;
				Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
				gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(num, num3, identityQuaternion2);
				CreatePlant.DestoryParticle(gameObject3);
				Transform transform = gameObject3.transform;
				Transform transform2 = gameObject2.transform;
				transform.parentInternal = transform2;
				component = gameObject3.GetComponent<Plant>();
				axis = component.axis;
				bool flag5;
				if (flag5)
				{
					Vector3 vector2;
					float z2 = vector2.z;
				}
				Transform plantTargetAxis = gardenPlant.plantTargetAxis;
				Vector3 vector3;
				float z3 = vector3.z;
				Animator anim = component.anim;
				num4 = global::UnityEngine.Random.Range(0.95f, 1.05f);
				int num5 = 0;
				anim.SetFloat("Speed", (float)num5);
				if (theSeedType <= PlantType.PeaMine)
				{
					goto IL_0156;
				}
				if (theSeedType == PlantType.SunMine || z3 <= 1E-45f)
				{
					goto IL_0176;
				}
				if (theSeedType == PlantType.ThreeMine)
				{
					Animator anim2 = component.anim;
					goto IL_0156;
				}
				IL_0187:
				if (!gameObject3.TryGetComponent<SortingGroup>(num))
				{
					break;
				}
				continue;
				IL_0156:
				if (theSeedType != PlantType.PotatoMine)
				{
					if (theSeedType == PlantType.Apple)
					{
						int num6 = 0;
						GameObject gameObject4;
						gameObject4.SetActive(num6 != 0);
					}
					if (theSeedType != PlantType.PeaMine)
					{
						goto IL_0187;
					}
				}
				IL_0176:
				component.anim.Play("armed");
				goto IL_0187;
			}
		}
		uint num7;
		gameObject3.AddComponent<SortingGroup>().sortingOrder = (int)num7;
		global::UnityEngine.Object.Destroy(component);
		Collider2D[] components = gameObject3.GetComponents<Collider2D>();
		if (num < components.Length)
		{
			global::UnityEngine.Object.Destroy(gameObject2);
			num++;
		}
		SortingGroup component2 = gameObject2.GetComponent<SortingGroup>();
		uint num8;
		component2.sortingOrder = (int)num8;
		component2.sortingOrder = (int)num2;
		string text;
		component2.sortingLayerName = text;
		GameObject gameObject5 = new GameObject("plantHead");
		Transform transform3 = gameObject5.transform;
		Transform transform4 = gameObject2.transform;
		transform3.parentInternal = transform4;
		Transform transform5 = gameObject5.transform;
		Transform transform6 = gameObject3.transform;
		Vector3 vector4;
		float z4 = vector4.z;
		Transform transform7 = gameObject3.transform;
		Transform transform8 = gameObject5.transform;
		transform7.parentInternal = transform8;
		int thePlantType = (int)component.thePlantType;
		bool flag6;
		float z5;
		if (flag6)
		{
			Transform transform9 = gameObject5.transform;
			Vector3 vector5;
			z5 = vector5.z;
		}
		gardenPlant.plantObject = gameObject5;
		gardenPlant.plantAxis = axis;
		Transform transform10 = gameObject5.transform;
		gardenPlant.plantScale = z5;
		num4 = z5;
		gardenPlant.plantScale.y = num4;
		gardenPlant.preview = true;
		global::UnityEngine.Object.Destroy(gameObject2.transform.Find("Shadow").gameObject);
		global::UnityEngine.Object.Destroy(gardenPlant.GetComponent<Collider2D>());
		Vector3 vector6;
		float z6 = vector6.z;
		gardenPlant.plantScale = z5;
		num4 = z5;
		gardenPlant.plantScale.y = num4;
		Transform axis2 = gardenPlant.axis;
		Transform transform11 = gameObject2.transform;
		Vector3 vector7;
		float z7 = vector7.z;
		ulong num9;
		gardenPlant.axis.AddComponent<SortingGroup>().sortAtRoot = num9 != 0UL;
		return gardenPlant;
		IL_0327:
		throw new NullReferenceException();
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x85E060", Offset = "0x85C660", VA = "0x18085E060")]
	private static void DestoryParticle(GameObject obj)
	{
		int num = 0;
		if (obj.TryGetComponent<ParticleSystem>(num))
		{
			global::UnityEngine.Object.Destroy(num);
		}
		int childCount = obj.transform.childCount;
		if (num < childCount)
		{
			CreatePlant.DestoryParticle(obj.transform.GetChild(num).gameObject);
			num++;
		}
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0002E744 File Offset: 0x0002C944
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x85D6F0", Offset = "0x85BCF0", VA = "0x18085D6F0")]
	public static GameObject CreatePlantPreview(PlantType theSeedType, Color color, Transform parent, Vector2 position)
	{
		int num;
		GameObject gameObject;
		Plant component;
		List<SpriteRenderer> sprites;
		do
		{
			num = 0;
			Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
			bool flag;
			if (!flag)
			{
			}
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			CreatePlant.DestoryParticle(gameObject);
			component = gameObject.GetComponent<Plant>();
			component.anim.Play("idle");
			Animator anim = component.anim;
			int num2 = 0;
			anim.speed = (float)num2;
			sprites = global::Core.Lawnf.GetSprites(gameObject);
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num != 0);
		int num3 = 0;
		if (num3 == 0)
		{
			Func<SpriteRenderer, int> func;
			if (CreatePlant.<>c.<>9__7_0 == 0)
			{
				CreatePlant.<>c.<>9__7_0 = func;
			}
			List<SpriteRenderer> list = Enumerable.ToList<SpriteRenderer>(Enumerable.OrderByDescending<SpriteRenderer, int>(sprites, func));
			int size = list._size;
			if (num3 < size)
			{
				SpriteRenderer spriteRenderer = list[num3];
				SpriteMask spriteMask = spriteRenderer.AddComponent<SpriteMask>();
				Sprite sprite = spriteRenderer.sprite;
				spriteMask.sprite = sprite;
				ulong num4;
				spriteMask.isCustomRangeActive = num4 != 0UL;
				int num5 = spriteRenderer.sortingOrder - 1;
				spriteMask.frontSortingOrder = num5;
				int sortingLayerID = spriteRenderer.sortingLayerID;
				spriteMask.frontSortingLayerID = sortingLayerID;
				spriteMask.alphaCutoff = 1f;
				SpriteRenderer spriteRenderer2 = list[1];
				num3++;
			}
		}
		GameObject gameObject2 = new GameObject();
		Transform transform = gameObject2.transform;
		Transform transform2 = gameObject2.transform;
		gameObject2.tag = "Preview";
		Transform transform3 = gameObject2.transform;
		Transform axis = component.axis;
		Transform transform4 = gameObject2.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform5 = gameObject.transform;
		Transform transform6 = gameObject.transform;
		Transform transform7 = gameObject2.transform;
		transform6.parentInternal = transform7;
		SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		uint num6;
		sortingGroup.sortingOrder = (int)num6;
		global::UnityEngine.Object.Destroy(component.axis.gameObject);
		global::UnityEngine.Object.Destroy(component);
		Collider2D[] components = component.GetComponents<Collider2D>();
		if (num3 < components.Length)
		{
			num3++;
		}
		global::UnityEngine.Object.Destroy(component.GetComponent<Rigidbody2D>());
		throw new NullReferenceException();
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x0002E944 File Offset: 0x0002CB44
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x8623F0", Offset = "0x8609F0", VA = "0x1808623F0")]
	public static GameObject SetPlantInAlmamac(Vector3 position, int theSeedType)
	{
		int num = 0;
		Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
		bool flag;
		if (flag)
		{
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject;
			Plant component = gameObject.GetComponent<Plant>();
			component.anim.updateMode = (AnimatorUpdateMode)((uint)2);
			if (component.TryGetComponent<SkeletonAnimation>(num))
			{
			}
			Transform axis = component.axis;
			Transform transform = gameObject.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = gameObject.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			component.startPos.z = z2;
			global::UnityEngine.Object.Destroy(component);
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0002E9DC File Offset: 0x0002CBDC
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x8635C0", Offset = "0x861BC0", VA = "0x1808635C0")]
	public Plant SetPlant(int newColumn, int newRow, PlantType theSeedType, [Optional] Plant targetPlant, [Optional] Vector2 puffV, bool isFreeSet = false, bool withEffect = true, [Optional] Plant hidplant)
	{
		int num;
		for (;;)
		{
			num = 0;
			if (theSeedType != PlantType.Nothing)
			{
				Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
				bool flag;
				if (!flag)
				{
					string text;
					Debug.LogError("不存在该类型的植物" + text);
					InGameText instance = InGameText.Instance;
					int num2 = 0;
					instance.ShowText("错误：尝试生成不存在的植物！用豌豆代替", 3f, num2 != 0);
					Dictionary<PlantType, GameObject> plantPrefabs2 = GameAPP.resourcesManager.plantPrefabs;
					int num3 = 0;
					bool flag2 = plantPrefabs2.TryGetValue(num3, num);
				}
				int columnNum = this.board.columnNum;
				int rowNum = this.board.rowNum;
				bool flag3;
				if (flag3)
				{
					Board board = this.board;
					bool flag4;
					if (flag4)
					{
						InGameText instance2 = InGameText.Instance;
						int num4 = 0;
						instance2.ShowText("植物数量已达上限", 3f, num4 != 0);
					}
				}
			}
			IL_00B5:
			Board board2 = this.board;
			bool flag5;
			Plant plant;
			if (!flag5)
			{
				int num5 = 0;
				if (!(plant != num5))
				{
					continue;
				}
				bool flag6;
				if (flag6)
				{
					Mouse.Instance.thePlantOnGlove = num;
				}
			}
			bool flag7;
			if (flag7)
			{
				if (plant == (ulong)252L)
				{
					GameAPP.PlaySound(flag7 ? 1 : 0, 0.5f, 1f);
				}
				if (flag7 <= true)
				{
					uint num7;
					int num6 = global::UnityEngine.Random.Range(0, (int)num7);
				}
			}
			if (this.board.gridSystem.GetBoxType(newColumn, newRow) != BoxType.Water)
			{
				uint num8;
				GameAPP.PlaySound((int)num8, 0.5f, 1f);
			}
			bool flag8;
			int num11;
			if (!flag8)
			{
				int num9 = 0;
				GridSystem gridSystem = this.board.gridSystem;
				this.board.UpdateBox(newRow, num9);
				global::Lawnf.ConnectPlant(newRow);
				int num10 = 0;
				Plant plant2;
				Plant plant3;
				if (plant2 != num10 && plant3.thePlantType == PlantType.BigPumpkin)
				{
					num11 = 0;
				}
				Board.Instance.gridSystem.RemovePot(newRow, num9);
				Board.Instance.gridSystem.RemoveLily(newRow, num9);
			}
			bool flag9;
			int num12;
			if (!flag9)
			{
				num12 = 0;
				GameObject gameObject;
				ulong num13;
				gameObject.SetActive(num13 != 0UL);
			}
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(num, num11, num12);
			string text2;
			gameObject2.name = text2;
			Plant component = gameObject2.GetComponent<Plant>();
			Plant p = component;
			Plant p23 = p;
			Plant p2 = p;
			TypeMgr.GetPlantTag(p2);
			p.thePlantColumn = p2;
			p.thePlantRow = newRow;
			Plant p3 = p;
			Board board3 = this.board;
			p3.board = board3;
			Plant p4 = p;
			this.SetTransform(p4, num11);
			bool flag10;
			bool flag11;
			if (flag10 && flag11)
			{
				Plant p5 = p;
				PlantDataManager.PlantData plantData;
				int attackDamage = plantData.attackDamage;
				p5.attackDamage = attackDamage;
				Plant p6 = p;
				float attackInterval = plantData.attackInterval;
				p6.thePlantAttackInterval = attackInterval;
				float produceInterval = plantData.produceInterval;
				p6.thePlantProduceInterval = produceInterval;
				int maxHealth = plantData.maxHealth;
				p6.thePlantMaxHealth = maxHealth;
				Plant p7 = p;
				int thePlantMaxHealth = p7.thePlantMaxHealth;
				p7.thePlantHealth = thePlantMaxHealth;
				bool flag12;
				if (flag12)
				{
					Plant p8 = p;
					int num14 = 0;
					int num15 = 0;
					p8.ModifyDamage((PlantDamageAdder)num15, 0.2f, num14 != 0, num);
				}
				bool flag13;
				if (flag13)
				{
					Plant p9 = p;
					List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
				}
				bool flag14;
				if (flag14)
				{
					Board instance3 = Board.Instance;
					Plant p10 = p;
				}
				bool flag15;
				if (flag15)
				{
					Plant p11 = p;
					if (p11.thePlantType == PlantType.UltimateTallNut || p11.thePlantType == PlantType.UltimatePotatoNut)
					{
					}
				}
				Plant p12 = p;
				float num16 = global::UnityEngine.Random.Range(0.9f, 1.1f);
				p12.thePlantSpeed = num16;
				if (p12 != 0)
				{
					float num17 = global::UnityEngine.Random.Range(0.2f, 0.8f);
					p12.thePlantAttackCountDown = num17;
				}
				if (p12 != 0)
				{
					float num18 = global::UnityEngine.Random.Range(4f, 7f);
					p12.thePlantProduceCountDown = num18;
				}
				bool flag16;
				if (flag16)
				{
				}
				AdvantureManager instance4 = AdvantureManager.Instance;
				Plant p13 = p;
				instance4.ReinforcePlant(p13);
				Plant p14 = p;
				if (p14.thePlantType == PlantType.SuperMachineNut)
				{
					Board board4 = this.board;
					int thePlantMaxHealth2 = p14.thePlantMaxHealth;
					p.thePlantHealth = thePlantMaxHealth2;
				}
				p.InitText();
				TravelMgr instance5 = TravelMgr.Instance;
				Plant p15 = p;
				Board board5 = this.board;
				instance5.ReinforcePlant(board5, p15);
				Board board6 = this.board;
			}
			GridSystem gridSystem2 = this.board.gridSystem;
			Board board7 = this.board;
			Plant p16 = p;
			GridSystem gridSystem3 = Board.Instance.gridSystem;
			if ((p.isLily ? 1 : 0) != num)
			{
				GridSystem gridSystem4 = Board.Instance.gridSystem;
			}
			bool flag17;
			if (flag17)
			{
				break;
			}
			continue;
			goto IL_00B5;
		}
		Plant p17 = CS$<>8__locals1.p;
		Func<Plant, bool> func;
		Plant plant4 = Enumerable.FirstOrDefault<Plant>(this.board.boardEntity.plantHead, func);
		int num19 = 0;
		if (!(plant4 != num19))
		{
			List<Plant> plantHead = this.board.boardEntity.plantHead;
		}
		Plant next = plant4.next;
		int num20 = 0;
		if (next != num20)
		{
			Plant next2 = plant4.next;
			Plant p18 = CS$<>8__locals1.p;
			next2.pre = p18;
			Plant p19 = CS$<>8__locals1.p;
			Plant next3 = plant4.next;
			p19.next = next3;
		}
		CS$<>8__locals1.p.pre = plant4;
		Plant p20 = CS$<>8__locals1.p;
		plant4.next = p20;
		BoardEntity boardEntity = this.board.boardEntity;
		Plant p21 = CS$<>8__locals1.p;
		Dictionary<PlantType, List<Plant>> plantHeads = boardEntity.plantHeads;
		PlantType thePlantType = p21.thePlantType;
		if (!plantHeads.TryGetValue(thePlantType, num))
		{
			List<Plant> list = new List();
			BoardEntity boardEntity2 = this.board.boardEntity;
			Plant p22 = CS$<>8__locals1.p;
			Dictionary<PlantType, List<Plant>> plantHeads2 = boardEntity2.plantHeads;
			PlantType thePlantType2 = p22.thePlantType;
			plantHeads2[thePlantType2] = list;
		}
		Board board8 = this.board;
		GameConfig config = GameAPP.config;
		return null;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x85D560", Offset = "0x85BB60", VA = "0x18085D560")]
	private void CreatePlantParticle(int column, int row, Vector3 position)
	{
		if (this.board.gridSystem.GetBoxType(column, row) != BoxType.Water)
		{
			ParticleManager instance = ParticleManager.Instance;
			return;
		}
		BoardGrid grid = this.board.gridSystem.GetGrid(column, row);
		ParticleManager instance2 = ParticleManager.Instance;
		if (!grid.lavaWater)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0002F00C File Offset: 0x0002D20C
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x85A350", Offset = "0x858950", VA = "0x18085A350")]
	public void AdjustLightLevel(int boxX, int boxY, int level, int range = 2)
	{
		int columnCount = this.board.gridSystem.ColumnCount;
		if (boxX < columnCount)
		{
			int rowCount = this.board.gridSystem.RowCount;
			if (boxY < rowCount)
			{
				BoardGrid grid = this.board.gridSystem.GetGrid(boxX, boxY);
			}
		}
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x0002F060 File Offset: 0x0002D260
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x85A190", Offset = "0x858790", VA = "0x18085A190")]
	private void AddToList(Plant plant)
	{
		int num = 0;
		List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
		Board instance = Board.Instance;
		Plant plant2 = instance.boardEntity.plantArray[num];
		int num2 = 0;
		if (!(plant2 == num2))
		{
			num++;
			Board instance2 = Board.Instance;
		}
		Board.Instance.boardEntity.plantArray[num] = plant;
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x0002F0DC File Offset: 0x0002D2DC
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x85A4F0", Offset = "0x858AF0", VA = "0x18085A4F0")]
	public bool CheckBox(int theBoxColumn, int theBoxRow, PlantType theSeedType)
	{
		for (;;)
		{
			int num = 0;
			float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theBoxColumn);
			IceRoad iceRoad = Board.Instance.iceRoads[theBoxColumn];
			if (boxXFromColumn > iceRoad.x && theSeedType != PlantType.Gravebuster && theSeedType != PlantType.Tower_gravebuster)
			{
				goto IL_0298;
			}
			int theBoardLevel = GameAPP.theBoardLevel;
			bool flag;
			bool flag2;
			if (((theBoardLevel == 29 || theBoardLevel == 82) && !flag) || flag2 || this.board.gridSystem.GetBoxType(theBoxColumn, theBoxRow) == BoxType.Stone)
			{
				goto IL_0298;
			}
			List<GridItem> griditemArray = this.board.griditemArray;
			int num2 = 0;
			bool flag3;
			if (flag3)
			{
				int num3 = 0;
				bool flag4 = num != num3;
				while (!flag4)
				{
				}
				while (flag4 > true)
				{
				}
				while (theSeedType == PlantType.Gravebuster)
				{
				}
				while (theSeedType == PlantType.Tower_gravebuster)
				{
				}
			}
			if (num2 != 0)
			{
				goto IL_02AE;
			}
			int num4 = 0;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag5;
			if (flag5)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
			if (num4 != 0)
			{
				goto IL_02B4;
			}
			int num6 = 0;
			GridSystem gridSystem = this.board.gridSystem;
			bool flag6;
			if (!flag6)
			{
				break;
			}
			BoxType boxType;
			BoxType boxType2;
			if (boxType == BoxType.Water || boxType2 == BoxType.Dirt)
			{
				goto IL_0298;
			}
			bool flag8;
			bool flag7 = !flag8;
			BoardGrid boardGrid2;
			List<Plant> plants2 = boardGrid2.plants;
			bool flag9;
			if (flag9)
			{
				int num7 = 0;
				if (!(num != num7))
				{
					continue;
				}
			}
			if (num6 == 0)
			{
				goto IL_0298;
			}
		}
		BoxType boxType3;
		bool flag10;
		bool flag11;
		bool flag12;
		if (boxType3 != BoxType.Roof || (!flag10 && !flag11 && flag12))
		{
			bool flag13;
			return flag13;
		}
		IL_0298:
		bool flag14 = this.CheckFlying(theBoxColumn, theBoxRow);
		throw new NullReferenceException();
		IL_02AE:
		throw new NullReferenceException();
		IL_02B4:
		throw new NullReferenceException();
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x85E180", Offset = "0x85C780", VA = "0x18085E180")]
	private bool DoubleBoxCheck(int theColumn, int theRow, PlantType theCurrentPlantType)
	{
		if (this.FindNeedPlants(theColumn, theRow, (PlantType)((uint)(-1)), theCurrentPlantType) != 0)
		{
			int columnNum = this.board.columnNum;
			if (theColumn < columnNum)
			{
				GridSystem gridSystem = this.board.gridSystem;
				int num = theColumn + 1;
				if (gridSystem.HasGrave(num, theRow))
				{
					goto IL_005A;
				}
				GridSystem gridSystem2 = this.board.gridSystem;
				int num2 = theColumn + 1;
				if (gridSystem2.HasPit(num2, theRow))
				{
					goto IL_005A;
				}
			}
			return true;
		}
		IL_005A:
		throw new NullReferenceException();
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0002F42C File Offset: 0x0002D62C
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x85E240", Offset = "0x85C840", VA = "0x18085E240")]
	private Plant[] FindNeedPlants(int theColumn, int theRow, PlantType needTheSeedType, PlantType theCurrentPlantType)
	{
		for (;;)
		{
			int num = 0;
			Plant[] array = new Plant[2];
			int columnNum = this.board.columnNum;
			if (theColumn == columnNum)
			{
				goto IL_0088;
			}
			int potNum = this.board.gridSystem.GetPotNum(theColumn, theRow);
			GridSystem gridSystem = this.board.gridSystem;
			int num2 = theColumn + 1;
			int potNum2 = gridSystem.GetPotNum(num2, theRow);
			if (potNum != potNum2)
			{
				goto IL_0088;
			}
			BoxType boxType = this.board.gridSystem.GetBoxType(theColumn, theRow);
			bool flag;
			if (boxType != BoxType.Grass)
			{
				if (boxType == BoxType.Grass)
				{
					goto IL_008B;
				}
				if (boxType == BoxType.Grass)
				{
					goto IL_0088;
				}
				if (boxType != BoxType.Grass)
				{
				}
				if (flag)
				{
					goto IL_0088;
				}
				goto IL_0104;
			}
			IL_00CE:
			while (needTheSeedType != PlantType.Peashooter)
			{
			}
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag2;
			if (flag2)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				array[0] = num;
			}
			ulong num4;
			if (num4 != (ulong)0L)
			{
				goto IL_0245;
			}
			IL_0104:
			List<Plant> plants2 = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag3;
			if (flag3)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				array[0] = num;
			}
			ulong num6;
			if (num6 != (ulong)0L)
			{
				goto IL_025D;
			}
			bool flag4;
			while (!flag4)
			{
			}
			BoxType boxType2;
			if (boxType2 != BoxType.Grass)
			{
				if (boxType2 != BoxType.Grass)
				{
					while (boxType2 == BoxType.Grass)
					{
					}
					if (boxType2 != BoxType.Grass)
					{
					}
					while (flag)
					{
					}
				}
				BoardGrid boardGrid2;
				List<Plant> plants3 = boardGrid2.plants;
				bool flag5;
				if (flag5)
				{
					array[1] = num;
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_0275;
				}
				GridSystem gridSystem2 = this.board.gridSystem;
				bool flag6;
				while (flag6)
				{
				}
			}
			while (flag)
			{
			}
			Plant plant = array[7];
			BoardGrid boardGrid3;
			List<Plant> plants4 = boardGrid3.plants;
			bool flag7;
			if (flag7)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
				array[1] = num;
			}
			ulong num9;
			if (num9 != (ulong)0L)
			{
				goto IL_028D;
			}
			BoardGrid boardGrid4;
			List<Plant> plants5 = boardGrid4.plants;
			bool flag8;
			if (flag8)
			{
				int num10 = 0;
				if (!(num != num10))
				{
					continue;
				}
				array[1] = num;
			}
			ulong num11;
			if (num11 == (ulong)0L)
			{
				break;
			}
			continue;
			IL_008B:
			List<Plant> plants6 = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag9;
			if (flag9)
			{
				array[0] = num;
			}
			ulong num12;
			if (num12 == (ulong)0L)
			{
				GridSystem gridSystem3 = this.board.gridSystem;
				bool flag10;
				while (flag10)
				{
				}
				goto IL_00CE;
			}
			goto IL_022D;
			IL_0088:
			goto IL_008B;
		}
		bool flag11;
		while (!flag11)
		{
		}
		throw new NullReferenceException();
		IL_022D:
		throw new ArrayTypeMismatchException();
		IL_0245:
		throw new ArrayTypeMismatchException();
		IL_025D:
		throw new ArrayTypeMismatchException();
		IL_0275:
		throw new ArrayTypeMismatchException();
		IL_028D:
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0002F6E0 File Offset: 0x0002D8E0
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x8617A0", Offset = "0x85FDA0", VA = "0x1808617A0")]
	private bool PotCheck(int theColumn, int theRow)
	{
		if (this.board.gridSystem.GetBoxType(theColumn, theRow) != BoxType.Water && this.board.gridSystem.GetBoxType(theColumn, theRow) != BoxType.Dirt && !this.board.gridSystem.HasPot(theColumn, theRow))
		{
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0002F738 File Offset: 0x0002D938
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x85B530", Offset = "0x859B30", VA = "0x18085B530")]
	private bool CheckFlying(int theBoxColumn, int theBoxRow)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2) || !TypeMgr.FlyingPlants((PlantType)num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x0002F790 File Offset: 0x0002D990
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x861720", Offset = "0x85FD20", VA = "0x180861720")]
	public bool OnHardLand(PlantType theSeedType)
	{
		bool flag;
		bool flag2;
		return theSeedType == PlantType.PotatoPumpkin || flag || flag2 || flag2;
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x85D260", Offset = "0x85B860", VA = "0x18085D260")]
	private bool CheckPuff(int theColumn, int theRow)
	{
		int num2;
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
				if (!this.IsPuff((PlantType)num3))
				{
					bool flag2;
					while (flag2)
					{
					}
					bool flag3;
					while (flag3)
					{
					}
				}
				num2++;
			}
		}
		while (num2 != 0);
		BoxType boxType;
		bool flag4;
		BoxType boxType2;
		if ((boxType != BoxType.Water || flag4) && boxType2 != BoxType.Dirt)
		{
			return num2 < 3;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x0002F82C File Offset: 0x0002DA2C
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x85B720", Offset = "0x859D20", VA = "0x18085B720")]
	private Plant CheckMix(int theColumn, int theRow, PlantType theUsedType)
	{
		int num4;
		do
		{
			int num = 0;
			int num2 = 0;
			List<Plant> list = new List();
			List<Plant> plants = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
			if (num2 != 0)
			{
				goto IL_03B4;
			}
			num4 = 0;
			Func<Plant, int> func;
			if (CreatePlant.<>c.<>9__20_0 == 0)
			{
				CreatePlant.<>c.<>9__20_0 = func;
			}
			List<Plant> list2 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list, func));
			Func<Plant, int> func2;
			if (CreatePlant.<>c.<>9__20_1 == 0)
			{
				CreatePlant.<>c.<>9__20_1 = func2;
			}
			List<Plant> list3 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list2, func2));
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (num == num5)
				{
					continue;
				}
				bool flag3;
				while (!flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
				bool flag5;
				if (flag5)
				{
				}
				Plant[] array;
				if (array != 0)
				{
					Plant plant = array[0];
					int num6 = 0;
					if (!(plant == num6))
					{
						Plant plant2 = array[1];
						int num7 = 0;
						if (!(plant2 == num7))
						{
							Plant plant3 = array[0];
							Plant plant4 = array[1];
							if (num2 == 926)
							{
							}
							while (num2 != 955)
							{
							}
							uint num8;
							if (global::UnityEngine.Random.Range(0, (int)num8) >= 2)
							{
								continue;
							}
							int num9 = 0;
							Plant plant5;
							Plant plant6;
							if (plant5 == num9)
							{
								List<PlantType> randomPlant = global::Lawnf.GetRandomPlant();
								int num10 = randomPlant._size;
								num10 = global::UnityEngine.Random.Range(0, num10);
								PlantType plantType = randomPlant[num10];
								int num11 = 0;
								if (plant6 == num11)
								{
								}
							}
							int num12 = 0;
							if (!(plant6 != num12))
							{
								continue;
							}
							plant6.secondParent = PlantType.Peashooter;
							int thePlantType = (int)plant6.thePlantType;
							PlantDataManager.PlantData plantData;
							if (plantData.cost != 0)
							{
								CreateItem instance = CreateItem.Instance;
								CreateItem instance2 = CreateItem.Instance;
							}
							uint num13;
							if (num13 <= (uint)953)
							{
								goto IL_02A7;
							}
							int num14;
							if (num13 > (uint)1111)
							{
								if (num13 == (uint)1125)
								{
									CreateItem instance3 = CreateItem.Instance;
									CreateItem instance4 = CreateItem.Instance;
									CreateItem instance5 = CreateItem.Instance;
									CreateItem instance6 = CreateItem.Instance;
									CreateItem instance7 = CreateItem.Instance;
									CreateItem instance8 = CreateItem.Instance;
									if (num13 <= (uint)1317)
									{
										goto IL_0334;
									}
									if (num13 <= (uint)1332)
									{
										goto IL_0320;
									}
									GameObject gameObject;
									if (gameObject > (ulong)31L)
									{
										goto IL_0370;
									}
									CreateItem instance9 = CreateItem.Instance;
								}
								if (num13 == (uint)1290)
								{
									goto IL_02EE;
								}
								while (num13 != (uint)1442)
								{
								}
								CreateItem instance10 = CreateItem.Instance;
								num14 = 0;
								CreateItem instance11 = CreateItem.Instance;
								CreateItem instance12 = CreateItem.Instance;
								CreateItem instance13 = CreateItem.Instance;
							}
							if (num14 == 964)
							{
								bool flag6 = "{il2cpp field on {'constant243' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(CobCannon).TypeHandle;
							}
							int num15;
							if (num14 != 977)
							{
								while (num14 != 1111)
								{
								}
								CreateItem instance14 = CreateItem.Instance;
								num15 = 0;
								CreateItem instance15 = CreateItem.Instance;
								CreateItem instance16 = CreateItem.Instance;
								CreateItem instance17 = CreateItem.Instance;
								goto IL_02A7;
							}
							goto IL_02DE;
							IL_0370:
							bool flag7;
							if (flag7 && num13 != (uint)1015)
							{
								if (num13 == (uint)1015)
								{
								}
								ulong num16;
								plant6.AttributeCountdown = (float)num16;
							}
							bool flag8;
							while (flag8)
							{
							}
							goto IL_0397;
							IL_0320:
							if (num13 == (uint)1325)
							{
								goto IL_0370;
							}
							if (num13 == (uint)1327)
							{
								goto IL_0334;
							}
							goto IL_0334;
							IL_02EE:
							bool flag9;
							if (flag9)
							{
							}
							int num17;
							if (num17 == 0)
							{
								if (num13 == (uint)915)
								{
								}
								while (num13 != (uint)935)
								{
								}
								bool flag10 = "{il2cpp field on {'constant362' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(IFVPumpkin).TypeHandle;
								goto IL_0320;
							}
							goto IL_0480;
							IL_02DE:
							bool flag11;
							if (flag11)
							{
							}
							int num18;
							if (num18 == 0)
							{
								num17 = 0;
								goto IL_02EE;
							}
							goto IL_047A;
							IL_02A7:
							int num19;
							if (num15 > 935)
							{
								if (num15 == 942)
								{
									bool flag12;
									if (flag12)
									{
									}
									if (num4 != 0)
									{
										goto IL_0456;
									}
									num19 = 0;
								}
								bool flag13;
								if (flag13)
								{
								}
							}
							bool flag14;
							if (flag14)
							{
							}
							if (num19 == 0)
							{
								num18 = 0;
								goto IL_02DE;
							}
							goto IL_0474;
							IL_0334:
							if (num13 == (uint)1198 || num13 == (uint)1308 || num13 == (uint)1317 || num13 == (uint)928 || num13 == (uint)1002 || num13 != (uint)1040)
							{
								goto IL_0370;
							}
							goto IL_0370;
						}
					}
				}
				IL_0397:;
			}
		}
		while (num4 != 0);
		throw new NullReferenceException();
		IL_03B4:
		throw new IndexOutOfRangeException();
		IL_0456:
		throw new NullReferenceException();
		IL_0474:
		throw new NullReferenceException();
		IL_047A:
		throw new NullReferenceException();
		IL_0480:
		throw new NullReferenceException();
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x0002FD08 File Offset: 0x0002DF08
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x860630", Offset = "0x85EC30", VA = "0x180860630")]
	private bool MixFail(int theBoxColumn, int theBoxRow, PlantType newPlantType)
	{
		for (;;)
		{
			int num = 0;
			Board board = this.board;
			bool flag;
			if (flag)
			{
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("通关挑战模式解锁配方", 7f, num2 != 0);
				bool flag2;
				if (flag2)
				{
					goto IL_0062;
				}
			}
			bool flag3;
			while (flag3)
			{
			}
			if (newPlantType == PlantType.UltimateGatlingBlover)
			{
				int num3 = this.board.rowNum;
				num3 += num3;
				InGameText instance2 = InGameText.Instance;
				goto IL_0062;
			}
			IL_006C:
			if (newPlantType == PlantType.UltimateJalapeno || newPlantType == PlantType.UltimateJalaPuff)
			{
				int num4 = this.board.rowNum;
				num4 += 2;
				InGameText instance3 = InGameText.Instance;
			}
			int num5 = GameAPP.theBoardLevel;
			InGameText instance4;
			if (num5 > 104)
			{
				if (num5 > 131)
				{
					num5 += -159;
					if (num5 <= 29)
					{
					}
					GridSystem gridSystem = this.board.gridSystem;
					bool flag4;
					bool flag5;
					if (gridSystem.GetBoxType(theBoxColumn, theBoxRow) != BoxType.Water || (!flag4 && !flag5))
					{
						goto IL_015F;
					}
					instance4 = InGameText.Instance;
				}
				if (instance4 == (ulong)4294967287L || instance4 <= (ulong)1L)
				{
					goto IL_0155;
				}
			}
			if ("不能在水上融合！" > (ulong)41L)
			{
				if (instance4 <= (ulong)1L)
				{
					goto IL_0155;
				}
				if (instance4 <= (ulong)6L)
				{
				}
				if ("不能在水上融合！" == (ulong)104L)
				{
					goto IL_0155;
				}
			}
			if ("不能在水上融合！" != (ulong)29L)
			{
				continue;
			}
			bool flag6;
			while (flag6)
			{
			}
			if (InGameText.Instance <= (ulong)1L)
			{
				goto IL_0155;
			}
			continue;
			IL_015F:
			bool flag7;
			bool flag8;
			if (flag7 && !flag8 && this.board.gridSystem.GetBoxType(theBoxColumn, theBoxRow) == BoxType.Roof)
			{
				InGameText instance5 = InGameText.Instance;
			}
			bool flag9;
			if (flag9 && this.board.gridSystem.GetBoxType(theBoxColumn, theBoxRow) != BoxType.Water)
			{
				InGameText instance6 = InGameText.Instance;
			}
			if (newPlantType == PlantType.CattailPlant)
			{
				List<Plant> plants = this.board.gridSystem.GetGrid(theBoxColumn, theBoxRow).plants;
				bool flag10;
				if (flag10)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_0338;
				}
			}
			bool flag11;
			if (!flag11)
			{
				break;
			}
			BoardGrid boardGrid;
			List<Plant> plants2 = boardGrid.plants;
			bool flag12;
			if (flag12)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
			}
			ulong num9;
			if (num9 == (ulong)0L)
			{
				break;
			}
			continue;
			IL_0155:
			InGameText instance7 = InGameText.Instance;
			goto IL_015F;
			IL_0062:
			InGameText instance8 = InGameText.Instance;
			goto IL_006C;
		}
		Predicate<Plant> predicate;
		if (CreatePlant.<>c.<>9__21_6 == 0)
		{
			CreatePlant.<>c.<>9__21_6 = predicate;
		}
		List<Plant> list;
		int num10 = list.RemoveAll(predicate);
		InGameText instance9 = InGameText.Instance;
		Func<Plant, bool> func;
		if (CreatePlant.<>c.<>9__21_4 == 0)
		{
			CreatePlant.<>c.<>9__21_4 = func;
		}
		List<Plant> list2;
		Plant plant = Enumerable.FirstOrDefault<Plant>(list2, func);
		int num11 = 0;
		if (plant == num11)
		{
			Predicate<Plant> predicate2;
			if (CreatePlant.<>c.<>9__21_5 == 0)
			{
				CreatePlant.<>c.<>9__21_5 = predicate2;
			}
			int num12 = list2.RemoveAll(predicate2);
			InGameText instance10 = InGameText.Instance;
			Func<Plant, bool> func2;
			if (CreatePlant.<>c.<>9__21_2 == 0)
			{
				CreatePlant.<>c.<>9__21_2 = func2;
			}
			List<Plant> list3;
			Plant plant2 = Enumerable.FirstOrDefault<Plant>(list3, func2);
			int num13 = 0;
			if (plant2 == num13)
			{
				Predicate<Plant> predicate3;
				if (CreatePlant.<>c.<>9__21_3 == 0)
				{
					CreatePlant.<>c.<>9__21_3 = predicate3;
				}
				int num14 = list3.RemoveAll(predicate3);
				InGameText instance11 = InGameText.Instance;
				Func<Plant, bool> func3;
				if (CreatePlant.<>c.<>9__21_0 == 0)
				{
					CreatePlant.<>c.<>9__21_0 = func3;
				}
				List<Plant> list4;
				Plant plant3 = Enumerable.FirstOrDefault<Plant>(list4, func3);
				int num15 = 0;
				if (plant3 == num15)
				{
					Predicate<Plant> predicate4;
					if (CreatePlant.<>c.<>9__21_1 == 0)
					{
						CreatePlant.<>c.<>9__21_1 = predicate4;
					}
					int num16 = list4.RemoveAll(predicate4);
					InGameText instance12 = InGameText.Instance;
				}
			}
		}
		throw new NullReferenceException();
		IL_0338:
		throw new NullReferenceException();
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00030054 File Offset: 0x0002E254
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x861B80", Offset = "0x860180", VA = "0x180861B80")]
	private bool PumpkinCheck(int theBoxColumn, int theBoxRow)
	{
		int num3;
		for (;;)
		{
			int num = 0;
			BoxType boxType = this.board.gridSystem.GetBoxType(theBoxColumn, theBoxRow);
			Board board = this.board;
			if (boxType != BoxType.Water)
			{
				List<Plant> plants = board.gridSystem.GetGrid(theBoxColumn, theBoxRow).plants;
				bool flag;
				if (!flag)
				{
					break;
				}
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else
			{
				num3 = 0;
				List<Plant> plants2 = board.gridSystem.GetGrid(theBoxColumn, theBoxRow).plants;
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					if (num > 366)
					{
						if (18446744073709550666UL == (ulong)4294967287L)
						{
							goto IL_00BD;
						}
						while (18446744073709550549UL > (ulong)2L)
						{
						}
					}
					if (num != 12 && num != 252)
					{
						while (num != 366)
						{
						}
					}
				}
				IL_00BD:
				ulong num5;
				if (num5 == (ulong)0L)
				{
					goto Block_7;
				}
			}
		}
		ulong num6;
		if (num6 == (ulong)0L)
		{
			return true;
		}
		throw new NullReferenceException();
		Block_7:
		if (num3 == 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00030140 File Offset: 0x0002E340
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x861850", Offset = "0x85FE50", VA = "0x180861850")]
	private bool PresentCheck(int theBoxColumn, int theBoxRow)
	{
		List<Plant> list = global::Lawnf.Get1x1Plants(theBoxColumn, theBoxColumn);
		return true;
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00030194 File Offset: 0x0002E394
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x85FE80", Offset = "0x85E480", VA = "0x18085FE80")]
	private bool MixBombCheck(int theBoxColumn, int theBoxRow)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = this.board.gridSystem.GetGrid(theBoxColumn, theBoxRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2) || !MixBomb.Recipe.ContainsKey(num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		return true;
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00030200 File Offset: 0x0002E400
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x861F20", Offset = "0x860520", VA = "0x180861F20")]
	public void SetLayer(Plant plant, int theColumn, int theRow)
	{
		long num2;
		bool flag2;
		do
		{
			List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theRow);
			bool flag;
			if (!flag)
			{
				SortingGroup sortingGroup = plant.AddComponent<SortingGroup>();
			}
			uint num;
			num -= (uint)theColumn;
			num2 = (long)(num * (uint)100);
			if (plant.isLily)
			{
				goto IL_00F8;
			}
			Transform axis = plant.axis;
		}
		while (flag2);
		ulong num3;
		plant.axis.AddComponent<SortingGroup>().sortAtRoot = num3 != 0UL;
		if (plant.plantTag == (ulong)0L)
		{
			if (plant.puffPlace == 0)
			{
				int num4;
				string text = string.Format("plantlow{0}", num4);
			}
			int num5;
			string text2 = string.Format("plant{0}", num5);
		}
		int num6;
		string text3 = string.Format("fly{0}", num6);
		Transform transform = plant.transform.Find("pumpkin_back");
		int num7 = 0;
		GameObject gameObject = transform.gameObject;
		SortingGroup sortingGroup2;
		if (!gameObject.TryGetComponent<SortingGroup>(num7))
		{
			sortingGroup2 = gameObject.AddComponent<SortingGroup>();
		}
		ulong num8;
		sortingGroup2.sortAtRoot = num8 != 0UL;
		sortingGroup2.sortingOrder = (int)num2;
		string text4 = string.Format("pumpkinback{0}", sortingGroup2);
		string text5 = string.Format("pumpkinfront{0}", text4);
		plant.sortingGroup = text5;
		return;
		IL_00F8:
		throw new NullReferenceException();
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x0003030C File Offset: 0x0002E50C
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x862330", Offset = "0x860930", VA = "0x180862330")]
	private void SetPlantAttributes(Plant plant)
	{
		float num = global::UnityEngine.Random.Range(0.9f, 1.1f);
		plant.thePlantSpeed = num;
		float thePlantAttackInterval = plant.thePlantAttackInterval;
		if (plant != 0)
		{
			float num2 = global::UnityEngine.Random.Range(0.2f, 0.8f);
			plant.thePlantAttackCountDown = thePlantAttackInterval;
		}
		if (plant != 0)
		{
			float num3 = global::UnityEngine.Random.Range(4f, 7f);
			plant.thePlantProduceCountDown = num3;
		}
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00030374 File Offset: 0x0002E574
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x865550", Offset = "0x863B50", VA = "0x180865550")]
	private void SetTransform(Plant plant, Vector3 position)
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = plant.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				float z = position.z;
				Transform transform = plant.transform;
				Transform transform2 = plant.transform;
				Vector3 vector;
				float z2 = vector.z;
				plant.startPos.z = z2;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		this.SetPuffTransform(plant);
		Transform transform3;
		Transform transform4;
		transform3.parentInternal = transform4;
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x0003041C File Offset: 0x0002E61C
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x8650D0", Offset = "0x8636D0", VA = "0x1808650D0")]
	public void SetPuffTransform(Plant plant)
	{
		bool[] array;
		ulong num3;
		do
		{
			int num = 0;
			int thePlantType = (int)plant.thePlantType;
			bool flag;
			if (!flag)
			{
				return;
			}
			array = new bool[3];
			Transform transform = plant.transform;
			Vector3 vector;
			float z = vector.z;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag2;
			if (flag2)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				bool flag3 = this.IsPuff((PlantType)num2);
				while (!flag3)
				{
				}
				while (plant.thePlantRow != (flag3 ? 1 : 0))
				{
				}
				while (plant.thePlantColumn != (flag3 ? 1 : 0))
				{
				}
			}
		}
		while (num3 != (ulong)0L);
		int num4 = 0;
		int num5 = 0;
		int length = array.Length;
		if (num5 < length)
		{
			num4++;
		}
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x000304E4 File Offset: 0x0002E6E4
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x864CB0", Offset = "0x8632B0", VA = "0x180864CB0")]
	public void SetPuffLayer(GameObject plant, bool isLower, int theRow)
	{
		int num;
		do
		{
			num = 0;
			if (plant.name != 0)
			{
				break;
			}
			bool flag = plant.TryGetComponent<SpriteRenderer>(num);
			if (flag)
			{
				if (!isLower)
				{
					string text = string.Format("plant{0}", flag);
				}
				string text2 = string.Format("plantlow{0}", flag);
			}
			if (plant.transform.childCount == 0)
			{
				return;
			}
			IEnumerator enumerator = plant.transform.GetEnumerator();
			GameObject gameObject;
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				this.SetPuffLayer(gameObject, isLower, theRow);
			}
			if (gameObject != 0)
			{
			}
		}
		while (num != 0);
		SpriteRenderer component = plant.GetComponent<SpriteRenderer>();
		string text3 = string.Format("plantlow{0}", component);
		if (!isLower)
		{
		}
		component.sortingLayerName = text3;
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x000305AC File Offset: 0x0002E7AC
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x85F750", Offset = "0x85DD50", VA = "0x18085F750")]
	private bool Lim(PlantType theSeedType)
	{
		if (theSeedType > PlantType.SuperTorch)
		{
			if (theSeedType > PlantType.SuperPumpkin)
			{
				if (theSeedType == PlantType.SuperMelon)
				{
					bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
					if ("{il2cpp array field local3->}" == (ulong)0L)
					{
						return true;
					}
				}
				if (theSeedType == PlantType.SuperUmbrella)
				{
					bool[] clgLevelCompleted2 = GameAPP.clgLevelCompleted;
				}
				while (theSeedType != PlantType.SuperSpruce)
				{
				}
				bool[] clgLevelCompleted3 = GameAPP.clgLevelCompleted;
			}
			if (theSeedType == PlantType.SuperKelp)
			{
				bool[] clgLevelCompleted4 = GameAPP.clgLevelCompleted;
			}
			if (theSeedType == PlantType.SuperStar)
			{
				bool[] clgLevelCompleted5 = GameAPP.clgLevelCompleted;
			}
			while (theSeedType != PlantType.SuperPumpkin)
			{
			}
			bool[] clgLevelCompleted6 = GameAPP.clgLevelCompleted;
		}
		if (theSeedType > PlantType.SuperChomper)
		{
			if (theSeedType == PlantType.SuperHypno)
			{
				bool[] clgLevelCompleted7 = GameAPP.clgLevelCompleted;
			}
			if (theSeedType == PlantType.SuperFume)
			{
				bool[] clgLevelCompleted8 = GameAPP.clgLevelCompleted;
			}
			while (theSeedType != PlantType.SuperTorch)
			{
			}
			bool[] clgLevelCompleted9 = GameAPP.clgLevelCompleted;
		}
		if (theSeedType != PlantType.SuperCherryShooter)
		{
			while (theSeedType != PlantType.SuperChomper)
			{
			}
			bool[] clgLevelCompleted10 = GameAPP.clgLevelCompleted;
			return "{il2cpp array field local14->}" == (ulong)0L;
		}
		bool[] clgLevelCompleted11 = GameAPP.clgLevelCompleted;
		while ("{il2cpp array field local13->}" != (ulong)0L)
		{
		}
		return true;
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x000306A8 File Offset: 0x0002E8A8
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x85F070", Offset = "0x85D670", VA = "0x18085F070")]
	public bool LimTravel(PlantType theSeedType)
	{
		List<PlantType> ulockedPlants_temp = TravelMgr.Instance.ulockedPlants_temp;
		bool flag;
		if (!flag)
		{
			Board board = this.board;
			bool flag2;
			if (flag2)
			{
				uint num;
				if (num == (uint)0)
				{
					goto IL_00BE;
				}
				if (this.board <= (ulong)98L)
				{
					bool flag3 = global::Lawnf.TravelUnlock(TravelUnlocks.UltimateChomper);
					bool flag4;
					bool flag5;
					bool flag6;
					if (!flag4 || !flag5 || !flag6)
					{
						goto IL_0061;
					}
				}
				bool flag7;
				bool flag8;
				if (theSeedType != PlantType.FlyingThreePeater_sp || (flag7 && flag8))
				{
					goto IL_0081;
				}
				IL_0061:
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("该配方需要抽取", 3f, num2 != 0);
			}
		}
		IL_0081:
		int num3 = 0;
		if (num3 <= 2 || num3 <= 1 || num3 > 3)
		{
		}
		Board board2 = this.board;
		List<PlantType> unlockedWeaks = TravelMgr.Instance.data.unlockedWeaks;
		bool flag9;
		while (flag9)
		{
		}
		InGameText instance2 = InGameText.Instance;
		IL_00BE:
		InGameText instance3 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00030784 File Offset: 0x0002E984
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x8600B0", Offset = "0x85E6B0", VA = "0x1808600B0")]
	private void MixEvent(PlantType theSeedType, Plant plant, int theRow)
	{
		int num = 0;
		Transform axis = plant.axis;
		if (theSeedType > PlantType.IceShroom)
		{
			if (theSeedType == PlantType.DoomShroom)
			{
				Transform axis2 = plant.axis;
				Transform axis3 = plant.axis;
				BoardAction boardAction = this.board.boardAction;
				return;
			}
			if (theSeedType == PlantType.Jalapeno)
			{
				BoardAction boardAction2 = this.board.boardAction;
			}
			while (theSeedType != PlantType.Thorns)
			{
			}
			Transform axis4 = plant.axis;
			CreateBullet instance = CreateBullet.Instance;
			if (18446744073709551612UL > (ulong)4L)
			{
				Bullet bullet;
				uint num2;
				bullet.Damage = (int)num2;
				int num3 = 0;
				bullet.fromType = (PlantType)((ulong)40L);
				bullet.transform.rotation = num3;
			}
			int num4 = 0;
			Bullet bullet2;
			bullet2.Damage = num4;
			int num5 = 0;
			bullet2.fromType = (PlantType)((ulong)40L);
			bullet2.transform.rotation = num5;
			bullet2.from = plant;
			num++;
			num += 30;
			ParticleManager instance2 = ParticleManager.Instance;
		}
		if (theSeedType == PlantType.CherryBomb)
		{
			BoardAction boardAction3 = this.board.boardAction;
		}
		while (theSeedType != PlantType.IceShroom)
		{
		}
		BoardAction boardAction4 = this.board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00030888 File Offset: 0x0002EA88
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x865920", Offset = "0x863F20", VA = "0x180865920")]
	private void UniqueEvent(PlantType theSeedType, Plant plant, int theRow)
	{
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		if (theSeedType > PlantType.PeaMine)
		{
			if (theSeedType == PlantType.SunMine)
			{
				CreateItem instance = CreateItem.Instance;
			}
			if (theSeedType == PlantType.PotatoChomper)
			{
				CreateItem instance2 = CreateItem.Instance;
				CreateItem instance3 = CreateItem.Instance;
			}
			if (theSeedType == PlantType.DarkThreePeater)
			{
				Board board = this.board;
				if (theRow != 0)
				{
					BoardAction boardAction = Board.Instance.boardAction;
				}
				int rowNum = this.board.rowNum;
				if (theRow != rowNum)
				{
					BoardAction boardAction2 = Board.Instance.boardAction;
				}
				BoardAction boardAction3 = Board.Instance.boardAction;
			}
			return;
		}
		int i;
		if (theSeedType == PlantType.SuperThreePeater)
		{
			Board board2 = this.board;
			i = 0;
			while (i >= board2.rowNum)
			{
			}
			BoardAction boardAction4 = Board.Instance.boardAction;
			Board board3 = this.board;
			i++;
			while (board3 != 0)
			{
			}
		}
		while (i != 1007)
		{
		}
		CreateItem instance4 = CreateItem.Instance;
		CreateItem instance5 = CreateItem.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00030984 File Offset: 0x0002EB84
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x85F020", Offset = "0x85D620", VA = "0x18085F020")]
	public bool IsPuff(PlantType theSeedType)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00030998 File Offset: 0x0002EB98
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x85EFE0", Offset = "0x85D5E0", VA = "0x18085EFE0")]
	public bool InTheSameBox(Plant p1, Plant p2)
	{
		int thePlantRow = p2.thePlantRow;
		if (p1.thePlantRow == thePlantRow)
		{
			int thePlantColumn = p2.thePlantColumn;
			return p1.thePlantColumn == thePlantColumn;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x000309D0 File Offset: 0x0002EBD0
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CreatePlant()
	{
	}

	// Token: 0x0400046C RID: 1132
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400046C")]
	private Board board;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	public static CreatePlant Instance;

	// Token: 0x0400046E RID: 1134
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400046E")]
	private LayerMask bulletLayer;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	public static bool canStarUp;
}
