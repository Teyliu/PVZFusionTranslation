using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000875 RID: 2165
[Token(Token = "0x2000875")]
public class GardenBagMenu : BaseMenu
{
	// Token: 0x06002C1B RID: 11291 RVA: 0x000F049C File Offset: 0x000EE69C
	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0x6BF120", Offset = "0x6BD720", VA = "0x1806BF120", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		Garden instance = Garden.Instance;
		this.garden = instance;
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x000F04BC File Offset: 0x000EE6BC
	[Token(Token = "0x6002C1C")]
	[Address(RVA = "0x6BF920", Offset = "0x6BDF20", VA = "0x1806BF920")]
	private void Update()
	{
		if (!base.Interactable || Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x000F04E0 File Offset: 0x000EE6E0
	[Token(Token = "0x6002C1D")]
	[Address(RVA = "0x6BF910", Offset = "0x6BDF10", VA = "0x1806BF910")]
	private void Start()
	{
		this.SetTreasureCards();
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x000F04F4 File Offset: 0x000EE6F4
	[Token(Token = "0x6002C1E")]
	[Address(RVA = "0x6BF290", Offset = "0x6BD890", VA = "0x1806BF290")]
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

	// Token: 0x06002C1F RID: 11295 RVA: 0x000F065C File Offset: 0x000EE85C
	[Token(Token = "0x6002C1F")]
	[Address(RVA = "0x6BF180", Offset = "0x6BD780", VA = "0x1806BF180")]
	public GardenCard SetTreasureCard(TreasureCardData data, Transform parent)
	{
		GardenCard component = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Cards/Prefab/GardenCard"), parent).GetComponent<GardenCard>();
		component.data = data;
		Garden garden = this.garden;
		component.garden = garden;
		return component;
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x000F069C File Offset: 0x000EE89C
	[Token(Token = "0x6002C20")]
	[Address(RVA = "0x6BF980", Offset = "0x6BDF80", VA = "0x1806BF980")]
	public GardenBagMenu()
	{
	}

	// Token: 0x04001A08 RID: 6664
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A08")]
	public Garden garden;

	// Token: 0x04001A09 RID: 6665
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A09")]
	public GameObject sampleGrid;

	// Token: 0x04001A0A RID: 6666
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A0A")]
	public Transform pageHead;

	// Token: 0x04001A0B RID: 6667
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A0B")]
	public int cardsInPage = (int)((ulong)54L);
}
