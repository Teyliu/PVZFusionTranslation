using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000839 RID: 2105
[Token(Token = "0x2000839")]
public class GardenBagMenu : BaseMenu
{
	// Token: 0x06002AE9 RID: 10985 RVA: 0x000EB75C File Offset: 0x000E995C
	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x65B2C0", Offset = "0x6598C0", VA = "0x18065B2C0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		Garden instance = Garden.Instance;
		this.garden = instance;
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x000EB77C File Offset: 0x000E997C
	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x65BAC0", Offset = "0x65A0C0", VA = "0x18065BAC0")]
	private void Update()
	{
		if (!base.Interactable || Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x000EB7A0 File Offset: 0x000E99A0
	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x65BAB0", Offset = "0x65A0B0", VA = "0x18065BAB0")]
	private void Start()
	{
		this.SetTreasureCards();
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x000EB7B4 File Offset: 0x000E99B4
	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x65B430", Offset = "0x659A30", VA = "0x18065B430")]
	private void SetTreasureCards()
	{
		List<TreasureCardData> list = new List(TreasureData.treasureCards);
		Predicate<TreasureCardData> <>9__7_ = GardenBagMenu.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			Predicate<TreasureCardData> predicate;
			GardenBagMenu.<>c.<>9__7_0 = predicate;
		}
		int num = list.RemoveAll(<>9__7_);
		Func<TreasureCardData, CardLevel> func;
		if (GardenBagMenu.<>c.<>9__7_1 == 0)
		{
			GardenBagMenu.<>c.<>9__7_1 = func;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable = Enumerable.OrderBy<TreasureCardData, CardLevel>(list, func);
		Func<TreasureCardData, PlantType> func2;
		if (GardenBagMenu.<>c.<>9__7_2 == 0)
		{
			GardenBagMenu.<>c.<>9__7_2 = func2;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable2 = Enumerable.ThenBy<TreasureCardData, PlantType>(orderedEnumerable, func2);
		Func<TreasureCardData, int> func3;
		if (GardenBagMenu.<>c.<>9__7_3 == 0)
		{
			GardenBagMenu.<>c.<>9__7_3 = func3;
		}
		List<TreasureCardData> list2 = Enumerable.ToList<TreasureCardData>(Enumerable.ThenBy<TreasureCardData, int>(orderedEnumerable2, func3));
		int size = list2._size;
		int num2 = 0;
		if (size + 1 > 0)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.sampleGrid);
			int num3;
			string text = string.Format("page{0}", num3);
			gameObject.name = text;
			Transform transform = gameObject.transform;
			Transform transform2 = this.pageHead;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject.transform;
			Transform transform4 = this.sampleGrid.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform5 = gameObject.transform;
			int num4 = 0;
			if (this.cardsInPage > num4)
			{
				int num5 = this.cardsInPage * num2;
				num5 += num4;
				TreasureCardData treasureCardData = list2[0];
				Transform transform6 = gameObject.transform;
				GardenCard gardenCard = this.SetTreasureCard(treasureCardData, transform6);
				int num6 = this.cardsInPage;
				num4++;
			}
			if (num2 != 0)
			{
				int num7 = 0;
				gameObject.SetActive(num7 != 0);
			}
			num2++;
		}
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x000EB91C File Offset: 0x000E9B1C
	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x65B320", Offset = "0x659920", VA = "0x18065B320")]
	public GardenCard SetTreasureCard(TreasureCardData data, Transform parent)
	{
		GardenCard component = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Cards/Prefab/GardenCard"), parent).GetComponent<GardenCard>();
		component.data = data;
		Garden garden = this.garden;
		component.garden = garden;
		return component;
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x000EB95C File Offset: 0x000E9B5C
	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x65BB20", Offset = "0x65A120", VA = "0x18065BB20")]
	public GardenBagMenu()
	{
	}

	// Token: 0x0400191A RID: 6426
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400191A")]
	public Garden garden;

	// Token: 0x0400191B RID: 6427
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400191B")]
	public GameObject sampleGrid;

	// Token: 0x0400191C RID: 6428
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400191C")]
	public Transform pageHead;

	// Token: 0x0400191D RID: 6429
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400191D")]
	public int cardsInPage = (int)((ulong)54L);
}
