using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200084D RID: 2125
[Token(Token = "0x200084D")]
public class InGameUI : BaseMenu
{
	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000EDD48 File Offset: 0x000EBF48
	[Token(Token = "0x170001B8")]
	public List<CardUI> Cards
	{
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x66BE60", Offset = "0x66A460", VA = "0x18066BE60")]
		get
		{
			return new List(this._cardSlotManager.Cards);
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000EDD6C File Offset: 0x000EBF6C
	[Token(Token = "0x170001B9")]
	public bool Full
	{
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x66BEF0", Offset = "0x66A4F0", VA = "0x18066BEF0")]
		get
		{
			return this._cardSlotManager.IsFull;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000EDD8C File Offset: 0x000EBF8C
	[Token(Token = "0x170001BA")]
	public CardSlotManager CardSlotManager
	{
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x66BE50", Offset = "0x66A450", VA = "0x18066BE50")]
		get
		{
			return this._cardSlotManager;
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06002B58 RID: 11096 RVA: 0x000EDDA0 File Offset: 0x000EBFA0
	// (set) Token: 0x06002B59 RID: 11097 RVA: 0x000EDDB4 File Offset: 0x000EBFB4
	[Token(Token = "0x170001BB")]
	public override bool Interactable
	{
		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x62BC20", Offset = "0x62A220", VA = "0x18062BC20", Slot = "4")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x66BF20", Offset = "0x66A520", VA = "0x18066BF20", Slot = "5")]
		set
		{
			base.Interactable = value;
			this.canvasUp.interactable = value;
			this.canvasUp.blocksRaycasts = value;
		}
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x000EDDE8 File Offset: 0x000EBFE8
	[Token(Token = "0x6002B5A")]
	[Address(RVA = "0x6670D0", Offset = "0x6656D0", VA = "0x1806670D0", Slot = "6")]
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

	// Token: 0x06002B5B RID: 11099 RVA: 0x000EDEC0 File Offset: 0x000EC0C0
	[Token(Token = "0x6002B5B")]
	[Address(RVA = "0x6696C0", Offset = "0x667CC0", VA = "0x1806696C0")]
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

	// Token: 0x06002B5C RID: 11100 RVA: 0x000EDF10 File Offset: 0x000EC110
	[Token(Token = "0x6002B5C")]
	[Address(RVA = "0x667B80", Offset = "0x666180", VA = "0x180667B80", Slot = "7")]
	protected override void GetCol()
	{
		base.GetCol();
		CanvasGroup canvasGroup = this.canvasUp;
		List<Collider2D> collider2Ds = this.collider2Ds;
		List<Collider2D> childs = global::Core.Lawnf.GetChilds<Collider2D>(canvasGroup.transform);
		collider2Ds.AddRange(childs);
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x000EDF4C File Offset: 0x000EC14C
	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x668C10", Offset = "0x667210", VA = "0x180668C10")]
	private void OnDestroy()
	{
		CardSlotManager cardSlotManager = this._cardSlotManager;
		if (cardSlotManager != 0)
		{
			cardSlotManager.ClearAll();
			return;
		}
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x000EDF6C File Offset: 0x000EC16C
	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x668C30", Offset = "0x667230", VA = "0x180668C30", Slot = "8")]
	public override void OnExit()
	{
		global::UnityEngine.Object.Destroy(this.canvasUp.gameObject);
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x000EDF90 File Offset: 0x000EC190
	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x66A100", Offset = "0x668700", VA = "0x18066A100")]
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

	// Token: 0x06002B60 RID: 11104 RVA: 0x000EDFE8 File Offset: 0x000EC1E8
	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x669B70", Offset = "0x668170", VA = "0x180669B70")]
	private void UpdateSunDisplay()
	{
		List<Plant> plantHead = this.board.boardEntity.plantHead;
		Func<Plant, bool> <>9__70_ = InGameUI.<>c.<>9__70_0;
		if (<>9__70_ == 0)
		{
			Func<Plant, bool> func;
			InGameUI.<>c.<>9__70_0 = func;
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

	// Token: 0x06002B61 RID: 11105 RVA: 0x000EE088 File Offset: 0x000EC288
	[Token(Token = "0x6002B61")]
	[Address(RVA = "0x667590", Offset = "0x665B90", VA = "0x180667590")]
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

	// Token: 0x06002B62 RID: 11106 RVA: 0x000EE0D4 File Offset: 0x000EC2D4
	[Token(Token = "0x6002B62")]
	[Address(RVA = "0x669DE0", Offset = "0x6683E0", VA = "0x180669DE0")]
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

	// Token: 0x06002B63 RID: 11107 RVA: 0x000EE174 File Offset: 0x000EC374
	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x667030", Offset = "0x665630", VA = "0x180667030")]
	public bool AddCardToBank(CardUI card, bool quick = false)
	{
		bool flag = this._cardSlotManager.AddCard(card, quick);
		if (!flag)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("已达关卡卡牌数量上限", 3f, num != 0);
		}
		return flag;
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x000EE1B8 File Offset: 0x000EC3B8
	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x6690E0", Offset = "0x6676E0", VA = "0x1806690E0")]
	public bool RemoveCardFromBank(CardUI card, bool quick = false)
	{
		return this._cardSlotManager.RemoveCard(card, quick);
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x000EE1D8 File Offset: 0x000EC3D8
	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x668A40", Offset = "0x667040", VA = "0x180668A40")]
	public void MoveCardToTarget(CardUI card, bool quick = false)
	{
		this._cardSlotManager.MoveCardToTarget(card, quick);
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x000EE1F8 File Offset: 0x000EC3F8
	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x6699A0", Offset = "0x667FA0", VA = "0x1806699A0")]
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

	// Token: 0x06002B67 RID: 11111 RVA: 0x000EE25C File Offset: 0x000EC45C
	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x669110", Offset = "0x667710", VA = "0x180669110")]
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

	// Token: 0x06002B68 RID: 11112 RVA: 0x000EE288 File Offset: 0x000EC488
	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x669240", Offset = "0x667840", VA = "0x180669240")]
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

	// Token: 0x06002B69 RID: 11113 RVA: 0x000EE31C File Offset: 0x000EC51C
	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x667C30", Offset = "0x666230", VA = "0x180667C30")]
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

	// Token: 0x06002B6A RID: 11114 RVA: 0x000EE384 File Offset: 0x000EC584
	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x667360", Offset = "0x665960", VA = "0x180667360")]
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

	// Token: 0x06002B6B RID: 11115 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x66A210", Offset = "0x668810", VA = "0x18066A210")]
	public void UpperUI()
	{
		Transform transform = base.transform;
		Transform transform2 = GameAPP.canvasUp;
		transform.parentInternal = transform2;
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x000EE3D0 File Offset: 0x000EC5D0
	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x6688E0", Offset = "0x666EE0", VA = "0x1806688E0")]
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

	// Token: 0x06002B6D RID: 11117 RVA: 0x000EE410 File Offset: 0x000EC610
	[Token(Token = "0x6002B6D")]
	[Address(RVA = "0x668FF0", Offset = "0x6675F0", VA = "0x180668FF0")]
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

	// Token: 0x06002B6E RID: 11118 RVA: 0x000EE464 File Offset: 0x000EC664
	[Token(Token = "0x6002B6E")]
	[Address(RVA = "0x667490", Offset = "0x665A90", VA = "0x180667490")]
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

	// Token: 0x06002B6F RID: 11119 RVA: 0x000EE4A8 File Offset: 0x000EC6A8
	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x6676A0", Offset = "0x665CA0", VA = "0x1806676A0")]
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

	// Token: 0x06002B70 RID: 11120 RVA: 0x000EE530 File Offset: 0x000EC730
	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x667A10", Offset = "0x666010", VA = "0x180667A10")]
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

	// Token: 0x06002B71 RID: 11121 RVA: 0x000EE598 File Offset: 0x000EC798
	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x6678C0", Offset = "0x665EC0", VA = "0x1806678C0")]
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

	// Token: 0x06002B72 RID: 11122 RVA: 0x000EE5FC File Offset: 0x000EC7FC
	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x668990", Offset = "0x666F90", VA = "0x180668990")]
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

	// Token: 0x06002B73 RID: 11123 RVA: 0x000EE644 File Offset: 0x000EC844
	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x669900", Offset = "0x667F00", VA = "0x180669900")]
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

	// Token: 0x06002B74 RID: 11124 RVA: 0x000EE688 File Offset: 0x000EC888
	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x6687C0", Offset = "0x666DC0", VA = "0x1806687C0")]
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

	// Token: 0x06002B75 RID: 11125 RVA: 0x000EE6CC File Offset: 0x000EC8CC
	[Token(Token = "0x6002B75")]
	[Address(RVA = "0x668860", Offset = "0x666E60", VA = "0x180668860")]
	public void LookTalent()
	{
		UIMgr.EnterPauseMenu();
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform transform = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)63), transform, num != 0);
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x000EE704 File Offset: 0x000EC904
	[Token(Token = "0x6002B76")]
	[Address(RVA = "0x668CA0", Offset = "0x6672A0", VA = "0x180668CA0")]
	public void OnLookZombieButtonClicked()
	{
		Board board = this.board;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)57), num != 0);
		List<ZombieType> list = Enumerable.ToList<ZombieType>(InitZombieList.zombieTypeList);
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x000EE740 File Offset: 0x000EC940
	[Token(Token = "0x6002B77")]
	[Address(RVA = "0x667870", Offset = "0x665E70", VA = "0x180667870")]
	public void Evacuate()
	{
		TreasureManager.Instance.Evacuate();
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x000EE760 File Offset: 0x000EC960
	[Token(Token = "0x6002B78")]
	[Address(RVA = "0x668E00", Offset = "0x667400", VA = "0x180668E00")]
	public void OnMainMenuButtonClick()
	{
		this.PauseGame();
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x000EE774 File Offset: 0x000EC974
	[Token(Token = "0x6002B79")]
	[Address(RVA = "0x668ED0", Offset = "0x6674D0", VA = "0x180668ED0")]
	public void OnShowPlantHealthButtonClick()
	{
		this.board.ShowPlantHealth();
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x000EE794 File Offset: 0x000EC994
	[Token(Token = "0x6002B7A")]
	[Address(RVA = "0x668F00", Offset = "0x667500", VA = "0x180668F00")]
	public void OnShowZombieHealthButtonClick()
	{
		this.board.ShowZombieHealth();
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x000EE7B4 File Offset: 0x000EC9B4
	[Token(Token = "0x6002B7B")]
	[Address(RVA = "0x668B70", Offset = "0x667170", VA = "0x180668B70")]
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

	// Token: 0x06002B7C RID: 11132 RVA: 0x000EE7E4 File Offset: 0x000EC9E4
	[Token(Token = "0x6002B7C")]
	[Address(RVA = "0x668A70", Offset = "0x667070", VA = "0x180668A70")]
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

	// Token: 0x06002B7D RID: 11133 RVA: 0x000EE838 File Offset: 0x000ECA38
	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x668E70", Offset = "0x667470", VA = "0x180668E70")]
	public void OnMouseFlipButtonClick()
	{
		GameAPP.mouseFlip = "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB8}" == (ulong)0L;
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x000EE854 File Offset: 0x000ECA54
	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x668F30", Offset = "0x667530", VA = "0x180668F30")]
	public void OnStartBattleButtonClick()
	{
		GameObject startBattle = this.StartBattle;
		int num = 0;
		startBattle.SetActive(num != 0);
		Board.Instance.boardTag.disableSummonZombie = false;
		Board.Instance.timeUntilNextWave = 3f;
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x000EE898 File Offset: 0x000ECA98
	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x66A290", Offset = "0x668890", VA = "0x18066A290")]
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

	// Token: 0x0400197A RID: 6522
	[Token(Token = "0x400197A")]
	public static InGameUI Instance;

	// Token: 0x0400197B RID: 6523
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400197B")]
	[Header("卡槽系统")]
	public List<GameObject> seed;

	// Token: 0x0400197C RID: 6524
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400197C")]
	public RectTransform movingCardContainer;

	// Token: 0x0400197D RID: 6525
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400197D")]
	[Header("阳光显示")]
	public TextMeshProUGUI sun;

	// Token: 0x0400197E RID: 6526
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400197E")]
	public Transform sunPos;

	// Token: 0x0400197F RID: 6527
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400197F")]
	[Header("工具栏")]
	public RectTransform toolContainer;

	// Token: 0x04001980 RID: 6528
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001980")]
	public GameObject ShovelBank;

	// Token: 0x04001981 RID: 6529
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001981")]
	public GameObject GloveBank;

	// Token: 0x04001982 RID: 6530
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001982")]
	public GameObject HammerBank;

	// Token: 0x04001983 RID: 6531
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001983")]
	public GameObject MoneyBank;

	// Token: 0x04001984 RID: 6532
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001984")]
	public GameObject WheelBank;

	// Token: 0x04001985 RID: 6533
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001985")]
	[Header("底部面板")]
	public GameObject Bottom;

	// Token: 0x04001986 RID: 6534
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001986")]
	public GameObject SeedBank;

	// Token: 0x04001987 RID: 6535
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001987")]
	public GameObject ConveyorBelt;

	// Token: 0x04001988 RID: 6536
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001988")]
	public GameObject ShowCardBank;

	// Token: 0x04001989 RID: 6537
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001989")]
	[Header("关卡进度")]
	public GameObject LevProgress;

	// Token: 0x0400198A RID: 6538
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400198A")]
	public GameObject ZombieNum;

	// Token: 0x0400198B RID: 6539
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400198B")]
	public GameObject Stars;

	// Token: 0x0400198C RID: 6540
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400198C")]
	public GameObject bossHealth;

	// Token: 0x0400198D RID: 6541
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400198D")]
	[Header("关卡名称")]
	public TextMeshProUGUI LevelName1;

	// Token: 0x0400198E RID: 6542
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400198E")]
	public TextMeshProUGUI LevelName2;

	// Token: 0x0400198F RID: 6543
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400198F")]
	public TextMeshProUGUI LevelName3;

	// Token: 0x04001990 RID: 6544
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001990")]
	[Header("按钮容器")]
	public RectTransform buttonContainer;

	// Token: 0x04001991 RID: 6545
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001991")]
	[Header("菜单按钮")]
	public GameObject BackToMenu;

	// Token: 0x04001992 RID: 6546
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001992")]
	public GameObject IngameMenu;

	// Token: 0x04001993 RID: 6547
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001993")]
	public GameObject StartBattle;

	// Token: 0x04001994 RID: 6548
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001994")]
	[Header("功能按钮")]
	public GameObject SlowTrigger;

	// Token: 0x04001995 RID: 6549
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001995")]
	public GameObject Difficulty;

	// Token: 0x04001996 RID: 6550
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001996")]
	public GameObject changeTowards;

	// Token: 0x04001997 RID: 6551
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001997")]
	public GameObject ChangeGlove;

	// Token: 0x04001998 RID: 6552
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001998")]
	public GameObject showBuffButton;

	// Token: 0x04001999 RID: 6553
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001999")]
	[Header("任务按钮")]
	public GameObject lookMission;

	// Token: 0x0400199A RID: 6554
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400199A")]
	public GameObject submitMission;

	// Token: 0x0400199B RID: 6555
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400199B")]
	public GameObject missionProgress;

	// Token: 0x0400199C RID: 6556
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400199C")]
	[Header("控制")]
	public GameObject CameraCtrl;

	// Token: 0x0400199D RID: 6557
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400199D")]
	public GameObject Inputs;

	// Token: 0x0400199E RID: 6558
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400199E")]
	[Header("查看功能")]
	public GameObject DrawCardsHead;

	// Token: 0x0400199F RID: 6559
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400199F")]
	public GameObject lookBuff;

	// Token: 0x040019A0 RID: 6560
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40019A0")]
	[Header("游戏信息")]
	public GameObject ShowPlantHealth;

	// Token: 0x040019A1 RID: 6561
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40019A1")]
	public GameObject ShowZombieHealth;

	// Token: 0x040019A2 RID: 6562
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40019A2")]
	public GameObject grid;

	// Token: 0x040019A3 RID: 6563
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x40019A3")]
	public GameObject progress2;

	// Token: 0x040019A4 RID: 6564
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40019A4")]
	[Header("其他")]
	public GameObject evacuate;

	// Token: 0x040019A5 RID: 6565
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40019A5")]
	[Header("布局")]
	public UIButton buttonPrefab;

	// Token: 0x040019A6 RID: 6566
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40019A6")]
	public UIButton graveButtonPrefab;

	// Token: 0x040019A7 RID: 6567
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40019A7")]
	public RectTransform showCardLayout;

	// Token: 0x040019A8 RID: 6568
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40019A8")]
	public RectTransform selectCardGroupLayout;

	// Token: 0x040019A9 RID: 6569
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40019A9")]
	public CanvasGroup canvasUp;

	// Token: 0x040019AA RID: 6570
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40019AA")]
	[Header("关卡名称文本")]
	public List<TextMeshProUGUI> levelNameText;

	// Token: 0x040019AB RID: 6571
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40019AB")]
	[Header("卡牌管理")]
	public HashSet<CardUI> cards;

	// Token: 0x040019AC RID: 6572
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40019AC")]
	public int avaliableCardCount;

	// Token: 0x040019AD RID: 6573
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x40019AD")]
	[Header("游戏设置")]
	public Towards towards;

	// Token: 0x040019AE RID: 6574
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40019AE")]
	private Board board;

	// Token: 0x040019AF RID: 6575
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40019AF")]
	private CardSlotManager _cardSlotManager;

	// Token: 0x040019B0 RID: 6576
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40019B0")]
	private float timer;

	// Token: 0x040019B1 RID: 6577
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40019B1")]
	private readonly Dictionary<int, string> levelDescriptions;

	// Token: 0x040019B2 RID: 6578
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40019B2")]
	private readonly Dictionary<SkinLevel, string> skinLevelDescription;
}
