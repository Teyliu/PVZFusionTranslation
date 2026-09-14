using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008C9 RID: 2249
[Token(Token = "0x20008C9")]
public class TreasureEquipmentMenu : BaseMenu
{
	// Token: 0x06002DD7 RID: 11735 RVA: 0x000FB2C0 File Offset: 0x000F94C0
	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x7060B0", Offset = "0x7046B0", VA = "0x1807060B0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		int num = 0;
		this.InitCards(num);
		TreasureEquipmentMenu.Instance = this;
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x000FB2E4 File Offset: 0x000F94E4
	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x706C70", Offset = "0x705270", VA = "0x180706C70")]
	public void UpdateCards()
	{
		for (;;)
		{
			int num = 0;
			List<TreasureCard> list = this.localCards;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (num == 0)
			{
				int num2 = 0;
				Transform transform = this.library;
				int num3;
				if (num2 < num3)
				{
					bool activeSelf = transform.GetChild(num2).gameObject.activeSelf;
					num2++;
				}
				int num4 = 0;
				if (num2 < num4)
				{
					num2 += num2;
					num2++;
				}
				if (num2 < num2)
				{
					num2 += num2;
					num2++;
				}
				num2 += 312;
				GameObject gameObject2;
				global::UnityEngine.Object.Destroy(gameObject2);
				if (gameObject2 != 0)
				{
				}
				if (num2 == 0)
				{
					break;
				}
			}
		}
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x000FB390 File Offset: 0x000F9590
	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x706120", Offset = "0x704720", VA = "0x180706120")]
	private void InitCards(int show = 0)
	{
		GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCard");
		GameObject gameObject2 = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCardBank");
		List<TreasureCardData> list = new List(TreasureData.treasureCards);
		Func<TreasureCardData, CardLevel> <>9__8_ = TreasureEquipmentMenu.<>c.<>9__8_0;
		if (<>9__8_ == 0)
		{
			Func<TreasureCardData, CardLevel> func;
			TreasureEquipmentMenu.<>c.<>9__8_0 = func;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable = Enumerable.OrderBy<TreasureCardData, CardLevel>(list, <>9__8_);
		Func<TreasureCardData, PlantType> func2;
		if (TreasureEquipmentMenu.<>c.<>9__8_1 == 0)
		{
			TreasureEquipmentMenu.<>c.<>9__8_1 = func2;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable2 = Enumerable.ThenBy<TreasureCardData, PlantType>(orderedEnumerable, func2);
		Func<TreasureCardData, int> func3;
		if (TreasureEquipmentMenu.<>c.<>9__8_2 == 0)
		{
			TreasureEquipmentMenu.<>c.<>9__8_2 = func3;
		}
		List<TreasureCardData> list2 = Enumerable.ToList<TreasureCardData>(Enumerable.ThenBy<TreasureCardData, int>(orderedEnumerable2, func3));
		Func<TreasureCardData, bool> func4;
		if (TreasureEquipmentMenu.<>c.<>9__8_3 == 0)
		{
			func4 = (TreasureCardData c) => c.equiped;
			TreasureEquipmentMenu.<>c.<>9__8_3 = func4;
		}
		uint num;
		List<TreasureCardData> list3 = Enumerable.ToList<TreasureCardData>(Enumerable.Take<TreasureCardData>(Enumerable.Where<TreasureCardData>(list2, func4), (int)num));
		List<TreasureCardData> equipedCards = list3;
		Predicate<TreasureCardData> predicate;
		int num2 = list2.RemoveAll(predicate);
		predicate += predicate;
		int num3 = 0;
		int num7;
		if (predicate > 0)
		{
			int num4 = 0;
			GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePage);
			int num5;
			string text = string.Format("page{0}", num5);
			gameObject3.name = text;
			Transform transform = gameObject3.transform;
			Transform transform2 = this.library;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject3.transform;
			Transform transform4 = this.samplePage.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform5 = gameObject3.transform;
			Transform transform6 = gameObject3.transform;
			Transform transform7 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform6).transform;
			TreasureCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform7).GetComponent<TreasureCard>();
			Transform transform8 = component.transform;
			list2[num4].Load(component);
			component.theStatus = (TreasureCard.Status)((ulong)3L);
			List<TreasureCard> list4 = this.localCards;
			num4++;
			int num6 = 0;
			gameObject3.SetActive(num6 != 0);
			num3++;
			num4 += 24;
			num7 = 0;
		}
		TreasureCardData treasureCardData = equipedCards[num7];
		Transform child = this.equipedLibrary.transform.GetChild(num7);
		TreasureCard component2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, child).GetComponent<TreasureCard>();
		Transform transform9 = component2.transform;
		treasureCardData.Load(component2);
		component2.Init();
		component2.theStatus = (TreasureCard.Status)((ulong)3L);
		int size = this.localCards._size;
		int realCost = component2.RealCost;
		num7 += realCost;
		num7++;
		TextMeshProUGUI textMeshProUGUI = this.armament;
		int num8;
		string text2 = string.Format("当前战备值：{0}", num8);
		textMeshProUGUI.text = text2;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x000FB5F4 File Offset: 0x000F97F4
	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x707130", Offset = "0x705730", VA = "0x180707130")]
	public TreasureEquipmentMenu()
	{
		List<TreasureCard> list = new List();
		this.localCards = list;
		base..ctor();
	}

	// Token: 0x04001BC8 RID: 7112
	[Token(Token = "0x4001BC8")]
	public static TreasureEquipmentMenu Instance;

	// Token: 0x04001BC9 RID: 7113
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BC9")]
	public Transform library;

	// Token: 0x04001BCA RID: 7114
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BCA")]
	public GameObject samplePage;

	// Token: 0x04001BCB RID: 7115
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BCB")]
	public Transform equipedLibrary;

	// Token: 0x04001BCC RID: 7116
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BCC")]
	public TextMeshProUGUI armament;

	// Token: 0x04001BCD RID: 7117
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BCD")]
	private readonly List<TreasureCard> localCards;
}
