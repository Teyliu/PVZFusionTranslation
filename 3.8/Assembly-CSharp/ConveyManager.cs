using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x02000815 RID: 2069
[Token(Token = "0x2000815")]
public class ConveyManager : MonoBehaviour
{
	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000E5E14 File Offset: 0x000E4014
	[Token(Token = "0x170001A9")]
	private Board Board
	{
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x638A40", Offset = "0x637040", VA = "0x180638A40")]
		get
		{
			Board board = this._board;
			int num = 0;
			if (board == num)
			{
				Board instance = Board.Instance;
				this._board = instance;
			}
			return this._board;
		}
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x000E5E48 File Offset: 0x000E4048
	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x6357B0", Offset = "0x633DB0", VA = "0x1806357B0")]
	private void Awake()
	{
		ConveyManager.Instance = this;
		List<PlantType> cardPool = this.GetCardPool();
		this.plants = cardPool;
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x000E5E6C File Offset: 0x000E406C
	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x638860", Offset = "0x636E60", VA = "0x180638860")]
	private void Start()
	{
		GameObject gameObject = this.clearButton;
		bool isElementRandom = this.Board.boardTag.isElementRandom;
		gameObject.SetActive(isElementRandom);
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x000E5EA0 File Offset: 0x000E40A0
	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x6388A0", Offset = "0x636EA0", VA = "0x1806388A0")]
	private void Update()
	{
		this.BeltUpdate();
		this.CardUpdate();
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x000E5EBC File Offset: 0x000E40BC
	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x635D60", Offset = "0x634360", VA = "0x180635D60")]
	public void ClearCards()
	{
		int num2;
		do
		{
			int num = 0;
			List<CardUI> list = this.cardsOnBelt;
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num != 0)
				{
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x000E5EEC File Offset: 0x000E40EC
	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x636480", Offset = "0x634A80", VA = "0x180636480")]
	private int GetCardCount(PlantType theSeedType)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<CardUI> list = this.cardsOnBelt;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		return num2;
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x000E5F34 File Offset: 0x000E4134
	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x635820", Offset = "0x633E20", VA = "0x180635820")]
	private void BeltUpdate()
	{
		int size = this.belts._size;
		int num = size - 1;
		if (size > 0)
		{
			Transform transform = this.belts[num].transform;
			float deltaTime = Time.deltaTime;
			Vector2 anchoredPosition = this.belts[num].anchoredPosition;
			RectTransform rectTransform = this.belts[num];
			this.belts.RemoveAt(num);
			List<RectTransform> list = this.belts;
			int size2 = list._size;
			RectTransform rectTransform2 = list[size2];
			int num2 = 0;
			Vector2 anchoredPosition2 = rectTransform2.anchoredPosition;
			rectTransform.anchoredPosition = num2;
			int num3 = 0;
			rectTransform.SetSiblingIndex(num3);
			List<RectTransform> list2 = this.belts;
		}
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x000E5FF0 File Offset: 0x000E41F0
	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x635AF0", Offset = "0x6340F0", VA = "0x180635AF0")]
	private void CardUpdate()
	{
		int size = this.cardsOnBelt._size;
		int num = size - 1;
		if (size > 0)
		{
			CardUI cardUI = this.cardsOnBelt[num];
			int num2 = 0;
			bool flag = cardUI == num2;
			List<CardUI> list = this.cardsOnBelt;
			if (!flag)
			{
				Vector2 anchoredPosition = list[num].GetComponent<RectTransform>().anchoredPosition;
				Transform transform = this.cardsOnBelt[num].transform;
				float deltaTime = Time.deltaTime;
			}
			list.RemoveAt(num);
		}
		List<CardUI> list2 = this.cardsOnBelt;
		this.NewCardUpdate();
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x000E6084 File Offset: 0x000E4284
	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x6385A0", Offset = "0x636BA0", VA = "0x1806385A0")]
	private void NewCardUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.time = deltaTime;
		if (deltaTime > this.interval)
		{
			int num = 0;
			this.time = (float)num;
			if (this.cardCount > 10)
			{
				Board board = this.Board;
				uint num2;
				if (global::UnityEngine.Random.Range(0, (int)num2) == 0)
				{
					this.ElementCardEffect();
					return;
				}
			}
			GameObject gameObject = GameAPP.itemPrefab[40];
			RectTransform rectTransform = this.cardParents;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform);
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			DroppedCard component2 = gameObject2.GetComponent<DroppedCard>();
			List<CardUI> list = this.cardsOnBelt;
			component2.movingWay = (int)((ulong)3L);
			PlantType cardType = this.GetCardType();
			component2.thePlantType = cardType;
			component2.onCardBank = true;
			Board board2 = this.Board;
			ulong num3;
			component2.text.enabled = num3 != 0UL;
			uint num4;
			bool flag = global::UnityEngine.Random.Range(0, (int)num4) >= 95;
			component2.maxUsedTimes = (flag ? 1 : 0);
			return;
		}
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x000E6170 File Offset: 0x000E4370
	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x635EC0", Offset = "0x6344C0", VA = "0x180635EC0")]
	private void ElementCardEffect()
	{
		List<FunctionCardType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int random = (int)ListExtensions.GetRandom<FunctionCardType>(list);
		SpecialCard specialCard;
		Transform transform = specialCard.transform;
		RectTransform rectTransform = this.cardParents;
		transform.parentInternal = rectTransform;
		Transform transform2 = specialCard.transform;
		Transform transform3 = specialCard.transform;
		List<CardUI> list2 = this.cardsOnBelt;
		int size7 = list2._size;
		list2._size = transform3;
		specialCard.onCardBank = true;
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x000E6210 File Offset: 0x000E4410
	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x637EF0", Offset = "0x6364F0", VA = "0x180637EF0")]
	private PlantType GetCardType()
	{
		List<PlantType> cardPool;
		for (;;)
		{
			Board board = this.Board;
			cardPool = this.GetCardPool();
			int theBoardLevel = GameAPP.theBoardLevel;
			if (theBoardLevel == 77)
			{
				Board board2 = this.Board;
				int i = this.cardCount;
				if (!board2.boss2 && i != 0 && i != 0 && i != 0)
				{
					if (i != 0 && i != 1)
					{
						break;
					}
				}
				else
				{
					while (i > 6)
					{
					}
				}
			}
			while (theBoardLevel != 111)
			{
			}
			if (this.cardCount <= 6)
			{
				goto Block_9;
			}
		}
		int num = cardPool._size;
		num = global::UnityEngine.Random.Range(0, num);
		PlantType plantType = cardPool[num];
		CS$<>8__locals1.targetType = plantType;
		uint num2;
		int num3;
		if (global::UnityEngine.Random.Range(0, (int)num2) < num3)
		{
			Predicate<PlantType> predicate = (PlantType n) => n == CS$<>8__locals1.targetType;
			int num4 = cardPool.RemoveAll(predicate);
			int num5 = cardPool._size;
			num5 = global::UnityEngine.Random.Range(0, num5);
			PlantType plantType2 = cardPool[num5];
			CS$<>8__locals1.targetType = plantType2;
			uint num7;
			int num6 = global::UnityEngine.Random.Range(0, (int)num7);
		}
		return CS$<>8__locals1.targetType;
		Block_9:
		this.interval = 15f;
		Board board3 = this.Board;
		List<PlantType> list = this.plants;
		int num8 = list._size;
		num8 = global::UnityEngine.Random.Range(0, num8);
		PlantType plantType3 = list[num8];
		this.interval = 5f;
		throw new NullReferenceException();
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x000E636C File Offset: 0x000E456C
	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x6382F0", Offset = "0x6368F0", VA = "0x1806382F0")]
	public List<PlantType> GetElementPlants()
	{
		List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
		Func<PlantType, bool> <>9__23_ = ConveyManager.<>c.<>9__23_0;
		if (<>9__23_ == 0)
		{
			ConveyManager.<>c.<>9__23_0 = delegate(PlantType p)
			{
				bool flag;
				if (!flag)
				{
					return flag;
				}
				bool flag2;
				return flag2;
			};
		}
		List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(allPlantTypes, <>9__23_));
		uint num;
		if (global::UnityEngine.Random.Range(0, (int)num) != 0)
		{
			Predicate<PlantType> predicate;
			if (ConveyManager.<>c.<>9__23_1 == 0)
			{
				predicate = (PlantType p) => p > PlantType.Melonpult;
				ConveyManager.<>c.<>9__23_1 = predicate;
			}
			int num2 = list.RemoveAll(predicate);
		}
		int size = list._size;
		return list;
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x000E6408 File Offset: 0x000E4608
	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x6365F0", Offset = "0x634BF0", VA = "0x1806365F0")]
	private List<PlantType> GetCardPool()
	{
		List<PlantType> list;
		for (;;)
		{
			int num = 0;
			Board board = this.Board;
			list = new List();
			List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
			LevelType theBoardType = GameAPP.theBoardType;
			int theBoardLevel = GameAPP.theBoardLevel;
			Board board2 = this.Board;
			bool flag = LevelManager.TryGetLevelData(num);
			if (!flag)
			{
				if (theBoardType > LevelType.StarAdvanture)
				{
					break;
				}
				if (theBoardLevel == 27)
				{
					this.interval = 3f;
				}
				if (theBoardLevel == 36)
				{
					break;
				}
				while (theBoardLevel != 45)
				{
				}
				if (theBoardLevel > 77)
				{
					if (theBoardLevel > 111)
					{
						if (theBoardLevel == 132)
						{
							this.interval = 5f;
						}
						while (flag > true)
						{
						}
						uint num2;
						flag = (flag ? 1U : 0U) + num2 != 0U;
						int size = list._size;
						list._size = (flag ? 1 : 0);
						int size2 = list._size;
						list._size = (flag ? 1 : 0);
						int size3 = list._size;
						list._size = (flag ? 1 : 0);
						num++;
						int size4 = list._size;
						int size5 = list._size;
						int size6 = list._size;
						int size7 = list._size;
						num++;
						this.interval = 7.5f;
						this.interval = 6f;
					}
					if (num == 99)
					{
					}
					while (num != 111)
					{
					}
				}
				if (num == 65)
				{
				}
				if (num == 67)
				{
				}
				while (num != 77)
				{
				}
				if ((Board.Instance.boss2 ? 1 : 0) != num)
				{
				}
				global::LevelData exploreData = ExploreDataManager.GetExploreData(GameAPP.theBoardLevel);
				float convayTimer = exploreData.convayTimer;
				this.interval = convayTimer;
				List<PlantType> usePlant = exploreData.usePlant;
				List<PlantType> list2 = new List(usePlant);
				if (usePlant == (ulong)1L)
				{
				}
				while (usePlant != (ulong)3L)
				{
				}
				this.interval = 11f;
				while (usePlant != (ulong)9L)
				{
				}
				if (usePlant == (ulong)9L)
				{
					goto Block_11;
				}
			}
		}
		return list;
		Block_11:
		return null;
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x000E65B4 File Offset: 0x000E47B4
	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x6362F0", Offset = "0x6348F0", VA = "0x1806362F0")]
	private bool FlagConveyPlant(PlantType theSeedType)
	{
		bool flag;
		bool flag2;
		if (!flag && !flag2)
		{
			Board board = this.Board;
			bool flag3;
			if (!flag3)
			{
				if (theSeedType > PlantType.TallNut && theSeedType > PlantType.GloomShroom && theSeedType > PlantType.CobCannon)
				{
					if (theSeedType != PlantType.BigPumpkin && theSeedType != PlantType.SpruceBallista)
					{
						goto IL_0048;
					}
				}
			}
		}
		IL_0041:
		ulong num;
		while (num <= (ulong)1L)
		{
		}
		goto IL_0048;
		goto IL_0041;
		IL_0048:
		throw new NullReferenceException();
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x000E6610 File Offset: 0x000E4810
	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x638920", Offset = "0x636F20", VA = "0x180638920")]
	public ConveyManager()
	{
		List<RectTransform> list = new List();
		this.belts = list;
		List<CardUI> list2 = new List();
		this.cardsOnBelt = list2;
		this.time = 10f;
		this.speed = -0.5f;
		this.interval = 4f;
		List<PlantType> list3 = new List();
		this.plants = list3;
		base..ctor();
	}

	// Token: 0x04001856 RID: 6230
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001856")]
	public List<RectTransform> belts;

	// Token: 0x04001857 RID: 6231
	[Token(Token = "0x4001857")]
	public static ConveyManager Instance;

	// Token: 0x04001858 RID: 6232
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001858")]
	public List<CardUI> cardsOnBelt;

	// Token: 0x04001859 RID: 6233
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001859")]
	public RectTransform cardParents;

	// Token: 0x0400185A RID: 6234
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400185A")]
	public GameObject clearButton;

	// Token: 0x0400185B RID: 6235
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400185B")]
	private float time;

	// Token: 0x0400185C RID: 6236
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400185C")]
	private readonly float speed;

	// Token: 0x0400185D RID: 6237
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400185D")]
	private float interval;

	// Token: 0x0400185E RID: 6238
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400185E")]
	public int cardCount;

	// Token: 0x0400185F RID: 6239
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400185F")]
	private List<PlantType> plants;

	// Token: 0x04001860 RID: 6240
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001860")]
	private Board _board;
}
