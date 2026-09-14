using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x02000853 RID: 2131
[Token(Token = "0x2000853")]
public class ConveyManager : MonoBehaviour
{
	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000EB154 File Offset: 0x000E9354
	[Token(Token = "0x170001F3")]
	private Board Board
	{
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x69CFB0", Offset = "0x69B5B0", VA = "0x18069CFB0")]
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

	// Token: 0x06002B50 RID: 11088 RVA: 0x000EB188 File Offset: 0x000E9388
	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x699D20", Offset = "0x698320", VA = "0x180699D20")]
	private void Awake()
	{
		ConveyManager.Instance = this;
		List<PlantType> cardPool = this.GetCardPool();
		this.plants = cardPool;
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x000EB1AC File Offset: 0x000E93AC
	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x69CDD0", Offset = "0x69B3D0", VA = "0x18069CDD0")]
	private void Start()
	{
		GameObject gameObject = this.clearButton;
		bool isElementRandom = this.Board.boardTag.isElementRandom;
		gameObject.SetActive(isElementRandom);
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x000EB1E0 File Offset: 0x000E93E0
	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x69CE10", Offset = "0x69B410", VA = "0x18069CE10")]
	private void Update()
	{
		this.BeltUpdate();
		this.CardUpdate();
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x000EB1FC File Offset: 0x000E93FC
	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x69A2D0", Offset = "0x6988D0", VA = "0x18069A2D0")]
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

	// Token: 0x06002B54 RID: 11092 RVA: 0x000EB22C File Offset: 0x000E942C
	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x69A9F0", Offset = "0x698FF0", VA = "0x18069A9F0")]
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

	// Token: 0x06002B55 RID: 11093 RVA: 0x000EB274 File Offset: 0x000E9474
	[Token(Token = "0x6002B55")]
	[Address(RVA = "0x699D90", Offset = "0x698390", VA = "0x180699D90")]
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

	// Token: 0x06002B56 RID: 11094 RVA: 0x000EB330 File Offset: 0x000E9530
	[Token(Token = "0x6002B56")]
	[Address(RVA = "0x69A060", Offset = "0x698660", VA = "0x18069A060")]
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

	// Token: 0x06002B57 RID: 11095 RVA: 0x000EB3C4 File Offset: 0x000E95C4
	[Token(Token = "0x6002B57")]
	[Address(RVA = "0x69CB10", Offset = "0x69B110", VA = "0x18069CB10")]
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

	// Token: 0x06002B58 RID: 11096 RVA: 0x000EB4B0 File Offset: 0x000E96B0
	[Token(Token = "0x6002B58")]
	[Address(RVA = "0x69A430", Offset = "0x698A30", VA = "0x18069A430")]
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

	// Token: 0x06002B59 RID: 11097 RVA: 0x000EB550 File Offset: 0x000E9750
	[Token(Token = "0x6002B59")]
	[Address(RVA = "0x69C460", Offset = "0x69AA60", VA = "0x18069C460")]
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

	// Token: 0x06002B5A RID: 11098 RVA: 0x000EB6AC File Offset: 0x000E98AC
	[Token(Token = "0x6002B5A")]
	[Address(RVA = "0x69C860", Offset = "0x69AE60", VA = "0x18069C860")]
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

	// Token: 0x06002B5B RID: 11099 RVA: 0x000EB748 File Offset: 0x000E9948
	[Token(Token = "0x6002B5B")]
	[Address(RVA = "0x69AB60", Offset = "0x699160", VA = "0x18069AB60")]
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

	// Token: 0x06002B5C RID: 11100 RVA: 0x000EB8F4 File Offset: 0x000E9AF4
	[Token(Token = "0x6002B5C")]
	[Address(RVA = "0x69A860", Offset = "0x698E60", VA = "0x18069A860")]
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

	// Token: 0x06002B5D RID: 11101 RVA: 0x000EB950 File Offset: 0x000E9B50
	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x69CE90", Offset = "0x69B490", VA = "0x18069CE90")]
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

	// Token: 0x04001952 RID: 6482
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001952")]
	public List<RectTransform> belts;

	// Token: 0x04001953 RID: 6483
	[Token(Token = "0x4001953")]
	public static ConveyManager Instance;

	// Token: 0x04001954 RID: 6484
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001954")]
	public List<CardUI> cardsOnBelt;

	// Token: 0x04001955 RID: 6485
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001955")]
	public RectTransform cardParents;

	// Token: 0x04001956 RID: 6486
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001956")]
	public GameObject clearButton;

	// Token: 0x04001957 RID: 6487
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001957")]
	private float time;

	// Token: 0x04001958 RID: 6488
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001958")]
	private readonly float speed;

	// Token: 0x04001959 RID: 6489
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001959")]
	private float interval;

	// Token: 0x0400195A RID: 6490
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400195A")]
	public int cardCount;

	// Token: 0x0400195B RID: 6491
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400195B")]
	private List<PlantType> plants;

	// Token: 0x0400195C RID: 6492
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400195C")]
	private Board _board;
}
