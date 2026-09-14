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

// Token: 0x02000871 RID: 2161
[Token(Token = "0x2000871")]
public class SeedLibrary : MonoBehaviour
{
	// Token: 0x06002C27 RID: 11303 RVA: 0x000F2818 File Offset: 0x000F0A18
	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x673910", Offset = "0x671F10", VA = "0x180673910")]
	private void Awake()
	{
		SeedLibrary.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		Board board = this.board;
		Board board2 = this.board;
		this.ShowCards("NormalCards");
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x000F285C File Offset: 0x000F0A5C
	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x6779C0", Offset = "0x675FC0", VA = "0x1806779C0")]
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

	// Token: 0x06002C29 RID: 11305 RVA: 0x000F299C File Offset: 0x000F0B9C
	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x6764D0", Offset = "0x674AD0", VA = "0x1806764D0")]
	private UniTask SetNormalCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x000F29B8 File Offset: 0x000F0BB8
	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x676250", Offset = "0x674850", VA = "0x180676250")]
	private UniTask SetColorfulCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x000F29D4 File Offset: 0x000F0BD4
	[Token(Token = "0x6002C2B")]
	[Address(RVA = "0x676190", Offset = "0x674790", VA = "0x180676190")]
	private UniTask SetAllCards()
	{
		return default(UniTask);
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x000F29F0 File Offset: 0x000F0BF0
	[Token(Token = "0x6002C2C")]
	[Address(RVA = "0x673B80", Offset = "0x672180", VA = "0x180673B80")]
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

	// Token: 0x06002C2D RID: 11309 RVA: 0x000F2A50 File Offset: 0x000F0C50
	[Token(Token = "0x6002C2D")]
	[Address(RVA = "0x675340", Offset = "0x673940", VA = "0x180675340")]
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

	// Token: 0x06002C2E RID: 11310 RVA: 0x000F2B64 File Offset: 0x000F0D64
	[Token(Token = "0x6002C2E")]
	[Address(RVA = "0x677430", Offset = "0x675A30", VA = "0x180677430")]
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

	// Token: 0x06002C2F RID: 11311 RVA: 0x000F2CE0 File Offset: 0x000F0EE0
	[Token(Token = "0x6002C2F")]
	[Address(RVA = "0x674870", Offset = "0x672E70", VA = "0x180674870")]
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

	// Token: 0x06002C30 RID: 11312 RVA: 0x000F2D54 File Offset: 0x000F0F54
	[Token(Token = "0x6002C30")]
	[Address(RVA = "0x674B80", Offset = "0x673180", VA = "0x180674B80")]
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

	// Token: 0x06002C31 RID: 11313 RVA: 0x000F2DC0 File Offset: 0x000F0FC0
	[Token(Token = "0x6002C31")]
	[Address(RVA = "0x673DA0", Offset = "0x6723A0", VA = "0x180673DA0")]
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

	// Token: 0x06002C32 RID: 11314 RVA: 0x000F2E08 File Offset: 0x000F1008
	[Token(Token = "0x6002C32")]
	[Address(RVA = "0x673F00", Offset = "0x672500", VA = "0x180673F00")]
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

	// Token: 0x06002C33 RID: 11315 RVA: 0x000F2E60 File Offset: 0x000F1060
	[Token(Token = "0x6002C33")]
	[Address(RVA = "0x675030", Offset = "0x673630", VA = "0x180675030")]
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

	// Token: 0x06002C34 RID: 11316 RVA: 0x000F2EF0 File Offset: 0x000F10F0
	[Token(Token = "0x6002C34")]
	[Address(RVA = "0x674010", Offset = "0x672610", VA = "0x180674010")]
	private CardUI CreateCard(PlantType thePlantType, Transform parent)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Cards/Prefab/LibraryCard"), parent);
		global::UnityEngine.Object.Destroy(gameObject.GetComponent<Card>());
		Type typeFromHandle = typeof(CardUI);
		Component componentInChildren = gameObject.GetComponentInChildren(typeFromHandle);
		throw new NullReferenceException();
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x000F2F3C File Offset: 0x000F113C
	[Token(Token = "0x6002C35")]
	[Address(RVA = "0x674720", Offset = "0x672D20", VA = "0x180674720")]
	public UniTask CreateNewTypeofCards(string cardsTypeName, List<PlantType> plants, Action<CardUI> cardAction, bool createButton, string buttonName, bool isAsync = false, bool show = false)
	{
		return default(UniTask);
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x000F2F54 File Offset: 0x000F1154
	[Token(Token = "0x6002C36")]
	[Address(RVA = "0x6741A0", Offset = "0x6727A0", VA = "0x1806741A0")]
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

	// Token: 0x06002C37 RID: 11319 RVA: 0x000F3100 File Offset: 0x000F1300
	[Token(Token = "0x6002C37")]
	[Address(RVA = "0x676590", Offset = "0x674B90", VA = "0x180676590")]
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
				int num7 = 0;
				instance.ShowText("已达关卡卡牌数量上限", 3f, num7 != 0);
			}
		}
		global::UnityEngine.Object.Destroy(componentInChildren);
		uint num8;
		ulong num9;
		componentInChildren.transform.GetChild((int)num8).gameObject.SetActive(num9 != 0UL);
		throw new InvalidCastException();
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x000F3278 File Offset: 0x000F1478
	[Token(Token = "0x6002C38")]
	[Address(RVA = "0x676B10", Offset = "0x675110", VA = "0x180676B10")]
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

	// Token: 0x06002C39 RID: 11321 RVA: 0x000F337C File Offset: 0x000F157C
	[Token(Token = "0x6002C39")]
	[Address(RVA = "0x676310", Offset = "0x674910", VA = "0x180676310")]
	private void SetEvolutitonCards()
	{
		List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
		if (SeedLibrary.<>c.<>9__30_0 == 0)
		{
			Action<CardUI> action;
			SeedLibrary.<>c.<>9__30_0 = action;
		}
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x000F33AC File Offset: 0x000F15AC
	[Token(Token = "0x6002C3A")]
	[Address(RVA = "0x677020", Offset = "0x675620", VA = "0x180677020")]
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

	// Token: 0x06002C3B RID: 11323 RVA: 0x000F341C File Offset: 0x000F161C
	[Token(Token = "0x6002C3B")]
	[Address(RVA = "0x675160", Offset = "0x673760", VA = "0x180675160")]
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

	// Token: 0x06002C3C RID: 11324 RVA: 0x000F34D4 File Offset: 0x000F16D4
	[Token(Token = "0x6002C3C")]
	[Address(RVA = "0x674DC0", Offset = "0x6733C0", VA = "0x180674DC0")]
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

	// Token: 0x06002C3D RID: 11325 RVA: 0x000F3550 File Offset: 0x000F1750
	[Token(Token = "0x6002C3D")]
	[Address(RVA = "0x6756B0", Offset = "0x673CB0", VA = "0x1806756B0")]
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
					Func<CardUI, bool> func;
					SeedLibrary.<>c.<>9__35_3 = func;
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
					goto IL_011F;
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
			int num10 = 0;
			instance3.ShowText("卡槽上有被固定的卡牌，无法使用自定义卡组", 5f, num10 != 0);
			uint num11;
			GameAPP.PlaySound((int)num11, 0.5f, 1f);
			return;
			IL_011F:
			throw new NullReferenceException();
		};
		clickEvent2.AddListener(unityAction2);
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x000F3698 File Offset: 0x000F1898
	[Token(Token = "0x6002C3E")]
	[Address(RVA = "0x675B00", Offset = "0x674100", VA = "0x180675B00")]
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

	// Token: 0x06002C3F RID: 11327 RVA: 0x000F36E0 File Offset: 0x000F18E0
	[Token(Token = "0x6002C3F")]
	[Address(RVA = "0x675C40", Offset = "0x674240", VA = "0x180675C40")]
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
		int num2 = 0;
		instance.ShowText(text, 5f, num2 != 0);
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x000F37F8 File Offset: 0x000F19F8
	[Token(Token = "0x6002C40")]
	[Address(RVA = "0x678BD0", Offset = "0x6771D0", VA = "0x180678BD0")]
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

	// Token: 0x04001A40 RID: 6720
	[Token(Token = "0x4001A40")]
	private const int pageSize = 54;

	// Token: 0x04001A41 RID: 6721
	[Token(Token = "0x4001A41")]
	public static SeedLibrary Instance;

	// Token: 0x04001A42 RID: 6722
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A42")]
	public Board board;

	// Token: 0x04001A43 RID: 6723
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A43")]
	[Header("卡牌设置")]
	public RectTransform cardPagesContainer;

	// Token: 0x04001A44 RID: 6724
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A44")]
	public GameObject sampleGrid;

	// Token: 0x04001A45 RID: 6725
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A45")]
	[Header("翻页设置")]
	public UIButton lastPage;

	// Token: 0x04001A46 RID: 6726
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A46")]
	public UIButton nextPage;

	// Token: 0x04001A47 RID: 6727
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A47")]
	public Page page;

	// Token: 0x04001A48 RID: 6728
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A48")]
	[Header("安全箱设置")]
	public GameObject safeBox;

	// Token: 0x04001A49 RID: 6729
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A49")]
	public bool safeMode;

	// Token: 0x04001A4A RID: 6730
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A4A")]
	public List<TextMeshProUGUI> safeText;

	// Token: 0x04001A4B RID: 6731
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A4B")]
	private readonly Dictionary<string, UIButton> buttons;

	// Token: 0x04001A4C RID: 6732
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A4C")]
	private readonly Dictionary<UIButton, SavedCardGroup> savedGroupPairs;
}
