using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel;
using UI;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000241 RID: 577
[Token(Token = "0x2000241")]
public class InitBoard : MonoBehaviour
{
	// Token: 0x06000A25 RID: 2597 RVA: 0x0003685C File Offset: 0x00034A5C
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x9101F0", Offset = "0x90E7F0", VA = "0x1809101F0")]
	private void Awake()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0003687C File Offset: 0x00034A7C
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x910830", Offset = "0x90EE30", VA = "0x180910830")]
	private void InitCamPos()
	{
		Board board = this.board;
		Camera main = Camera.main;
		float cameraSize = GameAPP.config.cameraSize;
		main.orthographicSize = cameraSize;
		UIConfig uiconfig = GameAPP.config.UIConfig;
		float y = uiconfig.seedBankOffset.y;
		Vector2 seedBankOffset = uiconfig.seedBankOffset;
		this.seedBank_showPos.y = y;
		this.seedBank_showPos = seedBankOffset;
		UIConfig uiconfig2 = GameAPP.config.UIConfig;
		float y2 = uiconfig2.seedBankOffset.y;
		Vector2 seedBankOffset2 = uiconfig2.seedBankOffset;
		this.seedBank_hidePos.y = y2;
		this.seedBank_hidePos = seedBankOffset2;
		UIConfig uiconfig3 = GameAPP.config.UIConfig;
		float y3 = uiconfig3.bottomOffset.y;
		Vector2 bottomOffset = uiconfig3.bottomOffset;
		this.bottom_showPos.y = y3;
		this.bottom_showPos = bottomOffset;
		UIConfig uiconfig4 = GameAPP.config.UIConfig;
		float y4 = uiconfig4.bottomOffset.y;
		Vector2 bottomOffset2 = uiconfig4.bottomOffset;
		this.bottom_hidePos.y = y4;
		this.bottom_hidePos = bottomOffset2;
		Transform transform = InGameUI.Instance.ConveyorBelt.transform;
		UIConfig uiconfig5 = GameAPP.config.UIConfig;
		RectTransform toolContainer = InGameUI.Instance.toolContainer;
		int num = 0;
		Vector2 anchoredPosition = toolContainer.anchoredPosition;
		UIConfig uiconfig6 = GameAPP.config.UIConfig;
		toolContainer.anchoredPosition = num;
		RectTransform buttonContainer = InGameUI.Instance.buttonContainer;
		int num2 = 0;
		Vector2 anchoredPosition2 = buttonContainer.anchoredPosition;
		UIConfig uiconfig7 = GameAPP.config.UIConfig;
		buttonContainer.anchoredPosition = num2;
		Transform transform2 = InGameUI.Instance.buttonContainer.transform;
		UIConfig uiconfig8 = GameAPP.config.UIConfig;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00036A34 File Offset: 0x00034C34
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x912980", Offset = "0x910F80", VA = "0x180912980")]
	private void QuickInGame()
	{
		int num25;
		do
		{
			Transform transform = Camera.main.transform;
			float z = this.camPos_startGame.z;
			int num = 0;
			GameAPP.theGameStatus = (GameStatus)num;
			Transform transform2 = InGameUI.Instance.transform;
			Transform canvas = GameAPP.canvas;
			transform2.parentInternal = canvas;
			GameObject gameObject = InGameUI.Instance.LevelName1.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			GameObject backToMenu = InGameUI.Instance.BackToMenu;
			int num3 = 0;
			backToMenu.SetActive(num3 != 0);
			GameObject bottom = InGameUI.Instance.Bottom;
			int num4 = 0;
			bottom.SetActive(num4 != 0);
			RectTransform component = InGameUI.Instance.SeedBank.GetComponent<RectTransform>();
			ulong num5;
			InGameUI.Instance.ShovelBank.SetActive(num5 != 0UL);
			ulong num6;
			InGameUI.Instance.SlowTrigger.SetActive(num6 != 0UL);
			ulong num7;
			InGameUI.Instance.IngameMenu.SetActive(num7 != 0UL);
			ulong num8;
			InGameUI.Instance.LevelName2.gameObject.SetActive(num8 != 0UL);
			ulong num9;
			InGameUI.Instance.ZombieNum.SetActive(num9 != 0UL);
			GameObject bossHealth = InGameUI.Instance.bossHealth;
			int num10 = 0;
			if (bossHealth != num10)
			{
				ulong num11;
				InGameUI.Instance.bossHealth.SetActive(num11 != 0UL);
			}
			if ((this.board.cardBank ? 1 : 0) == num)
			{
				GameObject seedBank = InGameUI.Instance.SeedBank;
				int num12 = 0;
				seedBank.SetActive(num12 != 0);
			}
			global::Lawnf.SetMusic(this.board);
			Board board = this.board;
			GameAPP instance = GameAPP.Instance;
			int num13 = 0;
			int num14 = 0;
			ulong num15;
			this.CreateCard((PlantType)num14, num15 != 0UL, num13 != 0).theSeedCost = (int)((ulong)200L);
			CardUI cardUI;
			cardUI.theSeedCost = (int)((ulong)200L);
			CardUI cardUI2;
			cardUI2.theSeedCost = (int)((ulong)200L);
			CardUI cardUI3;
			cardUI3.theSeedCost = (int)((ulong)200L);
			CardUI cardUI4;
			cardUI4.theSeedCost = (int)((ulong)200L);
			CardUI cardUI5;
			cardUI5.theSeedCost = (int)((ulong)200L);
			CardUI cardUI6;
			cardUI6.theSeedCost = (int)((ulong)100L);
			GameObject shovelBank = InGameUI.Instance.ShovelBank;
			int num16 = 0;
			shovelBank.SetActive(num16 != 0);
			ulong num17;
			InGameUI.Instance.GloveBank.SetActive(num17 != 0UL);
			Transform transform3 = InGameUI.Instance.transform;
			Transform canvasUp = GameAPP.canvasUp;
			transform3.parentInternal = canvasUp;
			Camera.main.orthographicSize = 9f;
			Transform transform4 = Camera.main.transform;
			GameAPP instance2 = GameAPP.Instance;
			InGameText instance3 = InGameText.Instance;
			ulong num18;
			InGameUI.Instance.GloveBank.SetActive(num18 != 0UL);
			ulong num19;
			InGameUI.Instance.HammerBank.SetActive(num19 != 0UL);
			IZECard izecard;
			izecard.theSeedCost = (int)((ulong)50L);
			IZECard izecard2;
			izecard2.theSeedCost = (int)((ulong)150L);
			IZECard izecard3;
			izecard3.theSeedCost = (int)((ulong)250L);
			IZECard izecard4;
			izecard4.theSeedCost = (int)((ulong)300L);
			IZECard izecard5;
			izecard5.theSeedCost = (int)((ulong)150L);
			IZECard izecard6;
			izecard6.theSeedCost = (int)((ulong)300L);
			GameAPP instance4 = GameAPP.Instance;
			InGameText instance5 = InGameText.Instance;
			ulong num20;
			InGameUI.Instance.GloveBank.SetActive(num20 != 0UL);
			ulong num21;
			InGameUI.Instance.HammerBank.SetActive(num21 != 0UL);
			IZECard izecard7;
			izecard7.theSeedCost = (int)((ulong)50L);
			IZECard izecard8;
			izecard8.theSeedCost = (int)((ulong)150L);
			IZECard izecard9;
			izecard9.theSeedCost = (int)((ulong)250L);
			IZECard izecard10;
			izecard10.theSeedCost = (int)((ulong)300L);
			IZECard izecard11;
			izecard11.theSeedCost = (int)((ulong)500L);
			IZECard izecard12;
			izecard12.theSeedCost = (int)((ulong)750L);
			IZECard izecard13;
			izecard13.theSeedCost = (int)((ulong)150L);
			IZECard izecard14;
			izecard14.theSeedCost = (int)((ulong)300L);
			IZECard izecard15;
			izecard15.theSeedCost = (int)((ulong)500L);
			GameAPP instance6 = GameAPP.Instance;
			InGameText instance7 = InGameText.Instance;
			GameObject gloveBank = InGameUI.Instance.GloveBank;
			int num22 = 0;
			gloveBank.SetActive(num22 != 0);
			GameObject wheelBank = InGameUI.Instance.WheelBank;
			int num23 = 0;
			wheelBank.SetActive(num23 != 0);
			GameObject hammerBank = InGameUI.Instance.HammerBank;
			int num24 = 0;
			hammerBank.SetActive(num24 != 0);
			GameObject shovelBank2 = InGameUI.Instance.ShovelBank;
			num25 = 0;
			int num26 = 0;
			shovelBank2.SetActive(num26 != 0);
			InGameUI instance8 = InGameUI.Instance;
		}
		while (num25 != 143);
		GameAPP instance9 = GameAPP.Instance;
		if (0 == 166)
		{
			GameAPP instance10 = GameAPP.Instance;
			GameObject seedBank2 = InGameUI.Instance.SeedBank;
			int num27 = 0;
			seedBank2.SetActive(num27 != 0);
			GameObject shovelBank3 = InGameUI.Instance.ShovelBank;
			int num28 = 0;
			shovelBank3.SetActive(num28 != 0);
		}
		Board board2 = this.board;
		InGameText instance11 = InGameText.Instance;
		GameObject shovelBank4 = InGameUI.Instance.ShovelBank;
		int num29 = 0;
		shovelBank4.SetActive(num29 != 0);
		Board board3 = this.board;
		ulong num30;
		InGameUI.Instance.GloveBank.SetActive(num30 != 0UL);
		ulong num31;
		InGameUI.Instance.HammerBank.SetActive(num31 != 0UL);
		ulong num32;
		InGameUI.Instance.ShowCardBank.SetActive(num32 != 0UL);
		Board board4 = this.board;
		GameObject shovelBank5 = InGameUI.Instance.ShovelBank;
		int num33 = 0;
		shovelBank5.SetActive(num33 != 0);
		ulong num34;
		InGameUI.Instance.HammerBank.SetActive(num34 != 0UL);
		InGameText instance12 = InGameText.Instance;
		InGameText instance13 = InGameText.Instance;
		GameObject slowTrigger = InGameUI.Instance.SlowTrigger;
		int num35 = 0;
		slowTrigger.SetActive(num35 != 0);
		GameAPP instance14 = GameAPP.Instance;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00036F48 File Offset: 0x00035148
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x914060", Offset = "0x912660", VA = "0x180914060")]
	public UniTask StartInit()
	{
		return default(UniTask);
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00036F64 File Offset: 0x00035164
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x913DA0", Offset = "0x9123A0", VA = "0x180913DA0")]
	private UniTask RightMoveCamera(float during)
	{
		return default(UniTask);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00036F84 File Offset: 0x00035184
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x913F80", Offset = "0x912580", VA = "0x180913F80")]
	private UniTask ShowSeedBank()
	{
		return default(UniTask);
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00036FA4 File Offset: 0x000351A4
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x910750", Offset = "0x90ED50", VA = "0x180910750")]
	private UniTask HideSeedBank()
	{
		return default(UniTask);
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00036FC4 File Offset: 0x000351C4
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x9141E0", Offset = "0x9127E0", VA = "0x1809141E0")]
	private UniTask WaitPlayerSelect()
	{
		return default(UniTask);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00036FE0 File Offset: 0x000351E0
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x913E90", Offset = "0x912490", VA = "0x180913E90")]
	public UniTask ShowBottom(bool quick = false)
	{
		return default(UniTask);
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00037000 File Offset: 0x00035200
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x910660", Offset = "0x90EC60", VA = "0x180910660")]
	public UniTask HideBottom(bool quick = false)
	{
		return default(UniTask);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00037020 File Offset: 0x00035220
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x9114C0", Offset = "0x90FAC0", VA = "0x1809114C0")]
	private UniTask LeftMoveCamera(float during, bool volume)
	{
		return default(UniTask);
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00037040 File Offset: 0x00035240
	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x910CF0", Offset = "0x90F2F0", VA = "0x180910CF0")]
	public void InitMower()
	{
		ulong num2;
		do
		{
			Board board = this.board;
			CreateMower instance = CreateMower._instance;
			BoxType[] roadType = this.board.roadType;
			instance.SetMowers(roadType);
			List<Mower> mowerArray = this.board.mowerArray;
			bool flag;
			if (flag)
			{
				int num;
				InitBoard.<MoveMowers>d__24 <MoveMowers>d__ = new InitBoard.<MoveMowers>d__24(num);
				num = 0;
				GameObject gameObject;
				<MoveMowers>d__.mower = gameObject;
				Coroutine coroutine = base.StartCoroutine(<MoveMowers>d__);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x000370B8 File Offset: 0x000352B8
	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x911670", Offset = "0x90FC70", VA = "0x180911670")]
	private IEnumerator MoveMowers(GameObject mower)
	{
		int num;
		InitBoard.<MoveMowers>d__24 <MoveMowers>d__ = new InitBoard.<MoveMowers>d__24(num);
		num = 0;
		<MoveMowers>d__.mower = mower;
		throw new NullReferenceException();
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x000370DC File Offset: 0x000352DC
	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x4C12A0", Offset = "0x4BF8A0", VA = "0x1804C12A0")]
	private float EaseInOut(float t)
	{
		return t;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x000370F0 File Offset: 0x000352F0
	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x9102A0", Offset = "0x90E8A0", VA = "0x1809102A0")]
	private bool CanSelectCard()
	{
		if (GameAPP.config.autoEnterGame)
		{
			Board board = this.board;
		}
		Board board2 = this.board;
		bool flag;
		return flag;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00037124 File Offset: 0x00035324
	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x9115C0", Offset = "0x90FBC0", VA = "0x1809115C0")]
	public void LookLawn()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00037144 File Offset: 0x00035344
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x914120", Offset = "0x912720", VA = "0x180914120")]
	private UniTask WaitPlayerClick()
	{
		return default(UniTask);
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00037160 File Offset: 0x00035360
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x9116E0", Offset = "0x90FCE0", VA = "0x1809116E0")]
	private void PreSelectCard()
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			if (!LevelManager.TryGetLevelData(num))
			{
				LevelType theBoardType = GameAPP.theBoardType;
				int num3 = (int)theBoardType;
				if (theBoardType != LevelType.Advanture)
				{
					if (theBoardType == LevelType.Advanture)
					{
						goto IL_015F;
					}
					if (theBoardType == LevelType.Advanture || theBoardType == LevelType.Advanture)
					{
						return;
					}
					if (num3 != 1)
					{
						if (theBoardType != LevelType.StarAdvanture)
						{
							return;
						}
						AdvantureConfig.PreSelectCard(this);
					}
					int theBoardLevel = GameAPP.theBoardLevel;
					bool flag;
					if (flag)
					{
						CardUI cardUI = this.PreSelect((PlantType)num);
					}
					int theBoardLevel2 = GameAPP.theBoardLevel;
					global::LevelData levelData;
					List<PlantType> usePlant = levelData.usePlant;
					bool flag2;
					if (flag2)
					{
						CardUI cardUI2 = this.PreSelect((PlantType)num2);
					}
					if (num != 0)
					{
						goto IL_02BA;
					}
				}
				if (GameAPP.config.disablePreSelectInAdv)
				{
					return;
				}
				List<PlantType> randomPlantInZhouMu = GameAPP.randomPlantInZhouMu;
				bool flag3 = "{il2cpp field on {'constant100' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" <= (ulong)36L;
				int theBoardLevel3 = GameAPP.theBoardLevel;
				GameAPP.randomPlantInZhouMu._size = num;
				List<PlantType> list = new List();
				HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
				bool flag4;
				if (flag4 && ((!flag3 && TypeMgr.IsWaterPlant((PlantType)num2)) || (theBoardLevel3 > 36 && TypeMgr.IsCaltrop((PlantType)num2))))
				{
					continue;
				}
				if (num != 0)
				{
					goto IL_02C0;
				}
				int num4 = 0;
				int num5 = list._size;
				int num6 = global::UnityEngine.Random.Range(0, num5);
				List<PlantType> randomPlantInZhouMu2 = GameAPP.randomPlantInZhouMu;
				num5 = num6;
				int num7 = list[num5];
				int size = randomPlantInZhouMu2._size;
				num7 = num6;
				list.RemoveAt(num7);
				num4++;
				List<PlantType> randomPlantInZhouMu3 = GameAPP.randomPlantInZhouMu;
				bool flag5;
				if (flag5)
				{
				}
				if (num4 != 0)
				{
					goto IL_02C0;
				}
				int num8 = 0;
				IL_015F:
				if (GameAPP.theBoardLevel > 124)
				{
					break;
				}
				CardUI cardUI3;
				cardUI3.theSeedCost = (int)((ulong)100L);
				CardUI cardUI4;
				cardUI4.theSeedCost = (int)((ulong)100L);
				CardUI cardUI5;
				cardUI5.theSeedCost = (int)((ulong)100L);
				CardUI cardUI6;
				cardUI6.theSeedCost = num8;
				CardUI cardUI7;
				cardUI7.theSeedCost = num8;
				CardUI cardUI8;
				cardUI8.theSeedCost = num8;
				CardUI cardUI9;
				cardUI9.theSeedCost = (int)((ulong)100L);
			}
			bool flag6;
			if (flag6)
			{
				InGameUI instance = InGameUI.Instance;
				int num9 = 0;
				CardUI cardUI10;
				if (!instance.AddCardToBank(cardUI10, num9 != 0))
				{
					global::UnityEngine.Object.Destroy(cardUI10.gameObject);
					cardUI10.isSelected = true;
					cardUI10.preSelected = true;
				}
				cardUI10.isSelected = true;
				cardUI10.preSelected = true;
			}
			if (num != 0)
			{
				goto IL_02D2;
			}
			int num10 = 0;
			bool flag7;
			if (flag7)
			{
				IZECard izecard;
				izecard.preSelected = true;
				izecard.isSelected = true;
				InGameUI instance2 = InGameUI.Instance;
				int num11 = 0;
				if (!instance2.AddCardToBank(izecard, num11 != 0))
				{
					global::UnityEngine.Object.Destroy(izecard.gameObject);
				}
				ZombieDataManager.ZombieData zombieData = ZombieDataManager.GetZombieData((ZombieType)num2);
				int cost = zombieData.cost;
				izecard.theSeedCost = cost;
				float cd = zombieData.cd;
				izecard.fullCD = cd;
				izecard.CD = cd;
			}
			if (num10 == 0)
			{
				goto Block_21;
			}
		}
		CardUI cardUI11;
		cardUI11.theSeedCost = (int)((ulong)300L);
		CardUI cardUI12;
		cardUI12.theSeedCost = (int)((ulong)100L);
		CardUI cardUI13;
		cardUI13.theSeedCost = (int)((ulong)400L);
		CardUI cardUI14;
		cardUI14.theSeedCost = (int)((ulong)200L);
		return;
		Block_21:
		throw new NullReferenceException();
		IL_02BA:
		throw new NullReferenceException();
		IL_02C0:
		throw new NullReferenceException();
		IL_02D2:
		throw new NullReferenceException();
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00037454 File Offset: 0x00035654
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x912650", Offset = "0x910C50", VA = "0x180912650")]
	public CardUI PreSelect(PlantType theSeedType)
	{
		ulong num2;
		do
		{
			int num = 0;
			List<CardUI> cards = InGameUI.Instance.Cards;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(InGameUI.Instance.grid.transform);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3 = InGameUI.Instance.AddCardToBank(num, true);
			}
		}
		while (num2 != (ulong)0L);
		CardUI cardUI;
		cardUI.preSelected = true;
		GameObject gameObject = cardUI.transform.Find("Shadow").gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		return cardUI;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x000374F8 File Offset: 0x000356F8
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x910F90", Offset = "0x90F590", VA = "0x180910F90")]
	private void InitZombieFromList()
	{
		ulong num6;
		do
		{
			int num = 0;
			int columnNum = this.board.columnNum;
			HashSet<ZombieType> zombieTypeList = InitZombieList.zombieTypeList;
			bool flag;
			if (flag)
			{
				while (num == 1)
				{
				}
				float num3;
				float num2 = global::UnityEngine.Random.Range(num3, num3);
				float num4 = global::UnityEngine.Random.Range(-4f, num3);
				if (num == 45 || num == 63)
				{
				}
				GameObject gameObject;
				string name = gameObject.name;
				Type[] array = new Type[1];
				Type typeFromHandle = typeof(SortingGroup);
				if (typeFromHandle != 0)
				{
				}
				array[0] = typeFromHandle;
				GameObject gameObject2 = new GameObject(name, array);
				Transform transform = gameObject.transform.Find("Shadow");
				int num5 = 0;
				if (transform != num5)
				{
					Transform transform2 = gameObject2.transform;
					Vector3 vector;
					float z = vector.z;
				}
				Transform transform3 = gameObject.transform;
				Transform transform4 = gameObject2.transform;
				transform3.parentInternal = transform4;
				Transform transform5 = gameObject2.transform;
				Transform transform6 = this.board.transform;
				transform5.parentInternal = transform6;
				List<GameObject> zombiePreviews = this.board.boardEntity.zombiePreviews;
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x0003766C File Offset: 0x0003586C
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x913AB0", Offset = "0x9120B0", VA = "0x180913AB0")]
	private void ResetLayer(GameObject obj, int baseLayer)
	{
		int num;
		do
		{
			num = 0;
			if (obj.name != 0)
			{
				break;
			}
			if (obj.TryGetComponent<SpriteRenderer>(num))
			{
			}
			if (obj.transform.childCount == 0)
			{
				break;
			}
			GameObject gameObject;
			if (obj.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				this.ResetLayer(gameObject, baseLayer);
			}
			if (gameObject != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x000376E8 File Offset: 0x000358E8
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x90EE20", Offset = "0x90D420", VA = "0x18090EE20")]
	private void AddCard()
	{
		int num = 0;
		List<PlantType> cardOnBank = EndlessShooting.Instance.cardOnBank;
		int num2 = 0;
		bool flag;
		if (flag)
		{
			int num3 = 0;
			ulong num4;
			CardUI cardUI = this.CreateCard((PlantType)num, num4 != 0UL, num3 != 0);
		}
		if (num2 == 0)
		{
			int num5 = 0;
			CardUI cardUI2;
			cardUI2.theSeedCost = (int)((ulong)50L);
			num5++;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00037B2C File Offset: 0x00035D2C
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x910470", Offset = "0x90EA70", VA = "0x180910470")]
	public CardUI CreateCard(PlantType theSeedType, bool shadow = true, bool quick = false)
	{
		CardUI cardUI;
		if (!InGameUI.Instance.AddCardToBank(cardUI, quick))
		{
			global::UnityEngine.Object.Destroy(cardUI.gameObject);
		}
		cardUI.isSelected = true;
		cardUI.preSelected = true;
		if (shadow)
		{
			cardUI.transform.GetChild(3).gameObject.SetActive(true);
		}
		return cardUI;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00037B88 File Offset: 0x00035D88
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x9105A0", Offset = "0x90EBA0", VA = "0x1809105A0")]
	public CardUI CreateCard(FunctionCardType functionCardType, bool quick = false)
	{
		SpecialCard specialCard;
		if (!InGameUI.Instance.AddCardToBank(specialCard, quick))
		{
			global::UnityEngine.Object.Destroy(specialCard.gameObject);
		}
		specialCard.preSelected = true;
		specialCard.isSelected = true;
		throw new NullReferenceException();
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00037BC8 File Offset: 0x00035DC8
	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x910340", Offset = "0x90E940", VA = "0x180910340")]
	public IZECard CreateCard(ZombieType theSeedType, bool shadow = true)
	{
		IZECard izecard;
		izecard.preSelected = true;
		izecard.isSelected = true;
		InGameUI instance = InGameUI.Instance;
		int num = 0;
		if (!instance.AddCardToBank(izecard, num != 0))
		{
			global::UnityEngine.Object.Destroy(izecard.gameObject);
		}
		if (shadow)
		{
			izecard.transform.GetChild(3).gameObject.SetActive(true);
		}
		return izecard;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00037C28 File Offset: 0x00035E28
	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x9142A0", Offset = "0x9128A0", VA = "0x1809142A0")]
	public InitBoard()
	{
	}

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	public static InitBoard Instance;

	// Token: 0x04000569 RID: 1385
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000569")]
	public bool ready;

	// Token: 0x0400056A RID: 1386
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400056A")]
	private Board board;

	// Token: 0x0400056B RID: 1387
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400056B")]
	private InGameUI uI;

	// Token: 0x0400056C RID: 1388
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400056C")]
	private Vector3 camPos_beforeInit;

	// Token: 0x0400056D RID: 1389
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400056D")]
	private Vector3 camPos_select;

	// Token: 0x0400056E RID: 1390
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400056E")]
	private Vector3 camPos_startGame;

	// Token: 0x0400056F RID: 1391
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400056F")]
	private Vector2 seedBank_showPos;

	// Token: 0x04000570 RID: 1392
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000570")]
	private Vector2 seedBank_hidePos;

	// Token: 0x04000571 RID: 1393
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000571")]
	private Vector2 bottom_showPos;

	// Token: 0x04000572 RID: 1394
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000572")]
	private Vector2 bottom_hidePos;

	// Token: 0x04000573 RID: 1395
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000573")]
	private readonly float uiMoveDuring = 0.3f;
}
