using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using ZenGarden;

// Token: 0x020008AD RID: 2221
[Token(Token = "0x20008AD")]
public class SeedLibrary : MonoBehaviour
{
	// Token: 0x06002D59 RID: 11609 RVA: 0x000F7430 File Offset: 0x000F5630
	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x6D8560", Offset = "0x6D6B60", VA = "0x1806D8560")]
	private void Awake()
	{
		SeedLibrary.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		Board board = this.board;
		Board board2 = this.board;
		this.ShowCards("NormalCards");
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x000F7474 File Offset: 0x000F5674
	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x6DC630", Offset = "0x6DAC30", VA = "0x1806DC630")]
	private void Start()
	{
		int num4;
		do
		{
			int num = 0;
			int num2 = 0;
			List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
			if (SeedLibrary.<>c.<>9__30_0 == 0)
			{
				Action<CardUI> action;
				SeedLibrary.<>c.<>9__30_0 = action;
			}
			Board board = this.board;
			this.SetTreasureCards();
			this.ShowCards("TreasureCards");
			Board board2 = this.board;
			GameObject gameObject;
			if (InGameUI.Instance.showCardLayout.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
			}
			if (gameObject != 0)
			{
			}
			if (num != 0)
			{
				goto IL_0118;
			}
			num4 = 0;
			List<PlantType> list = new List();
			GardenUnifiedData data = GardenUI.Data;
			int num5 = 0;
			List<GardenPlantData> plants = data.GetPlants(num5);
			bool flag;
			if (flag)
			{
				int size = list._size;
				list._size = num2;
			}
		}
		while (num4 != 0);
		if (SeedLibrary.<>c.<>9__13_0 == 0)
		{
			Action<CardUI> action2;
			SeedLibrary.<>c.<>9__13_0 = action2;
		}
		if (GameAPP.config.easyTravel)
		{
		}
		GameAPP instance = GameAPP.Instance;
		List<ZombieType> allZombieTypes = GameAPP.resourcesManager.allZombieTypes;
		return;
		IL_0118:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x000F75B4 File Offset: 0x000F57B4
	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x6DB140", Offset = "0x6D9740", VA = "0x1806DB140")]
	private UniTask SetNormalCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x000F75D0 File Offset: 0x000F57D0
	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x6DAEC0", Offset = "0x6D94C0", VA = "0x1806DAEC0")]
	private UniTask SetColorfulCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x000F75EC File Offset: 0x000F57EC
	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x6DAE00", Offset = "0x6D9400", VA = "0x1806DAE00")]
	private UniTask SetAllCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002D5E RID: 11614 RVA: 0x000F7608 File Offset: 0x000F5808
	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x6D87D0", Offset = "0x6D6DD0", VA = "0x1806D87D0")]
	public void ChangeSafeMode()
	{
		ulong num2;
		do
		{
			bool flag = this.safeMode;
			bool flag2 = !flag;
			this.safeMode = flag2;
			if (!flag)
			{
				List<TextMeshProUGUI> list = this.safeText;
				bool flag3;
				if (flag3)
				{
				}
				ulong num;
				if (num != (ulong)0L)
				{
					goto IL_004A;
				}
			}
			List<TextMeshProUGUI> list2 = this.safeText;
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num2 != (ulong)0L);
		return;
		IL_004A:
		throw new NullReferenceException();
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x000F7668 File Offset: 0x000F5868
	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x6D9F90", Offset = "0x6D8590", VA = "0x1806D9F90")]
	public void OnStartGame()
	{
		ulong num3;
		do
		{
			Board board = this.board;
			this.safeBox.SetActive(true);
			IEnumerator enumerator = this.cardPagesContainer.GetEnumerator();
			if (enumerator != 0)
			{
				string text;
				if (!string.Equals(text, "TreasureCards"))
				{
					continue;
				}
				int i = 0;
				int num;
				while (i >= num)
				{
				}
				int num2 = 0;
				Transform transform;
				int childCount = transform.childCount;
				Transform transform2;
				if (num2 < childCount)
				{
					Transform child = transform.transform.GetChild(num2);
					if (child.transform.childCount != 1)
					{
						global::UnityEngine.Object.Destroy(child.gameObject);
						num2++;
					}
					Transform transform3;
					transform2.parentInternal = transform3;
					num2++;
				}
				GameObject gameObject = transform2.gameObject;
				if (i == 0)
				{
					gameObject.SetActive(true);
					i++;
				}
				global::UnityEngine.Object.Destroy(gameObject);
				i++;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002D60 RID: 11616 RVA: 0x000F777C File Offset: 0x000F597C
	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x6DC0A0", Offset = "0x6DA6A0", VA = "0x1806DC0A0")]
	public void ShowCards(string name)
	{
		int num;
		int num2;
		do
		{
			num = 0;
			num2 = 0;
			IEnumerator enumerator = this.cardPagesContainer.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				if (text != 0)
				{
					bool flag;
					if (!flag)
					{
						Page page;
						this.page = page;
					}
					this.lastPage.clickEvent.RemoveAllListeners();
					UnityEvent clickEvent = this.lastPage.clickEvent;
					UnityAction unityAction = new UnityAction(this.page.LastPage);
					clickEvent.AddListener(unityAction);
					this.nextPage.clickEvent.RemoveAllListeners();
					UnityEvent clickEvent2 = this.nextPage.clickEvent;
					UnityAction unityAction2 = new UnityAction(this.page.NextPage);
					clickEvent2.AddListener(unityAction2);
				}
				string text2;
				bool flag2 = string.Equals(text2, name);
				GameObject gameObject;
				gameObject.SetActive(flag2);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		if (num2 == 0)
		{
			Transform transform;
			GameObject gameObject2 = transform.gameObject;
			ulong num3;
			gameObject2.SetActive(num3 != 0UL);
			bool flag3;
			if (!flag3)
			{
				Page page2 = gameObject2.AddComponent<Page>();
			}
			object target = new UnityAction(gameObject2.LastPage).m_target;
			UnityAction unityAction3 = new UnityAction(gameObject2.NextPage);
		}
	}

	// Token: 0x06002D61 RID: 11617 RVA: 0x000F78F8 File Offset: 0x000F5AF8
	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x6D94C0", Offset = "0x6D7AC0", VA = "0x1806D94C0")]
	public void DeleteCards(string name)
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = this.cardPagesContainer.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		bool flag;
		if (flag)
		{
			GameObject gameObject2;
			global::UnityEngine.Object.Destroy(gameObject2);
		}
	}

	// Token: 0x06002D62 RID: 11618 RVA: 0x000F796C File Offset: 0x000F5B6C
	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x6D97D0", Offset = "0x6D7DD0", VA = "0x1806D97D0")]
	public void HideCards(string name)
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = this.cardPagesContainer.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				int num2 = 0;
				GameObject gameObject;
				gameObject.SetActive(num2 != 0);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002D63 RID: 11619 RVA: 0x000F79D8 File Offset: 0x000F5BD8
	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x6D89F0", Offset = "0x6D6FF0", VA = "0x1806D89F0")]
	private Transform CreateCardContainer(string name)
	{
		GameObject gameObject = new GameObject(name);
		Transform transform = gameObject.transform;
		RectTransform rectTransform = this.cardPagesContainer;
		transform.parentInternal = rectTransform;
		Transform transform2 = gameObject.transform;
		Transform transform3 = gameObject.transform;
		return gameObject.transform;
	}

	// Token: 0x06002D64 RID: 11620 RVA: 0x000F7A20 File Offset: 0x000F5C20
	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x6D8B50", Offset = "0x6D7150", VA = "0x1806D8B50")]
	private Transform CreateCardPage(Transform container)
	{
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(this.sampleGrid, container).transform;
		Transform transform2 = transform.transform;
		RectTransform rectTransform = this.cardPagesContainer;
		int num = 0;
		Transform child = rectTransform.GetChild(num);
		int num2 = 0;
		Transform child2 = child.GetChild(num2);
		Vector3 vector;
		float z = vector.z;
		return transform;
	}

	// Token: 0x06002D65 RID: 11621 RVA: 0x000F7A78 File Offset: 0x000F5C78
	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x6D9C80", Offset = "0x6D8280", VA = "0x1806D9C80")]
	public Transform LateCreateCardPage(string name)
	{
		RectTransform rectTransform = this.cardPagesContainer;
		int num = 0;
		int childCount = rectTransform.childCount;
		if (num < childCount)
		{
			Transform child = this.cardPagesContainer.GetChild(num);
			if (!string.Equals(child.gameObject.name, name))
			{
				RectTransform rectTransform2 = this.cardPagesContainer;
				num++;
			}
			int num2 = child.childCount - 1;
			int childCount2 = child.GetChild(num2).childCount;
			Transform transform = this.CreateCardPage(child);
			GameObject gameObject = transform.gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			return transform;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002D66 RID: 11622 RVA: 0x000F7B08 File Offset: 0x000F5D08
	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x6D8C60", Offset = "0x6D7260", VA = "0x1806D8C60")]
	private CardUI CreateCard(PlantType thePlantType, Transform parent)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Cards/Prefab/LibraryCard"), parent);
		global::UnityEngine.Object.Destroy(gameObject.GetComponent<Card>());
		Type typeFromHandle = typeof(CardUI);
		Component componentInChildren = gameObject.GetComponentInChildren(typeFromHandle);
		throw new NullReferenceException();
	}

	// Token: 0x06002D67 RID: 11623 RVA: 0x000F7B54 File Offset: 0x000F5D54
	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x6D9370", Offset = "0x6D7970", VA = "0x1806D9370")]
	public UniTask CreateNewTypeofCards(string cardsTypeName, List<PlantType> plants, Action<CardUI> cardAction, bool createButton, string buttonName, bool isAsync = false, bool show = false)
	{
		return default(UniTask);
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x000F7B6C File Offset: 0x000F5D6C
	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x6D8DF0", Offset = "0x6D73F0", VA = "0x1806D8DF0")]
	private void CreateNewTypeofCards(string cardsTypeName, List<ZombieType> zombies, bool createButton, string buttonName)
	{
		Transform transform;
		int num2;
		do
		{
			int num = 0;
			string cardsTypeName2 = cardsTypeName;
			transform = this.CreateCardContainer(cardsTypeName2);
			Transform transform2 = transform.transform;
			Transform transform3 = this.CreateCardPage(transform2);
			num2 = 0;
			bool flag;
			if (flag)
			{
				ZombieCardPackage zombieCardPackage = global::Lawnf.SetZombieCardPackage((ZombieType)num);
				Transform transform4 = zombieCardPackage.transform;
				Transform transform5 = transform3.transform;
				transform4.parentInternal = transform5;
				Transform transform6 = zombieCardPackage.transform;
				IZECard card = zombieCardPackage.card;
				int cost = ZombieDataManager.zombieDataDic[num].cost;
				card.theSeedCost = cost;
				num2++;
				while (num2 != 54)
				{
				}
				Transform transform7 = transform.transform;
				Transform transform8;
				GameObject gameObject = transform8.gameObject;
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
			}
		}
		while (num2 != 0);
		int num4 = 0;
		GameObject gameObject2 = transform.gameObject;
		int num5 = 0;
		gameObject2.SetActive(num5 != 0);
		InGameUI instance = InGameUI.Instance;
		string cardsTypeName3 = CS$<>8__locals1.cardsTypeName;
		UIButton buttonPrefab = instance.buttonPrefab;
		Transform transform9 = instance.showCardLayout.transform;
		UIButton component = global::UnityEngine.Object.Instantiate<UIButton>(buttonPrefab, transform9).GetComponent<UIButton>();
		component.name = cardsTypeName3;
		TextMeshProUGUI[] componentsInChildren = component.GetComponentsInChildren<TextMeshProUGUI>();
		if (num4 < componentsInChildren.Length)
		{
			num4++;
		}
		component.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent = component.clickEvent;
		UnityAction unityAction = delegate
		{
			SeedLibrary <>4__this = CS$<>8__locals1.<>4__this;
			string cardsTypeName4 = CS$<>8__locals1.cardsTypeName;
			<>4__this.ShowCards(cardsTypeName4);
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x000F7D18 File Offset: 0x000F5F18
	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x6DB200", Offset = "0x6D9800", VA = "0x1806DB200")]
	public CardUI SetTreasureCard(TreasureCardData data, Transform page)
	{
		PlantType thePlantType = data.thePlantType;
		int num = 0;
		int num6;
		if (!(page != num))
		{
			RectTransform rectTransform = this.cardPagesContainer;
			int num2 = 0;
			int num3 = 0;
			int childCount = rectTransform.childCount;
			if (num3 < childCount)
			{
				Transform child = this.cardPagesContainer.GetChild(num2);
				if (child.gameObject.name == 0)
				{
					RectTransform rectTransform2 = this.cardPagesContainer;
					num2++;
				}
				int num4 = child.childCount - 1;
				int childCount2 = child.GetChild(num4).childCount;
				GameObject gameObject = this.CreateCardPage(child).gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
			}
			num6 = 0;
		}
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Cards/Prefab/LibraryCard"), num6);
		global::UnityEngine.Object.Destroy(gameObject2.GetComponent<Card>());
		Type typeFromHandle = typeof(CardUI);
		Component componentInChildren = gameObject2.GetComponentInChildren(typeFromHandle);
		int durability = data.durability;
		int maxDurability = data.maxDurability;
		PlantDataManager.PlantData plantData;
		float cd = plantData.cd;
		float cd2 = plantData.cd;
		int cost = plantData.cost;
		CardLevel cardLevel;
		if (cardLevel <= CardLevel.Red)
		{
		}
		if (!global::Lawnf.IsUltiPlant(data.thePlantType) && data.equiped)
		{
			CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
			bool flag;
			if (!flag)
			{
				InGameText instance = InGameText.Instance;
			}
		}
		global::UnityEngine.Object.Destroy(componentInChildren);
		uint num7;
		ulong num8;
		componentInChildren.transform.GetChild((int)num7).gameObject.SetActive(num8 != 0UL);
		throw new InvalidCastException();
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x000F7E78 File Offset: 0x000F6078
	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x6DB780", Offset = "0x6D9D80", VA = "0x1806DB780")]
	private void SetTreasureCards()
	{
		Transform transform;
		int num2;
		do
		{
			int num = 0;
			List<TreasureCardData> list = new List(TreasureData.treasureCards);
			Func<TreasureCardData, CardLevel> <>9__29_ = SeedLibrary.<>c.<>9__29_0;
			if (<>9__29_ == 0)
			{
				Func<TreasureCardData, CardLevel> func;
				SeedLibrary.<>c.<>9__29_0 = func;
			}
			IOrderedEnumerable<TreasureCardData> orderedEnumerable = Enumerable.OrderBy<TreasureCardData, CardLevel>(list, <>9__29_);
			Func<TreasureCardData, PlantType> func2;
			if (SeedLibrary.<>c.<>9__29_1 == 0)
			{
				SeedLibrary.<>c.<>9__29_1 = func2;
			}
			IOrderedEnumerable<TreasureCardData> orderedEnumerable2 = Enumerable.ThenBy<TreasureCardData, PlantType>(orderedEnumerable, func2);
			Func<TreasureCardData, int> func3;
			if (SeedLibrary.<>c.<>9__29_2 == 0)
			{
				SeedLibrary.<>c.<>9__29_2 = func3;
			}
			List<TreasureCardData> list2 = Enumerable.ToList<TreasureCardData>(Enumerable.ThenBy<TreasureCardData, int>(orderedEnumerable2, func3));
			transform = this.CreateCardContainer("TreasureCards");
			Transform transform2 = transform.transform;
			Transform transform3 = this.CreateCardPage(transform2);
			num2 = 0;
			bool flag;
			if (flag)
			{
				CardUI cardUI = this.SetTreasureCard(num, transform3);
				num2++;
				while (num2 != 54)
				{
				}
				Transform transform4 = transform.transform;
				GameObject gameObject = this.CreateCardPage(transform4).gameObject;
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
			}
		}
		while (num2 != 0);
		GameObject gameObject2 = transform.gameObject;
		int num4 = 0;
		gameObject2.SetActive(num4 != 0);
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x000F7F7C File Offset: 0x000F617C
	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x6DAF80", Offset = "0x6D9580", VA = "0x1806DAF80")]
	private void SetEvolutitonCards()
	{
		List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
		if (SeedLibrary.<>c.<>9__30_0 == 0)
		{
			Action<CardUI> action;
			SeedLibrary.<>c.<>9__30_0 = action;
		}
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x000F7FAC File Offset: 0x000F61AC
	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x6DBC90", Offset = "0x6DA290", VA = "0x1806DBC90")]
	public void SetUltimateCards()
	{
		List<PlantType> list;
		ulong num;
		do
		{
			list = new List();
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				int size = list._size;
				list._size = (flag ? 1 : 0);
				while (!flag)
				{
				}
			}
		}
		while (num != (ulong)0L);
		bool flag2 = list.Remove((uint)5001);
		InGameText.Instance.TimeOver();
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x000F801C File Offset: 0x000F621C
	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x6D9DB0", Offset = "0x6D83B0", VA = "0x1806D9DB0")]
	private void OnCreateUltimateCard(CardUI card)
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType thePlantType = card.thePlantType;
		if (instance.LimTravel(thePlantType))
		{
			card.transform.GetChild(3).gameObject.SetActive(true);
			global::UnityEngine.Object.Destroy(card);
			return;
		}
		int thePlantType2 = (int)card.thePlantType;
		PlantDataManager.PlantData plantData;
		float cd = plantData.cd;
		PlantType thePlantType3 = card.thePlantType;
		card.fullCD = cd;
		int cost = plantData.cost;
		card.theSeedCost = cost;
		card.mixAnim = true;
		int num = (int)thePlantType3;
		bool flag;
		if (flag)
		{
			card.theSeedCost = num;
			float num2 = card.fullCD * 3f;
			card.fullCD = num2;
		}
		float fullCD = card.fullCD;
		card.CD = fullCD;
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x000F80D4 File Offset: 0x000F62D4
	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x6D9A10", Offset = "0x6D8010", VA = "0x1806D9A10")]
	private void InitCardGroup()
	{
		ulong num3;
		do
		{
			int num = 0;
			RectTransform selectCardGroupLayout = InGameUI.Instance.selectCardGroupLayout;
			int num2 = 0;
			UnityEvent clickEvent = selectCardGroupLayout.GetChild(num2).GetComponent<UIButton>().clickEvent;
			UnityAction unityAction = new UnityAction(this.SaveCardGroup);
			clickEvent.AddListener(unityAction);
			List<SavedCardGroup> savedCardGroups = GameAPP.config.savedCardGroups;
			bool flag;
			if (flag)
			{
				string text2;
				string text = "group" + text2;
				this.RegisterGroupButton(text, num);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x000F8150 File Offset: 0x000F6350
	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x6DA300", Offset = "0x6D8900", VA = "0x1806DA300")]
	private void RegisterGroupButton(string name, SavedCardGroup group)
	{
		SavedCardGroup group2 = group;
		InGameUI instance = InGameUI.Instance;
		RectTransform selectCardGroupLayout = instance.selectCardGroupLayout;
		UIButton buttonPrefab = instance.buttonPrefab;
		Transform transform = selectCardGroupLayout.transform;
		UIButton uibutton = global::UnityEngine.Object.Instantiate<UIButton>(buttonPrefab, transform);
		uibutton.name = name;
		TextMeshProUGUI[] componentsInChildren = uibutton.GetComponentsInChildren<TextMeshProUGUI>();
		int num = 0;
		if (num < componentsInChildren.Length)
		{
			num++;
		}
		uibutton.clickEvent.RemoveAllListeners();
		UIButton button = uibutton;
		Dictionary<UIButton, SavedCardGroup> dictionary = this.savedGroupPairs;
		SavedCardGroup group3 = group;
		UIButton button3 = button;
		dictionary[button3] = group3;
		List<SavedCard> savedCards = group.savedCards;
		Predicate<SavedCard> predicate;
		if (SeedLibrary.<>c.<>9__35_0 == 0)
		{
			SeedLibrary.<>c.<>9__35_0 = predicate;
		}
		int num2 = savedCards.RemoveAll(predicate);
		uint num3;
		UIButton component = button.transform.GetChild((int)num3).GetComponent<UIButton>();
		UnityEvent clickEvent = component.clickEvent;
		UnityAction unityAction = delegate
		{
			SeedLibrary <>4__this = this;
			UIButton button2 = button;
			<>4__this.RemoveCardGroup(button2);
		};
		clickEvent.AddListener(unityAction);
		ulong num4;
		component.gameObject.SetActive(num4 != 0UL);
		UnityEvent clickEvent2 = button.clickEvent;
		UnityAction unityAction2 = delegate
		{
			ulong num9;
			do
			{
				int num5 = 0;
				List<CardUI> cards = InGameUI.Instance.Cards;
				Func<CardUI, bool> <>9__35_ = SeedLibrary.<>c.<>9__35_3;
				if (<>9__35_ == 0)
				{
					SeedLibrary.<>c.<>9__35_3 = (CardUI c) => c.preSelected;
				}
				if (Enumerable.FirstOrDefault<CardUI>(cards, <>9__35_))
				{
					break;
				}
				bool flag;
				if (flag)
				{
					ulong num6;
					bool flag2 = InGameUI.Instance.RemoveCardFromBank(num5, num6 != 0UL);
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_0117;
				}
				Transform transform2;
				List<CardUI> childs = global::Core.Lawnf.GetChilds<CardUI>(transform2);
				bool flag3;
				if (flag3)
				{
					int i = childs._size;
					while (i <= 0)
					{
					}
					CardUI cardUI = childs[i];
					CardUI cardUI2 = childs[i];
					InGameUI instance2 = InGameUI.Instance;
					CardUI cardUI3 = childs[i];
					int num8 = 0;
					if (!instance2.AddCardToBank(cardUI3, num8 != 0))
					{
						continue;
					}
					PlantType thePlantType = childs[i].thePlantType;
					string text;
					Debug.Log("添加：" + text);
					childs.RemoveAt(i);
				}
			}
			while (num9 != (ulong)0L);
			InGameText instance3 = InGameText.Instance;
			uint num10;
			GameAPP.PlaySound((int)num10, 0.5f, 1f);
			return;
			IL_0117:
			throw new NullReferenceException();
		};
		clickEvent2.AddListener(unityAction2);
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x000F8298 File Offset: 0x000F6498
	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x6DA750", Offset = "0x6D8D50", VA = "0x1806DA750")]
	public void RemoveCardGroup(UIButton groupButton)
	{
		Dictionary<UIButton, SavedCardGroup> dictionary = this.savedGroupPairs;
		bool flag;
		if (flag)
		{
			List<SavedCardGroup> savedCardGroups = GameAPP.config.savedCardGroups;
			SaveInfo.Instance.SavePlayerData();
		}
		global::UnityEngine.Object.Destroy(groupButton.gameObject);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002D71 RID: 11633 RVA: 0x000F82E0 File Offset: 0x000F64E0
	[Token(Token = "0x6002D71")]
	[Address(RVA = "0x6DA890", Offset = "0x6D8E90", VA = "0x1806DA890")]
	public void SaveCardGroup()
	{
		SavedCardGroup savedCardGroup;
		ulong num;
		do
		{
			List<SavedCardGroup> savedCardGroups = GameAPP.config.savedCardGroups;
			savedCardGroup = new SavedCardGroup();
			List<CardUI> list = new List(InGameUI.Instance._cardSlotManager.Cards);
			bool flag;
			if (flag)
			{
				List<SavedCard> savedCards = savedCardGroup.savedCards;
				SavedCard savedCard = new SavedCard();
				savedCard.extra = savedCard != null;
				savedCard.plantType = savedCard;
				int size = savedCards._size;
				savedCards._size = savedCard;
			}
		}
		while (num != (ulong)0L);
		int size2 = GameAPP.config.savedCardGroups._size;
		string playerName = GameAPP.playerName;
		SaveInfo.Instance.SavePlayerData();
		InGameText instance = InGameText.Instance;
		int size3 = savedCardGroup.savedCards._size;
		string text = string.Format("成功保存{0}张卡牌至自定义卡组中", instance);
	}

	// Token: 0x06002D72 RID: 11634 RVA: 0x000F83E4 File Offset: 0x000F65E4
	[Token(Token = "0x6002D72")]
	[Address(RVA = "0x6DD8E0", Offset = "0x6DBEE0", VA = "0x1806DD8E0")]
	public SeedLibrary()
	{
		List<TextMeshProUGUI> list = new List();
		this.safeText = list;
		Dictionary<string, UIButton> dictionary = new Dictionary();
		this.buttons = dictionary;
		Dictionary<UIButton, SavedCardGroup> dictionary2 = new Dictionary();
		this.savedGroupPairs = dictionary2;
		base..ctor();
	}

	// Token: 0x04001B2E RID: 6958
	[Token(Token = "0x4001B2E")]
	private const int pageSize = 54;

	// Token: 0x04001B2F RID: 6959
	[Token(Token = "0x4001B2F")]
	public static SeedLibrary Instance;

	// Token: 0x04001B30 RID: 6960
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B30")]
	public Board board;

	// Token: 0x04001B31 RID: 6961
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B31")]
	[Header("卡牌设置")]
	public RectTransform cardPagesContainer;

	// Token: 0x04001B32 RID: 6962
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B32")]
	public GameObject sampleGrid;

	// Token: 0x04001B33 RID: 6963
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B33")]
	[Header("翻页设置")]
	public UIButton lastPage;

	// Token: 0x04001B34 RID: 6964
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B34")]
	public UIButton nextPage;

	// Token: 0x04001B35 RID: 6965
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B35")]
	public Page page;

	// Token: 0x04001B36 RID: 6966
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B36")]
	[Header("安全箱设置")]
	public GameObject safeBox;

	// Token: 0x04001B37 RID: 6967
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B37")]
	public bool safeMode;

	// Token: 0x04001B38 RID: 6968
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B38")]
	public List<TextMeshProUGUI> safeText;

	// Token: 0x04001B39 RID: 6969
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B39")]
	private readonly Dictionary<string, UIButton> buttons;

	// Token: 0x04001B3A RID: 6970
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001B3A")]
	private readonly Dictionary<UIButton, SavedCardGroup> savedGroupPairs;
}
