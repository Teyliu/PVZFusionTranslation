using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008D6 RID: 2262
[Token(Token = "0x20008D6")]
public class TreasureWarehouseMenu : BaseMenu
{
	// Token: 0x06002E14 RID: 11796 RVA: 0x000FC45C File Offset: 0x000FA65C
	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x70ACE0", Offset = "0x7092E0", VA = "0x18070ACE0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TreasureWarehouseMenu.Instance = this;
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x000FC478 File Offset: 0x000FA678
	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x70B990", Offset = "0x709F90", VA = "0x18070B990")]
	public void QuickSell()
	{
		bool flag = !this.quickSell;
		this.quickSell = flag;
		TextMeshProUGUI textMeshProUGUI = this.quickSellText;
		throw new NullReferenceException();
	}

	// Token: 0x06002E16 RID: 11798 RVA: 0x000FC4A4 File Offset: 0x000FA6A4
	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x70BA10", Offset = "0x70A010", VA = "0x18070BA10")]
	private void Start()
	{
		this.InitCards();
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x000FC4B8 File Offset: 0x000FA6B8
	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x70AD40", Offset = "0x709340", VA = "0x18070AD40")]
	public void EnterStore()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)46), canvasUp, num != 0);
	}

	// Token: 0x06002E18 RID: 11800 RVA: 0x000FC4E8 File Offset: 0x000FA6E8
	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x70AFC0", Offset = "0x7095C0", VA = "0x18070AFC0")]
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
			func = delegate(TreasureCardData a)
			{
				HashSet<PlantType> collectedPlants = TreasureData.collectedPlants;
				PlantType thePlantType = a.thePlantType;
				return collectedPlants.Contains(thePlantType);
			};
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

	// Token: 0x06002E19 RID: 11801 RVA: 0x000FC6D4 File Offset: 0x000FA8D4
	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x70ADC0", Offset = "0x7093C0", VA = "0x18070ADC0")]
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

	// Token: 0x06002E1A RID: 11802 RVA: 0x000FC748 File Offset: 0x000FA948
	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x70BA40", Offset = "0x70A040", VA = "0x18070BA40")]
	public TreasureWarehouseMenu()
	{
		List<TreasureCard> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x04001BEF RID: 7151
	[Token(Token = "0x4001BEF")]
	public static TreasureWarehouseMenu Instance;

	// Token: 0x04001BF0 RID: 7152
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BF0")]
	public List<TreasureCard> cards;

	// Token: 0x04001BF1 RID: 7153
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BF1")]
	public Transform library;

	// Token: 0x04001BF2 RID: 7154
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BF2")]
	public GameObject samplePage;

	// Token: 0x04001BF3 RID: 7155
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BF3")]
	public TextMeshProUGUI quickSellText;

	// Token: 0x04001BF4 RID: 7156
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BF4")]
	public bool quickSell;
}
