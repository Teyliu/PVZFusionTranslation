using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200089A RID: 2202
[Token(Token = "0x200089A")]
public class TreasureWarehouseMenu : BaseMenu
{
	// Token: 0x06002CE2 RID: 11490 RVA: 0x000F7900 File Offset: 0x000F5B00
	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x691610", Offset = "0x68FC10", VA = "0x180691610", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TreasureWarehouseMenu.Instance = this;
	}

	// Token: 0x06002CE3 RID: 11491 RVA: 0x000F791C File Offset: 0x000F5B1C
	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x6922C0", Offset = "0x6908C0", VA = "0x1806922C0")]
	public void QuickSell()
	{
		bool flag = !this.quickSell;
		this.quickSell = flag;
		TextMeshProUGUI textMeshProUGUI = this.quickSellText;
		throw new NullReferenceException();
	}

	// Token: 0x06002CE4 RID: 11492 RVA: 0x000F7948 File Offset: 0x000F5B48
	[Token(Token = "0x6002CE4")]
	[Address(RVA = "0x692340", Offset = "0x690940", VA = "0x180692340")]
	private void Start()
	{
		this.InitCards();
	}

	// Token: 0x06002CE5 RID: 11493 RVA: 0x000F795C File Offset: 0x000F5B5C
	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x691670", Offset = "0x68FC70", VA = "0x180691670")]
	public void EnterStore()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)46), canvasUp, num != 0);
	}

	// Token: 0x06002CE6 RID: 11494 RVA: 0x000F798C File Offset: 0x000F5B8C
	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x6918F0", Offset = "0x68FEF0", VA = "0x1806918F0")]
	private void InitCards()
	{
		GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCard");
		GameObject gameObject2 = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCardBank");
		List<TreasureCardData> list = new List(TreasureData.treasureCards);
		Predicate<TreasureCardData> <>9__10_ = TreasureWarehouseMenu.<>c.<>9__10_0;
		if (<>9__10_ == 0)
		{
			Predicate<TreasureCardData> predicate;
			TreasureWarehouseMenu.<>c.<>9__10_0 = predicate;
		}
		int num = list.RemoveAll(<>9__10_);
		Func<TreasureCardData, bool> func;
		if (TreasureWarehouseMenu.<>c.<>9__10_1 == 0)
		{
			TreasureWarehouseMenu.<>c.<>9__10_1 = func;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable = Enumerable.OrderByDescending<TreasureCardData, bool>(list, func);
		Func<TreasureCardData, CardLevel> func2;
		if (TreasureWarehouseMenu.<>c.<>9__10_2 == 0)
		{
			TreasureWarehouseMenu.<>c.<>9__10_2 = func2;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable2 = Enumerable.ThenBy<TreasureCardData, CardLevel>(orderedEnumerable, func2);
		Func<TreasureCardData, PlantType> func3;
		if (TreasureWarehouseMenu.<>c.<>9__10_3 == 0)
		{
			TreasureWarehouseMenu.<>c.<>9__10_3 = func3;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable3 = Enumerable.ThenBy<TreasureCardData, PlantType>(orderedEnumerable2, func3);
		Func<TreasureCardData, int> func4;
		if (TreasureWarehouseMenu.<>c.<>9__10_4 == 0)
		{
			TreasureWarehouseMenu.<>c.<>9__10_4 = func4;
		}
		List<TreasureCardData> list2 = Enumerable.ToList<TreasureCardData>(Enumerable.ThenBy<TreasureCardData, int>(orderedEnumerable3, func4));
		int num2 = 0;
		ulong num3;
		num3 += (ulong)1L;
		num3 += num3;
		if (num3 > (ulong)0L)
		{
			GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePage);
			int num4;
			string text = string.Format("page{0}", num4);
			gameObject3.name = text;
			Transform transform = gameObject3.transform;
			Transform transform2 = this.library;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject3.transform;
			Transform transform4 = gameObject3.transform;
			Transform transform5 = gameObject3.transform;
			Transform transform6 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform5).transform;
			TreasureCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform6).GetComponent<TreasureCard>();
			Transform transform7 = component.transform;
			list2[num2].Load(component);
			component.Init();
			List<TreasureCard> list3 = this.cards;
			num2++;
			num2++;
			num2 += 44;
		}
		int childCount = this.library.childCount;
		if (num2 < childCount)
		{
			if (num2 != 0)
			{
				GameObject gameObject4 = this.library.transform.GetChild(num2).gameObject;
				int num5 = 0;
				gameObject4.SetActive(num5 != 0);
			}
			Transform transform8 = this.library;
			num2++;
		}
	}

	// Token: 0x06002CE7 RID: 11495 RVA: 0x000F7B64 File Offset: 0x000F5D64
	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x6916F0", Offset = "0x68FCF0", VA = "0x1806916F0")]
	public void FastSell(string str)
	{
		object obj = Enum.Parse(typeof(CardLevel), str);
		int size = this.cards._size;
		int num = size - 1;
		if (size > 0)
		{
			TreasureCard treasureCard = this.cards[num];
			int num2 = 0;
			if (treasureCard != num2)
			{
				int plantType = (int)treasureCard._plantType;
				CardLevel cardLevel;
				if (cardLevel == obj)
				{
					treasureCard.Sell();
				}
			}
		}
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002CE8 RID: 11496 RVA: 0x000F7BD8 File Offset: 0x000F5DD8
	[Token(Token = "0x6002CE8")]
	[Address(RVA = "0x692370", Offset = "0x690970", VA = "0x180692370")]
	public TreasureWarehouseMenu()
	{
		List<TreasureCard> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x04001B01 RID: 6913
	[Token(Token = "0x4001B01")]
	public static TreasureWarehouseMenu Instance;

	// Token: 0x04001B02 RID: 6914
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B02")]
	public List<TreasureCard> cards;

	// Token: 0x04001B03 RID: 6915
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B03")]
	public Transform library;

	// Token: 0x04001B04 RID: 6916
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B04")]
	public GameObject samplePage;

	// Token: 0x04001B05 RID: 6917
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B05")]
	public TextMeshProUGUI quickSellText;

	// Token: 0x04001B06 RID: 6918
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B06")]
	public bool quickSell;
}
