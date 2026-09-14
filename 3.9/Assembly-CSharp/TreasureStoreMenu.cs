using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008D0 RID: 2256
[Token(Token = "0x20008D0")]
public class TreasureStoreMenu : BaseMenu
{
	// Token: 0x06002E00 RID: 11776 RVA: 0x000FBDFC File Offset: 0x000F9FFC
	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x7099D0", Offset = "0x707FD0", VA = "0x1807099D0")]
	private void Start()
	{
		this.InitCards();
	}

	// Token: 0x06002E01 RID: 11777 RVA: 0x000FBE10 File Offset: 0x000FA010
	[Token(Token = "0x6002E01")]
	[Address(RVA = "0x708FD0", Offset = "0x7075D0", VA = "0x180708FD0")]
	private void InitCards()
	{
		GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/TreasureCard");
		List<PlantType> list = new List(GameAPP.resourcesManager.allPlants);
		Func<PlantType, bool> <>9__3_ = TreasureStoreMenu.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			TreasureStoreMenu.<>c.<>9__3_0 = delegate(PlantType a)
			{
				HashSet<PlantType> collectedPlants = TreasureData.collectedPlants;
				bool flag;
				return flag;
			};
		}
		IOrderedEnumerable<PlantType> orderedEnumerable = Enumerable.OrderByDescending<PlantType, bool>(list, <>9__3_);
		Func<PlantType, int> func;
		if (TreasureStoreMenu.<>c.<>9__3_1 == 0)
		{
			TreasureStoreMenu.<>c.<>9__3_1 = func;
		}
		List<PlantType> list2 = Enumerable.ToList<PlantType>(Enumerable.ThenBy<PlantType, int>(orderedEnumerable, func));
		Predicate<PlantType> predicate;
		if (TreasureStoreMenu.<>c.<>9__3_2 == 0)
		{
			predicate = delegate(PlantType p)
			{
				bool flag2;
				return flag2;
			};
			TreasureStoreMenu.<>c.<>9__3_2 = predicate;
		}
		int num = list2.RemoveAll(predicate);
		Predicate<PlantType> predicate2;
		if (TreasureStoreMenu.<>c.<>9__3_3 == 0)
		{
			predicate2 = delegate(PlantType p)
			{
				HashSet<PlantType> redPlant = TypeMgr.RedPlant;
				bool flag3;
				return flag3;
			};
			TreasureStoreMenu.<>c.<>9__3_3 = predicate2;
		}
		int num2 = list2.RemoveAll(predicate2);
		HashSet<PlantType> hashSet = new HashSet();
		HashSet<PlantType> plantsToRemove = hashSet;
		Predicate<PlantType> predicate3 = delegate(PlantType plant)
		{
			HashSet<PlantType> plantsToRemove2 = plantsToRemove;
			bool flag4;
			return flag4;
		};
		int num3 = list2.RemoveAll(predicate3);
		int num4 = 0;
		predicate3 += predicate3;
		if (predicate3 > 0)
		{
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePage);
			int num5;
			string text = string.Format("page{0}", num5);
			gameObject2.name = text;
			Transform transform = gameObject2.transform;
			Transform transform2 = this.library;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject2.transform;
			Transform transform4 = gameObject2.transform;
			Transform transform5 = gameObject2.transform;
			TreasureCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform5).GetComponent<TreasureCard>();
			Transform transform6 = component.transform;
			uint num6;
			component.Durability = (int)num6;
			uint num7;
			component.MaxDurability = (int)num7;
			PlantType plantType = list2[num4];
			num4++;
			component.theStatus = (TreasureCard.Status)((ulong)1L);
			num4 += 44;
			num4++;
		}
		int childCount = this.library.childCount;
		if (num4 < childCount)
		{
			if (num4 != 0)
			{
				GameObject gameObject3 = this.library.transform.GetChild(num4).gameObject;
				int num8 = 0;
				gameObject3.SetActive(num8 != 0);
			}
			Transform transform7 = this.library;
			num4++;
		}
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x000FC018 File Offset: 0x000FA218
	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public TreasureStoreMenu()
	{
	}

	// Token: 0x04001BE2 RID: 7138
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BE2")]
	public Transform library;

	// Token: 0x04001BE3 RID: 7139
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BE3")]
	public GameObject samplePage;
}
