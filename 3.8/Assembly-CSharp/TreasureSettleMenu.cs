using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000892 RID: 2194
[Token(Token = "0x2000892")]
public class TreasureSettleMenu : BaseMenu
{
	// Token: 0x06002CC6 RID: 11462 RVA: 0x000F7038 File Offset: 0x000F5238
	[Token(Token = "0x6002CC6")]
	[Address(RVA = "0x68F8F0", Offset = "0x68DEF0", VA = "0x18068F8F0")]
	private void Start()
	{
		this.InitCards();
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x000F704C File Offset: 0x000F524C
	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x68F110", Offset = "0x68D710", VA = "0x18068F110")]
	private void InitCards()
	{
		GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCard");
		GameObject gameObject2 = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCardBank");
		List<TreasureCardData> cardData = TreasureManager.Instance.cardData;
		Func<TreasureCardData, CardLevel> <>9__3_ = TreasureSettleMenu.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Func<TreasureCardData, CardLevel> func;
			TreasureSettleMenu.<>c.<>9__3_0 = func;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable = Enumerable.OrderBy<TreasureCardData, CardLevel>(cardData, <>9__3_);
		Func<TreasureCardData, PlantType> func2;
		if (TreasureSettleMenu.<>c.<>9__3_1 == 0)
		{
			TreasureSettleMenu.<>c.<>9__3_1 = func2;
		}
		IOrderedEnumerable<TreasureCardData> orderedEnumerable2 = Enumerable.ThenBy<TreasureCardData, PlantType>(orderedEnumerable, func2);
		Func<TreasureCardData, int> func3;
		if (TreasureSettleMenu.<>c.<>9__3_2 == 0)
		{
			TreasureSettleMenu.<>c.<>9__3_2 = func3;
		}
		List<TreasureCardData> list = Enumerable.ToList<TreasureCardData>(Enumerable.ThenBy<TreasureCardData, int>(orderedEnumerable2, func3));
		int num = 0;
		GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePage);
		int num2;
		string text = string.Format("page{0}", num2);
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
		component.theStatus = (TreasureCard.Status)((ulong)2L);
		list[num].Load(component);
		num++;
		num++;
		num += 44;
		int childCount = this.library.childCount;
		if (num < childCount)
		{
			if (num != 0)
			{
				GameObject gameObject4 = this.library.transform.GetChild(num).gameObject;
				int num3 = 0;
				gameObject4.SetActive(num3 != 0);
			}
			Transform transform8 = this.library;
			num++;
		}
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x000F71D4 File Offset: 0x000F53D4
	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public TreasureSettleMenu()
	{
	}

	// Token: 0x04001AEE RID: 6894
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AEE")]
	public GameObject samplePage;

	// Token: 0x04001AEF RID: 6895
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AEF")]
	public Transform library;
}
