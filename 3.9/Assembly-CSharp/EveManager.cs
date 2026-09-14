using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000865 RID: 2149
[Token(Token = "0x2000865")]
public class EveManager : MonoBehaviour
{
	// Token: 0x06002B9D RID: 11165 RVA: 0x000ED14C File Offset: 0x000EB34C
	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x6B2530", Offset = "0x6B0B30", VA = "0x1806B2530")]
	private void Awake()
	{
		EveManager.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x000ED16C File Offset: 0x000EB36C
	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x6B7780", Offset = "0x6B5D80", VA = "0x1806B7780")]
	public void StartEveMode()
	{
		this.board.isEveStarted = true;
		this.board.AddLightLevel(3);
		InGameUI_IZ.Instance.shovel.SetActive(true);
		InGameUI_IZ.Instance.glove.SetActive(true);
		InGameUI_IZ.Instance.wheel.SetActive(true);
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x000ED1C8 File Offset: 0x000EB3C8
	[Token(Token = "0x6002B9F")]
	[Address(RVA = "0x6B3AE0", Offset = "0x6B20E0", VA = "0x1806B3AE0")]
	private void Limit()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x000ED1E8 File Offset: 0x000EB3E8
	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x6B7860", Offset = "0x6B5E60", VA = "0x1806B7860")]
	public void StartNewEveMode()
	{
		int num5;
		do
		{
			this.board.isEveStarted = true;
			this.board.AddLightLevel(2);
			this.newEve = true;
			GameObject shovel = InGameUI_IZ.Instance.shovel;
			int num = 0;
			shovel.SetActive(num != 0);
			GameObject glove = InGameUI_IZ.Instance.glove;
			int num2 = 0;
			glove.SetActive(num2 != 0);
			GameObject wheel = InGameUI_IZ.Instance.wheel;
			int num3 = 0;
			wheel.SetActive(num3 != 0);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			int num4 = 0;
			bool flag;
			if (flag)
			{
			}
			if (num4 != 0)
			{
				goto IL_00E0;
			}
			num5 = 0;
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(true);
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num5 != 0);
		int num6 = 0;
		num6++;
		BoardGrid boardGrid;
		List<Plant> plants = boardGrid.plants;
		num6++;
		num6++;
		Plant plant;
		plant.m_CachedPtr = (IntPtr)((ulong)1L);
		return;
		IL_00E0:
		throw new NullReferenceException();
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x000ED2DC File Offset: 0x000EB4DC
	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x6B7750", Offset = "0x6B5D50", VA = "0x1806B7750")]
	public void StartEveGame()
	{
		Board board = this.board;
		bool flag = !board.isEveStart;
		board.isEveStart = flag;
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x000ED308 File Offset: 0x000EB508
	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x6B6F20", Offset = "0x6B5520", VA = "0x1806B6F20")]
	public void SaveThePlant()
	{
		int num2;
		do
		{
			int num = 0;
			List<GameAPP.EVEPlant> plantEVE = GameAPP.plantEVE;
			num2 = 0;
			plantEVE._size = num2;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				List<GameAPP.EVEPlant> plantEVE2 = GameAPP.plantEVE;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x000ED368 File Offset: 0x000EB568
	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x6B3B90", Offset = "0x6B2190", VA = "0x1806B3B90")]
	public void LoadPlants()
	{
		int num5;
		do
		{
			int num = 0;
			List<Plant> list = new List();
			List<Plant> plantArray = this.board.boardEntity.plantArray;
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
				goto IL_008E;
			}
			int num4 = 0;
			bool flag2;
			if (flag2)
			{
			}
			if (num4 != 0)
			{
				goto IL_0094;
			}
			num5 = 0;
			List<GameAPP.EVEPlant> plantEVE = GameAPP.plantEVE;
			bool flag3;
			if (flag3)
			{
				CreatePlant instance = CreatePlant.Instance;
				int num6 = 0;
				Plant plant;
				if (!(plant != num6))
				{
					continue;
				}
				while (plant == 0)
				{
				}
				int num7 = 0;
				plant.AttributeCountdown = (float)num7;
			}
		}
		while (num5 != 0);
		return;
		IL_008E:
		throw new NullReferenceException();
		IL_0094:
		throw new NullReferenceException();
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x000ED410 File Offset: 0x000EB610
	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x6B7310", Offset = "0x6B5910", VA = "0x1806B7310")]
	public void SetPlant()
	{
		int num = 0;
		Board board = this.board;
		if (num < board.rowNum)
		{
			List<Plant> plants = board.gridSystem.GetGrid(num, num).plants;
			Board board2 = this.board;
			int num2 = 0;
			Plant plant = board2.SetEvePlants(num, num, num2 != 0);
			num++;
		}
		num++;
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x000ED468 File Offset: 0x000EB668
	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x6B24F0", Offset = "0x6B0AF0", VA = "0x1806B24F0")]
	public void AutoGame()
	{
		this.board.isEveStart = true;
		this.board.isAutoEve = true;
		this.SaveThePlant();
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x000ED49C File Offset: 0x000EB69C
	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x6B7630", Offset = "0x6B5C30", VA = "0x1806B7630")]
	public void ShowPlantCards()
	{
		GameObject plantLibrary = IZBottomMenu.Instance.plantLibrary;
		if (!plantLibrary.activeSelf)
		{
			plantLibrary.SetActive(true);
			Time.timeScale = (float)0;
			return;
		}
		int num = 0;
		plantLibrary.SetActive(num != 0);
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x000ED4EC File Offset: 0x000EB6EC
	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x6B6A40", Offset = "0x6B5040", VA = "0x1806B6A40")]
	public void SaveCustomIZ()
	{
		Board instance;
		string text;
		List<SavePlantData> list;
		ulong num3;
		do
		{
			int num = 0;
			instance = Board.Instance;
			text = Path.Combine(SaveInfo.GetDataPath(), "CustomIZ.json");
			list = new List();
			List<Plant> plantArray = instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				SavePlantData savePlantData = new SavePlantData(num);
			}
		}
		while (num3 != (ulong)0L);
		List<ZombieType> list2 = new List();
		CardUI[] cardOnBank = InGameUI_IZ.Instance.cardOnBank;
		int num4 = 0;
		int num5 = 0;
		if (num5 < cardOnBank.Length)
		{
			bool flag2;
			if (flag2)
			{
			}
			num4++;
		}
		IZData izdata = new IZData();
		izdata.plants = list;
		int theSun = instance.theSun;
		izdata.theSun = theSun;
		izdata.zombietTypes = list2;
		int izDropCount = instance.config.izDropCount;
		izdata.dropSunPerPlant = izDropCount;
		int difficulty = GameAPP.config.difficulty;
		izdata.recommendDifficulty = difficulty;
		int redLineColumn = instance.config.redLineColumn;
		izdata.redlineColumn = redLineColumn;
		SceneType sceneType = instance.sceneType;
		izdata.sceneType = sceneType;
		string text2 = JsonUtility.ToJson(izdata);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text));
		File.WriteAllText(text, text2);
		InGameText instance2 = InGameText.Instance;
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x000ED634 File Offset: 0x000EB834
	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x6B25B0", Offset = "0x6B0BB0", VA = "0x1806B25B0")]
	public void ChangeMap()
	{
		GameAPP.UIManager.PopAll();
		this.board.Die();
		Board board = this.board;
		int theBoardLevel = GameAPP.theBoardLevel;
		SceneType sceneType = board.sceneType;
		List<SceneType> sceneOrder = this.SceneOrder;
		int num;
		if (num != -1)
		{
			List<SceneType> sceneOrder2 = this.SceneOrder;
			num++;
		}
		Debug.LogError(string.Format("SceneType {0} not found in SceneOrder!", num));
		List<SceneType> sceneOrder3 = this.SceneOrder;
		int num2 = 0;
		SceneType sceneType2 = sceneOrder3[num2];
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x000ED6BC File Offset: 0x000EB8BC
	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x6B2AA0", Offset = "0x6B10A0", VA = "0x1806B2AA0")]
	private SceneType GetNextSceneType(SceneType currentScene)
	{
		List<SceneType> sceneOrder = this.SceneOrder;
		int num;
		if (num != -1)
		{
			List<SceneType> sceneOrder2 = this.SceneOrder;
			num++;
			return sceneOrder2[(int)currentScene];
		}
		Debug.LogError(string.Format("SceneType {0} not found in SceneOrder!", num));
		List<SceneType> sceneOrder3 = this.SceneOrder;
		int num2 = 0;
		return sceneOrder3[num2];
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x000ED720 File Offset: 0x000EB920
	[Token(Token = "0x6002BAA")]
	[Address(RVA = "0x6B2BD0", Offset = "0x6B11D0", VA = "0x1806B2BD0")]
	public static PlantType GetPlantType(int row)
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		int size16 = list._size;
		int size17 = list._size;
		int size18 = list._size;
		int size19 = list._size;
		int size20 = list._size;
		int size21 = list._size;
		int size22 = list._size;
		int size23 = list._size;
		int size24 = list._size;
		int size25 = list._size;
		int size26 = list._size;
		int size27 = list._size;
		int size28 = list._size;
		int size29 = list._size;
		int size30 = list._size;
		int size31 = list._size;
		int size32 = list._size;
		int size33 = list._size;
		int size34 = list._size;
		int size35 = list._size;
		int size36 = list._size;
		int size37 = list._size;
		int size38 = list._size;
		int size39 = list._size;
		int size40 = list._size;
		Predicate<PlantType> <>9__17_ = EveManager.<>c.<>9__17_0;
		if (<>9__17_ == 0)
		{
			EveManager.<>c.<>9__17_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num = list.RemoveAll(<>9__17_);
		return ListExtensions.GetRandom<PlantType>(list);
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x000ED8B4 File Offset: 0x000EBAB4
	[Token(Token = "0x6002BAB")]
	[Address(RVA = "0x6B7DA0", Offset = "0x6B63A0", VA = "0x1806B7DA0")]
	public void WantSelect()
	{
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x000ED8D0 File Offset: 0x000EBAD0
	[Token(Token = "0x6002BAC")]
	[Address(RVA = "0x6B7250", Offset = "0x6B5850", VA = "0x1806B7250")]
	public void SelectTeam(int row)
	{
		NewEveData newEveData = this.newEveData;
		newEveData.selectedRow = row;
		InGameText instance = InGameText.Instance;
		int num = row + 1;
		string text = string.Format("已选择第{0}路", instance);
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x000ED90C File Offset: 0x000EBB0C
	[Token(Token = "0x6002BAD")]
	[Address(RVA = "0x6B7180", Offset = "0x6B5780", VA = "0x1806B7180")]
	public void SelectConfirm()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)58), canvasUp, num != 0);
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x000ED948 File Offset: 0x000EBB48
	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x6B4090", Offset = "0x6B2690", VA = "0x1806B4090")]
	public void LookBuff(int row)
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)58), canvasUp, num != 0);
		Time.timeScale = (float)0;
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x000ED980 File Offset: 0x000EBB80
	[Token(Token = "0x6002BAF")]
	[Address(RVA = "0x6B2830", Offset = "0x6B0E30", VA = "0x1806B2830")]
	public void GameStart()
	{
		EveManager.<GameUpdate>d__31 <GameUpdate>d__;
		<GameUpdate>d__.System.IDisposable.Dispose();
		<GameUpdate>d__.<>1__state = (int)((ulong)0L);
		<GameUpdate>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<GameUpdate>d__);
		this.gameUpdate = coroutine;
		this.SaveThePlant();
		GameObject newEveModeButton = IZBottomMenu.Instance.newEveModeButton;
		int num = 0;
		newEveModeButton.SetActive(num != 0);
		IZBottomMenu.Instance.lookBuffButton.SetActive(true);
		this.OnGameStart();
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x000ED9EC File Offset: 0x000EBBEC
	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x6B67F0", Offset = "0x6B4DF0", VA = "0x1806B67F0")]
	public void RoundOver()
	{
		if (this.gameUpdate != (ulong)0L)
		{
			Coroutine coroutine = this.gameUpdate;
			base.StopCoroutine(coroutine);
		}
		NewEveData newEveData = this.newEveData;
		NewEveData newEveData2 = this.newEveData;
		int num = 0;
		List<int> recoverTimes = newEveData2.recoverTimes;
		List<int> recoverTimes2 = newEveData2.recoverTimes;
		int num2 = 0;
		recoverTimes2[num] = num2;
		NewEveData newEveData3 = this.newEveData;
		num++;
		EveManager.<GameOver>d__29 <GameOver>d__;
		<GameOver>d__.System.IDisposable.Dispose();
		<GameOver>d__.<>1__state = (int)((ulong)0L);
		<GameOver>d__.<>4__this = this;
		Coroutine coroutine2 = base.StartCoroutine(<GameOver>d__);
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x000EDAD0 File Offset: 0x000EBCD0
	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x6B29B0", Offset = "0x6B0FB0", VA = "0x1806B29B0")]
	private int GetMaxPointIndex()
	{
		int num = Enumerable.Max(this.newEveData.points);
		int maxValue = num;
		List<int> points = this.newEveData.points;
		Predicate<int> predicate = (int x) => x == maxValue;
		return points.FindIndex(predicate);
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x000EDB24 File Offset: 0x000EBD24
	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x6B6590", Offset = "0x6B4B90", VA = "0x1806B6590")]
	private void ResetPlant()
	{
		int num;
		do
		{
			this.board.brainManager.SetBrains();
			num = 0;
			Board board = this.board;
			Board board2 = this.board;
			if (num < board.rowNum)
			{
				BoardAction boardAction = board2.boardAction;
				num++;
				Board board3 = this.board;
			}
			BoardAction boardAction2 = board2.boardAction;
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x000EDBA0 File Offset: 0x000EBDA0
	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x6B27C0", Offset = "0x6B0DC0", VA = "0x1806B27C0")]
	private IEnumerator GameOver()
	{
		EveManager.<GameOver>d__29 <GameOver>d__;
		<GameOver>d__.System.IDisposable.Dispose();
		<GameOver>d__.<>1__state = (int)((ulong)0L);
		<GameOver>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x000EDBC4 File Offset: 0x000EBDC4
	[Token(Token = "0x6002BB4")]
	[Address(RVA = "0x6B62E0", Offset = "0x6B48E0", VA = "0x1806B62E0")]
	private void RandomZombieBuff()
	{
		this.newEveData.zombieBuffs._size = (int)((ulong)0L);
		Array values = Enum.GetValues(typeof(EveZombieBuff));
		if (values == 0 || values != 0)
		{
			EveZombieBuff random = ListExtensions.GetRandom<EveZombieBuff>(Enumerable.ToList<EveZombieBuff>(values));
			NewEveData newEveData = this.newEveData;
			int size = newEveData.zombieBuffs._size;
			InGameText instance = InGameText.Instance;
			string text2;
			string text = "随机到的僵尸词条：\n" + text2;
			IZBottomMenu.Instance.ChangeString(text2);
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000EDC50 File Offset: 0x000EBE50
	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x6B2940", Offset = "0x6B0F40", VA = "0x1806B2940")]
	private IEnumerator GameUpdate()
	{
		EveManager.<GameUpdate>d__31 <GameUpdate>d__;
		<GameUpdate>d__.System.IDisposable.Dispose();
		<GameUpdate>d__.<>1__state = (int)((ulong)0L);
		<GameUpdate>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x000EDC74 File Offset: 0x000EBE74
	[Token(Token = "0x6002BB6")]
	[Address(RVA = "0x6B73D0", Offset = "0x6B59D0", VA = "0x1806B73D0")]
	private void SetRandomZombies(float more)
	{
		int num = 0;
		int i = num;
		int rowNum = this.board.rowNum;
		if (i < rowNum)
		{
			List<Brain> brains = this.board.brainManager.brains;
			Func<Brain, bool> func = delegate(Brain brain)
			{
				int i2 = i;
				return brain.theRow == i2;
			};
			if (Enumerable.FirstOrDefault<Brain>(brains, func))
			{
				CreateZombie instance = CreateZombie.Instance;
				int j = i;
				Zombie zombie = instance.SetZombie(j, (ZombieType)((uint)105), 9.9f, num != 0);
				int num2 = 0;
				if (zombie != num2)
				{
					Zombie component = zombie.GetComponent<Zombie>();
					component.theHealth = zombie;
					component.theMaxHealth = zombie;
				}
			}
		}
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x000EDD2C File Offset: 0x000EBF2C
	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x6B4180", Offset = "0x6B2780", VA = "0x1806B4180")]
	private void OnGameStart()
	{
		EveManager.<>c__DisplayClass33_0 CS$<>8__locals1;
		for (;;)
		{
			int i = 0;
			int num = 0;
			List<List<EveBuff>> eveBuffs = this.newEveData.eveBuffs;
			List<EveBuff> list = this.newEveData.eveBuffs[num];
			bool flag;
			if (flag)
			{
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.theRow = num;
				while (i > 31)
				{
				}
				int theRow = CS$<>8__locals1.theRow;
				List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, theRow);
				bool flag2;
				if (flag2)
				{
				}
				if (num == 0)
				{
					int num2 = 0;
					int theRow2 = CS$<>8__locals1.theRow;
					uint num3;
					List<Plant> list2 = global::Lawnf.Get1x1Plants((int)num3, theRow2);
					bool flag3;
					if (flag3)
					{
					}
					if (num2 == 0)
					{
						int num4 = 0;
						Action action = delegate
						{
							ulong num15;
							do
							{
								int num14 = 0;
								List<Zombie> zombiesByRow = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num14 != 0);
								bool flag9;
								if (flag9)
								{
								}
							}
							while (num15 != (ulong)0L);
						};
						EveManager.CyclicTimer cyclicTimer = new EveManager.CyclicTimer(15f, action);
						Action action2 = delegate
						{
							BoardAction boardAction = CS$<>8__locals1.<>4__this.board.boardAction;
						};
						EveManager.CyclicTimer cyclicTimer2 = new EveManager.CyclicTimer(45f, action2);
						Action action3 = delegate
						{
							ulong num17;
							do
							{
								int num16 = 0;
								List<Zombie> zombiesByRow2 = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num16 != 0);
								bool flag10;
								if (flag10)
								{
								}
							}
							while (num17 != (ulong)0L);
						};
						Action action4 = delegate
						{
							ulong num19;
							do
							{
								int num18 = 0;
								List<Zombie> zombiesByRow3 = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num18 != 0);
								bool flag11;
								if (flag11)
								{
								}
							}
							while (num19 != (ulong)0L);
						};
						EveManager.CyclicTimer cyclicTimer3 = new EveManager.CyclicTimer(delegate
						{
							bool flag12;
							ulong num21;
							do
							{
								int num20 = 0;
								List<Zombie> zombiesByRow4 = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num20 != 0);
							}
							while ((flag12 && global::UnityEngine.Random.Range(0, 2) != 0) || num21 != (ulong)0L);
						});
						Action action5 = delegate
						{
							bool flag13;
							ulong num23;
							do
							{
								int num22 = 0;
								List<Zombie> zombiesByRow5 = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num22 != 0);
							}
							while ((flag13 && global::UnityEngine.Random.Range(0, 2) != 0) || num23 != (ulong)0L);
						};
						Action action6 = delegate
						{
							bool flag14;
							ulong num25;
							do
							{
								int num24 = 0;
								List<Zombie> zombiesByRow6 = global::Lawnf.GetZombiesByRow(CS$<>8__locals1.theRow, num24 != 0);
							}
							while ((flag14 && global::UnityEngine.Random.Range(0, 2) != 0) || num25 != (ulong)0L);
						};
						EveManager.CyclicTimer cyclicTimer4 = new EveManager.CyclicTimer(delegate
						{
							int theRow8 = CS$<>8__locals1.theRow;
							int num26 = 0;
							Zombie random = ListExtensions.GetRandom<Zombie>(global::Lawnf.GetZombiesByRow(theRow8, num26 != 0));
							int num27 = 0;
							if (random != num27)
							{
							}
						});
						Action action7 = delegate
						{
							int theRow9 = CS$<>8__locals1.theRow;
							int num28 = 0;
							Zombie random2 = ListExtensions.GetRandom<Zombie>(global::Lawnf.GetZombiesByRow(theRow9, num28 != 0));
							int num29 = 0;
							if (random2 != num29)
							{
							}
						};
						EveManager.CyclicTimer cyclicTimer5 = new EveManager.CyclicTimer(delegate
						{
							ulong num30;
							do
							{
								List<Plant> allPlants = global::Lawnf.GetAllPlants();
								bool flag15;
								if (flag15)
								{
									int theRow10 = CS$<>8__locals1.theRow;
								}
							}
							while (num30 != (ulong)0L);
						});
						Action action8 = delegate
						{
							ulong num31;
							do
							{
								List<Plant> allPlants2 = global::Lawnf.GetAllPlants();
								bool flag16;
								if (flag16)
								{
									int theRow11 = CS$<>8__locals1.theRow;
								}
							}
							while (num31 != (ulong)0L);
						};
						Action action9 = delegate
						{
							ulong num32;
							do
							{
								List<Plant> allPlants3 = global::Lawnf.GetAllPlants();
								bool flag17;
								if (flag17)
								{
									int theRow12 = CS$<>8__locals1.theRow;
								}
							}
							while (num32 != (ulong)0L);
						};
						bool flag4;
						if (flag4)
						{
						}
						if (num4 == 0)
						{
							int num5 = 0;
							int theRow3 = CS$<>8__locals1.theRow;
							uint num6;
							List<Plant> list3 = global::Lawnf.Get1x1Plants((int)num6, theRow3);
							bool flag5;
							if (flag5)
							{
							}
							if (num5 == 0)
							{
								int num7 = 0;
								bool flag6;
								if (flag6)
								{
									int theRow4 = CS$<>8__locals1.theRow;
								}
								if (num7 == 0)
								{
									int num8 = 0;
									int num9;
									while (num9 == CS$<>8__locals1.theRow)
									{
									}
									bool flag7;
									if (flag7)
									{
									}
									if (num8 == 0)
									{
										int num10 = 0;
										CreatePlant instance = CreatePlant.Instance;
										EveManager.<>c__DisplayClass33_1 CS$<>8__locals2;
										Plant plant;
										CS$<>8__locals2.temp = plant;
										DelayAction delayAction = GameAPP.delayAction;
										Action action10 = delegate
										{
											Plant temp = CS$<>8__locals2.temp;
											int num33 = 0;
											if (temp != num33)
											{
												Plant temp2 = CS$<>8__locals2.temp;
												int num34 = 0;
												temp2.Die((Plant.DieReason)num34);
											}
										};
										delayAction.SetAction(action10, 90f);
										CreatePlant instance2 = CreatePlant.Instance;
										Action action11 = delegate
										{
											int num36;
											do
											{
												EveManager <>4__this = CS$<>8__locals1.<>4__this;
												int theRow13 = CS$<>8__locals1.theRow;
												List<Plant> plantsByRow2 = global::Lawnf.GetPlantsByRow(<>4__this.board, theRow13);
												int num35 = 0;
												bool flag18;
												if (flag18)
												{
												}
												if (num35 != 0)
												{
													goto IL_0047;
												}
												num36 = 0;
												bool flag19;
												if (flag19)
												{
												}
											}
											while (num36 != 0);
											return;
											IL_0047:
											throw new NullReferenceException();
										};
										bool flag8;
										if (flag8)
										{
										}
										if (num10 == 0)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		int theRow5 = CS$<>8__locals1.theRow;
		int theRow6 = CS$<>8__locals1.theRow;
		uint num11;
		List<Plant> list4 = global::Lawnf.Get1x1Plants((int)num11, theRow6);
		int theRow7 = CS$<>8__locals1.theRow;
		uint num12;
		List<Plant> list5 = global::Lawnf.Get1x1Plants((int)num12, theRow7);
		Func<Plant, int> func;
		if (EveManager.<>c.<>9__33_12 == 0)
		{
			EveManager.<>c.<>9__33_12 = func;
		}
		int num13 = Enumerable.Max<Plant>(list4, func);
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x000EDFA8 File Offset: 0x000EC1A8
	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x6B7E10", Offset = "0x6B6410", VA = "0x1806B7E10")]
	public EveManager()
	{
		List<SceneType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		this.SceneOrder = list;
		NewEveData newEveData = new NewEveData();
		this.newEveData = newEveData;
		List<EveManager.CyclicTimer> list2 = new List();
		this.cyclicTimers = list2;
		base..ctor();
	}

	// Token: 0x040019A8 RID: 6568
	[Token(Token = "0x40019A8")]
	public static EveManager Instance;

	// Token: 0x040019A9 RID: 6569
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019A9")]
	public bool newEve;

	// Token: 0x040019AA RID: 6570
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019AA")]
	private Board board;

	// Token: 0x040019AB RID: 6571
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019AB")]
	private readonly List<SceneType> SceneOrder;

	// Token: 0x040019AC RID: 6572
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019AC")]
	public NewEveData newEveData;

	// Token: 0x040019AD RID: 6573
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019AD")]
	public Coroutine gameUpdate;

	// Token: 0x040019AE RID: 6574
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019AE")]
	public List<EveManager.CyclicTimer> cyclicTimers;

	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	[Serializable]
	public class CyclicTimer
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x000EE01C File Offset: 0x000EC21C
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x6B0D20", Offset = "0x6AF320", VA = "0x1806B0D20")]
		public CyclicTimer(float interval, Action action)
		{
			this.timer = interval;
			this.interval = interval;
			this.action = action;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000EE044 File Offset: 0x000EC244
		[Token(Token = "0x6002BBA")]
		[Address(RVA = "0x6B0CC0", Offset = "0x6AF2C0", VA = "0x1806B0CC0")]
		public void OnUpdate()
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num;
			Action action = this.action;
			float num2 = this.interval;
			this.timer = num2;
			if (action != 0)
			{
			}
		}

		// Token: 0x040019AF RID: 6575
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40019AF")]
		public float timer;

		// Token: 0x040019B0 RID: 6576
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40019B0")]
		public float interval;

		// Token: 0x040019B1 RID: 6577
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40019B1")]
		public Action action;
	}
}
