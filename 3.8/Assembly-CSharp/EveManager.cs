using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000829 RID: 2089
[Token(Token = "0x2000829")]
public class EveManager : MonoBehaviour
{
	// Token: 0x06002A6B RID: 10859 RVA: 0x000E831C File Offset: 0x000E651C
	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x64E780", Offset = "0x64CD80", VA = "0x18064E780")]
	private void Awake()
	{
		EveManager.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x000E833C File Offset: 0x000E653C
	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x653970", Offset = "0x651F70", VA = "0x180653970")]
	public void StartEveMode()
	{
		this.board.isEveStarted = true;
		this.board.AddLightLevel(3);
		InGameUI_IZ.Instance.shovel.SetActive(true);
		InGameUI_IZ.Instance.glove.SetActive(true);
		InGameUI_IZ.Instance.wheel.SetActive(true);
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x000E8398 File Offset: 0x000E6598
	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x64FD30", Offset = "0x64E330", VA = "0x18064FD30")]
	private void Limit()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x000E83B8 File Offset: 0x000E65B8
	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x653A50", Offset = "0x652050", VA = "0x180653A50")]
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

	// Token: 0x06002A6F RID: 10863 RVA: 0x000E84AC File Offset: 0x000E66AC
	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x653940", Offset = "0x651F40", VA = "0x180653940")]
	public void StartEveGame()
	{
		Board board = this.board;
		bool flag = !board.isEveStart;
		board.isEveStart = flag;
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x000E84D8 File Offset: 0x000E66D8
	[Token(Token = "0x6002A70")]
	[Address(RVA = "0x653140", Offset = "0x651740", VA = "0x180653140")]
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

	// Token: 0x06002A71 RID: 10865 RVA: 0x000E8538 File Offset: 0x000E6738
	[Token(Token = "0x6002A71")]
	[Address(RVA = "0x64FDE0", Offset = "0x64E3E0", VA = "0x18064FDE0")]
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

	// Token: 0x06002A72 RID: 10866 RVA: 0x000E85E0 File Offset: 0x000E67E0
	[Token(Token = "0x6002A72")]
	[Address(RVA = "0x653510", Offset = "0x651B10", VA = "0x180653510")]
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

	// Token: 0x06002A73 RID: 10867 RVA: 0x000E8638 File Offset: 0x000E6838
	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x64E740", Offset = "0x64CD40", VA = "0x18064E740")]
	public void AutoGame()
	{
		this.board.isEveStart = true;
		this.board.isAutoEve = true;
		this.SaveThePlant();
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x000E866C File Offset: 0x000E686C
	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x653820", Offset = "0x651E20", VA = "0x180653820")]
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

	// Token: 0x06002A75 RID: 10869 RVA: 0x000E86BC File Offset: 0x000E68BC
	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x652C70", Offset = "0x651270", VA = "0x180652C70")]
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
		int num6 = 0;
		instance2.ShowText("保存成功，前往我是僵尸的自定义关卡游玩\n自定义允许使用的僵尸为当前卡槽上的僵尸，初始阳光数为当前阳光，推荐难度为当前难度\n自定义关卡信息在存档文件夹下的CustomIZ.json", 20f, num6 != 0);
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x000E8818 File Offset: 0x000E6A18
	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x64E800", Offset = "0x64CE00", VA = "0x18064E800")]
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

	// Token: 0x06002A77 RID: 10871 RVA: 0x000E88A0 File Offset: 0x000E6AA0
	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x64ECF0", Offset = "0x64D2F0", VA = "0x18064ECF0")]
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

	// Token: 0x06002A78 RID: 10872 RVA: 0x000E8904 File Offset: 0x000E6B04
	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x64EE20", Offset = "0x64D420", VA = "0x18064EE20")]
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

	// Token: 0x06002A79 RID: 10873 RVA: 0x000E8A98 File Offset: 0x000E6C98
	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x653F90", Offset = "0x652590", VA = "0x180653F90")]
	public void WantSelect()
	{
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("在5个队伍中选择1个你认为最强的队伍", 5f, num != 0);
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x000E8AC8 File Offset: 0x000E6CC8
	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x653460", Offset = "0x651A60", VA = "0x180653460")]
	public void SelectTeam(int row)
	{
		NewEveData newEveData = this.newEveData;
		newEveData.selectedRow = row;
		InGameText instance = InGameText.Instance;
		int num = row + 1;
		string text = string.Format("已选择第{0}路", instance);
		int num2 = 0;
		instance.ShowText(text, 3f, num2 != 0);
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x000E8B14 File Offset: 0x000E6D14
	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x6533A0", Offset = "0x6519A0", VA = "0x1806533A0")]
	public void SelectConfirm()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)58), canvasUp, num != 0);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("为你的队伍挑选词条", 3f, num2 != 0);
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x000E8B64 File Offset: 0x000E6D64
	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x6502E0", Offset = "0x64E8E0", VA = "0x1806502E0")]
	public void LookBuff(int row)
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)58), canvasUp, num != 0);
		Time.timeScale = (float)0;
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x000E8B9C File Offset: 0x000E6D9C
	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x64EA80", Offset = "0x64D080", VA = "0x18064EA80")]
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

	// Token: 0x06002A7E RID: 10878 RVA: 0x000E8C08 File Offset: 0x000E6E08
	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x652A30", Offset = "0x651030", VA = "0x180652A30")]
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

	// Token: 0x06002A7F RID: 10879 RVA: 0x000E8CFC File Offset: 0x000E6EFC
	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x64EC00", Offset = "0x64D200", VA = "0x18064EC00")]
	private int GetMaxPointIndex()
	{
		int num = Enumerable.Max(this.newEveData.points);
		int maxValue = num;
		List<int> points = this.newEveData.points;
		Predicate<int> predicate = (int x) => x == maxValue;
		return points.FindIndex(predicate);
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x000E8D50 File Offset: 0x000E6F50
	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x6527D0", Offset = "0x650DD0", VA = "0x1806527D0")]
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

	// Token: 0x06002A81 RID: 10881 RVA: 0x000E8DCC File Offset: 0x000E6FCC
	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x64EA10", Offset = "0x64D010", VA = "0x18064EA10")]
	private IEnumerator GameOver()
	{
		EveManager.<GameOver>d__29 <GameOver>d__;
		<GameOver>d__.System.IDisposable.Dispose();
		<GameOver>d__.<>1__state = (int)((ulong)0L);
		<GameOver>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000E8DF0 File Offset: 0x000E6FF0
	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x652530", Offset = "0x650B30", VA = "0x180652530")]
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
			int num = 0;
			instance.ShowText(text, 5f, num != 0);
			IZBottomMenu.Instance.ChangeString(text2);
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x000E8E90 File Offset: 0x000E7090
	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x64EB90", Offset = "0x64D190", VA = "0x18064EB90")]
	private IEnumerator GameUpdate()
	{
		EveManager.<GameUpdate>d__31 <GameUpdate>d__;
		<GameUpdate>d__.System.IDisposable.Dispose();
		<GameUpdate>d__.<>1__state = (int)((ulong)0L);
		<GameUpdate>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000E8EB4 File Offset: 0x000E70B4
	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x6535D0", Offset = "0x651BD0", VA = "0x1806535D0")]
	private void SetRandomZombies(float more)
	{
		int num = 0;
		int i = num;
		int rowNum = this.board.rowNum;
		Func<Brain, bool> func;
		if (i < rowNum && Enumerable.FirstOrDefault<Brain>(this.board.brainManager.brains, func))
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

	// Token: 0x06002A85 RID: 10885 RVA: 0x000E8F58 File Offset: 0x000E7158
	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x6503D0", Offset = "0x64E9D0", VA = "0x1806503D0")]
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

	// Token: 0x06002A86 RID: 10886 RVA: 0x000E91D4 File Offset: 0x000E73D4
	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x653FF0", Offset = "0x6525F0", VA = "0x180653FF0")]
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

	// Token: 0x040018BA RID: 6330
	[Token(Token = "0x40018BA")]
	public static EveManager Instance;

	// Token: 0x040018BB RID: 6331
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018BB")]
	public bool newEve;

	// Token: 0x040018BC RID: 6332
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018BC")]
	private Board board;

	// Token: 0x040018BD RID: 6333
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018BD")]
	private readonly List<SceneType> SceneOrder;

	// Token: 0x040018BE RID: 6334
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018BE")]
	public NewEveData newEveData;

	// Token: 0x040018BF RID: 6335
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018BF")]
	public Coroutine gameUpdate;

	// Token: 0x040018C0 RID: 6336
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018C0")]
	public List<EveManager.CyclicTimer> cyclicTimers;

	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	[Serializable]
	public class CyclicTimer
	{
		// Token: 0x06002A87 RID: 10887 RVA: 0x000E9248 File Offset: 0x000E7448
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x64C990", Offset = "0x64AF90", VA = "0x18064C990")]
		public CyclicTimer(float interval, Action action)
		{
			this.timer = interval;
			this.interval = interval;
			this.action = action;
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000E9270 File Offset: 0x000E7470
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x64C930", Offset = "0x64AF30", VA = "0x18064C930")]
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

		// Token: 0x040018C1 RID: 6337
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40018C1")]
		public float timer;

		// Token: 0x040018C2 RID: 6338
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40018C2")]
		public float interval;

		// Token: 0x040018C3 RID: 6339
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40018C3")]
		public Action action;
	}
}
