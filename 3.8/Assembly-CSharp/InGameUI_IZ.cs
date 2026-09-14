using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000850 RID: 2128
[Token(Token = "0x2000850")]
public class InGameUI_IZ : BaseMenu
{
	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000EEE54 File Offset: 0x000ED054
	[Token(Token = "0x170001BC")]
	public List<CardUI> Cards
	{
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x668740", Offset = "0x666D40", VA = "0x180668740")]
		get
		{
			return new List(this._cardSlotManager.Cards);
		}
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x000EEE78 File Offset: 0x000ED078
	[Token(Token = "0x6002B86")]
	[Address(RVA = "0x6681E0", Offset = "0x6667E0", VA = "0x1806681E0", Slot = "6")]
	protected override void Awake()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x000EEE98 File Offset: 0x000ED098
	[Token(Token = "0x6002B87")]
	[Address(RVA = "0x668550", Offset = "0x666B50", VA = "0x180668550")]
	private void Update()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			TextMeshProUGUI textMeshProUGUI = this.sun;
			Board instance2 = Board.Instance;
			string text;
			textMeshProUGUI.text = text;
		}
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x000EEED4 File Offset: 0x000ED0D4
	[Token(Token = "0x6002B88")]
	[Address(RVA = "0x668430", Offset = "0x666A30", VA = "0x180668430")]
	public void ShowZombieCard()
	{
		GameObject zombieLibary = IZBottomMenu.Instance.zombieLibary;
		if (!zombieLibary.activeSelf)
		{
			zombieLibary.SetActive(true);
			Time.timeScale = (float)0;
			return;
		}
		int num = 0;
		zombieLibary.SetActive(num != 0);
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x000EEF24 File Offset: 0x000ED124
	[Token(Token = "0x6002B89")]
	[Address(RVA = "0x6681C0", Offset = "0x6667C0", VA = "0x1806681C0")]
	public bool AddCardToBank(CardUI card, bool quick = false)
	{
		return this._cardSlotManager.AddCard(card, quick);
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x000EEF44 File Offset: 0x000ED144
	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x668410", Offset = "0x666A10", VA = "0x180668410")]
	public void RemoveCardFromBank(CardUI card, bool quick = false)
	{
		bool flag = this._cardSlotManager.RemoveCard(card, quick);
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x000EEF68 File Offset: 0x000ED168
	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x668340", Offset = "0x666940", VA = "0x180668340")]
	public static IZData GetCustomIZData()
	{
		string text = Path.Combine(SaveInfo.GetDataPath(), "CustomIZ.json");
		if (!File.Exists(text))
		{
		}
		return JsonUtility.FromJson<IZData>(File.ReadAllText(text));
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x000EEFA0 File Offset: 0x000ED1A0
	[Token(Token = "0x6002B8C")]
	[Address(RVA = "0x668290", Offset = "0x666890", VA = "0x180668290")]
	public static IZData GetCustomIZData(string name)
	{
		int num = 0;
		bool flag = GameAPP.customIZManager.customIZDatas.TryGetValue(name, num);
		throw new NullReferenceException();
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x000EEFC8 File Offset: 0x000ED1C8
	[Token(Token = "0x6002B8D")]
	[Address(RVA = "0x6683F0", Offset = "0x6669F0", VA = "0x1806683F0")]
	private void OnDestroy()
	{
		CardSlotManager cardSlotManager = this._cardSlotManager;
		if (cardSlotManager != 0)
		{
			cardSlotManager.ClearAll();
			return;
		}
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x000EEFE8 File Offset: 0x000ED1E8
	[Token(Token = "0x6002B8E")]
	[Address(RVA = "0x668620", Offset = "0x666C20", VA = "0x180668620")]
	public InGameUI_IZ()
	{
		CardUI[] array = new CardUI[14];
		this.cardOnBank = array;
		GameObject[] array2 = new GameObject[14];
		this.seed = array2;
		List<ZombieType> list = new List();
		this.customCards = list;
		List<IZECard> list2 = new List();
		this.zombieCards = list2;
		base..ctor();
	}

	// Token: 0x040019B7 RID: 6583
	[Token(Token = "0x40019B7")]
	public static InGameUI_IZ Instance;

	// Token: 0x040019B8 RID: 6584
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019B8")]
	public CardUI[] cardOnBank;

	// Token: 0x040019B9 RID: 6585
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019B9")]
	public GameObject[] seed;

	// Token: 0x040019BA RID: 6586
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019BA")]
	public List<ZombieType> customCards;

	// Token: 0x040019BB RID: 6587
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40019BB")]
	public List<IZECard> zombieCards;

	// Token: 0x040019BC RID: 6588
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019BC")]
	private CardSlotManager _cardSlotManager;

	// Token: 0x040019BD RID: 6589
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019BD")]
	public TextMeshProUGUI sun;

	// Token: 0x040019BE RID: 6590
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40019BE")]
	public GameObject shovel;

	// Token: 0x040019BF RID: 6591
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019BF")]
	public GameObject glove;

	// Token: 0x040019C0 RID: 6592
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40019C0")]
	public GameObject wheel;

	// Token: 0x040019C1 RID: 6593
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40019C1")]
	public Transform sunPos;

	// Token: 0x040019C2 RID: 6594
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40019C2")]
	public UIButton zombieCardButton;
}
