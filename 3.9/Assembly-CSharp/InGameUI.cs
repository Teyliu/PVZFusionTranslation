using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000889 RID: 2185
[Token(Token = "0x2000889")]
public class InGameUI : BaseMenu
{
	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000F29A8 File Offset: 0x000F0BA8
	[Token(Token = "0x17000200")]
	public List<CardUI> Cards
	{
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x6D0970", Offset = "0x6CEF70", VA = "0x1806D0970")]
		get
		{
			return new List(this._cardSlotManager.Cards);
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000F29CC File Offset: 0x000F0BCC
	[Token(Token = "0x17000201")]
	public bool Full
	{
		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x6D0A00", Offset = "0x6CF000", VA = "0x1806D0A00")]
		get
		{
			return this._cardSlotManager.IsFull;
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06002C89 RID: 11401 RVA: 0x000F29EC File Offset: 0x000F0BEC
	[Token(Token = "0x17000202")]
	public CardSlotManager CardSlotManager
	{
		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x6D0960", Offset = "0x6CEF60", VA = "0x1806D0960")]
		get
		{
			return this._cardSlotManager;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000F2A00 File Offset: 0x000F0C00
	// (set) Token: 0x06002C8B RID: 11403 RVA: 0x000F2A14 File Offset: 0x000F0C14
	[Token(Token = "0x17000203")]
	public override bool Interactable
	{
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x68F520", Offset = "0x68DB20", VA = "0x18068F520", Slot = "4")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x6D0A30", Offset = "0x6CF030", VA = "0x1806D0A30", Slot = "5")]
		set
		{
			base.Interactable = value;
			this.canvasUp.interactable = value;
			this.canvasUp.blocksRaycasts = value;
		}
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x000F2A48 File Offset: 0x000F0C48
	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x6CBBE0", Offset = "0x6CA1E0", VA = "0x1806CBBE0", Slot = "6")]
	protected override void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		base.Awake();
		InGameUI.Instance = this;
		HashSet<CardUI> hashSet = Enumerable.ToHashSet<CardUI>(global::Core.Lawnf.GetChilds<CardUI>(base.transform));
		this.cards = hashSet;
		GameObject[] array = this.seed.ToArray();
		int cardCountLimit = this.board.cardCountLimit;
		RectTransform rectTransform = this.movingCardContainer;
		CardSlotManager cardSlotManager = new CardSlotManager(array, cardCountLimit, rectTransform);
		this._cardSlotManager = cardSlotManager;
		Board board = this.board;
		List<GameObject> list = this.seed;
		int num = board.cardCountLimit;
		GameObject gameObject = this.seed[num];
		int num2 = 0;
		if (gameObject != num2)
		{
			GameObject gameObject2 = this.seed[num];
			int num3 = 0;
			gameObject2.SetActive(num3 != 0);
		}
		List<GameObject> list2 = this.seed;
		num++;
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x000F2B20 File Offset: 0x000F0D20
	[Token(Token = "0x6002C8D")]
	[Address(RVA = "0x6CE1D0", Offset = "0x6CC7D0", VA = "0x1806CE1D0")]
	private void Start()
	{
		ulong num;
		do
		{
			int theBoardLevel = GameAPP.theBoardLevel;
			List<TextMeshProUGUI> list = this.levelNameText;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		if (!TravelMgr.Instance.data.NeedShowInUI())
		{
		}
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x000F2B70 File Offset: 0x000F0D70
	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x6CC690", Offset = "0x6CAC90", VA = "0x1806CC690", Slot = "7")]
	protected override void GetCol()
	{
		base.GetCol();
		CanvasGroup canvasGroup = this.canvasUp;
		List<Collider2D> collider2Ds = this.collider2Ds;
		List<Collider2D> childs = global::Core.Lawnf.GetChilds<Collider2D>(canvasGroup.transform);
		collider2Ds.AddRange(childs);
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x000F2BAC File Offset: 0x000F0DAC
	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x6CD720", Offset = "0x6CBD20", VA = "0x1806CD720")]
	private void OnDestroy()
	{
		CardSlotManager cardSlotManager = this._cardSlotManager;
		if (cardSlotManager != 0)
		{
			cardSlotManager.ClearAll();
			return;
		}
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x000F2BCC File Offset: 0x000F0DCC
	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x6CD740", Offset = "0x6CBD40", VA = "0x1806CD740", Slot = "8")]
	public override void OnExit()
	{
		global::UnityEngine.Object.Destroy(this.canvasUp.gameObject);
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x000F2BF0 File Offset: 0x000F0DF0
	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x6CEC10", Offset = "0x6CD210", VA = "0x1806CEC10")]
	private void Update()
	{
		this.UpdateSunDisplay();
		if (!Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
			if (!Input.GetKeyDownInt((KeyCode)((uint)32)))
			{
				goto IL_003B;
			}
			Board board = this.board;
		}
		TowerUpgradeMenu instance = TowerUpgradeMenu.Instance;
		int num = 0;
		if (!(instance != num))
		{
			this.PauseGame();
		}
		IL_003B:
		this.UpdateTowerDefenseTimer();
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x000F2C48 File Offset: 0x000F0E48
	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x6CE680", Offset = "0x6CCC80", VA = "0x1806CE680")]
	private void UpdateSunDisplay()
	{
		List<Plant> plantHead = this.board.boardEntity.plantHead;
		Func<Plant, bool> <>9__70_ = InGameUI.<>c.<>9__70_0;
		if (<>9__70_ == 0)
		{
			InGameUI.<>c.<>9__70_0 = (Plant p) => p.thePlantType == PlantType.GoldSunflower;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__70_);
		int num = 0;
		int num2 = 0;
		if (plant != num2)
		{
		}
		if (num > 0)
		{
			long num3 = (long)(num * (int)((uint)50));
			string text = string.Format("+{0}", num3);
		}
		Board board = this.board;
		TextMeshProUGUI textMeshProUGUI = this.sun;
		int theSun = board.theSun;
		string text2 = string.Format("{0}{1}", theSun, "");
		textMeshProUGUI.text = text2;
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x000F2CF4 File Offset: 0x000F0EF4
	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x6CC0A0", Offset = "0x6CA6A0", VA = "0x1806CC0A0")]
	private void CheckPauseInput()
	{
		if (!Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
			if (!Input.GetKeyDownInt((KeyCode)((uint)32)))
			{
				return;
			}
			Board board = this.board;
		}
		TowerUpgradeMenu instance = TowerUpgradeMenu.Instance;
		int num = 0;
		if (!(instance != num))
		{
			this.PauseGame();
			return;
		}
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x000F2D40 File Offset: 0x000F0F40
	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x6CE8F0", Offset = "0x6CCEF0", VA = "0x1806CE8F0")]
	private void UpdateTowerDefenseTimer()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			Board board = this.board;
			this.timer = 1f;
			if (board.boardStatistics.gameDuration > 60f)
			{
				Board board2 = this.board;
				List<TextMeshProUGUI> list = this.levelNameText;
				int theBoardLevel = GameAPP.theBoardLevel;
				string text;
				this.ChangeString(list, text);
				return;
			}
			List<TextMeshProUGUI> list2 = this.levelNameText;
			int theBoardLevel2 = GameAPP.theBoardLevel;
			BoardStatistics boardStatistics = this.board.boardStatistics;
			string text2;
			this.ChangeString(list2, text2);
		}
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x000F2DE0 File Offset: 0x000F0FE0
	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x6CBB30", Offset = "0x6CA130", VA = "0x1806CBB30")]
	public bool AddCardToBank(CardUI card, bool quick = false)
	{
		bool flag = this._cardSlotManager.AddCard(card, quick);
		if (!flag)
		{
			InGameText instance = InGameText.Instance;
		}
		return flag;
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x000F2E10 File Offset: 0x000F1010
	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x6CDBF0", Offset = "0x6CC1F0", VA = "0x1806CDBF0")]
	public bool RemoveCardFromBank(CardUI card, bool quick = false)
	{
		return this._cardSlotManager.RemoveCard(card, quick);
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x000F2E30 File Offset: 0x000F1030
	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x6CD550", Offset = "0x6CBB50", VA = "0x1806CD550")]
	public void MoveCardToTarget(CardUI card, bool quick = false)
	{
		this._cardSlotManager.MoveCardToTarget(card, quick);
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x000F2E50 File Offset: 0x000F1050
	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x6CE4B0", Offset = "0x6CCAB0", VA = "0x1806CE4B0")]
	public bool UnlockCard(PlantType theSeedType)
	{
		for (;;)
		{
			int num = 0;
			HashSet<CardUI> hashSet = this.cards;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				GameObject gameObject;
				if (num != num2 && !gameObject.activeSelf)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject2;
		gameObject2.SetActive(true);
		return true;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x000F2EB4 File Offset: 0x000F10B4
	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x6CDC20", Offset = "0x6CC220", VA = "0x1806CDC20")]
	public void SetLevelName(string name)
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.levelNameText;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x000F2EE0 File Offset: 0x000F10E0
	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x6CDD50", Offset = "0x6CC350", VA = "0x1806CDD50")]
	public void SetUniqueText(List<TextMeshProUGUI> T)
	{
		int num = 0;
		if (!LevelManager.TryGetLevelData(num))
		{
			if (GameAPP.theBoardType <= LevelType.StarAdvanture)
			{
				Dictionary<int, string> dictionary = this.levelDescriptions;
				int theBoardLevel = GameAPP.theBoardLevel;
				if (!dictionary.TryGetValue(theBoardLevel, num))
				{
				}
				string survivalLevelName = this.GetSurvivalLevelName();
			}
			int theBoardLevel2 = GameAPP.theBoardLevel;
			string text2;
			string text = "配方：" + text2;
			Dictionary<SkinLevel, string> dictionary2 = this.skinLevelDescription;
			bool flag;
			while (!flag)
			{
			}
			int theBoardLevel3 = GameAPP.theBoardLevel;
			int theBoardLevel4 = GameAPP.theBoardLevel;
			Dictionary<AdvantureLevel, ILevelStrategy> levelStrategies = AdvantureConfig._levelStrategies;
			if (dictionary2 < levelStrategies)
			{
				dictionary2 += dictionary2;
			}
			dictionary2 += dictionary2;
		}
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x000F2F74 File Offset: 0x000F1174
	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x6CC740", Offset = "0x6CAD40", VA = "0x1806CC740")]
	private string GetSurvivalLevelName()
	{
		Board instance2;
		do
		{
			if (GameAPP.theBoardLevel <= 37)
			{
				Dictionary<LeaderType, string> leaderNameDic = RogueStartMenu.LeaderNameDic;
				RogueManager instance = RogueManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}
			instance2 = Board.Instance;
		}
		while (instance2.theCurrentSurvivalRound <= 1);
		int theCurrentSurvivalRound = instance2.theCurrentSurvivalRound;
		string text = string.Format(" 第{0}轮", theCurrentSurvivalRound);
		return "" + text;
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x000F2FDC File Offset: 0x000F11DC
	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x6CBE70", Offset = "0x6CA470", VA = "0x1806CBE70")]
	private void ChangeString(List<TextMeshProUGUI> T, string name)
	{
		ulong num;
		do
		{
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x000F3000 File Offset: 0x000F1200
	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x6CED20", Offset = "0x6CD320", VA = "0x1806CED20")]
	public void UpperUI()
	{
		Transform transform = base.transform;
		Transform transform2 = GameAPP.canvasUp;
		transform.parentInternal = transform2;
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x000F3028 File Offset: 0x000F1228
	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x6CD3F0", Offset = "0x6CB9F0", VA = "0x1806CD3F0")]
	public void LowerUI()
	{
		if (this.board.sceneType != SceneType.Chess)
		{
			Transform transform = base.transform;
			Transform canvas = GameAPP.canvas;
			transform.parentInternal = canvas;
			return;
		}
		this.UpperUI();
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x000F3068 File Offset: 0x000F1268
	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x6CDB00", Offset = "0x6CC100", VA = "0x1806CDB00")]
	public void PauseGame()
	{
		Transform transform = base.transform;
		Transform transform2 = GameAPP.canvasUp;
		transform.parentInternal = transform2;
		UIMgr.EnterPauseMenu();
		GameAPP.music.Pause();
		GameAPP.musicDrum.Pause();
		GameAPP.prelude.audioSource.Pause();
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x000F30BC File Offset: 0x000F12BC
	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x6CBFA0", Offset = "0x6CA5A0", VA = "0x1806CBFA0")]
	public void ChangeTowards(GameObject head)
	{
		Transform transform = head.transform;
		int num = 0;
		TextMeshProUGUI component = transform.GetChild(num).GetComponent<TextMeshProUGUI>();
		if (this.towards != Towards.Left)
		{
			this.towards = (Towards)((ulong)0L);
		}
		this.towards = (Towards)((ulong)1L);
		throw new NullReferenceException();
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x000F3100 File Offset: 0x000F1300
	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x6CC1B0", Offset = "0x6CA7B0", VA = "0x1806CC1B0")]
	public UIButton CreateLeftButton(string name, Action<UIButton> action)
	{
		RectTransform rectTransform = this.buttonContainer;
		UIButton uibutton = this.graveButtonPrefab;
		Transform transform = rectTransform.transform;
		UIButton component = global::UnityEngine.Object.Instantiate<UIButton>(uibutton, transform).GetComponent<UIButton>();
		UIButton button = component;
		button.GetComponentInChildren<TextMeshProUGUI>().text = name;
		UnityEvent clickEvent = button.clickEvent;
		UnityAction unityAction = delegate
		{
			if (action != 0)
			{
			}
		};
		clickEvent.AddListener(unityAction);
		return button;
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x000F3188 File Offset: 0x000F1388
	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x6CC520", Offset = "0x6CAB20", VA = "0x1806CC520")]
	public UIButton GetButtonToShowPlant(string buttonName, string textName)
	{
		RectTransform rectTransform = this.showCardLayout;
		UIButton uibutton = this.buttonPrefab;
		Transform transform = rectTransform.transform;
		UIButton component = global::UnityEngine.Object.Instantiate<UIButton>(uibutton, transform).GetComponent<UIButton>();
		component.name = buttonName;
		TextMeshProUGUI[] componentsInChildren = component.GetComponentsInChildren<TextMeshProUGUI>();
		int num = 0;
		if (num < componentsInChildren.Length)
		{
			num++;
		}
		component.clickEvent.RemoveAllListeners();
		return component;
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000F31F0 File Offset: 0x000F13F0
	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x6CC3D0", Offset = "0x6CA9D0", VA = "0x1806CC3D0")]
	public UIButton GetButtonSelectGroup(string buttonName, string textName)
	{
		RectTransform rectTransform = this.selectCardGroupLayout;
		UIButton uibutton = this.buttonPrefab;
		Transform transform = rectTransform.transform;
		UIButton uibutton2 = global::UnityEngine.Object.Instantiate<UIButton>(uibutton, transform);
		uibutton2.name = buttonName;
		TextMeshProUGUI[] componentsInChildren = uibutton2.GetComponentsInChildren<TextMeshProUGUI>();
		int num = 0;
		if (num < componentsInChildren.Length)
		{
			num++;
		}
		uibutton2.clickEvent.RemoveAllListeners();
		return uibutton2;
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x000F3254 File Offset: 0x000F1454
	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x6CD4A0", Offset = "0x6CBAA0", VA = "0x1806CD4A0")]
	public void Mission()
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (instance != num)
		{
			AdvantureManager instance2 = AdvantureManager.Instance;
			if (instance2.mission != (ulong)0L)
			{
				instance2.mission.Show(7f);
				return;
			}
		}
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x000F329C File Offset: 0x000F149C
	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x6CE410", Offset = "0x6CCA10", VA = "0x1806CE410")]
	public void SubmitMission()
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (instance != num)
		{
			AdvantureManager instance2 = AdvantureManager.Instance;
			if (instance2.mission != (ulong)0L)
			{
				instance2.mission.Submit();
				return;
			}
		}
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x000F32E0 File Offset: 0x000F14E0
	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x6CD2D0", Offset = "0x6CB8D0", VA = "0x1806CD2D0")]
	public void LookProgress()
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (instance != num)
		{
			AdvantureManager instance2 = AdvantureManager.Instance;
			if (instance2.mission != (ulong)0L)
			{
				instance2.mission.LookProgress();
				return;
			}
		}
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x000F3324 File Offset: 0x000F1524
	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x6CD370", Offset = "0x6CB970", VA = "0x1806CD370")]
	public void LookTalent()
	{
		UIMgr.EnterPauseMenu();
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform transform = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)63), transform, num != 0);
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x000F335C File Offset: 0x000F155C
	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x6CD7B0", Offset = "0x6CBDB0", VA = "0x1806CD7B0")]
	public void OnLookZombieButtonClicked()
	{
		Board board = this.board;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)57), num != 0);
		List<ZombieType> list = Enumerable.ToList<ZombieType>(InitZombieList.zombieTypeList);
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x000F3398 File Offset: 0x000F1598
	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0x6CC380", Offset = "0x6CA980", VA = "0x1806CC380")]
	public void Evacuate()
	{
		TreasureManager.Instance.Evacuate();
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x000F33B8 File Offset: 0x000F15B8
	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0x6CD910", Offset = "0x6CBF10", VA = "0x1806CD910")]
	public void OnMainMenuButtonClick()
	{
		this.PauseGame();
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x000F33CC File Offset: 0x000F15CC
	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x6CD9E0", Offset = "0x6CBFE0", VA = "0x1806CD9E0")]
	public void OnShowPlantHealthButtonClick()
	{
		this.board.ShowPlantHealth();
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x000F33EC File Offset: 0x000F15EC
	[Token(Token = "0x6002CAC")]
	[Address(RVA = "0x6CDA10", Offset = "0x6CC010", VA = "0x1806CDA10")]
	public void OnShowZombieHealthButtonClick()
	{
		this.board.ShowZombieHealth();
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x000F340C File Offset: 0x000F160C
	[Token(Token = "0x6002CAD")]
	[Address(RVA = "0x6CD680", Offset = "0x6CBC80", VA = "0x1806CD680")]
	public void OnChangeGloveButtonClick()
	{
		Glove instance = Glove.Instance;
		int num = 0;
		if (instance != num)
		{
			Glove.Instance.SwitchStatus();
			return;
		}
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x000F343C File Offset: 0x000F163C
	[Token(Token = "0x6002CAE")]
	[Address(RVA = "0x6CD580", Offset = "0x6CBB80", VA = "0x1806CD580")]
	public void OnCameraScaleButtonClick()
	{
		float orthographicSize = Camera.main.orthographicSize;
		Camera main = Camera.main;
		GameConfig config = GameAPP.config;
		Camera main2 = Camera.main;
		float orthographicSize2 = main2.orthographicSize;
		main2.orthographicSize = orthographicSize2;
		CamaraFollowMouse.Instance.AdjustCameraPosition();
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x000F3490 File Offset: 0x000F1690
	[Token(Token = "0x6002CAF")]
	[Address(RVA = "0x6CD980", Offset = "0x6CBF80", VA = "0x1806CD980")]
	public void OnMouseFlipButtonClick()
	{
		GameAPP.mouseFlip = "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB8}" == (ulong)0L;
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x000F34AC File Offset: 0x000F16AC
	[Token(Token = "0x6002CB0")]
	[Address(RVA = "0x6CDA40", Offset = "0x6CC040", VA = "0x1806CDA40")]
	public void OnStartBattleButtonClick()
	{
		GameObject startBattle = this.StartBattle;
		int num = 0;
		startBattle.SetActive(num != 0);
		Board.Instance.boardTag.disableSummonZombie = false;
		Board.Instance.timeUntilNextWave = 3f;
	}

	// Token: 0x06002CB1 RID: 11441 RVA: 0x000F34F0 File Offset: 0x000F16F0
	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0x6CEDA0", Offset = "0x6CD3A0", VA = "0x1806CEDA0")]
	public InGameUI()
	{
		List<GameObject> list = new List(14);
		this.seed = list;
		HashSet<CardUI> hashSet = new HashSet();
		this.cards = hashSet;
		this.towards = (Towards)((ulong)1L);
		Dictionary<int, string> dictionary = new Dictionary();
		dictionary.Add(1, "旅行体验：第1关");
		dictionary.Add(2, "旅行体验：第2关");
		dictionary.Add(3, "旅行体验：第3关");
		dictionary.Add(4, "旅行体验：第4关");
		dictionary.Add(5, "旅行体验：第5关");
		dictionary.Add(6, "旅行体验：第6关");
		dictionary.Add(7, "超级樱桃射手挑战");
		dictionary.Add(8, "超级樱桃射手挑战");
		dictionary.Add(9, "超级樱桃射手挑战");
		dictionary.Add(10, "超级大嘴花挑战");
		dictionary.Add(11, "超级大嘴花挑战");
		dictionary.Add(12, "超级大嘴花挑战");
		dictionary.Add(13, "十旗挑战：白天");
		dictionary.Add(14, "十旗挑战：植物僵尸");
		dictionary.Add(15, "十旗挑战：随机植物");
		dictionary.Add(16, "十旗挑战：随机僵尸");
		dictionary.Add(17, "十旗挑战：随机植物VS随机僵尸");
		dictionary.Add(18, "十旗挑战：黑夜");
		dictionary.Add(19, "超级魅惑菇挑战");
		dictionary.Add(20, "超级魅惑菇挑战");
		dictionary.Add(21, "超级魅惑菇挑战");
		dictionary.Add(22, "超级大喷菇挑战");
		dictionary.Add(23, "超级大喷菇挑战");
		dictionary.Add(24, "超级大喷菇挑战");
		dictionary.Add(25, "胆小菇之梦");
		dictionary.Add(26, "十旗挑战：胆小菇之梦");
		dictionary.Add(27, "十旗挑战：黑夜舞会");
		dictionary.Add(28, "撑杆舞会");
		dictionary.Add(29, "合理密植");
		dictionary.Add(30, "二爷战争");
		dictionary.Add(31, "超级火炬挑战");
		dictionary.Add(32, "超级窝草挑战");
		dictionary.Add(33, "十旗挑战：泳池");
		dictionary.Add(34, "泳池激斗");
		dictionary.Add(35, "经典塔防");
		dictionary.Add(36, "经典塔防2");
		dictionary.Add(37, "全是套娃");
		dictionary.Add(38, "排山倒海");
		dictionary.Add(39, "超级随机模式");
		dictionary.Add(40, "诸神：升级");
		dictionary.Add(41, "十旗挑战：诸神");
		dictionary.Add(42, "种子雨");
		dictionary.Add(43, "谁能笑到最后");
		dictionary.Add(44, "空袭");
		dictionary.Add(45, "旅行体验：第7关");
		dictionary.Add(46, "旅行体验：第8关");
		dictionary.Add(47, "超级白天");
		dictionary.Add(48, "十旗挑战：究极随机");
		dictionary.Add(49, "超级泳池");
		dictionary.Add(50, "经典塔防3");
		dictionary.Add(51, "旅行体验：第9关");
		dictionary.Add(52, "关卡编辑器");
		dictionary.Add(53, "自定义关卡");
		dictionary.Add(54, "超级杨桃挑战");
		dictionary.Add(55, "超级南瓜挑战");
		dictionary.Add(56, "随机塔防");
		dictionary.Add(57, "十旗挑战：浓雾");
		dictionary.Add(58, "艺术就是爆炸");
		dictionary.Add(59, "跳跳舞会");
		dictionary.Add(60, "旅行体验：第10关");
		dictionary.Add(61, "花园保卫战：第1关");
		dictionary.Add(62, "巨人之怒");
		dictionary.Add(63, "祖玛保龄球");
		dictionary.Add(64, "大麦之战");
		dictionary.Add(65, "严肃窝瓜");
		dictionary.Add(66, "你看，他们像镜子一样");
		dictionary.Add(67, "魅惑坚果");
		dictionary.Add(68, "十旗挑战：等价交换");
		dictionary.Add(69, "十旗挑战：等价交换2");
		dictionary.Add(70, "旅行体验：第11关");
		dictionary.Add(71, "旅行体验：第12关");
		dictionary.Add(72, "诸神：末世重生");
		dictionary.Add(73, "十旗挑战：末世重生");
		dictionary.Add(74, "超级投手挑战");
		dictionary.Add(75, "超级伞挑战");
		dictionary.Add(76, "阳光保龄球");
		dictionary.Add(77, "僵王博士的复仇");
		dictionary.Add(78, "保卫吸金磁");
		dictionary.Add(79, "旅行体验：第13关");
		dictionary.Add(80, "十旗挑战：超级传送带");
		dictionary.Add(81, "经典塔防4");
		dictionary.Add(82, "合理密植2");
		dictionary.Add(83, "经典塔防5");
		dictionary.Add(84, "诸神：坚如磐石");
		dictionary.Add(85, "十旗挑战：坚如磐石");
		dictionary.Add(86, "黑曜石武装巨人的复仇");
		dictionary.Add(87, "十旗挑战：屋顶");
		dictionary.Add(88, "诸神：全军出击");
		dictionary.Add(89, "花园保卫战：第2关");
		dictionary.Add(90, "花园保卫战：第3关");
		dictionary.Add(91, "花园保卫战：第4关");
		dictionary.Add(92, "花园保卫战：第5关");
		dictionary.Add(93, "超级随机：模仿");
		dictionary.Add(94, "旅行体验：第14关");
		dictionary.Add(95, "真正的超级随机");
		dictionary.Add(96, "大麦之战2：拆拆乐");
		dictionary.Add(97, "塔防：冰天雪地");
		dictionary.Add(98, "单枪匹马");
		dictionary.Add(99, "蹦极闪电战");
		dictionary.Add(100, "宝石迷阵");
	}

	// Token: 0x04001A68 RID: 6760
	[Token(Token = "0x4001A68")]
	public static InGameUI Instance;

	// Token: 0x04001A69 RID: 6761
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A69")]
	[Header("卡槽系统")]
	public List<GameObject> seed;

	// Token: 0x04001A6A RID: 6762
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A6A")]
	public RectTransform movingCardContainer;

	// Token: 0x04001A6B RID: 6763
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A6B")]
	[Header("阳光显示")]
	public TextMeshProUGUI sun;

	// Token: 0x04001A6C RID: 6764
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A6C")]
	public Transform sunPos;

	// Token: 0x04001A6D RID: 6765
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A6D")]
	[Header("工具栏")]
	public RectTransform toolContainer;

	// Token: 0x04001A6E RID: 6766
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A6E")]
	public GameObject ShovelBank;

	// Token: 0x04001A6F RID: 6767
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A6F")]
	public GameObject GloveBank;

	// Token: 0x04001A70 RID: 6768
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A70")]
	public GameObject HammerBank;

	// Token: 0x04001A71 RID: 6769
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A71")]
	public GameObject MoneyBank;

	// Token: 0x04001A72 RID: 6770
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A72")]
	public GameObject WheelBank;

	// Token: 0x04001A73 RID: 6771
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001A73")]
	[Header("底部面板")]
	public GameObject Bottom;

	// Token: 0x04001A74 RID: 6772
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001A74")]
	public GameObject SeedBank;

	// Token: 0x04001A75 RID: 6773
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001A75")]
	public GameObject ConveyorBelt;

	// Token: 0x04001A76 RID: 6774
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001A76")]
	public GameObject ShowCardBank;

	// Token: 0x04001A77 RID: 6775
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001A77")]
	[Header("关卡进度")]
	public GameObject LevProgress;

	// Token: 0x04001A78 RID: 6776
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001A78")]
	public GameObject ZombieNum;

	// Token: 0x04001A79 RID: 6777
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001A79")]
	public GameObject Stars;

	// Token: 0x04001A7A RID: 6778
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001A7A")]
	public GameObject bossHealth;

	// Token: 0x04001A7B RID: 6779
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001A7B")]
	[Header("关卡名称")]
	public TextMeshProUGUI LevelName1;

	// Token: 0x04001A7C RID: 6780
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001A7C")]
	public TextMeshProUGUI LevelName2;

	// Token: 0x04001A7D RID: 6781
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001A7D")]
	public TextMeshProUGUI LevelName3;

	// Token: 0x04001A7E RID: 6782
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001A7E")]
	[Header("按钮容器")]
	public RectTransform buttonContainer;

	// Token: 0x04001A7F RID: 6783
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001A7F")]
	[Header("菜单按钮")]
	public GameObject BackToMenu;

	// Token: 0x04001A80 RID: 6784
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001A80")]
	public GameObject IngameMenu;

	// Token: 0x04001A81 RID: 6785
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001A81")]
	public GameObject StartBattle;

	// Token: 0x04001A82 RID: 6786
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001A82")]
	[Header("功能按钮")]
	public GameObject SlowTrigger;

	// Token: 0x04001A83 RID: 6787
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001A83")]
	public GameObject Difficulty;

	// Token: 0x04001A84 RID: 6788
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001A84")]
	public GameObject changeTowards;

	// Token: 0x04001A85 RID: 6789
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001A85")]
	public GameObject ChangeGlove;

	// Token: 0x04001A86 RID: 6790
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001A86")]
	public GameObject showBuffButton;

	// Token: 0x04001A87 RID: 6791
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001A87")]
	[Header("任务按钮")]
	public GameObject lookMission;

	// Token: 0x04001A88 RID: 6792
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001A88")]
	public GameObject submitMission;

	// Token: 0x04001A89 RID: 6793
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001A89")]
	public GameObject missionProgress;

	// Token: 0x04001A8A RID: 6794
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001A8A")]
	[Header("控制")]
	public GameObject CameraCtrl;

	// Token: 0x04001A8B RID: 6795
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4001A8B")]
	public GameObject Inputs;

	// Token: 0x04001A8C RID: 6796
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4001A8C")]
	[Header("查看功能")]
	public GameObject DrawCardsHead;

	// Token: 0x04001A8D RID: 6797
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4001A8D")]
	public GameObject lookBuff;

	// Token: 0x04001A8E RID: 6798
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4001A8E")]
	[Header("游戏信息")]
	public GameObject ShowPlantHealth;

	// Token: 0x04001A8F RID: 6799
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4001A8F")]
	public GameObject ShowZombieHealth;

	// Token: 0x04001A90 RID: 6800
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4001A90")]
	public GameObject grid;

	// Token: 0x04001A91 RID: 6801
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4001A91")]
	public GameObject progress2;

	// Token: 0x04001A92 RID: 6802
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4001A92")]
	[Header("其他")]
	public GameObject evacuate;

	// Token: 0x04001A93 RID: 6803
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4001A93")]
	[Header("布局")]
	public UIButton buttonPrefab;

	// Token: 0x04001A94 RID: 6804
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4001A94")]
	public UIButton graveButtonPrefab;

	// Token: 0x04001A95 RID: 6805
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4001A95")]
	public RectTransform showCardLayout;

	// Token: 0x04001A96 RID: 6806
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4001A96")]
	public RectTransform selectCardGroupLayout;

	// Token: 0x04001A97 RID: 6807
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001A97")]
	public CanvasGroup canvasUp;

	// Token: 0x04001A98 RID: 6808
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001A98")]
	[Header("关卡名称文本")]
	public List<TextMeshProUGUI> levelNameText;

	// Token: 0x04001A99 RID: 6809
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001A99")]
	[Header("卡牌管理")]
	public HashSet<CardUI> cards;

	// Token: 0x04001A9A RID: 6810
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001A9A")]
	public int avaliableCardCount;

	// Token: 0x04001A9B RID: 6811
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001A9B")]
	[Header("游戏设置")]
	public Towards towards;

	// Token: 0x04001A9C RID: 6812
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4001A9C")]
	private Board board;

	// Token: 0x04001A9D RID: 6813
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001A9D")]
	private CardSlotManager _cardSlotManager;

	// Token: 0x04001A9E RID: 6814
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4001A9E")]
	private float timer;

	// Token: 0x04001A9F RID: 6815
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4001A9F")]
	private readonly Dictionary<int, string> levelDescriptions;

	// Token: 0x04001AA0 RID: 6816
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4001AA0")]
	private readonly Dictionary<SkinLevel, string> skinLevelDescription;
}
