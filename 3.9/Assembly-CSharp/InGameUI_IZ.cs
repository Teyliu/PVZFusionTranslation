using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200088C RID: 2188
[Token(Token = "0x200088C")]
public class InGameUI_IZ : BaseMenu
{
	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000F3AAC File Offset: 0x000F1CAC
	[Token(Token = "0x17000204")]
	public List<CardUI> Cards
	{
		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x6CD250", Offset = "0x6CB850", VA = "0x1806CD250")]
		get
		{
			return new List(this._cardSlotManager.Cards);
		}
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x000F3AD0 File Offset: 0x000F1CD0
	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x6CCCF0", Offset = "0x6CB2F0", VA = "0x1806CCCF0", Slot = "6")]
	protected override void Awake()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000F3AF0 File Offset: 0x000F1CF0
	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0x6CD060", Offset = "0x6CB660", VA = "0x1806CD060")]
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

	// Token: 0x06002CBA RID: 11450 RVA: 0x000F3B2C File Offset: 0x000F1D2C
	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x6CCF40", Offset = "0x6CB540", VA = "0x1806CCF40")]
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

	// Token: 0x06002CBB RID: 11451 RVA: 0x000F3B7C File Offset: 0x000F1D7C
	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0x6CCCD0", Offset = "0x6CB2D0", VA = "0x1806CCCD0")]
	public bool AddCardToBank(CardUI card, bool quick = false)
	{
		return this._cardSlotManager.AddCard(card, quick);
	}

	// Token: 0x06002CBC RID: 11452 RVA: 0x000F3B9C File Offset: 0x000F1D9C
	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0x6CCF20", Offset = "0x6CB520", VA = "0x1806CCF20")]
	public void RemoveCardFromBank(CardUI card, bool quick = false)
	{
		bool flag = this._cardSlotManager.RemoveCard(card, quick);
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x000F3BC0 File Offset: 0x000F1DC0
	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0x6CCE50", Offset = "0x6CB450", VA = "0x1806CCE50")]
	public static IZData GetCustomIZData()
	{
		string text = Path.Combine(SaveInfo.GetDataPath(), "CustomIZ.json");
		if (!File.Exists(text))
		{
		}
		return JsonUtility.FromJson<IZData>(File.ReadAllText(text));
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x000F3BF8 File Offset: 0x000F1DF8
	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x6CCDA0", Offset = "0x6CB3A0", VA = "0x1806CCDA0")]
	public static IZData GetCustomIZData(string name)
	{
		int num = 0;
		bool flag = GameAPP.customIZManager.customIZDatas.TryGetValue(name, num);
		throw new NullReferenceException();
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x000F3C20 File Offset: 0x000F1E20
	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x6CCF00", Offset = "0x6CB500", VA = "0x1806CCF00")]
	private void OnDestroy()
	{
		CardSlotManager cardSlotManager = this._cardSlotManager;
		if (cardSlotManager != 0)
		{
			cardSlotManager.ClearAll();
			return;
		}
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x000F3C40 File Offset: 0x000F1E40
	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x6CD130", Offset = "0x6CB730", VA = "0x1806CD130")]
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

	// Token: 0x04001AA5 RID: 6821
	[Token(Token = "0x4001AA5")]
	public static InGameUI_IZ Instance;

	// Token: 0x04001AA6 RID: 6822
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AA6")]
	public CardUI[] cardOnBank;

	// Token: 0x04001AA7 RID: 6823
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AA7")]
	public GameObject[] seed;

	// Token: 0x04001AA8 RID: 6824
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AA8")]
	public List<ZombieType> customCards;

	// Token: 0x04001AA9 RID: 6825
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001AA9")]
	public List<IZECard> zombieCards;

	// Token: 0x04001AAA RID: 6826
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AAA")]
	private CardSlotManager _cardSlotManager;

	// Token: 0x04001AAB RID: 6827
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AAB")]
	public TextMeshProUGUI sun;

	// Token: 0x04001AAC RID: 6828
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001AAC")]
	public GameObject shovel;

	// Token: 0x04001AAD RID: 6829
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001AAD")]
	public GameObject glove;

	// Token: 0x04001AAE RID: 6830
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001AAE")]
	public GameObject wheel;

	// Token: 0x04001AAF RID: 6831
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001AAF")]
	public Transform sunPos;

	// Token: 0x04001AB0 RID: 6832
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001AB0")]
	public UIButton zombieCardButton;
}
