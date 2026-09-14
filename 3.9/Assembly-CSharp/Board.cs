using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
public class Board : MonoBehaviour
{
	// Token: 0x06000A73 RID: 2675 RVA: 0x00039504 File Offset: 0x00037704
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x918DC0", Offset = "0x9173C0", VA = "0x180918DC0")]
	private void Awake()
	{
		Board.Instance = this;
		EventManager.TriggerEvent((GameEvent)((uint)11), this);
		Transform transform = new GameObject("UIParent").transform;
		this.UIParent = transform;
		Transform uiparent = this.UIParent;
		Transform canvasUp = GameAPP.canvasUp;
		uiparent.parentInternal = canvasUp;
		Transform transform2 = this.UIParent.transform;
		Transform transform3 = this.UIParent.transform;
		BoardSpawner boardSpawner = new BoardSpawner(this);
		this.boardSpawner = boardSpawner;
		this.damageReporter = new DamageReporter
		{
			board = this
		};
		this.boardAction = new BoardAction
		{
			board = this
		};
		BoardStatistics boardStatistics = new BoardStatistics(this);
		this.boardStatistics = boardStatistics;
		this.gridSystem = new GridSystem
		{
			board = this
		};
		CreateItem createItem = this.AddComponent<CreateItem>();
		CreateBullet createBullet = this.AddComponent<CreateBullet>();
		CreatePlant createPlant = this.AddComponent<CreatePlant>();
		CreateZombie createZombie = this.AddComponent<CreateZombie>();
		Mouse mouse = this.AddComponent<Mouse>();
		MagnetLineMgr magnetLineMgr = this.AddComponent<MagnetLineMgr>();
		BulletPoolManager bulletPoolManager = this.AddComponent<BulletPoolManager>();
		ParticleManager particleManager = this.AddComponent<ParticleManager>();
		this.InitSeedPool();
		this.SetUniqueLevel();
		Mouse instance = Mouse.Instance;
		int num = this.columnNum;
		float boxXFromColumn = instance.GetBoxXFromColumn(num);
		this.boardMaxY = 6.5f;
		this.boardMinX = -10f;
		this.plantMaxVisionX = boxXFromColumn;
		Mouse instance2 = Mouse.Instance;
		int num2 = this.columnNum;
		float boxXFromColumn2 = instance2.GetBoxXFromColumn(num2);
		this.boardMaxX = boxXFromColumn2;
		Mouse instance3 = Mouse.Instance;
		int num3 = this.rowNum;
		float boxYFromRow = instance3.GetBoxYFromRow(num3);
		this.boardMinY = boxYFromRow;
		Mouse instance4 = Mouse.Instance;
		int num4 = this.columnNum;
		float boxXFromColumn3 = instance4.GetBoxXFromColumn(num4);
		this.zombieMinX = -10f;
		this.zombieMaxX = boxXFromColumn3;
		EventManager.TriggerEvent((GameEvent)((uint)12), this);
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000396D0 File Offset: 0x000378D0
	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x927B30", Offset = "0x926130", VA = "0x180927B30")]
	private void Start()
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (instance != num)
		{
			AdvantureManager instance2 = AdvantureManager.Instance;
		}
		DefaultVictory defaultVictory = new DefaultVictory();
		IZVictory izvictory = new IZVictory();
		this.boardVicotry = izvictory;
		BoardVictory boardVictory = this.boardVicotry;
		Action action = delegate
		{
			if (!this.fakeTrophy)
			{
				this.EnterNextRound();
				return;
			}
			this.fakeTrophy = false;
		};
		boardVictory.<Victiory>k__BackingField = action;
		if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)1018)))
		{
			this.AddLightLevel(4);
		}
		TravelMgr.Instance.OnBoardStart(this);
		bool flag;
		if (flag)
		{
			return;
		}
		this.SetPrePlants();
		this.InitIZSettings();
		if (this.sceneType == SceneType.Night)
		{
			this.SetGrave();
			return;
		}
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00039778 File Offset: 0x00037978
	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x926E70", Offset = "0x925470", VA = "0x180926E70")]
	private void SetVictoryCondition()
	{
		DefaultVictory defaultVictory = new DefaultVictory();
		IZVictory izvictory = new IZVictory();
		this.boardVicotry = izvictory;
		BoardVictory boardVictory = this.boardVicotry;
		Action action = delegate
		{
			if (!this.fakeTrophy)
			{
				this.EnterNextRound();
				return;
			}
			this.fakeTrophy = false;
		};
		boardVictory.<Victiory>k__BackingField = action;
		throw new NullReferenceException();
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x000397BC File Offset: 0x000379BC
	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x91BAA0", Offset = "0x91A0A0", VA = "0x18091BAA0")]
	public void GetJigsawFromList()
	{
		ulong num2;
		do
		{
			List<JigSawData> list = this.jigSawDatas;
			bool flag;
			if (flag)
			{
				GridSystem gridSystem = this.gridSystem;
				BoardGrid boardGrid;
				List<JigsawType> jigsaws = boardGrid.jigsaws;
				int num = jigsaws._size + 1;
				jigsaws._size = num;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00039824 File Offset: 0x00037A24
	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x91F2E0", Offset = "0x91D8E0", VA = "0x18091F2E0")]
	public void SaveJiasawToList()
	{
		int num2;
		do
		{
			int num = 0;
			if (this.jigSawDatas == num)
			{
				List<JigSawData> list = new List();
				this.jigSawDatas = list;
			}
			List<JigSawData> list2 = this.jigSawDatas;
			num2 = 0;
			list2._size = num2;
			int columnCount = this.gridSystem.ColumnCount;
			if (num2 >= columnCount)
			{
				return;
			}
			int rowCount = this.gridSystem.RowCount;
			if (num2 >= rowCount)
			{
				goto IL_0083;
			}
			List<JigsawType> jigsaws = this.gridSystem.GetGrid(num2, num2).jigsaws;
			bool flag;
			if (flag)
			{
				List<JigSawData> list3 = this.jigSawDatas;
			}
		}
		while (num2 != 0);
		num2++;
		IL_0083:
		num2++;
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x000398C4 File Offset: 0x00037AC4
	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x9295F0", Offset = "0x927BF0", VA = "0x1809295F0")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)283)) && (this.sceneType == SceneType.Day || this.sceneType == SceneType.Night))
		{
			IEnumerator enumerator = this.SmoothlyChangeMap((SceneType)((uint)1));
			Coroutine coroutine = base.StartCoroutine(enumerator);
		}
		if (Input.GetKeyDownInt(KeyCodeManager.HideUI))
		{
			CanvasGroup component = GameAPP.canvas.GetComponent<CanvasGroup>();
			CanvasGroup component2 = GameAPP.canvasUp.GetComponent<CanvasGroup>();
			float alpha = component.alpha;
			if (component == 0)
			{
				int num = 0;
				component.alpha = (float)num;
			}
			component.alpha = 1f;
			component2.alpha = 1f;
		}
		if (this.boardEnvironment != 0)
		{
		}
		BoardStatistics boardStatistics = this.boardStatistics;
		float gameDuration = boardStatistics.gameDuration;
		float deltaTime = Time.deltaTime;
		boardStatistics.gameDuration = gameDuration;
		if (this.lockedDifficulty != -1)
		{
			GameConfig gameConfig = GameAPP.config;
			int num2 = this.lockedDifficulty;
			gameConfig.difficulty = num2;
		}
		GridSystem gridSystem = this.gridSystem;
		if (gridSystem != 0)
		{
			gridSystem.OnUpdate();
		}
		RogueManager.Instance.OnUpdate(this);
		if (this.isEveStart)
		{
			this.EveUpdate();
		}
		this.LevelUpdate();
		Plant plant = this.controledPlant;
		int num3 = 0;
		if (plant != num3)
		{
			this.ControledPlantUpdate();
		}
		GameAPP.config.gameSpeed = 1f;
		Time.timeScale = GameAPP.config.gameSpeed;
		TravelMgr.Instance.OnUpdate();
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
		if (!this.over)
		{
			BoardVictory boardVictory = this.boardVicotry;
			if (boardVictory != 0)
			{
				boardVictory.OnUpdate(this);
			}
		}
		this.theSun = (int)((ulong)50000L);
		this.theMoney = (int)((ulong)1000000L);
		this.freeCD = true;
		if (Input.GetKeyDownInt(KeyCodeManager.ShowPlantHealth))
		{
			this.ShowPlantHealth();
		}
		if (!Input.GetKeyDownInt(KeyCodeManager.ShowZombieHealth))
		{
			if (!Input.GetKeyDownInt(KeyCodeManager.ShowBulletDamage))
			{
				return;
			}
			bool flag = !this.showBulletDamage;
			this.showBulletDamage = flag;
			if (!Input.GetKeyDownInt((KeyCode)((uint)114)))
			{
				return;
			}
		}
		this.ShowZombieHealth();
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00039AD0 File Offset: 0x00037CD0
	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x9241F0", Offset = "0x9227F0", VA = "0x1809241F0")]
	public void SetSun(int count)
	{
		this.theSun = count;
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00039AE4 File Offset: 0x00037CE4
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x929C40", Offset = "0x928240", VA = "0x180929C40")]
	public void UseSun(float count)
	{
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		int num = 0;
		if (count > (float)num)
		{
			BoardStatistics boardStatistics = this.boardStatistics;
		}
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00039B10 File Offset: 0x00037D10
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x91C2D0", Offset = "0x91A8D0", VA = "0x18091C2D0")]
	public void GetSun(float count, bool save = true)
	{
		float num = count * this.sunEfficiency;
		if (global::Lawnf.TravelCurse())
		{
		}
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		BoardStatistics boardStatistics = this.boardStatistics;
		int num2 = this.theSun;
		int num3 = this.maxSun;
		bool flag2;
		if (!flag2)
		{
			if (num2 >= num3)
			{
			}
		}
		this.theSun = (flag2 ? 1 : 0);
		if (save)
		{
			int num4 = this.extraSun;
			num4 -= (flag2 ? 1 : 0);
			this.extraSun = (flag2 ? 1 : 0);
			ulong num5;
			num5 += num5;
			List<Plant> plantHead = this.boardEntity.plantHead;
			Func<Plant, bool> func;
			if (Board.<>c.<>9__129_0 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.GoldSunflower;
				Board.<>c.<>9__129_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			if (num5 > (ulong)0L)
			{
				int num6 = 0;
				uint num7;
				if (plant != num6 && num7 > (uint)0)
				{
					int num8;
					if (num5 < (ulong)num7)
					{
						num8 = 0;
					}
					plant.attributeCount = (int)((ulong)200L);
					num8 -= (int)num7;
				}
			}
			int num9 = this.extraSun;
			ulong num10;
			num10 += num10;
			long num11 = (long)(num10 * (ulong)((uint)50));
			num9 = (int)((long)num9 - num11);
			this.extraSun = num9;
			this.OnGetSun();
		}
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00039C38 File Offset: 0x00037E38
	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x91E980", Offset = "0x91CF80", VA = "0x18091E980")]
	private void OnGetSun()
	{
		int num2;
		do
		{
			int num = 0;
			List<Plant> plants = global::Lawnf.GetPlants((PlantType)((uint)963), this, num != 0);
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00039C70 File Offset: 0x00037E70
	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x9204A0", Offset = "0x91EAA0", VA = "0x1809204A0")]
	public void SetMoney(int value)
	{
		this.theMoney = value;
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00039C84 File Offset: 0x00037E84
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x929C10", Offset = "0x928210", VA = "0x180929C10")]
	public void UseMoney(int value)
	{
		BoardStatistics boardStatistics = this.boardStatistics;
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00039CA0 File Offset: 0x00037EA0
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x91BC80", Offset = "0x91A280", VA = "0x18091BC80")]
	public void GetMoney(float count)
	{
		float num = count * this.moneyEfficiency;
		BoardStatistics boardStatistics = this.boardStatistics;
		int num2 = this.maxMoney;
		this.theMoney = num2;
		this.theMoney = (int)((ulong)0L);
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00039CDC File Offset: 0x00037EDC
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x91C1D0", Offset = "0x91A7D0", VA = "0x18091C1D0")]
	public void GetPoint(float count, bool killZombie = false)
	{
		if (!killZombie || !TravelMgr.Instance.data.Invest)
		{
			if (global::Lawnf.TravelCurse())
			{
			}
			TravelData data = TravelMgr.Instance.data;
			int num = 0;
			float num2 = count * data.pointsBonus;
			this.thePoints = num2;
			if (num > (int)num2)
			{
				this.thePoints = 0f;
			}
		}
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00039D44 File Offset: 0x00037F44
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x91D950", Offset = "0x91BF50", VA = "0x18091D950")]
	private void MoveControlPlant(int index)
	{
		GridItem ladder = this.controledPlant.Ladder;
		int num = 0;
		if (!(ladder != num))
		{
			global::Lawnf.ConnectPlant(this.controledPlant.thePlantColumn);
			Plant plant = this.controledPlant;
			GridSystem gridSystem = this.gridSystem;
			int thePlantRow = plant.thePlantRow;
			int num2 = 0;
			int thePlantColumn = plant.thePlantColumn;
			Plant plant2 = this.controledPlant;
			gridSystem.RemovePlant(plant2, thePlantColumn, thePlantRow);
			if (index != 0)
			{
				if (index != 0)
				{
					if (index != 0)
					{
						if (index != 1)
						{
							goto IL_00C4;
						}
						Plant plant3 = this.controledPlant;
						int num3 = this.columnNum;
						if (plant3.thePlantColumn >= num3)
						{
							goto IL_00C4;
						}
					}
					Plant plant4 = this.controledPlant;
					int num4 = this.rowNum;
					if (plant4.thePlantRow >= num4)
					{
						goto IL_00C4;
					}
				}
				if (this.controledPlant.thePlantColumn <= num2)
				{
					goto IL_00C4;
				}
			}
			if (this.controledPlant.thePlantRow > num2)
			{
			}
			IL_00C4:
			Plant plant5 = this.controledPlant;
			GridSystem gridSystem2 = this.gridSystem;
			int thePlantRow2 = plant5.thePlantRow;
			int thePlantColumn2 = plant5.thePlantColumn;
			Plant plant6 = this.controledPlant;
			gridSystem2.AddPlant(plant6, thePlantColumn2, thePlantRow2);
			MagnetSystem.MagnetSystemUpdate();
			global::Lawnf.ConnectPlant(this.controledPlant.thePlantColumn);
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00039E6C File Offset: 0x0003806C
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x9196D0", Offset = "0x917CD0", VA = "0x1809196D0")]
	private void ControledPlantUpdate()
	{
		int num3;
		do
		{
			int num = 0;
			if (global::Lawnf.GetKeyDown((KeyCode)((uint)119)) || global::Lawnf.GetKeyDown((KeyCode)((uint)97)) || global::Lawnf.GetKeyDown((KeyCode)((uint)115)) || global::Lawnf.GetKeyDown((KeyCode)((uint)100)))
			{
				int num2 = 0;
				this.MoveControlPlant(num2);
			}
			Plant plant = this.controledPlant;
			int thePlantRow = plant.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(plant.thePlantColumn, thePlantRow);
			num3 = 0;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				int num5 = global::UnityEngine.Random.Range(-1, 8);
				Vector3 vector;
				float z = vector.z;
				if (num5 != -1)
				{
					SingleBuffManager instance = SingleBuffManager.Instance;
				}
				Plant plant2 = this.controledPlant;
				InGameText instance2 = InGameText.Instance;
				GameAPP.PlaySound(66, 0.5f, 1f);
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00039F50 File Offset: 0x00038150
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x9272A0", Offset = "0x9258A0", VA = "0x1809272A0")]
	public void ShowPlantHealth()
	{
		int num5;
		do
		{
			int num = 0;
			int num2 = this.showPlantHealth;
			int num3 = num2 + 1;
			this.showPlantHealth = num3;
			int num4 = num2 + 1;
			num5 = 0;
			if (num4 > 2)
			{
				this.showPlantHealth = num5;
			}
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)1018)))
			{
				this.showPlantHealth = num5;
			}
			List<Plant> plantArray = this.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num6 = 0;
				if (!(num != num6))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				int num7 = this.showPlantHealth;
			}
		}
		while (num5 != 0);
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00039FE0 File Offset: 0x000381E0
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x9274B0", Offset = "0x925AB0", VA = "0x1809274B0")]
	public void ShowZombieHealth()
	{
		ulong num3;
		do
		{
			int num = 0;
			bool flag = (this.showZombieHealth ? 1 : 0) == num;
			this.showZombieHealth = flag;
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)1019)))
			{
				this.showZombieHealth = false;
			}
			List<Zombie> list = this.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				bool flag3;
				while (!flag3)
				{
				}
				bool flag4 = this.showZombieHealth;
				GameObject gameObject;
				gameObject.SetActive(flag4);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0003A064 File Offset: 0x00038264
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x927710", Offset = "0x925D10", VA = "0x180927710")]
	public IEnumerator SmoothlyChangeMap(SceneType sceneType)
	{
		int num;
		Board.<SmoothlyChangeMap>d__139 <SmoothlyChangeMap>d__ = new Board.<SmoothlyChangeMap>d__139(num);
		num = 0;
		<SmoothlyChangeMap>d__.<>4__this = this;
		<SmoothlyChangeMap>d__.sceneType = sceneType;
		throw new NullReferenceException();
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0003A094 File Offset: 0x00038294
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x919360", Offset = "0x917960", VA = "0x180919360")]
	public void ChangeMap(GameObject map)
	{
		bool flag;
		do
		{
			GameObject gameObject = this.background;
			int num = 0;
			if (gameObject != num)
			{
				global::UnityEngine.Object.Destroy(this.background);
			}
			this.background = map;
		}
		while (flag);
		map.AddComponent<SortingGroup>().sortingOrder = -200;
		Transform transform = this.background.transform.Find("Fog");
		int num2 = 0;
		if (transform != num2)
		{
			GameObject gameObject2 = transform.gameObject;
			this.fog = gameObject2;
		}
		this.GetPlane();
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0003A120 File Offset: 0x00038320
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x91BD60", Offset = "0x91A360", VA = "0x18091BD60")]
	private void GetPlane()
	{
		int num;
		do
		{
			num = 0;
			List<Transform> list = this.plane;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			List<Transform> list2 = this.planeRoof;
			int size2 = list2._size;
			list2._size = num;
			if (size2 > 0)
			{
			}
			List<IceRoad> list3 = this.iceRoads;
			int size3 = list3._size;
			list3._size = num;
			if (size3 > 0)
			{
			}
			IEnumerator enumerator = this.background.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				bool flag;
				while (!flag)
				{
				}
				List<Transform> list4 = this.plane;
				GameObject gameObject = Resources.Load<GameObject>("Background/IceRoad");
				GameObject gameObject2;
				IceRoad component = gameObject2.GetComponent<IceRoad>();
				List<IceRoad> list5 = this.iceRoads;
				component.theRow = num;
				float num2 = this.boardMaxX;
				component.roadStartX = num2;
				component.x = num2;
				List<Transform> list6 = this.planeRoof;
				num++;
			}
			Transform transform;
			if (transform != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x0003A258 File Offset: 0x00038458
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x91F7D0", Offset = "0x91DDD0", VA = "0x18091F7D0")]
	private void SetBoundaries()
	{
		Mouse instance = Mouse.Instance;
		int num = this.columnNum;
		float boxXFromColumn = instance.GetBoxXFromColumn(num);
		this.boardMaxY = 6.5f;
		this.boardMinX = -10f;
		this.plantMaxVisionX = boxXFromColumn;
		Mouse instance2 = Mouse.Instance;
		int num2 = this.columnNum;
		float boxXFromColumn2 = instance2.GetBoxXFromColumn(num2);
		this.boardMaxX = boxXFromColumn2;
		Mouse instance3 = Mouse.Instance;
		int num3 = this.rowNum;
		float boxYFromRow = instance3.GetBoxYFromRow(num3);
		this.boardMinY = boxYFromRow;
		Mouse instance4 = Mouse.Instance;
		int num4 = this.columnNum;
		float boxXFromColumn3 = instance4.GetBoxXFromColumn(num4);
		this.zombieMinX = -10f;
		this.zombieMaxX = boxXFromColumn3;
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x0003A30C File Offset: 0x0003850C
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x9247B0", Offset = "0x922DB0", VA = "0x1809247B0")]
	private void SetUniqueLevel()
	{
		for (;;)
		{
			int num = 0;
			if (!LevelManager.TryGetLevelData(num))
			{
				LevelType theBoardType = GameAPP.theBoardType;
				int theBoardLevel = GameAPP.theBoardLevel;
				SceneType sceneType = UIMgr.GetSceneType(theBoardType, theBoardLevel);
				this.sceneType = sceneType;
				int theBoardLevel2 = GameAPP.theBoardLevel;
				global::LevelData exploreData = ExploreDataManager.GetExploreData(GameAPP.theBoardLevel);
				BoardConfig boardConfig;
				if (exploreData != 0)
				{
					boardConfig = this.config;
					float nextWaveInterval = exploreData.nextWaveInterval;
					boardConfig.waveInterval = nextWaveInterval;
				}
				if (boardConfig != 0)
				{
					float firstWaveCountdown = exploreData.firstWaveCountdown;
					this.timeUntilNextWave = firstWaveCountdown;
				}
				BoardConfig boardConfig2 = this.config;
				int num2 = exploreData.theSun;
				this.theSun = num2;
				float zombieHealthMultiplier = exploreData.zombieHealthMultiplier;
				boardConfig2.zombieHealthMultiplier = zombieHealthMultiplier;
				BoardConfig boardConfig3 = this.config;
				float zombieSpeedAdder = exploreData.zombieSpeedAdder;
				boardConfig3.zombieSpeedMultiplier = zombieSpeedAdder;
				bool convay = exploreData.convay;
				this.boardTag.isConvey = convay;
				if (convay)
				{
					this.cardBank = num != 0;
					this.boardTag.disableSelectCard = true;
					TutorManager tutorManager = this.AddComponent<TutorManager>();
					this.boardTag.isTutor = true;
					int num3 = GameAPP.theBoardLevel;
					num3 += -9;
					if (num3 <= 9)
					{
						this.boardTag.disableSelectCard = true;
						this.boardTag.isConvey = true;
						this.timeUntilNextWave = 3f;
						this.boardTag.disableSelectCard = true;
						this.boardTag.isConvey = true;
						this.timeUntilNextWave = 3f;
						this.rowNum = (int)((ulong)6L);
						this.columnNum = (int)((ulong)11L);
						this.boardTag.isNight = true;
					}
					this.boardTag.isTowerDefence = true;
					this.boardTag.disableMower = true;
					this.AddComponent<TowerManager>().board = this;
					int theBoardLevel3 = GameAPP.theBoardLevel;
					TowerData.SetBoxData(this, theBoardLevel3);
					this.theSun = (int)((ulong)200L);
					this.boardTag.snowBoss = true;
					this.cardBank = num != 0;
					this.boardTag.disableSelectCard = true;
					this.boardTag.isConvey = true;
					GameAPP.config.difficulty = (int)((ulong)5L);
					BoardConfig boardConfig4 = this.config;
					this.timeUntilNextWave = 3f;
					boardConfig4.waveInterval = 10f;
					this.config.zombieHealthMultiplier = 1.4f;
					this.boardTag.enableAllTravelPlant = true;
					TravelMgr instance = TravelMgr.Instance;
					int theBoardLevel4 = GameAPP.theBoardLevel;
					if (instance == 0)
					{
						goto IL_025D;
					}
					if (instance != 0)
					{
						if (theBoardLevel4 == 1)
						{
							TravelMgr instance2 = TravelMgr.Instance;
							this.boardTag.freeGloveZombie = true;
							goto IL_025D;
						}
						continue;
					}
					IL_027C:
					this.theSun = (int)((ulong)1000L);
					this.boardTag.disableSelectCard = true;
					int num4 = GameAPP.theBoardLevel;
					num4 += -7;
					if (num4 > 31)
					{
						continue;
					}
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.boardTag.isIndestructible = true;
					this.boardTag.disableSummonZombie = true;
					this.theSun = (int)((ulong)5000L);
					this.boardTag.isEndless = true;
					this.boardTag.isSuperRandom = true;
					this.theSun = (int)((ulong)3000L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					TravelMgr.Instance.data.travelProcess = (TravelProcess)((ulong)2L);
					this.boardTag.isEndless = true;
					this.boardTag.ultimateEndless = true;
					this.boardTag.enableAllTravelPlant = true;
					this.boardTag.disableSelectCard = true;
					TravelMgr instance3 = TravelMgr.Instance;
					this.theSun = (int)((ulong)1500L);
					TravelMgr.Instance.data.travelProcess = (TravelProcess)((ulong)1L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.boardTag.randomTravel = true;
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.boardTag.isEndless = true;
					this.boardTag.randomTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.boardTag.isEndless = true;
					this.config.zombieHealthMultiplier = 2f;
					this.boardTag.isEndless = true;
					this.config.zombieHealthMultiplier = 1.5f;
					this.boardTag.isRogue = true;
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.boardTag.disableMower = true;
					this.boardTag.isEndless = true;
					GameAPP.config.difficulty = (int)((ulong)5L);
					this.lockedDifficulty = (int)((ulong)5L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					TravelMgr.Instance.data.travelDifficulty = (TravelDifficulty)((ulong)2L);
					TravelMgr.Instance.data.routeBossType = (ZombieType)((ulong)234L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					GameAPP.config.difficulty = (int)((ulong)5L);
					this.lockedDifficulty = (int)((ulong)5L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					TravelMgr.Instance.data.travelDifficulty = (TravelDifficulty)((ulong)2L);
					TravelMgr.Instance.data.routeBossType = (ZombieType)((ulong)234L);
					TravelMgr.Instance.data.travelDifficulty = (TravelDifficulty)((ulong)3L);
					this.boardTag.isTravel = true;
					this.boardTag.enableTravelPlant = true;
					this.thePoints = 5000f;
					TravelMgr.Instance.data.travelDifficulty = (TravelDifficulty)((ulong)3L);
					TravelMgr.Instance.data.routeBossType = (ZombieType)((ulong)234L);
					this.boardTag.isNight = true;
					int num5 = GameAPP.theBoardLevel;
					num5 += -25;
					if (num5 <= 5)
					{
						this.config.izDropCount = (int)((ulong)2L);
						this.boardTag.isRoof = true;
						this.config.izDropCount = (int)((ulong)4L);
						this.boardTag.isRoof = true;
					}
					this.config.izDropCount = (int)((ulong)4L);
					int num6 = GameAPP.theBoardLevel;
					num6 += -15;
					if (num6 <= 159)
					{
						break;
					}
					continue;
					IL_025D:
					this.boardTag.isConvey = true;
					this.cardBank = num != 0;
					this.boardTag.disableSelectCard = true;
					goto IL_027C;
				}
			}
		}
		this.theSun = (int)((ulong)1000L);
		this.boardTag.isNormalRandom = true;
		this.boardTag.isScaredyDream = true;
		this.theSun = (int)((ulong)1500L);
		this.boardTag.isSuperRandom = true;
		this.boardTag.isSeedRain = true;
		GameObject gameObject = Resources.Load<GameObject>("Image/Rain/RainPrefab");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = base.transform;
		this.theSun = (int)((ulong)300L);
		this.boardTag.isIndestructible = true;
		this.theSun = (int)((ulong)7500L);
		this.boardTag.disableSummonZombie = true;
		this.theSun = (int)((ulong)3000L);
		this.boardTag.isSuperRandom = true;
		this.boardGame = (BoardGame)((ulong)1L);
		this.boardTag.disableSelectCard = true;
		this.cardBank = gameObject != null;
		this.timeUntilNextWave = 3f;
		this.boardTag.enableAllTravelPlant = true;
		this.boardTag.isMirror = true;
		TravelMgr instance4 = TravelMgr.Instance;
		this.boardTag.isExchange = true;
		this.boardTag.disableSelectCard = true;
		this.timeUntilNextWave = 3f;
		TravelMgr instance5 = TravelMgr.Instance;
		this.boardTag.isSuperRandom = true;
		this.boardTag.isExchange = true;
		this.boardTag.disableSelectCard = true;
		this.boardTag.isColumn = true;
		this.boardTag.enableAllTravelPlant = true;
		this.boardTag.shooting_loon = true;
		float num7 = this.moneyEfficiency * 100000f;
		BoardStatistics boardStatistics = this.boardStatistics;
		int num8 = this.maxMoney;
		this.theMoney = num8;
		this.theMoney = gameObject;
		int num9 = this.theMaxWave;
		this.boardTag.isConvey = true;
		this.boardTag.disableSelectCard = true;
		this.cardBank = gameObject != null;
		this.boardTag.isBoss = true;
		this.theWave = num9;
		this.fakeTrophy = true;
		this.boardTag.isConvey = true;
		this.boardTag.disableSelectCard = true;
		this.cardBank = gameObject != null;
		this.boardTag.enableAllTravelPlant = true;
		this.boardTag.isSuperRandom = true;
		TravelMgr instance6 = TravelMgr.Instance;
		TravelMgr instance7 = TravelMgr.Instance;
		TravelMgr instance8 = TravelMgr.Instance;
		TravelMgr instance9 = TravelMgr.Instance;
		TravelMgr instance10 = TravelMgr.Instance;
		TravelMgr instance11 = TravelMgr.Instance;
		TravelMgr instance12 = TravelMgr.Instance;
		this.boardTag.isShooting = true;
		uint num10;
		this.AddLightLevel((int)num10);
		this.boardTag.isObsidianImp = true;
		int num11 = 0;
		this.boardTag.enableAllTravelPlant = true;
		ulong num12;
		this.EnableTravelBuff(num12 != 0UL, num11 != 0);
		List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
		List<AdvBuff> advBuffs2 = TravelMgr.Instance.data.advBuffs;
		this.timeUntilNextWave = 30f;
		TravelMgr instance13 = TravelMgr.Instance;
		TravelMgr instance14 = TravelMgr.Instance;
		TravelMgr instance15 = TravelMgr.Instance;
		TravelMgr instance16 = TravelMgr.Instance;
		TravelMgr instance17 = TravelMgr.Instance;
		TravelMgr instance18 = TravelMgr.Instance;
		TravelMgr instance19 = TravelMgr.Instance;
		this.boardTag.isGarden = true;
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0003AC54 File Offset: 0x00038E54
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x9204B0", Offset = "0x91EAB0", VA = "0x1809204B0")]
	private void SetPrePlants()
	{
		for (;;)
		{
			CreatePlant instance = CreatePlant.Instance;
			int num = 0;
			if (this.rowNum > 0)
			{
				CreatePlant instance2 = CreatePlant.Instance;
				num++;
			}
			num++;
			LevelType theBoardType = GameAPP.theBoardType;
			if (theBoardType == LevelType.Advanture)
			{
				goto IL_007C;
			}
			int num2;
			if (theBoardType != LevelType.Advanture)
			{
				if (theBoardType == LevelType.Advanture)
				{
					return;
				}
				if (theBoardType == LevelType.Advanture)
				{
					goto IL_0093;
				}
				if (theBoardType != LevelType.Challenge)
				{
					return;
				}
				List<PrePlantData> prePlant = ExploreDataManager.GetExploreData(GameAPP.theBoardLevel).prePlant;
				bool flag;
				if (flag)
				{
					CreatePlant instance3 = CreatePlant.Instance;
				}
				if (num == 0)
				{
					num2 = 0;
					goto IL_007C;
				}
				continue;
			}
			IL_009D:
			int theBoardLevel = GameAPP.theBoardLevel;
			if (theBoardLevel > 121)
			{
				int num4;
				if (theBoardLevel > 138)
				{
					if (theBoardLevel != 159)
					{
						continue;
					}
					CreatePlant instance4 = CreatePlant.Instance;
					CreatePlant instance5 = CreatePlant.Instance;
					CreatePlant instance6 = CreatePlant.Instance;
					CreatePlant instance7 = CreatePlant.Instance;
					CreatePlant instance8 = CreatePlant.Instance;
					CreatePlant instance9 = CreatePlant.Instance;
					CreatePlant instance10 = CreatePlant.Instance;
					if (0 == 162)
					{
						CreatePlant instance11 = CreatePlant.Instance;
						CreatePlant instance12 = CreatePlant.Instance;
						CreatePlant instance13 = CreatePlant.Instance;
					}
					uint num3;
					if (num3 != (uint)170)
					{
						return;
					}
					CreatePlant instance14 = CreatePlant.Instance;
					CreatePlant instance15 = CreatePlant.Instance;
					CreatePlant instance16 = CreatePlant.Instance;
					CreatePlant instance17 = CreatePlant.Instance;
					num4 = 0;
					CreatePlant instance18 = CreatePlant.Instance;
				}
				if (num4 == 128)
				{
					break;
				}
				uint num5;
				if (num5 != (uint)130)
				{
					continue;
				}
				CreatePlant instance19 = CreatePlant.Instance;
				CreatePlant instance20 = CreatePlant.Instance;
				CreatePlant instance21 = CreatePlant.Instance;
				CreatePlant instance22 = CreatePlant.Instance;
				CreatePlant instance23 = CreatePlant.Instance;
				CreatePlant instance24 = CreatePlant.Instance;
				CreatePlant instance25 = CreatePlant.Instance;
				if (0 != 138)
				{
					continue;
				}
				CreatePlant instance26 = CreatePlant.Instance;
			}
			uint num6;
			if (num6 > (uint)101)
			{
				if (num6 != (uint)108)
				{
					continue;
				}
				CreatePlant instance27 = CreatePlant.Instance;
				if (0 != 113)
				{
					continue;
				}
				CreatePlant instance28 = CreatePlant.Instance;
				CreatePlant instance29 = CreatePlant.Instance;
				CreatePlant instance30 = CreatePlant.Instance;
				CreatePlant instance31 = CreatePlant.Instance;
				CreatePlant instance32 = CreatePlant.Instance;
				if (0 != 121)
				{
					continue;
				}
				CreatePlant instance33 = CreatePlant.Instance;
				CreatePlant instance34 = CreatePlant.Instance;
				CreatePlant instance35 = CreatePlant.Instance;
				CreatePlant instance36 = CreatePlant.Instance;
				CreatePlant instance37 = CreatePlant.Instance;
				CreatePlant instance38 = CreatePlant.Instance;
			}
			if (18446744073709551615UL <= (ulong)5L)
			{
				goto Block_20;
			}
			continue;
			IL_0093:
			CreatePlant instance39 = CreatePlant.Instance;
			goto IL_009D;
			IL_007C:
			CreatePlant instance40 = CreatePlant.Instance;
			num2++;
			uint num7;
			num7 += (uint)1;
			goto IL_0093;
		}
		CreatePlant instance41 = CreatePlant.Instance;
		CreatePlant instance42 = CreatePlant.Instance;
		return;
		Block_20:
		CreatePlant instance43 = CreatePlant.Instance;
		CreatePlant instance44 = CreatePlant.Instance;
		CreatePlant instance45 = CreatePlant.Instance;
		CreatePlant instance46 = CreatePlant.Instance;
		CreatePlant instance47 = CreatePlant.Instance;
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0003AED0 File Offset: 0x000390D0
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x91FE10", Offset = "0x91E410", VA = "0x18091FE10")]
	private void SetFreezedPlant()
	{
		List<Vector2Int> list = new List();
		int num = this.columnNum;
		int num2 = 0;
		if (num < this.columnNum)
		{
			if (this.rowNum > 0)
			{
				int num3 = this.rowNum;
				num2++;
			}
			num++;
		}
		int num4 = list._size;
		int num5 = global::UnityEngine.Random.Range(0, num4);
		num4 = num5;
		Vector2Int vector2Int = list[num4];
		num4 = num5;
		Vector2Int vector2Int2 = list[num4];
		int x = vector2Int.m_X;
		int num6 = num5;
		list.RemoveAt(num6);
		num2++;
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0003AF60 File Offset: 0x00039160
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x920000", Offset = "0x91E600", VA = "0x180920000")]
	private void SetGrave()
	{
		List<Vector2Int> list = new List();
		int num = this.columnNum;
		int num2 = 0;
		if (num < this.columnNum)
		{
			if (this.rowNum > 0)
			{
				int num3 = this.rowNum;
				num2++;
			}
			num++;
		}
		int difficulty = GameAPP.config.difficulty;
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if ((flag ? 1 : 0) * difficulty > 0)
		{
			int num4 = list._size;
			int num5 = global::UnityEngine.Random.Range(0, num4);
			num4 = num5;
			num = num5;
			Vector2Int vector2Int = list[num4];
			num4 = num;
			int num6 = list[num4].m_X;
			int x = vector2Int.m_X;
			num6 = num;
			list.RemoveAt(num6);
			num2++;
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0003B00C File Offset: 0x0003920C
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x91C9B0", Offset = "0x91AFB0", VA = "0x18091C9B0")]
	private void InitIZSettings()
	{
		BrainManager brainManager = new BrainManager(this);
		this.brainManager = brainManager;
		this.config.minOriginalSpeed = 1.3f;
		this.config.maxOriginalSpeed = 1.3f;
		int num = GameAPP.theBoardLevel;
		int num2;
		if (num == 1)
		{
			if (!this.isAutoEve)
			{
				num2 = 0;
				if (this.rowNum > num2)
				{
					if (this.gridSystem.GetBoxType(num2, num2) == BoxType.Grass)
					{
						int num3 = 0;
						Plant plant = this.SetEvePlants(num2, num2, num3 != 0);
					}
					num2++;
				}
				num2++;
			}
			this.theSun = (int)((ulong)30000L);
			return;
		}
		num += -25;
		if (num2 != 5)
		{
			if (num2 != 5)
			{
				if (num != 1)
				{
					this.theSun = (int)((ulong)1000L);
				}
				this.theSun = (int)((ulong)275L);
			}
			this.theSun = (int)((ulong)150L);
		}
		this.theSun = (int)((ulong)225L);
		OldIZLevel.SetPlants(GameAPP.theBoardLevel);
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x0003B17C File Offset: 0x0003937C
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x91B670", Offset = "0x919C70", VA = "0x18091B670")]
	private void EveUpdate()
	{
		float num = this.eveCountDown;
		float deltaTime = Time.deltaTime;
		this.eveCountDown = num;
		float deltaTime2 = Time.deltaTime;
		this.eveCurrentTime = deltaTime2;
		float num2;
		if (num2 > 1f)
		{
		}
		int num3 = 0;
		if (num3 > (int)this.eveCountDown)
		{
			int num4 = 0;
			int i = num4;
			int num5 = this.rowNum;
			if (i < num5)
			{
				BoxType[] array = this.roadType;
				int j = i;
				if ("{il2cpp array field local13->}" != (ulong)1L)
				{
					List<Brain> brains = this.brainManager.brains;
					Func<Brain, bool> func = delegate(Brain brain)
					{
						int i3 = i;
						return brain.theRow == i3;
					};
					if (Enumerable.FirstOrDefault<Brain>(brains, func))
					{
						CreateZombie instance = CreateZombie.Instance;
						int i2 = i;
						Zombie zombie = instance.SetZombie(i2, (ZombieType)((uint)105), 9.9f, num4 != 0);
					}
				}
			}
			if (num3 > (int)num2 || num2 > 1f)
			{
			}
			float num6 = (float)(num3 * (int)(-4f));
			this.eveCountDown = num6;
		}
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0003B284 File Offset: 0x00039484
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x923E30", Offset = "0x922430", VA = "0x180923E30")]
	private void SetRandomZombies(float t)
	{
		int num = 0;
		int i = num;
		int num2 = this.rowNum;
		if (i < num2)
		{
			BoxType[] array = this.roadType;
			int j = i;
			if ("{il2cpp array field local6->}" != (ulong)1L)
			{
				List<Brain> brains = this.brainManager.brains;
				Func<Brain, bool> func = delegate(Brain brain)
				{
					int i3 = i;
					return brain.theRow == i3;
				};
				if (Enumerable.FirstOrDefault<Brain>(brains, func))
				{
					CreateZombie instance = CreateZombie.Instance;
					int i2 = i;
					Zombie zombie = instance.SetZombie(i2, (ZombieType)((uint)105), 9.9f, num != 0);
				}
			}
		}
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x0003B320 File Offset: 0x00039520
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x929CF0", Offset = "0x9282F0", VA = "0x180929CF0")]
	private bool WheatLimit(PlantType plantType)
	{
		bool flag;
		bool flag2;
		bool flag3;
		bool flag4;
		bool flag5;
		if (!flag && !flag2 && !flag3 && !flag4 && !flag5 && flag5 <= true)
		{
			if (plantType > PlantType.SuperGatling)
			{
				if (plantType > PlantType.SuperHypnoGatling)
				{
					if (plantType > PlantType.GarlicSniper)
					{
						if (plantType == PlantType.SuperCherryGatling || flag5 <= true || plantType == PlantType.StarSniper)
						{
							return true;
						}
						return false;
					}
					else
					{
						while (plantType == PlantType.SunJalapeno)
						{
						}
					}
				}
				if (plantType > PlantType.DoomSniper)
				{
				}
				while (plantType == PlantType.SpruceBallista)
				{
				}
				while (flag5 <= true)
				{
				}
			}
			int i;
			if (plantType > PlantType.SniperPea)
			{
				if (plantType > PlantType.SuperMachineNut)
				{
					while (plantType == PlantType.SuperSnowGatling)
					{
					}
					while (flag5 <= true)
					{
					}
					i = 0;
				}
				while (plantType == PlantType.CobCannon)
				{
				}
			}
			if (plantType > PlantType.SpikeRock)
			{
				while (plantType == PlantType.GloomShroom)
				{
				}
			}
			while (i <= 1)
			{
			}
			while (plantType == PlantType.SpikeRock)
			{
			}
			return false;
		}
		return true;
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0003B3E8 File Offset: 0x000395E8
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x91F900", Offset = "0x91DF00", VA = "0x18091F900")]
	public Plant SetEvePlants(int theColumn, int theRow, bool fromWheat = false)
	{
		int num4;
		do
		{
			if (fromWheat)
			{
				List<PlantType> allPlantTypes = global::Lawnf.GetAllPlantTypes();
				Predicate<PlantType> predicate = (PlantType p) => this.WheatLimit(p);
				int num = allPlantTypes.RemoveAll(predicate);
				int num2 = allPlantTypes._size;
				num2 = global::UnityEngine.Random.Range(0, num2);
				PlantType plantType = allPlantTypes[num2];
				CreatePlant instance = CreatePlant.Instance;
				int num3 = 0;
				Plant plant;
				if (!(plant != num3))
				{
					float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
					float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
				}
			}
			List<Plant> list = global::Lawnf.Get1x1Plants(theColumn - 1, theColumn);
			num4 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num4 != 0);
		bool flag2;
		if (flag2)
		{
			CreatePlant instance2 = CreatePlant.Instance;
			CreatePlant instance3 = CreatePlant.Instance;
		}
		CreatePlant instance4 = CreatePlant.Instance;
		int num5 = 0;
		Plant plant2;
		if (plant2 != num5 && plant2.thePlantType == PlantType.Hamburger)
		{
			plant2.thePlantStage = (int)((ulong)3L);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0003B4F0 File Offset: 0x000396F0
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x91D340", Offset = "0x91B940", VA = "0x18091D340")]
	private void LevelUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.zombieHealthUpdater = deltaTime;
		float deltaTime2 = Time.deltaTime;
		int num = 0;
		float num2 = this.zombieHealthUpdater;
		int num3 = 0;
		this.lastRandomBuffTime = (float)num;
		if (num2 > 1f)
		{
			this.zombieHealthUpdater = 0f;
			this.UpdateZombieHealth();
		}
		float num4 = this.theFallingSunCountDown;
		float deltaTime3 = Time.deltaTime;
		this.theFallingSunCountDown = num4;
		if (num3 > (int)num4)
		{
			int num5 = global::UnityEngine.Random.Range(-3, 5);
			GameObject gameObject = GameAPP.itemPrefab[9];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			PlantType random = ListExtensions.GetRandom<PlantType>(this.seedPool);
			component.thePlantType = random;
			component.movingWay = (int)((ulong)1L);
			component.onCardBank = true;
			component.theSeedCost = (int)((ulong)0L);
			this.theFallingSunCountDown = 6f;
		}
		if (this.fallSun)
		{
			this.SunUpdate();
		}
		this.MeteoriteUpdate();
		this.LevelUpUpdate();
		float num6 = this.randomPresentTime;
		float deltaTime4 = Time.deltaTime;
		this.randomPresentTime = num6;
		if (num3 > (int)num6)
		{
			this.randomPresentTime = 60f;
			this.CreateRandomPresent();
		}
		float num7 = this.randomDataUpdateTimer;
		float deltaTime5 = Time.deltaTime;
		this.randomDataUpdateTimer = num7;
		this.randomDataUpdateTimer = 150f;
		this.UpdateRandomData(true);
		if (num3 == (int)num7)
		{
			this.NewZombieUpdate();
		}
		float deltaTime6 = Time.deltaTime;
		this.iceDoomFreezeTime = num7;
		this.iceDoomFreezeTime = 0f;
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0003B674 File Offset: 0x00039874
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x91D040", Offset = "0x91B640", VA = "0x18091D040")]
	private void LevelUpUpdate()
	{
		float num3;
		int num4;
		ulong num6;
		do
		{
			int num = 0;
			float num2 = this.happyRandomCardTimer;
			float deltaTime = Time.deltaTime;
			this.happyRandomCardTimer = num2;
			num3 = this.happyRecoverTimer;
			float deltaTime2 = Time.deltaTime;
			this.happyRecoverTimer = num3;
			num4 = 0;
			if (num4 <= (int)num3)
			{
				break;
			}
			this.happyRecoverTimer = 10f;
			List<Plant> plantArray = this.boardEntity.plantArray;
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
		while (num6 != (ulong)0L);
		if (num3 > 0.3f)
		{
			BoardConfig boardConfig = this.config;
			if (num4 > (int)num3 || num3 > 1f)
			{
			}
			float num7 = (float)(num4 * (int)9f);
			boardConfig.zombieHealthMultiplier = num7;
		}
		if (num4 > (int)this.happyRandomCardTimer)
		{
			int num8 = 0;
			if ((this.happyRandomCard ? 1 : 0) != num8)
			{
				this.happyRandomCardTimer = 60f;
				this.RefreshHappyRandomCards();
				this.happyRandomCardTimer = 90f;
				this.RefreshHappyRandomCards();
			}
			this.happyRandomCard = true;
			this.RefreshHappyRandomCards();
			this.happyRandomCardTimer = 90f;
		}
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0003B77C File Offset: 0x0003997C
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x91F190", Offset = "0x91D790", VA = "0x18091F190")]
	private void RefreshHappyRandomCards()
	{
		CardUI cardAtIndex = InGameUI.Instance._cardSlotManager.GetCardAtIndex(10);
		int num = 0;
		if (cardAtIndex != num)
		{
			global::UnityEngine.Object.Destroy(cardAtIndex.gameObject);
			bool flag = InGameUI.Instance._cardSlotManager.RemoveCard(cardAtIndex, true);
		}
		this.GetHappyRandomCard();
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0003B7D4 File Offset: 0x000399D4
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x91B990", Offset = "0x919F90", VA = "0x18091B990")]
	public void GetHappyRandomCard()
	{
		PlantType happyRandomPlantType = global::Lawnf.GetHappyRandomPlantType(this);
		int num = (int)happyRandomPlantType;
		CardUI cardUI;
		ulong num2;
		bool flag = InGameUI.Instance.AddCardToBank(cardUI, num2 != 0UL);
		int randomPlantLevel = global::Lawnf.GetRandomPlantLevel();
		cardUI.SetLevel(randomPlantLevel);
		PlantDataManager.PlantData plantData;
		int cost = plantData.cost;
		cardUI.theSeedCost = cost;
		int num3;
		num3 += cost;
		long num4 = (long)(num * (int)((uint)100));
		num4 += (long)num3;
		cardUI.theSeedCost = (int)num4;
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x0003B844 File Offset: 0x00039A44
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x9276C0", Offset = "0x925CC0", VA = "0x1809276C0")]
	private void SinglePresentUpdate()
	{
		float num = this.randomPresentTime;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.randomPresentTime = num;
		if (num2 > (int)num)
		{
			this.randomPresentTime = 60f;
			this.CreateRandomPresent();
		}
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x0003B880 File Offset: 0x00039A80
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x919FF0", Offset = "0x9185F0", VA = "0x180919FF0")]
	private void CreateRandomPresent()
	{
		Vector2Int randomBox = global::Lawnf.GetRandomBox(this);
		Vector2Int randomBox2 = global::Lawnf.GetRandomBox(this);
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		Plant plant;
		Present component = plant.GetComponent<Present>();
		Collider2D[] components = component.GetComponents<Collider2D>();
		if (num < components.Length)
		{
			num++;
		}
		component.buff = true;
		InGameText instance2 = InGameText.Instance;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0003B8E4 File Offset: 0x00039AE4
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x929150", Offset = "0x927750", VA = "0x180929150")]
	private void UpdateZombieHealth()
	{
		int num4;
		do
		{
			int num = 0;
			List<Zombie> list = this.zombieArray;
			int num2 = 0;
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
				goto IL_005D;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				if (flag3)
				{
					int num5 = 0;
					if (!(num != num5))
					{
						continue;
					}
				}
				if (num4 != 0)
				{
					goto IL_0063;
				}
			}
		}
		while (num4 != 0);
		return;
		IL_005D:
		throw new NullReferenceException();
		IL_0063:
		throw new NullReferenceException();
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0003B95C File Offset: 0x00039B5C
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x927E30", Offset = "0x926430", VA = "0x180927E30")]
	private void SunUpdate()
	{
		int num4;
		CreateItem instance2;
		do
		{
			float num = this.theFallingSunCountDown;
			float deltaTime = Time.deltaTime;
			this.theFallingSunCountDown = num;
			Solar instance = Solar.Instance;
			int num2 = 0;
			if (instance != num2)
			{
				float num3 = this.theFallingSunCountDown;
				float deltaTime2 = Time.deltaTime;
				this.theFallingSunCountDown = num3;
			}
			if (0 <= (int)this.theFallingSunCountDown)
			{
				return;
			}
			num4 = global::UnityEngine.Random.Range(3, 9);
			int theBoardLevel = GameAPP.theBoardLevel;
			if (theBoardLevel > 56)
			{
				if (theBoardLevel > 112 && theBoardLevel == 136)
				{
					goto IL_00DB;
				}
				instance2 = CreateItem.Instance;
				if (instance2 == (ulong)112L)
				{
					goto IL_00DB;
				}
			}
			if (instance2 <= (ulong)17L)
			{
				goto IL_00CA;
			}
			if (instance2 == (ulong)39L)
			{
				goto IL_00DB;
			}
		}
		while (instance2 != (ulong)48L);
		CreateItem instance3 = CreateItem.Instance;
		CreateItem instance4 = CreateItem.Instance;
		CreateItem instance5 = CreateItem.Instance;
		CreateItem instance6 = CreateItem.Instance;
		if (CreateItem.Instance == (ulong)56L)
		{
			goto IL_00DB;
		}
		IL_00CA:
		if (typeof(CreateItem).TypeHandle != (ulong)4294967293L)
		{
			goto IL_00F0;
		}
		IL_00DB:
		CreateItem instance7 = CreateItem.Instance;
		CreateItem instance8 = CreateItem.Instance;
		CreateItem instance9 = CreateItem.Instance;
		IL_00F0:
		int num5 = 0;
		CreateItem instance10 = CreateItem.Instance;
		int num6 = 0;
		ulong num7;
		GameObject gameObject = instance10.SetCoin(num4, -1, num6, (int)num7, num5, num5 != 0);
		this.theFallingSunCountDown = 7.5f;
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x0003BA8C File Offset: 0x00039C8C
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x91F580", Offset = "0x91DB80", VA = "0x18091F580")]
	private void SeedRainUpdate()
	{
		float num = this.theFallingSunCountDown;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.theFallingSunCountDown = num;
		if (num2 > (int)num)
		{
			int num3 = global::UnityEngine.Random.Range(-3, 5);
			GameObject gameObject = GameAPP.itemPrefab[9];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			PlantType random = ListExtensions.GetRandom<PlantType>(this.seedPool);
			component.thePlantType = random;
			component.movingWay = (int)((ulong)1L);
			component.onCardBank = true;
			component.theSeedCost = (int)((ulong)0L);
			this.theFallingSunCountDown = 6f;
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0003BB24 File Offset: 0x00039D24
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x91CE20", Offset = "0x91B420", VA = "0x18091CE20")]
	private void InitSeedPool()
	{
		int num = 0;
		List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
		PlantType plantType = GameAPP.resourcesManager.allPlants[num];
		int num2 = (int)plantType;
		if (plantType > PlantType.TallNut)
		{
			if (plantType == PlantType.CobCannon || plantType == PlantType.SpruceBallista)
			{
				goto IL_00A3;
			}
			if (plantType > (PlantType)46)
			{
				goto IL_0073;
			}
		}
		if ((num2 > 252 && (num2 == 255 || num2 == 912 || num2 == 1027)) || num2 == 1 || num2 == 234 || plantType <= PlantType.CherryBomb)
		{
			goto IL_00A3;
		}
		IL_0073:
		bool flag;
		if (!flag && num2 != 918)
		{
			SceneType sceneType = this.sceneType;
			bool flag2;
			if (plantType <= PlantType.SunFlower || sceneType == SceneType.SuperPool || plantType <= PlantType.WallNut || !flag2)
			{
				List<PlantType> list = this.seedPool;
			}
		}
		IL_00A3:
		num++;
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0003BBE0 File Offset: 0x00039DE0
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x91DB60", Offset = "0x91C160", VA = "0x18091DB60")]
	private void NewZombieUpdate()
	{
		GameObject gameObject4;
		for (;;)
		{
			int num = 0;
			int num2 = this.theMaxWave;
			if (this.theWave < num2)
			{
				if (this.theWave > num2 && this.theMaxWave > 12)
				{
					int num3 = this.theMaxWave;
					this.theWave = num3;
				}
				this.punishTime = 180f;
				float num4 = this.timeUntilNextWave;
				float deltaTime = Time.deltaTime;
				this.timeUntilNextWave = num4;
				float num5 = this.holdOnTime;
				float deltaTime2 = Time.deltaTime;
				this.holdOnTime = num5;
				if (this.theWave <= 0)
				{
					goto IL_00E4;
				}
				float num6 = this.zombieSpawnHealth;
				BoardConfig boardConfig = this.config;
				if (deltaTime2 <= boardConfig.holdTimer)
				{
					goto IL_00E4;
				}
				float num7 = this.timeUntilNextWave;
				float holdTimer = boardConfig.holdTimer2;
				if (holdTimer <= num7)
				{
					num7 = holdTimer;
				}
				this.timeUntilNextWave = num7;
				int num8 = 0;
				this.holdOnTime = (float)num8;
				int num9 = this.theWave;
				ulong num10;
				num10 += num10;
				if ((ulong)num9 == num10)
				{
					this.SupplyGrave();
					goto IL_00E4;
				}
				IL_00E7:
				if (0 <= (int)this.timeUntilNextWave)
				{
					return;
				}
				int num14;
				if (this.theWave == 0)
				{
					InGameUI instance = InGameUI.Instance;
					ulong num11;
					InGameUI.Instance.progress2.SetActive(num11 != 0UL);
					GameObject gameObject = InGameUI.Instance.LevelName2.gameObject;
					int num12 = 0;
					gameObject.SetActive(num12 != 0);
					ulong num13;
					InGameUI.Instance.LevelName3.gameObject.SetActive(num13 != 0UL);
					if (this.rowNum > 0)
					{
						CreateZombie instance2 = CreateZombie.Instance;
						num14++;
					}
				}
				int num15 = this.theWave;
				num15++;
				ulong num16;
				num16 += num16;
				num16 += num16;
				float deltaTime3;
				BoardConfig boardConfig2;
				if ((ulong)num15 == num16)
				{
					if (!this.isHugeWave)
					{
						this.isHugeWave = true;
						uint num17;
						GameAPP.PlaySound((int)num17, 0.5f, 1f);
						GameObject gameObject2 = Resources.Load<GameObject>("Board/RSP/HugeWavePrefab");
						int num18 = 0;
						if (!(gameObject2 == num18))
						{
							GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2);
							string name = gameObject2.name;
							gameObject3.name = name;
							Transform transform = gameObject3.transform;
							Transform transform2 = base.transform;
							transform.parentInternal = transform2;
						}
						Debug.LogError("hugeWavePrefab预制体加载错误");
						SceneType sceneType = this.sceneType;
						if ((sceneType > SceneType.Snow_6 && sceneType == SceneType.SnowPool) || sceneType == (SceneType)(-3))
						{
							SnowMap.Instance.HugeWave();
						}
					}
					float num19 = this.hugeWaveCountDown;
					deltaTime3 = Time.deltaTime;
					this.hugeWaveCountDown = num19;
					boardConfig2 = this.config;
					if (deltaTime3 > boardConfig2.holdTimer3)
					{
						this.hugeWaveCountDown = (float)num14;
					}
				}
				if (deltaTime3 != boardConfig2.holdTimer3)
				{
					return;
				}
				this.isHugeWave = false;
				EventManager.TriggerEvent(GameEvent.BoardWaveAdd);
				if (this.theWave == 1)
				{
					uint num20;
					GameAPP.PlaySound((int)num20, 0.5f, 1f);
				}
				int num21 = this.theMaxWave;
				if (this.theWave != num21)
				{
					goto IL_0346;
				}
				uint num22;
				GameAPP.PlaySound((int)num22, 0.5f, 1f);
				gameObject4 = Resources.Load<GameObject>("Board/RSP/FinalWavePrefab");
				List<GridItem> list = this.griditemArray;
				bool flag;
				if (flag)
				{
					int num23 = 0;
					if (!(num != num23))
					{
						continue;
					}
					while (num == 0)
					{
					}
				}
				if (num14 == 0)
				{
					break;
				}
				continue;
				IL_00E4:
				num14 = 0;
				goto IL_00E7;
			}
			goto IL_03BB;
		}
		int num24 = 0;
		if (!(gameObject4 == num24))
		{
			Transform transform3;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject4).transform.parentInternal = transform3;
		}
		Debug.LogError("finalWavePrefab预制体加载错误");
		if (GameAPP.config.difficulty == 5)
		{
			List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
			uint num25;
			List<ZombieSpawnData> list2 = InitZombieList.zombieList[(int)num25];
			List<List<ZombieSpawnData>> zombieList2 = InitZombieList.zombieList;
			List<List<ZombieSpawnData>> zombieList3 = InitZombieList.zombieList;
		}
		IL_0346:
		ulong num26;
		num26 += num26;
		num26 += num26;
		List<ZombieSpawnData> list3;
		if (list3 == num26)
		{
			uint num27;
			GameAPP.PlaySound((int)num27, 0.5f, 1f);
		}
		TowerManager instance3 = TowerManager.Instance;
		int num28 = 0;
		if (instance3 != num28)
		{
			TowerManager.Instance.SummonZombies(num28);
		}
		ulong num29;
		num29 += num29;
		num29 += num29;
		this.boardTag.disableSummonZombie = true;
		int num30;
		Board.<CheckZombieNum>d__167 <CheckZombieNum>d__ = new Board.<CheckZombieNum>d__167(num30);
		num30 = 0;
		<CheckZombieNum>d__.<>4__this = 0;
		IL_03BB:
		if (this.enermyCount > 0)
		{
			this.SurvivalPunish();
		}
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x928310", Offset = "0x926910", VA = "0x180928310")]
	private void SupplyGrave()
	{
		List<Vector2Int> list;
		ulong num7;
		do
		{
			int num = 0;
			list = new List();
			int num2 = this.columnNum;
			if (num2 < this.columnNum)
			{
				int num3 = this.rowNum;
				int num4 = 0;
				if (num3 > 0)
				{
					num4++;
					int num5 = this.rowNum;
				}
				num2++;
			}
			List<GridItem> list2 = this.griditemArray;
			bool flag;
			if (flag)
			{
				int num6 = 0;
				if (!(num != num6))
				{
					continue;
				}
			}
		}
		while (num7 != (ulong)0L);
		int num8 = list._size;
		int num9 = global::UnityEngine.Random.Range(0, num8);
		num8 = num9;
		Vector2Int vector2Int = list[num8];
		num8 = num9;
		Vector2Int vector2Int2 = list[num8];
		int x = vector2Int.m_X;
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x0003C070 File Offset: 0x0003A270
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x91C620", Offset = "0x91AC20", VA = "0x18091C620")]
	private void HammerSummonZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			this.zombieTotalHealth = (float)num2;
			this.zombieSpawnHealth = (float)num2;
			List<Grave> list = new List();
			List<GridItem> list2 = this.griditemArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				while (num == 0)
				{
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0003C104 File Offset: 0x0003A304
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x9285F0", Offset = "0x926BF0", VA = "0x1809285F0")]
	private void SurvivalPunish()
	{
		ulong num6;
		do
		{
			int num = 0;
			float num2 = this.punishTime;
			int num3 = 0;
			if (num2 <= (float)num3)
			{
				break;
			}
			float deltaTime = Time.deltaTime;
			this.punishTime = num2;
			List<Zombie> list = new List();
			List<Zombie> list2 = this.zombieArray;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
			}
			ulong num5;
			if (num5 != (ulong)0L)
			{
				goto IL_005E;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num6 != (ulong)0L);
		return;
		IL_005E:
		throw new NullReferenceException();
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0003C178 File Offset: 0x0003A378
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x920260", Offset = "0x91E860", VA = "0x180920260")]
	public void SetHealthInTravel(Zombie z)
	{
		if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)1004)))
		{
		}
		int num = this.theCurrentSurvivalRound;
		float num3;
		float num2 = num3 * 0.4f;
		if (GameAPP.config.difficulty == 5)
		{
		}
		float num5;
		float num4 = num5 * 0.2f;
		if (global::Lawnf.TravelCurse())
		{
		}
		if (global::Lawnf.TravelInvest((InvestBuff)((uint)6)))
		{
			int theZombieType = (int)z.theZombieType;
			bool flag;
			if (!flag)
			{
			}
		}
		if (global::Lawnf.TravelInvest((InvestBuff)((uint)7)))
		{
			int theZombieType2 = (int)z.theZombieType;
			bool flag2;
			if (flag2)
			{
			}
		}
		global::Lawnf.SetZombieHealth(z, num4);
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0003C200 File Offset: 0x0003A400
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x919520", Offset = "0x917B20", VA = "0x180919520")]
	private IEnumerator CheckZombieNum()
	{
		int num;
		Board.<CheckZombieNum>d__167 <CheckZombieNum>d__ = new Board.<CheckZombieNum>d__167(num);
		num = 0;
		<CheckZombieNum>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0003C224 File Offset: 0x0003A424
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x91AEF0", Offset = "0x9194F0", VA = "0x18091AEF0")]
	public void EnterNextRound()
	{
		int num10;
		do
		{
			int num = 0;
			int num2 = this.theSurvivalMaxRound;
			if (this.theCurrentSurvivalRound >= num2)
			{
				return;
			}
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num4 = 0;
			GameAPP.music.Stop();
			GameAPP.musicDrum.Stop();
			GameAPP.prelude.audioSource.Stop();
			if (TravelMgr.Instance.data.Invest)
			{
				int num5 = this.theCurrentSurvivalRound;
				if ((TravelMgr.Instance.data.invest_challenge ? 1 : 0) != num4)
				{
				}
			}
			if (global::Lawnf.TravelCurse())
			{
			}
			TravelData data = TravelMgr.Instance.data;
			float num6;
			this.thePoints = num6;
			if (0 > (int)num6)
			{
				this.thePoints = (float)num4;
			}
			int num7 = this.theCurrentSurvivalRound;
			num7 += 9;
			num7 += num7;
			if (num7 > 0)
			{
				CreateItem instance2 = CreateItem.Instance;
				num4++;
				int num8 = this.theCurrentSurvivalRound;
				num8 += 9;
				num8 += num8;
			}
			EndlessShooting.Instance.GetCards();
			List<Zombie> list = new List();
			List<Zombie> list2 = this.zombieArray;
			bool flag;
			if (flag)
			{
				int num9 = 0;
				if (!(num != num9))
				{
					continue;
				}
			}
			if (num4 != 0)
			{
				goto IL_016F;
			}
			num10 = 0;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num10 != 0);
		int num11 = 0;
		CreateItem instance3 = CreateItem.Instance;
		num11++;
		instance3.Invoke("StartNextRound", 3f);
		return;
		IL_016F:
		throw new NullReferenceException();
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x928A50", Offset = "0x927050", VA = "0x180928A50")]
	private void Travel()
	{
		int num = this.theCurrentSurvivalRound;
		this.ShowChoice(num);
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0003C3C4 File Offset: 0x0003A5C4
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x926F70", Offset = "0x925570", VA = "0x180926F70")]
	private void ShowChoice(int round)
	{
		if (TravelMgr.Instance.data.Invest || TravelMgr.Instance.data.travelProcess != TravelProcess.Fast)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
		}
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		BaseMenu baseMenu;
		if (baseMenu != 0)
		{
		}
		if (global::Lawnf.TravelHell())
		{
			if (round > 6)
			{
				if (round == 10)
				{
					RogueManager instance = RogueManager.Instance;
					int num = 0;
					uint num2;
					instance.CrisisManifested((int)num2, num != 0);
				}
				if (round != 14)
				{
					goto IL_00BF;
				}
				RogueManager instance2 = RogueManager.Instance;
				int num3 = 0;
				uint num4;
				instance2.CrisisManifested((int)num4, num3 != 0);
			}
			if (round == 1)
			{
				RogueManager instance3 = RogueManager.Instance;
				int num5 = 0;
				instance3.CrisisManifested(round, num5 != 0);
			}
			if (round == 6)
			{
				RogueManager instance4 = RogueManager.Instance;
				int num6 = 0;
				uint num7;
				instance4.CrisisManifested((int)num7, num6 != 0);
			}
			IL_00BF:
			UIResourcesLoader uimanager3 = GameAPP.UIManager;
		}
		Time.timeScale = (float)0;
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0003C4A8 File Offset: 0x0003A6A8
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x9289A0", Offset = "0x926FA0", VA = "0x1809289A0")]
	public void TravelNextRound()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x927790", Offset = "0x925D90", VA = "0x180927790")]
	public void StartNextRound()
	{
		SurvivalData survivalData = SaveMgr.SaveBoard(GameAPP.theBoardLevel, -1, "新的存档");
		if (GameAPP.config.realEndless)
		{
			GameAPP.music.Play();
			GameAPP.musicDrum.Play();
			SceneType sceneType = this.sceneType;
			int num = 0;
			this.theWave = num;
			this.over = num != 0;
			int theBoardType = (int)GameAPP.theBoardType;
			this.timeUntilNextWave = 3f;
			List<TextMeshProUGUI> levelNameText = InGameUI.Instance.levelNameText;
			InGameUI.Instance.SetUniqueText(levelNameText);
			if (!InGameUI.Instance.ShowCardBank.activeSelf)
			{
				InGameUI.Instance.ShowCardBank.SetActive(true);
				InGameText instance = InGameText.Instance;
				DelayAction delayAction = GameAPP.delayAction;
				Action action = delegate
				{
					int num3 = 0;
					if (this != num3)
					{
						InGameUI instance2 = InGameUI.Instance;
						int num4 = 0;
						if (instance2 != num4)
						{
							GameObject showCardBank = InGameUI.Instance.ShowCardBank;
							int num5 = 0;
							showCardBank.SetActive(num5 != 0);
							return;
						}
					}
				};
				delayAction.SetAction(action, 7.5f);
			}
			return;
		}
		this.Die();
		int num2 = 0;
		LevelType theBoardType2 = GameAPP.theBoardType;
		int theBoardLevel = GameAPP.theBoardLevel;
		UIMgr.EnterGame(theBoardType2, theBoardLevel, -1, num2);
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0003C5C8 File Offset: 0x0003A7C8
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x919590", Offset = "0x917B90", VA = "0x180919590")]
	public void ClearTheBoard()
	{
		LevelType theBoardType = GameAPP.theBoardType;
		if (theBoardType == LevelType.Survival)
		{
		}
		if (theBoardType == LevelType.StarAdvanture)
		{
			int theBoardLevel = GameAPP.theBoardLevel;
			bool flag;
			if (flag)
			{
				SaveMgr.ClearBoard(GameAPP.theBoardLevel);
				return;
			}
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0003C5FC File Offset: 0x0003A7FC
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x924440", Offset = "0x922A40", VA = "0x180924440")]
	private void SetSuperTorch()
	{
		CreatePlant instance = CreatePlant.Instance;
		CreatePlant instance2 = CreatePlant.Instance;
		CreatePlant instance3 = CreatePlant.Instance;
		CreatePlant instance4 = CreatePlant.Instance;
		CreatePlant instance5 = CreatePlant.Instance;
		CreatePlant instance6 = CreatePlant.Instance;
		CreatePlant instance7 = CreatePlant.Instance;
		CreatePlant instance8 = CreatePlant.Instance;
		CreatePlant instance9 = CreatePlant.Instance;
		CreatePlant instance10 = CreatePlant.Instance;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0003C65C File Offset: 0x0003A85C
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x924200", Offset = "0x922800", VA = "0x180924200")]
	private void SetSuperKelp()
	{
		CreatePlant instance = CreatePlant.Instance;
		CreatePlant instance2 = CreatePlant.Instance;
		CreatePlant instance3 = CreatePlant.Instance;
		CreatePlant instance4 = CreatePlant.Instance;
		CreatePlant instance5 = CreatePlant.Instance;
		CreatePlant instance6 = CreatePlant.Instance;
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0003C6A0 File Offset: 0x0003A8A0
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x9288D0", Offset = "0x926ED0", VA = "0x1809288D0")]
	public void TempAddLightLevel(float time)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x918C10", Offset = "0x917210", VA = "0x180918C10")]
	public void AddLightLevel(int level = 4)
	{
		int num;
		do
		{
			num = 0;
			if (this.gridSystem.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
					}
				}
				num += 312;
			}
			if ("{il2cpp array field local6->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x0003C724 File Offset: 0x0003A924
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x91D740", Offset = "0x91BD40", VA = "0x18091D740")]
	private void MeteoriteUpdate()
	{
		bool flag = global::Lawnf.TravelAdvanced((AdvBuff)((uint)1017));
		float num = this.bigStarPassiveCountDown;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.bigStarPassiveCountDown = num;
			this.PassiveCreateMeteorite();
		}
		float num3 = this.bigStarActiveCountDown;
		if (num3 > (float)num2)
		{
			float deltaTime2 = Time.deltaTime;
			this.bigStarActiveCountDown = num3;
		}
		float num4 = this.solarCountDown;
		if (num4 > (float)num2)
		{
			num3 = num4;
			float deltaTime3 = Time.deltaTime;
			this.solarCountDown = num3;
			float num5 = this.solarMaxTime;
			this.solarCountDown = num5;
			Solar instance = Solar.Instance;
			int num6 = 0;
			if (!(instance == num6))
			{
				Solar.Instance.SetDamage();
			}
			this.CreateSolar();
			Lunar instance2 = Lunar.Instance;
			int num7 = 0;
			if (instance2 == num7)
			{
				this.CreateLunar();
			}
		}
		float num8 = this.ultimateStarCountDown;
		if (num8 > (float)num2)
		{
			num3 = num8;
			float deltaTime4 = Time.deltaTime;
			this.ultimateStarCountDown = num3;
			this.PassiveUltimateMeteorite();
		}
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x0003C824 File Offset: 0x0003AA24
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x91A280", Offset = "0x918880", VA = "0x18091A280")]
	private void CreateSolar()
	{
		BoardEntity boardEntity = this.boardEntity;
		int num = 0;
		List<Plant> plantHead = boardEntity.plantHead;
		Func<Plant, bool> <>9__179_ = Board.<>c.<>9__179_0;
		if (<>9__179_ == 0)
		{
			Board.<>c.<>9__179_0 = (Plant p) => p.thePlantType == PlantType.UltimateCabbage;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__179_);
		int num2 = 0;
		if (plant != num2)
		{
			plant.anim.SetTrigger("super");
			num++;
		}
		if (num != 0)
		{
			GameObject gameObject = GameAPP.itemPrefab[46];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = base.transform;
			GameObject gameObject2;
			gameObject2.GetComponent<Solar>().SetDamage();
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
		}
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x919C80", Offset = "0x918280", VA = "0x180919C80")]
	private void CreateLunar()
	{
		ulong num2;
		do
		{
			List<Plant> plants = global::Lawnf.GetPlants((PlantType)((uint)955), this, true);
			int num = 0;
			List<Plant> plants2 = global::Lawnf.GetPlants((PlantType)((uint)302), this, num != 0);
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Concat<Plant>(plants, plants2));
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
		GameAPP.PlaySound(95, 0.5f, 1f);
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0003C948 File Offset: 0x0003AB48
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x91EC30", Offset = "0x91D230", VA = "0x18091EC30")]
	private void PassiveCreateMeteorite()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = this.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		if (num2 != 0)
		{
			if (num2 > 0)
			{
				this.bigStarPassiveMaxTime = 30f;
				this.bigStarPassiveMaxTime = 25f;
			}
			GameAPP.PlaySound(83, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x9189E0", Offset = "0x916FE0", VA = "0x1809189E0")]
	public void ActiveCreateMeteorite()
	{
		ulong num4;
		do
		{
			int num = 0;
			float num2 = this.bigStarActiveMaxTime;
			this.bigStarActiveCountDown = num2;
			GameAPP.PlaySound(83, 0.5f, 1f);
			List<Plant> plantArray = this.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0003CA34 File Offset: 0x0003AC34
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x919EA0", Offset = "0x9184A0", VA = "0x180919EA0")]
	public BigStar CreatePassiveMateorite()
	{
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[10]).transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0003CA74 File Offset: 0x0003AC74
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x919B30", Offset = "0x918130", VA = "0x180919B30")]
	public BigStar CreateActiveMateorite()
	{
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[11]).transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x91EEF0", Offset = "0x91D4F0", VA = "0x18091EEF0")]
	private void PassiveUltimateMeteorite()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = this.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		float num4 = this.ultimateStarMaxTime;
		this.ultimateStarCountDown = num4;
		if (num2 != 0)
		{
			if (num2 == 0)
			{
			}
			GameAPP.PlaySound(83, 0.5f, 1f);
		}
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0003CB2C File Offset: 0x0003AD2C
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x91A5D0", Offset = "0x918BD0", VA = "0x18091A5D0")]
	private void CreateUltimateMateorite2()
	{
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[56]).transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0003CB6C File Offset: 0x0003AD6C
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x91A710", Offset = "0x918D10", VA = "0x18091A710")]
	private void CreateUltimateMateorite()
	{
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[12]).transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x0003CBAC File Offset: 0x0003ADAC
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x91AC10", Offset = "0x919210", VA = "0x18091AC10")]
	public void EnableTravelBuff(bool add = true, bool zombie = false)
	{
		int num3;
		do
		{
			int num = 0;
			TravelMgr instance = TravelMgr.Instance;
			int num2 = 0;
			List<AdvBuff> advancedBuffPool = instance.GetAdvancedBuffPool(num2 != 0);
			num3 = 0;
			bool flag;
			if (flag)
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)num);
			}
		}
		while (num3 != 0);
		int num4 = 0;
		UltiBuff[] enumValues = global::Core.Lawnf.GetEnumValues<UltiBuff>();
		if (num4 < enumValues.Length)
		{
			TravelMgr instance2 = TravelMgr.Instance;
			num4++;
		}
		TravelDebuff[] enumValues2 = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
		if (num4 < enumValues2.Length)
		{
			TravelMgr instance3 = TravelMgr.Instance;
			num4++;
		}
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0003CC3C File Offset: 0x0003AE3C
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x91EB20", Offset = "0x91D120", VA = "0x18091EB20")]
	public void OnPlantCreate(Plant plant)
	{
		Dictionary<PlantType, PlantStatisticsDetail> plantDetails = this.boardStatistics.plantDetails;
		BoardStatistics boardStatistics = this.boardStatistics;
		bool flag;
		if (!flag)
		{
			Dictionary<PlantType, PlantStatisticsDetail> plantDetails2 = boardStatistics.plantDetails;
			PlantType thePlantType = plant.thePlantType;
			return;
		}
		ulong num;
		num += (ulong)1L;
		Dictionary<PlantType, PlantStatisticsDetail> plantDetails3 = boardStatistics.plantDetails;
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0003CC88 File Offset: 0x0003AE88
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	public void OnPlantDie(Plant plant, Plant.DieReason plantDieReason)
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x0003CC98 File Offset: 0x0003AE98
	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x9290B0", Offset = "0x9276B0", VA = "0x1809290B0")]
	public void UpdateRandomData(bool showText = false)
	{
		MixData.UpdateRandomMix();
		if (showText)
		{
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x0003CCC0 File Offset: 0x0003AEC0
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
	private void HugeWaveEvent(int currentWave)
	{
		SceneType sceneType = this.sceneType;
		if ((sceneType > SceneType.Snow_6 && sceneType == SceneType.SnowPool) || sceneType == (SceneType)(-3))
		{
			SnowMap.Instance.HugeWave();
			return;
		}
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x924010", Offset = "0x922610", VA = "0x180924010")]
	public void SetRedLine(int theColumn)
	{
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(theColumn);
		float boxXFromColumn2 = global::Lawnf.GetBoxXFromColumn(theColumn + 1);
		GameObject gameObject = Resources.Load<GameObject>("Background/MapItem/RedLine");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		Transform transform = gameObject2.transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		gameObject2.GetComponent<SpriteRenderer>().sortingOrder = -199;
		BoardConfig boardConfig = this.config;
		int num = theColumn + 1;
		boardConfig.redLineColumn = num;
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x0003CD70 File Offset: 0x0003AF70
	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x91B920", Offset = "0x919F20", VA = "0x18091B920")]
	public BoxType GetBoxType(int theColumn, int theRow)
	{
		int num = this.rowNum;
		return this.gridSystem.GetGrid(theColumn, num).boxType;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x928BC0", Offset = "0x9271C0", VA = "0x180928BC0")]
	public void UpdateBox(int theColumn, int theRow)
	{
		int num;
		do
		{
			RogueManager.Instance.UpdateBox(theColumn, theRow);
			List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
			Func<Plant, bool> func;
			if (Board.<>c.<>9__195_0 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.XXSPot;
				Board.<>c.<>9__195_0 = func;
			}
			bool flag = Enumerable.FirstOrDefault<Plant>(list, func);
			Func<Plant, bool> func2;
			if (Board.<>c.<>9__195_1 == 0)
			{
				func2 = (Plant p) => p.thePlantType == PlantType.UltimateHypnoPumpkin;
				Board.<>c.<>9__195_1 = func2;
			}
			bool flag2 = Enumerable.FirstOrDefault<Plant>(list, func2);
			List<Plant> list2 = global::Lawnf.Get1x1Plants(theColumn, theRow);
			num = 0;
			bool flag3;
			if (flag3)
			{
				Func<Plant, bool> func3;
				if (Board.<>c.<>9__195_2 == 0)
				{
					func3 = (Plant p) => p.thePlantType == PlantType.XXSPot;
					Board.<>c.<>9__195_2 = func3;
				}
				if (Enumerable.FirstOrDefault<Plant>(list, func3))
				{
				}
				while (flag2)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x0003CE88 File Offset: 0x0003B088
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x91E8E0", Offset = "0x91CEE0", VA = "0x18091E8E0")]
	private void OnDestroy()
	{
		Transform uiparent = this.UIParent;
		int num = 0;
		if (uiparent != num)
		{
			global::UnityEngine.Object.DestroyImmediate(this.UIParent.gameObject);
		}
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x91A850", Offset = "0x918E50", VA = "0x18091A850")]
	public void Die()
	{
		int num;
		do
		{
			num = 0;
			this.somethings.Clear();
			UnityEvent dieEvent = this.DieEvent;
			if (dieEvent != 0)
			{
				dieEvent.Invoke();
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
			EventManager.ClearAllEvents();
			LuckyBlover.lucky = num != 0;
			this.brainManager = num;
			ScreenShine.Instance.EndEmit();
			List<Plant> plantArray = this.boardEntity.plantArray;
			int size = plantArray._size;
			plantArray._size = num;
			if (size > 0)
			{
			}
			List<Zombie> list = this.zombieArray;
			int size2 = list._size;
			list._size = num;
			if (size2 > 0)
			{
			}
			List<Bullet> bulletArray = this.boardEntity.bulletArray;
			int size3 = bulletArray._size;
			bulletArray._size = num;
			if (size3 > 0)
			{
			}
			IEnumerator<BoardGrid> enumerator = this.gridSystem.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_00E5;
					}
					num++;
				}
				if (0 <= 0)
				{
					continue;
				}
				int num2 = 0;
				IL_00E5:
				enumerator += enumerator;
				num2 += 312;
			}
			if ("{il2cpp array field local32->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		TravelMgr.Instance.Clear();
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0003D000 File Offset: 0x0003B200
	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x929EE0", Offset = "0x9284E0", VA = "0x180929EE0")]
	public Board()
	{
		BoardConfig boardConfig = new BoardConfig();
		this.config = boardConfig;
		BoardData boardData = new BoardData();
		this.boardData = boardData;
		BoardEntity boardEntity = new BoardEntity();
		this.boardEntity = boardEntity;
		BoardAction boardAction = new BoardAction();
		this.boardAction = boardAction;
		List<Zombie> list = new List();
		this.zombieArray = list;
		List<Zombie> list2 = new List();
		this.zombieHead = list2;
		Dictionary<ZombieType, List<Zombie>> dictionary = new Dictionary();
		this.zombieHeads = dictionary;
		List<Obstacle> list3 = new List();
		this.zombieBalls = list3;
		List<GridItem> list4 = new List();
		this.griditemArray = list4;
		List<Mower> list5 = new List();
		this.mowerArray = list5;
		FireLine[] array = new FireLine[12];
		this.fireLineArray = array;
		List<IceRoad> list6 = new List();
		this.iceRoads = list6;
		List<BlackHole> list7 = new List();
		this.blackHoles = list7;
		BoxType[] array2 = new BoxType[12];
		this.roadType = array2;
		List<PlantType> list8 = new List();
		this.seedPool = list8;
		this.maxSun = (int)((ulong)50000L);
		this.maxMoney = (int)((ulong)99999L);
		this.sunEfficiency = 1f;
		this.moneyEfficiency = 1f;
		this.theSun = (int)((ulong)500L);
		this.theMoney = (int)((ulong)3000L);
		this.theLimPlantCount = (int)((ulong)5L);
		this.rowNum = (int)((ulong)5L);
		this.columnNum = (int)((ulong)10L);
		this.cardCountLimit = (int)((ulong)14L);
		this.thePoints = 500f;
		this.bulletStrikeMultiplier = 1.5f;
		this.timeUntilNextWave = 15f;
		this.happyRandomCardTimer = 180f;
		this.happyRecoverTimer = 10f;
		this.punishTime = 180f;
		this.bigStarPassiveCountDown = 50f;
		this.solarCountDown = 30f;
		this.solarMaxTime = 30f;
		this.bigStarPassiveMaxTime = 50f;
		this.bigStarActiveMaxTime = 50f;
		this.ultimateStarCountDown = 15f;
		this.ultimateStarMaxTime = 15f;
		this.randomPresentTime = 3f;
		this.evebalance = true;
		this.cardBank = true;
		this.fallSun = true;
		List<Transform> list9 = new List();
		this.plane = list9;
		List<Transform> list10 = new List();
		this.planeRoof = list10;
		Dictionary<ZombieType, int> dictionary2 = new Dictionary();
		this.enermyCountDic = dictionary2;
		Dictionary<string, object> dictionary3 = new Dictionary();
		this.somethings = dictionary3;
		this.theFallingSunCountDown = 7.5f;
		this.randomDataUpdateTimer = 150f;
		this.zombieDefenseMultiplier = 1f;
		HashSet<EveZombieBuff> hashSet = new HashSet();
		this.eveZombieBuffs = hashSet;
		this.maxMatchCount = (int)((ulong)75L);
		this.lockedDifficulty = (int)((ulong)4294967295L);
		UnityEvent unityEvent = new UnityEvent();
		this.DieEvent = unityEvent;
		base..ctor();
	}

	// Token: 0x040005EB RID: 1515
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005EB")]
	[Header("管理类")]
	public BoardVictory boardVicotry;

	// Token: 0x040005EC RID: 1516
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005EC")]
	public BoardConfig config;

	// Token: 0x040005ED RID: 1517
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005ED")]
	public BoardSpawner boardSpawner;

	// Token: 0x040005EE RID: 1518
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005EE")]
	public BoardData boardData;

	// Token: 0x040005EF RID: 1519
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005EF")]
	public BoardEntity boardEntity;

	// Token: 0x040005F0 RID: 1520
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005F0")]
	public BoardAction boardAction;

	// Token: 0x040005F1 RID: 1521
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005F1")]
	public BoardStatistics boardStatistics;

	// Token: 0x040005F2 RID: 1522
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005F2")]
	public GridSystem gridSystem;

	// Token: 0x040005F3 RID: 1523
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005F3")]
	public IBoardEnvironment boardEnvironment;

	// Token: 0x040005F4 RID: 1524
	[Token(Token = "0x40005F4")]
	public static Board Instance;

	// Token: 0x040005F5 RID: 1525
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005F5")]
	public List<Zombie> zombieArray;

	// Token: 0x040005F6 RID: 1526
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005F6")]
	public List<Zombie> zombieHead;

	// Token: 0x040005F7 RID: 1527
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005F7")]
	public Dictionary<ZombieType, List<Zombie>> zombieHeads;

	// Token: 0x040005F8 RID: 1528
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005F8")]
	public List<Obstacle> zombieBalls;

	// Token: 0x040005F9 RID: 1529
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005F9")]
	public List<GridItem> griditemArray;

	// Token: 0x040005FA RID: 1530
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40005FA")]
	public List<Mower> mowerArray;

	// Token: 0x040005FB RID: 1531
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40005FB")]
	public FireLine[] fireLineArray;

	// Token: 0x040005FC RID: 1532
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40005FC")]
	public GameObject fog;

	// Token: 0x040005FD RID: 1533
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40005FD")]
	public List<IceRoad> iceRoads;

	// Token: 0x040005FE RID: 1534
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40005FE")]
	public List<BlackHole> blackHoles;

	// Token: 0x040005FF RID: 1535
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40005FF")]
	public MiniPet pet;

	// Token: 0x04000600 RID: 1536
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000600")]
	public BoxType[] roadType;

	// Token: 0x04000601 RID: 1537
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000601")]
	public List<PlantType> seedPool;

	// Token: 0x04000602 RID: 1538
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000602")]
	public float plantMaxVisionX;

	// Token: 0x04000603 RID: 1539
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000603")]
	public float boardMaxY;

	// Token: 0x04000604 RID: 1540
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000604")]
	public float boardMinY;

	// Token: 0x04000605 RID: 1541
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000605")]
	public float boardMaxX;

	// Token: 0x04000606 RID: 1542
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000606")]
	public float boardMinX;

	// Token: 0x04000607 RID: 1543
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000607")]
	public float zombieMaxX;

	// Token: 0x04000608 RID: 1544
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000608")]
	public float zombieMinX;

	// Token: 0x04000609 RID: 1545
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000609")]
	public List<JigSawData> jigSawDatas;

	// Token: 0x0400060A RID: 1546
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400060A")]
	public int maxSun;

	// Token: 0x0400060B RID: 1547
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x400060B")]
	public int maxMoney;

	// Token: 0x0400060C RID: 1548
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400060C")]
	public float sunEfficiency;

	// Token: 0x0400060D RID: 1549
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400060D")]
	public float moneyEfficiency;

	// Token: 0x0400060E RID: 1550
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400060E")]
	public int theSun;

	// Token: 0x0400060F RID: 1551
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400060F")]
	public int extraSun;

	// Token: 0x04000610 RID: 1552
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000610")]
	public int theMoney;

	// Token: 0x04000611 RID: 1553
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000611")]
	public int enermyCount;

	// Token: 0x04000612 RID: 1554
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000612")]
	public int theTotalNumOfZombie;

	// Token: 0x04000613 RID: 1555
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000613")]
	public int theTotalNumOfCoin;

	// Token: 0x04000614 RID: 1556
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000614")]
	public int theTotalNumOfPlant;

	// Token: 0x04000615 RID: 1557
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000615")]
	public int plantedCount;

	// Token: 0x04000616 RID: 1558
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000616")]
	public int theCurrentPlantCount;

	// Token: 0x04000617 RID: 1559
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000617")]
	public int theLimPlantCount;

	// Token: 0x04000618 RID: 1560
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000618")]
	public int theWave;

	// Token: 0x04000619 RID: 1561
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000619")]
	public int theMaxWave;

	// Token: 0x0400061A RID: 1562
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400061A")]
	public int theSurvivalMaxRound;

	// Token: 0x0400061B RID: 1563
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x400061B")]
	public int theCurrentSurvivalRound;

	// Token: 0x0400061C RID: 1564
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400061C")]
	public int currentBulletNum;

	// Token: 0x0400061D RID: 1565
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400061D")]
	public int musicType;

	// Token: 0x0400061E RID: 1566
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400061E")]
	public int rowNum;

	// Token: 0x0400061F RID: 1567
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x400061F")]
	public int columnNum;

	// Token: 0x04000620 RID: 1568
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000620")]
	public int savedID;

	// Token: 0x04000621 RID: 1569
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000621")]
	public int cannonNutCount;

	// Token: 0x04000622 RID: 1570
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000622")]
	public int cardCountLimit;

	// Token: 0x04000623 RID: 1571
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000623")]
	public float thePoints;

	// Token: 0x04000624 RID: 1572
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000624")]
	public float currentRoundPoint;

	// Token: 0x04000625 RID: 1573
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000625")]
	public float zombieTotalHealth;

	// Token: 0x04000626 RID: 1574
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000626")]
	public float zombieCurrentWaveHealth;

	// Token: 0x04000627 RID: 1575
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x4000627")]
	public float zombieSpawnHealth;

	// Token: 0x04000628 RID: 1576
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000628")]
	public float zombieHealthUpdater;

	// Token: 0x04000629 RID: 1577
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x4000629")]
	public float holdOnTime;

	// Token: 0x0400062A RID: 1578
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400062A")]
	public float iceDoomFreezeTime;

	// Token: 0x0400062B RID: 1579
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x400062B")]
	public float bulletStrikeP;

	// Token: 0x0400062C RID: 1580
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400062C")]
	public float bulletStrikeMultiplier;

	// Token: 0x0400062D RID: 1581
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x400062D")]
	public float timeUntilNextWave;

	// Token: 0x0400062E RID: 1582
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400062E")]
	public float happyRandomCardTimer;

	// Token: 0x0400062F RID: 1583
	[FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x400062F")]
	public float happyRecoverTimer;

	// Token: 0x04000630 RID: 1584
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000630")]
	public float punishTime;

	// Token: 0x04000631 RID: 1585
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000631")]
	public float bigStarPassiveCountDown;

	// Token: 0x04000632 RID: 1586
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000632")]
	public float solarCountDown;

	// Token: 0x04000633 RID: 1587
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000633")]
	public float solarMaxTime;

	// Token: 0x04000634 RID: 1588
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000634")]
	public float bigStarPassiveMaxTime;

	// Token: 0x04000635 RID: 1589
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000635")]
	public float bigStarActiveCountDown;

	// Token: 0x04000636 RID: 1590
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000636")]
	public float bigStarActiveMaxTime;

	// Token: 0x04000637 RID: 1591
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000637")]
	public float ultimateStarCountDown;

	// Token: 0x04000638 RID: 1592
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000638")]
	public float ultimateStarMaxTime;

	// Token: 0x04000639 RID: 1593
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4000639")]
	public float lastRandomBuffTime;

	// Token: 0x0400063A RID: 1594
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400063A")]
	public float randomPresentTime;

	// Token: 0x0400063B RID: 1595
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x400063B")]
	public bool isEveStart;

	// Token: 0x0400063C RID: 1596
	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x400063C")]
	public bool isEveStarted;

	// Token: 0x0400063D RID: 1597
	[FieldOffset(Offset = "0x1BE")]
	[Token(Token = "0x400063D")]
	public bool isAutoEve;

	// Token: 0x0400063E RID: 1598
	[FieldOffset(Offset = "0x1BF")]
	[Token(Token = "0x400063E")]
	public bool evebalance;

	// Token: 0x0400063F RID: 1599
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400063F")]
	public bool over;

	// Token: 0x04000640 RID: 1600
	[FieldOffset(Offset = "0x1C1")]
	[Token(Token = "0x4000640")]
	public bool freeCD;

	// Token: 0x04000641 RID: 1601
	[FieldOffset(Offset = "0x1C2")]
	[Token(Token = "0x4000641")]
	public bool droppedGardenPlant;

	// Token: 0x04000642 RID: 1602
	[FieldOffset(Offset = "0x1C3")]
	[Token(Token = "0x4000642")]
	public bool cardBank;

	// Token: 0x04000643 RID: 1603
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4000643")]
	public int showPlantHealth;

	// Token: 0x04000644 RID: 1604
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000644")]
	public bool showZombieHealth;

	// Token: 0x04000645 RID: 1605
	[FieldOffset(Offset = "0x1C9")]
	[Token(Token = "0x4000645")]
	public bool showBulletDamage;

	// Token: 0x04000646 RID: 1606
	[FieldOffset(Offset = "0x1CA")]
	[Token(Token = "0x4000646")]
	public bool fallSun;

	// Token: 0x04000647 RID: 1607
	[FieldOffset(Offset = "0x1CB")]
	[Token(Token = "0x4000647")]
	public bool happyRandomCard;

	// Token: 0x04000648 RID: 1608
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4000648")]
	public bool boss2;

	// Token: 0x04000649 RID: 1609
	[FieldOffset(Offset = "0x1CD")]
	[Token(Token = "0x4000649")]
	public bool goldHypnoAward;

	// Token: 0x0400064A RID: 1610
	[FieldOffset(Offset = "0x1CE")]
	[Token(Token = "0x400064A")]
	public bool fakeTrophy;

	// Token: 0x0400064B RID: 1611
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400064B")]
	public List<Transform> plane;

	// Token: 0x0400064C RID: 1612
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400064C")]
	public List<Transform> planeRoof;

	// Token: 0x0400064D RID: 1613
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400064D")]
	public Dictionary<ZombieType, int> enermyCountDic;

	// Token: 0x0400064E RID: 1614
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400064E")]
	public Dictionary<string, object> somethings;

	// Token: 0x0400064F RID: 1615
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400064F")]
	public Plant maxShieldPlant;

	// Token: 0x04000650 RID: 1616
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000650")]
	public Plant controledPlant;

	// Token: 0x04000651 RID: 1617
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000651")]
	public GameObject background;

	// Token: 0x04000652 RID: 1618
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000652")]
	public BrainManager brainManager;

	// Token: 0x04000653 RID: 1619
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000653")]
	public DamageReporter damageReporter;

	// Token: 0x04000654 RID: 1620
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000654")]
	public Board.BoardTag boardTag;

	// Token: 0x04000655 RID: 1621
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000655")]
	public BoardGame boardGame;

	// Token: 0x04000656 RID: 1622
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000656")]
	public SceneType sceneType;

	// Token: 0x04000657 RID: 1623
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000657")]
	private float theFallingSunCountDown;

	// Token: 0x04000658 RID: 1624
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000658")]
	private float hugeWaveCountDown;

	// Token: 0x04000659 RID: 1625
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000659")]
	private bool isHugeWave;

	// Token: 0x0400065A RID: 1626
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400065A")]
	private float eveCountDown;

	// Token: 0x0400065B RID: 1627
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400065B")]
	public float eveCurrentTime;

	// Token: 0x0400065C RID: 1628
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400065C")]
	private float randomDataUpdateTimer;

	// Token: 0x0400065D RID: 1629
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400065D")]
	public float zombieDefenseMultiplier;

	// Token: 0x0400065E RID: 1630
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400065E")]
	public HashSet<EveZombieBuff> eveZombieBuffs;

	// Token: 0x0400065F RID: 1631
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400065F")]
	public int maxMatchCount;

	// Token: 0x04000660 RID: 1632
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x4000660")]
	public int matchCount;

	// Token: 0x04000661 RID: 1633
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000661")]
	public int lockedDifficulty;

	// Token: 0x04000662 RID: 1634
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000662")]
	public Transform UIParent;

	// Token: 0x04000663 RID: 1635
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000663")]
	public UnityEvent DieEvent;

	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	[Serializable]
	public struct BoardTag
	{
		// Token: 0x04000664 RID: 1636
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000664")]
		public bool waveLeaders;

		// Token: 0x04000665 RID: 1637
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000665")]
		public bool evolutionWar;

		// Token: 0x04000666 RID: 1638
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000666")]
		public bool rhythmGame;

		// Token: 0x04000667 RID: 1639
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000667")]
		public bool imZombieBoss;

		// Token: 0x04000668 RID: 1640
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000668")]
		public bool allScaryPotShow;

		// Token: 0x04000669 RID: 1641
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000669")]
		public bool customEdit;

		// Token: 0x0400066A RID: 1642
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x400066A")]
		public bool allCards;

		// Token: 0x0400066B RID: 1643
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x400066B")]
		public bool isIZ;

		// Token: 0x0400066C RID: 1644
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400066C")]
		public bool HorseBoss;

		// Token: 0x0400066D RID: 1645
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400066D")]
		public bool Iz_ai;

		// Token: 0x0400066E RID: 1646
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x400066E")]
		public bool rShowHealth;

		// Token: 0x0400066F RID: 1647
		[FieldOffset(Offset = "0xB")]
		[Token(Token = "0x400066F")]
		public bool lessSun;

		// Token: 0x04000670 RID: 1648
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000670")]
		public bool lessMoney;

		// Token: 0x04000671 RID: 1649
		[FieldOffset(Offset = "0xD")]
		[Token(Token = "0x4000671")]
		public bool zombieDropSun;

		// Token: 0x04000672 RID: 1650
		[FieldOffset(Offset = "0xE")]
		[Token(Token = "0x4000672")]
		public bool disableNormalSun;

		// Token: 0x04000673 RID: 1651
		[FieldOffset(Offset = "0xF")]
		[Token(Token = "0x4000673")]
		public bool zombieRevive;

		// Token: 0x04000674 RID: 1652
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000674")]
		public bool isScaredyDream;

		// Token: 0x04000675 RID: 1653
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000675")]
		public bool isTowerDefence;

		// Token: 0x04000676 RID: 1654
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4000676")]
		public bool isShooting;

		// Token: 0x04000677 RID: 1655
		[FieldOffset(Offset = "0x13")]
		[Token(Token = "0x4000677")]
		public bool rogueShooting;

		// Token: 0x04000678 RID: 1656
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000678")]
		public bool newShooting;

		// Token: 0x04000679 RID: 1657
		[FieldOffset(Offset = "0x15")]
		[Token(Token = "0x4000679")]
		public bool isSeedRain;

		// Token: 0x0400067A RID: 1658
		[FieldOffset(Offset = "0x16")]
		[Token(Token = "0x400067A")]
		public bool isIndestructible;

		// Token: 0x0400067B RID: 1659
		[FieldOffset(Offset = "0x17")]
		[Token(Token = "0x400067B")]
		public bool isColumn;

		// Token: 0x0400067C RID: 1660
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400067C")]
		public bool isSuperRandom;

		// Token: 0x0400067D RID: 1661
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x400067D")]
		public bool isNormalRandom;

		// Token: 0x0400067E RID: 1662
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x400067E")]
		public bool isElementRandom;

		// Token: 0x0400067F RID: 1663
		[FieldOffset(Offset = "0x1B")]
		[Token(Token = "0x400067F")]
		public bool isDrawCards;

		// Token: 0x04000680 RID: 1664
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000680")]
		public bool isUltimateSuperRandom;

		// Token: 0x04000681 RID: 1665
		[FieldOffset(Offset = "0x1D")]
		[Token(Token = "0x4000681")]
		public bool isNight;

		// Token: 0x04000682 RID: 1666
		[FieldOffset(Offset = "0x1E")]
		[Token(Token = "0x4000682")]
		public bool isBigMap;

		// Token: 0x04000683 RID: 1667
		[FieldOffset(Offset = "0x1F")]
		[Token(Token = "0x4000683")]
		public bool freeCamera;

		// Token: 0x04000684 RID: 1668
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000684")]
		public bool isEndless;

		// Token: 0x04000685 RID: 1669
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x4000685")]
		public bool isTravel;

		// Token: 0x04000686 RID: 1670
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x4000686")]
		public bool isEasyTravel;

		// Token: 0x04000687 RID: 1671
		[FieldOffset(Offset = "0x23")]
		[Token(Token = "0x4000687")]
		public bool randomTravel;

		// Token: 0x04000688 RID: 1672
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000688")]
		public bool superCustomEditorMode;

		// Token: 0x04000689 RID: 1673
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x4000689")]
		public bool enableTravelPlant;

		// Token: 0x0400068A RID: 1674
		[FieldOffset(Offset = "0x26")]
		[Token(Token = "0x400068A")]
		public bool enableAllTravelPlant;

		// Token: 0x0400068B RID: 1675
		[FieldOffset(Offset = "0x27")]
		[Token(Token = "0x400068B")]
		public bool enableTravelBuff;

		// Token: 0x0400068C RID: 1676
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400068C")]
		public bool isRoof;

		// Token: 0x0400068D RID: 1677
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x400068D")]
		public bool isGarden;

		// Token: 0x0400068E RID: 1678
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x400068E")]
		public bool isMirror;

		// Token: 0x0400068F RID: 1679
		[FieldOffset(Offset = "0x2B")]
		[Token(Token = "0x400068F")]
		public bool isConvey;

		// Token: 0x04000690 RID: 1680
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000690")]
		public bool isExchange;

		// Token: 0x04000691 RID: 1681
		[FieldOffset(Offset = "0x2D")]
		[Token(Token = "0x4000691")]
		public bool shooting_loon;

		// Token: 0x04000692 RID: 1682
		[FieldOffset(Offset = "0x2E")]
		[Token(Token = "0x4000692")]
		public bool isBoss;

		// Token: 0x04000693 RID: 1683
		[FieldOffset(Offset = "0x2F")]
		[Token(Token = "0x4000693")]
		public bool isBoss2;

		// Token: 0x04000694 RID: 1684
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000694")]
		public bool isFreeCardSelect;

		// Token: 0x04000695 RID: 1685
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x4000695")]
		public bool isTutor;

		// Token: 0x04000696 RID: 1686
		[FieldOffset(Offset = "0x32")]
		[Token(Token = "0x4000696")]
		public bool isObsidianImp;

		// Token: 0x04000697 RID: 1687
		[FieldOffset(Offset = "0x33")]
		[Token(Token = "0x4000697")]
		public bool isDixMix;

		// Token: 0x04000698 RID: 1688
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000698")]
		public bool isSingle;

		// Token: 0x04000699 RID: 1689
		[FieldOffset(Offset = "0x35")]
		[Token(Token = "0x4000699")]
		public bool bungiBattle;

		// Token: 0x0400069A RID: 1690
		[FieldOffset(Offset = "0x36")]
		[Token(Token = "0x400069A")]
		public bool isBejeweled;

		// Token: 0x0400069B RID: 1691
		[FieldOffset(Offset = "0x37")]
		[Token(Token = "0x400069B")]
		public bool isBubbleGame;

		// Token: 0x0400069C RID: 1692
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400069C")]
		public bool isScaryPot;

		// Token: 0x0400069D RID: 1693
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x400069D")]
		public bool isMidMap;

		// Token: 0x0400069E RID: 1694
		[FieldOffset(Offset = "0x3A")]
		[Token(Token = "0x400069E")]
		public bool isChess;

		// Token: 0x0400069F RID: 1695
		[FieldOffset(Offset = "0x3B")]
		[Token(Token = "0x400069F")]
		public bool isMidMap2;

		// Token: 0x040006A0 RID: 1696
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40006A0")]
		public bool isLookStar;

		// Token: 0x040006A1 RID: 1697
		[FieldOffset(Offset = "0x3D")]
		[Token(Token = "0x40006A1")]
		public bool isGardenBattle;

		// Token: 0x040006A2 RID: 1698
		[FieldOffset(Offset = "0x3E")]
		[Token(Token = "0x40006A2")]
		public bool isRandomMix;

		// Token: 0x040006A3 RID: 1699
		[FieldOffset(Offset = "0x3F")]
		[Token(Token = "0x40006A3")]
		public bool isRandomMix2;

		// Token: 0x040006A4 RID: 1700
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006A4")]
		public bool freeGloveZombie;

		// Token: 0x040006A5 RID: 1701
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x40006A5")]
		public bool disableMower;

		// Token: 0x040006A6 RID: 1702
		[FieldOffset(Offset = "0x42")]
		[Token(Token = "0x40006A6")]
		public bool isHappyRandom;

		// Token: 0x040006A7 RID: 1703
		[FieldOffset(Offset = "0x43")]
		[Token(Token = "0x40006A7")]
		public bool oppsiteBuff;

		// Token: 0x040006A8 RID: 1704
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40006A8")]
		public bool pvpScaryPot;

		// Token: 0x040006A9 RID: 1705
		[FieldOffset(Offset = "0x45")]
		[Token(Token = "0x40006A9")]
		public bool pvpRandom;

		// Token: 0x040006AA RID: 1706
		[FieldOffset(Offset = "0x46")]
		[Token(Token = "0x40006AA")]
		public bool ultimateEndless;

		// Token: 0x040006AB RID: 1707
		[FieldOffset(Offset = "0x47")]
		[Token(Token = "0x40006AB")]
		public bool isHammerZombie;

		// Token: 0x040006AC RID: 1708
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40006AC")]
		public bool fastZombie;

		// Token: 0x040006AD RID: 1709
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x40006AD")]
		public bool isHugeGravity;

		// Token: 0x040006AE RID: 1710
		[FieldOffset(Offset = "0x4A")]
		[Token(Token = "0x40006AE")]
		public bool zombieSplit;

		// Token: 0x040006AF RID: 1711
		[FieldOffset(Offset = "0x4B")]
		[Token(Token = "0x40006AF")]
		public bool fullStrike;

		// Token: 0x040006B0 RID: 1712
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40006B0")]
		public bool billiardBall;

		// Token: 0x040006B1 RID: 1713
		[FieldOffset(Offset = "0x4D")]
		[Token(Token = "0x40006B1")]
		public bool isSnake;

		// Token: 0x040006B2 RID: 1714
		[FieldOffset(Offset = "0x4E")]
		[Token(Token = "0x40006B2")]
		public bool isSquash;

		// Token: 0x040006B3 RID: 1715
		[FieldOffset(Offset = "0x4F")]
		[Token(Token = "0x40006B3")]
		public bool zombieBattle;

		// Token: 0x040006B4 RID: 1716
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40006B4")]
		public bool plantingZombie;

		// Token: 0x040006B5 RID: 1717
		[FieldOffset(Offset = "0x51")]
		[Token(Token = "0x40006B5")]
		public bool is2048;

		// Token: 0x040006B6 RID: 1718
		[FieldOffset(Offset = "0x52")]
		[Token(Token = "0x40006B6")]
		public bool isRogue;

		// Token: 0x040006B7 RID: 1719
		[FieldOffset(Offset = "0x53")]
		[Token(Token = "0x40006B7")]
		public bool isFruitNinjia;

		// Token: 0x040006B8 RID: 1720
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40006B8")]
		public bool isFruitNinjia2;

		// Token: 0x040006B9 RID: 1721
		[FieldOffset(Offset = "0x55")]
		[Token(Token = "0x40006B9")]
		public bool lightShadow;

		// Token: 0x040006BA RID: 1722
		[FieldOffset(Offset = "0x56")]
		[Token(Token = "0x40006BA")]
		public bool isLoonGame;

		// Token: 0x040006BB RID: 1723
		[FieldOffset(Offset = "0x57")]
		[Token(Token = "0x40006BB")]
		public bool snowBoss;

		// Token: 0x040006BC RID: 1724
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40006BC")]
		public bool playerShooting;

		// Token: 0x040006BD RID: 1725
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x40006BD")]
		public bool smallZombie;

		// Token: 0x040006BE RID: 1726
		[FieldOffset(Offset = "0x5A")]
		[Token(Token = "0x40006BE")]
		public bool isFlagGame;

		// Token: 0x040006BF RID: 1727
		[FieldOffset(Offset = "0x5B")]
		[Token(Token = "0x40006BF")]
		public bool isTreasure;

		// Token: 0x040006C0 RID: 1728
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40006C0")]
		public bool isBrick;

		// Token: 0x040006C1 RID: 1729
		[FieldOffset(Offset = "0x5D")]
		[Token(Token = "0x40006C1")]
		public bool disableSummonZombie;

		// Token: 0x040006C2 RID: 1730
		[FieldOffset(Offset = "0x5E")]
		[Token(Token = "0x40006C2")]
		public bool disableSelectCard;

		// Token: 0x040006C3 RID: 1731
		[FieldOffset(Offset = "0x5F")]
		[Token(Token = "0x40006C3")]
		public bool disableInInterlude;
	}
}
