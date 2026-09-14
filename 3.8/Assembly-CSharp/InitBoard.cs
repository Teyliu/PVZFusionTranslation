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

// Token: 0x0200023B RID: 571
[Token(Token = "0x200023B")]
public class InitBoard : MonoBehaviour
{
	// Token: 0x06000A0A RID: 2570 RVA: 0x00036960 File Offset: 0x00034B60
	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x8806E0", Offset = "0x87ECE0", VA = "0x1808806E0")]
	private void Awake()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00036980 File Offset: 0x00034B80
	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x880D20", Offset = "0x87F320", VA = "0x180880D20")]
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

	// Token: 0x06000A0C RID: 2572 RVA: 0x00036B38 File Offset: 0x00034D38
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x882E70", Offset = "0x881470", VA = "0x180882E70")]
	private void QuickInGame()
	{
		int num28;
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
			int num18 = 0;
			instance3.ShowText("按方向键WASD来控制僵尸，点击魅惑僵尸来模仿", 5f, num18 != 0);
			ulong num19;
			InGameUI.Instance.GloveBank.SetActive(num19 != 0UL);
			ulong num20;
			InGameUI.Instance.HammerBank.SetActive(num20 != 0UL);
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
			int num21 = 0;
			instance5.ShowText("按方向键WASD来控制僵尸，点击魅惑僵尸来模仿", 5f, num21 != 0);
			ulong num22;
			InGameUI.Instance.GloveBank.SetActive(num22 != 0UL);
			ulong num23;
			InGameUI.Instance.HammerBank.SetActive(num23 != 0UL);
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
			int num24 = 0;
			instance7.ShowText("按方向键WASD来移动植物", 5f, num24 != 0);
			GameObject gloveBank = InGameUI.Instance.GloveBank;
			int num25 = 0;
			gloveBank.SetActive(num25 != 0);
			GameObject wheelBank = InGameUI.Instance.WheelBank;
			int num26 = 0;
			wheelBank.SetActive(num26 != 0);
			GameObject hammerBank = InGameUI.Instance.HammerBank;
			int num27 = 0;
			hammerBank.SetActive(num27 != 0);
			GameObject shovelBank2 = InGameUI.Instance.ShovelBank;
			num28 = 0;
			int num29 = 0;
			shovelBank2.SetActive(num29 != 0);
			InGameUI instance8 = InGameUI.Instance;
		}
		while (num28 != 143);
		GameAPP instance9 = GameAPP.Instance;
		if (0 == 166)
		{
			GameAPP instance10 = GameAPP.Instance;
			GameObject seedBank2 = InGameUI.Instance.SeedBank;
			int num30 = 0;
			seedBank2.SetActive(num30 != 0);
			GameObject shovelBank3 = InGameUI.Instance.ShovelBank;
			int num31 = 0;
			shovelBank3.SetActive(num31 != 0);
		}
		Board board2 = this.board;
		InGameText instance11 = InGameText.Instance;
		int num32 = 0;
		instance11.ShowText("按方向键WASD来移动\n不要让植物死亡，不要让植物撞到植物", 5f, num32 != 0);
		GameObject shovelBank4 = InGameUI.Instance.ShovelBank;
		int num33 = 0;
		shovelBank4.SetActive(num33 != 0);
		Board board3 = this.board;
		ulong num34;
		InGameUI.Instance.GloveBank.SetActive(num34 != 0UL);
		ulong num35;
		InGameUI.Instance.HammerBank.SetActive(num35 != 0UL);
		ulong num36;
		InGameUI.Instance.ShowCardBank.SetActive(num36 != 0UL);
		Board board4 = this.board;
		GameObject shovelBank5 = InGameUI.Instance.ShovelBank;
		int num37 = 0;
		shovelBank5.SetActive(num37 != 0);
		ulong num38;
		InGameUI.Instance.HammerBank.SetActive(num38 != 0UL);
		InGameText instance12 = InGameText.Instance;
		int num39 = 0;
		instance12.ShowText("使用锤子击杀僵尸，点击鼠标右键可以放下锤子\n点击0费卡可以切换锤子效果，或者按键盘1、2、E切换", 5f, num39 != 0);
		InGameText instance13 = InGameText.Instance;
		int num40 = 0;
		instance13.ShowText("使用锤子击杀僵尸，点击鼠标右键可以放下锤子", 3f, num40 != 0);
		GameObject slowTrigger = InGameUI.Instance.SlowTrigger;
		int num41 = 0;
		slowTrigger.SetActive(num41 != 0);
		GameAPP instance14 = GameAPP.Instance;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x000370D0 File Offset: 0x000352D0
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x884520", Offset = "0x882B20", VA = "0x180884520")]
	public UniTask StartInit()
	{
		return default(UniTask);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x000370EC File Offset: 0x000352EC
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x884260", Offset = "0x882860", VA = "0x180884260")]
	private UniTask RightMoveCamera(float during)
	{
		return default(UniTask);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0003710C File Offset: 0x0003530C
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x884440", Offset = "0x882A40", VA = "0x180884440")]
	private UniTask ShowSeedBank()
	{
		return default(UniTask);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x0003712C File Offset: 0x0003532C
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x880C40", Offset = "0x87F240", VA = "0x180880C40")]
	private UniTask HideSeedBank()
	{
		return default(UniTask);
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0003714C File Offset: 0x0003534C
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x8846A0", Offset = "0x882CA0", VA = "0x1808846A0")]
	private UniTask WaitPlayerSelect()
	{
		return default(UniTask);
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00037168 File Offset: 0x00035368
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x884350", Offset = "0x882950", VA = "0x180884350")]
	public UniTask ShowBottom(bool quick = false)
	{
		return default(UniTask);
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00037188 File Offset: 0x00035388
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x880B50", Offset = "0x87F150", VA = "0x180880B50")]
	public UniTask HideBottom(bool quick = false)
	{
		return default(UniTask);
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x000371A8 File Offset: 0x000353A8
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x8819B0", Offset = "0x87FFB0", VA = "0x1808819B0")]
	private UniTask LeftMoveCamera(float during, bool volume)
	{
		return default(UniTask);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x000371C8 File Offset: 0x000353C8
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x8811E0", Offset = "0x87F7E0", VA = "0x1808811E0")]
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

	// Token: 0x06000A16 RID: 2582 RVA: 0x00037240 File Offset: 0x00035440
	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x881B60", Offset = "0x880160", VA = "0x180881B60")]
	private IEnumerator MoveMowers(GameObject mower)
	{
		int num;
		InitBoard.<MoveMowers>d__24 <MoveMowers>d__ = new InitBoard.<MoveMowers>d__24(num);
		num = 0;
		<MoveMowers>d__.mower = mower;
		throw new NullReferenceException();
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00037264 File Offset: 0x00035464
	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x46ADD0", Offset = "0x4693D0", VA = "0x18046ADD0")]
	private float EaseInOut(float t)
	{
		return t;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00037278 File Offset: 0x00035478
	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x880790", Offset = "0x87ED90", VA = "0x180880790")]
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

	// Token: 0x06000A19 RID: 2585 RVA: 0x000372AC File Offset: 0x000354AC
	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x881AB0", Offset = "0x8800B0", VA = "0x180881AB0")]
	public void LookLawn()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x000372CC File Offset: 0x000354CC
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x8845E0", Offset = "0x882BE0", VA = "0x1808845E0")]
	private UniTask WaitPlayerClick()
	{
		return default(UniTask);
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x000372E8 File Offset: 0x000354E8
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x881BD0", Offset = "0x8801D0", VA = "0x180881BD0")]
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

	// Token: 0x06000A1C RID: 2588 RVA: 0x000375DC File Offset: 0x000357DC
	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x882B40", Offset = "0x881140", VA = "0x180882B40")]
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

	// Token: 0x06000A1D RID: 2589 RVA: 0x00037680 File Offset: 0x00035880
	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x881480", Offset = "0x87FA80", VA = "0x180881480")]
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

	// Token: 0x06000A1E RID: 2590 RVA: 0x000377F4 File Offset: 0x000359F4
	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x883F70", Offset = "0x882570", VA = "0x180883F70")]
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

	// Token: 0x06000A1F RID: 2591 RVA: 0x00037870 File Offset: 0x00035A70
	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x87F310", Offset = "0x87D910", VA = "0x18087F310")]
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

	// Token: 0x06000A20 RID: 2592 RVA: 0x00037CB4 File Offset: 0x00035EB4
	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x880960", Offset = "0x87EF60", VA = "0x180880960")]
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

	// Token: 0x06000A21 RID: 2593 RVA: 0x00037D10 File Offset: 0x00035F10
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x880A90", Offset = "0x87F090", VA = "0x180880A90")]
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

	// Token: 0x06000A22 RID: 2594 RVA: 0x00037D50 File Offset: 0x00035F50
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x880830", Offset = "0x87EE30", VA = "0x180880830")]
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

	// Token: 0x06000A23 RID: 2595 RVA: 0x00037DB0 File Offset: 0x00035FB0
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x884760", Offset = "0x882D60", VA = "0x180884760")]
	public InitBoard()
	{
	}

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	public static InitBoard Instance;

	// Token: 0x0400055E RID: 1374
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400055E")]
	public bool ready;

	// Token: 0x0400055F RID: 1375
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400055F")]
	private Board board;

	// Token: 0x04000560 RID: 1376
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000560")]
	private InGameUI uI;

	// Token: 0x04000561 RID: 1377
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000561")]
	private Vector3 camPos_beforeInit;

	// Token: 0x04000562 RID: 1378
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000562")]
	private Vector3 camPos_select;

	// Token: 0x04000563 RID: 1379
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000563")]
	private Vector3 camPos_startGame;

	// Token: 0x04000564 RID: 1380
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000564")]
	private Vector2 seedBank_showPos;

	// Token: 0x04000565 RID: 1381
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000565")]
	private Vector2 seedBank_hidePos;

	// Token: 0x04000566 RID: 1382
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000566")]
	private Vector2 bottom_showPos;

	// Token: 0x04000567 RID: 1383
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000567")]
	private Vector2 bottom_hidePos;

	// Token: 0x04000568 RID: 1384
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000568")]
	private readonly float uiMoveDuring = 0.3f;
}
