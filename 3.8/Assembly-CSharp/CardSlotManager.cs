using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x02000847 RID: 2119
[Token(Token = "0x2000847")]
public class CardSlotManager
{
	// Token: 0x06002B1C RID: 11036 RVA: 0x000ECA80 File Offset: 0x000EAC80
	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x64C580", Offset = "0x64AB80", VA = "0x18064C580")]
	public CardSlotManager(GameObject[] slotPositions, int maxCardCount = 14, [Optional] RectTransform movingCardContainer)
	{
		Dictionary<CardUI, CancellationTokenSource> dictionary = new Dictionary();
		this._movingCards = dictionary;
		base..ctor();
		if (slotPositions != 0)
		{
			if (slotPositions.Length > 14)
			{
				int length = slotPositions.Length;
				int num;
				Debug.LogWarning(string.Format("[CardSlotManager] 卡槽数量 {0} 超过最大值 {1}", length, num));
			}
			this._slotPositions = slotPositions;
			this._movingCardContainer = movingCardContainer;
			this._maxCardCount = 14;
			CardUI[] array = new CardUI[this._slotPositions.Length];
			this._cardOnBank = array;
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000ECAF8 File Offset: 0x000EACF8
	[Token(Token = "0x170001B1")]
	public IReadOnlyList<CardUI> Cards
	{
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x64BB40", Offset = "0x64A140", VA = "0x18064BB40")]
		get
		{
			List<CardUI> list = new List();
			CardUI[] cardOnBank = this._cardOnBank;
			int num = 0;
			if (num < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = this._cardOnBank;
				int num2 = 0;
				CardUI cardUI;
				if (cardUI != num2)
				{
					CardUI[] cardOnBank3 = this._cardOnBank;
				}
				CardUI[] cardOnBank4 = this._cardOnBank;
				num++;
				uint num3;
				num3 += (uint)8;
			}
			throw new NullReferenceException();
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000ECB60 File Offset: 0x000EAD60
	[Token(Token = "0x170001B2")]
	public bool IsFull
	{
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x64C830", Offset = "0x64AE30", VA = "0x18064C830")]
		get
		{
			CardUI[] cardOnBank = this._cardOnBank;
			int num = 0;
			if (num < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = this._cardOnBank;
				int num2 = 0;
				CardUI cardUI;
				bool flag = cardUI != num2;
				CardUI[] cardOnBank3 = this._cardOnBank;
				num++;
				uint num3;
				num3 += (uint)8;
			}
			return num >= this._maxCardCount;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000ECBBC File Offset: 0x000EADBC
	[Token(Token = "0x170001B3")]
	public int ActiveCardCount
	{
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x64C760", Offset = "0x64AD60", VA = "0x18064C760")]
		get
		{
			CardUI[] cardOnBank = this._cardOnBank;
			int num = 0;
			if (num < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = this._cardOnBank;
				int num2 = 0;
				CardUI cardUI;
				bool flag = cardUI != num2;
				CardUI[] cardOnBank3 = this._cardOnBank;
				num++;
				uint num3;
				num3 += (uint)8;
			}
			return num;
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000ECC0C File Offset: 0x000EAE0C
	[Token(Token = "0x170001B4")]
	public int MaxCardCount
	{
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
		get
		{
			return this._maxCardCount;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000ECC20 File Offset: 0x000EAE20
	[Token(Token = "0x170001B5")]
	public int TotalSlots
	{
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x64C910", Offset = "0x64AF10", VA = "0x18064C910")]
		get
		{
			return this._slotPositions.Length;
		}
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x000ECC40 File Offset: 0x000EAE40
	[Token(Token = "0x6002B22")]
	[Address(RVA = "0x64B460", Offset = "0x649A60", VA = "0x18064B460")]
	public bool AddCard(CardUI card, bool quick = false)
	{
		int num = 0;
		if (!(card == num))
		{
			CardUI[] cardOnBank = this._cardOnBank;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			uint num6;
			if (num4 < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = this._cardOnBank;
				int num5 = 0;
				CardUI cardUI;
				bool flag = cardUI != num5;
				CardUI[] cardOnBank3 = this._cardOnBank;
				num3++;
				num6 += (uint)8;
			}
			if (num2 < this._maxCardCount)
			{
				CardUI[] cardOnBank4 = this._cardOnBank;
				int num7 = 0;
				int num8 = 0;
				if (num8 < cardOnBank4.Length)
				{
					CardUI[] cardOnBank5 = this._cardOnBank;
					int num9 = 0;
					CardUI cardUI2;
					bool flag2 = cardUI2 == num9;
					CardUI[] cardOnBank6 = this._cardOnBank;
					if (!flag2)
					{
						num7++;
						num6 += (uint)8;
						while (cardOnBank6 != 0)
						{
						}
					}
					if (card != 0)
					{
					}
					cardOnBank6[0] = card;
					num7 += 4;
					card.theNumberInCardSort = num7;
					Transform transform = this._slotPositions[num7].transform;
					UniTaskVoid uniTaskVoid = this.MoveCardAsync(card, quick, transform);
				}
			}
		}
		Debug.LogWarning("[CardSlotManager] 尝试添加空卡牌");
		throw new NullReferenceException();
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x000ECD54 File Offset: 0x000EAF54
	[Token(Token = "0x6002B23")]
	[Address(RVA = "0x64C1A0", Offset = "0x64A7A0", VA = "0x18064C1A0")]
	public bool RemoveCard(CardUI card, bool quick = false)
	{
		int num = 0;
		if (!(card == num))
		{
			CardUI[] cardOnBank = this._cardOnBank;
			int num2 = 0;
			int num3 = 0;
			if (num3 < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = this._cardOnBank;
				CardUI cardUI;
				if (!(cardUI == card))
				{
					CardUI[] cardOnBank3 = this._cardOnBank;
					num2++;
					uint num4;
					num4 += (uint)8;
				}
				GameObject parent = card.parent;
				int num5 = 0;
				if (parent != num5)
				{
					Transform transform = card.parent.transform;
				}
				int num6 = 0;
				card.isSelected = false;
				if (card.isExtra)
				{
					this.HandleExtraCardSibling(card);
				}
				UniTaskVoid uniTaskVoid = this.MoveCardAsync(card, quick, num6);
				this.ShiftCardsForward(num2, quick);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x000ECE10 File Offset: 0x000EB010
	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x64BA70", Offset = "0x64A070", VA = "0x18064BA70")]
	public bool ContainsCard(CardUI card)
	{
		CardUI[] cardOnBank = this._cardOnBank;
		int num = 0;
		if (num < cardOnBank.Length)
		{
			CardUI[] cardOnBank2 = this._cardOnBank;
			CardUI cardUI;
			if (!(cardUI == card))
			{
				CardUI[] cardOnBank3 = this._cardOnBank;
				num++;
				uint num2;
				num2 += (uint)8;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x000ECE5C File Offset: 0x000EB05C
	[Token(Token = "0x6002B25")]
	[Address(RVA = "0x64BC80", Offset = "0x64A280", VA = "0x18064BC80")]
	public CardUI GetCardAtIndex(int index)
	{
		CardUI[] cardOnBank = this._cardOnBank;
		if (index < cardOnBank.Length)
		{
			return cardOnBank[index];
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x000ECE8C File Offset: 0x000EB08C
	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x64BCC0", Offset = "0x64A2C0", VA = "0x18064BCC0")]
	public int GetCardIndex(CardUI card)
	{
		CardUI[] cardOnBank = this._cardOnBank;
		int num = 0;
		if (num < cardOnBank.Length)
		{
			CardUI[] cardOnBank2 = this._cardOnBank;
			CardUI cardUI;
			if (!(cardUI == card))
			{
				CardUI[] cardOnBank3 = this._cardOnBank;
				num++;
				uint num2;
				num2 += (uint)8;
			}
			return num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x000ECED8 File Offset: 0x000EB0D8
	[Token(Token = "0x6002B27")]
	[Address(RVA = "0x64B7F0", Offset = "0x649DF0", VA = "0x18064B7F0")]
	public void ClearAll()
	{
		int num;
		do
		{
			Dictionary<CardUI, CancellationTokenSource> movingCards = this._movingCards;
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		bool flag2;
		uint num3;
		if (flag2)
		{
			num3.m_value = (uint)num2;
		}
		num2++;
		num3 += (uint)8;
	}

	// Token: 0x06002B28 RID: 11048 RVA: 0x000ECF1C File Offset: 0x000EB11C
	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x64B740", Offset = "0x649D40", VA = "0x18064B740")]
	public void CancelCardMovement(CardUI card)
	{
		Dictionary<CardUI, CancellationTokenSource> movingCards = this._movingCards;
		bool flag;
		if (flag)
		{
			bool flag2 = this._movingCards.Remove(card);
		}
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x000ECF48 File Offset: 0x000EB148
	[Token(Token = "0x6002B29")]
	[Address(RVA = "0x64C070", Offset = "0x64A670", VA = "0x18064C070")]
	public void MoveCardToTarget(CardUI card, bool quick = false)
	{
		int num = 0;
		if (!(card == num))
		{
		}
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x000ECF64 File Offset: 0x000EB164
	[Token(Token = "0x6002B2A")]
	[Address(RVA = "0x64BEB0", Offset = "0x64A4B0", VA = "0x18064BEB0")]
	private UniTaskVoid MoveCardAsync(CardUI card, bool quick, [Optional] Transform targetParent)
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x000ECF80 File Offset: 0x000EB180
	[Token(Token = "0x6002B2B")]
	[Address(RVA = "0x64BFA0", Offset = "0x64A5A0", VA = "0x18064BFA0")]
	private UniTaskVoid MoveCardToTargetAsync(CardUI card, bool quick)
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x000ECF9C File Offset: 0x000EB19C
	[Token(Token = "0x6002B2C")]
	[Address(RVA = "0x64C350", Offset = "0x64A950", VA = "0x18064C350")]
	private void ShiftCardsForward(int fromIndex, bool quick)
	{
		CardUI[] cardOnBank = this._cardOnBank;
		int num = 0;
		int length = cardOnBank.Length;
		CardUI[] cardOnBank2 = this._cardOnBank;
		if (fromIndex < length)
		{
			int num2 = fromIndex + 1;
			CardUI cardUI;
			if (cardUI != 0)
			{
			}
			num2 = fromIndex + 4;
			CardUI[] cardOnBank3 = this._cardOnBank;
			int num3 = 0;
			CardUI cardUI2;
			if (cardUI2 != num3)
			{
				CardUI[] cardOnBank4 = this._cardOnBank;
				CardUI cardUI3;
				int theNumberInCardSort = cardUI3.theNumberInCardSort;
				int num4 = theNumberInCardSort - 1;
				cardUI3.theNumberInCardSort = num4;
				CardUI[] cardOnBank5 = this._cardOnBank;
				GameObject[] slotPositions = this._slotPositions;
				int num5 = theNumberInCardSort - 1;
				Transform transform = slotPositions.transform;
				CardUI cardUI4;
				UniTaskVoid uniTaskVoid = this.MoveCardAsync(cardUI4, quick, transform);
			}
			CardUI[] cardOnBank6 = this._cardOnBank;
		}
		int num6 = cardOnBank2.Length;
		cardOnBank2[0] = num;
		num6 += 4;
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x000ED068 File Offset: 0x000EB268
	[Token(Token = "0x6002B2D")]
	[Address(RVA = "0x64BB40", Offset = "0x64A140", VA = "0x18064BB40")]
	private List<CardUI> GetActiveCards()
	{
		List<CardUI> list = new List();
		CardUI[] cardOnBank = this._cardOnBank;
		int num = 0;
		if (num < cardOnBank.Length)
		{
			CardUI[] cardOnBank2 = this._cardOnBank;
			int num2 = 0;
			CardUI cardUI;
			if (cardUI != num2)
			{
				CardUI[] cardOnBank3 = this._cardOnBank;
			}
			CardUI[] cardOnBank4 = this._cardOnBank;
			num++;
			uint num3;
			num3 += (uint)8;
		}
		return list;
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x000ED0D0 File Offset: 0x000EB2D0
	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x64BDA0", Offset = "0x64A3A0", VA = "0x18064BDA0")]
	private void HandleExtraCardSibling(CardUI card)
	{
		GameObject parent = card.parent;
		int num = 0;
		if (parent != num && card.parent.transform.childCount == 3)
		{
			card.parent.transform.GetChild(1).transform.SetSiblingIndex(2);
			card.transform.SetSiblingIndex(1);
			return;
		}
	}

	// Token: 0x04001946 RID: 6470
	[Token(Token = "0x4001946")]
	public const int MaxSlotCount = 14;

	// Token: 0x04001947 RID: 6471
	[Token(Token = "0x4001947")]
	public const int DefaultMaxCardCount = 14;

	// Token: 0x04001948 RID: 6472
	[Token(Token = "0x4001948")]
	public const float DefaultMoveDuration = 0.1f;

	// Token: 0x04001949 RID: 6473
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001949")]
	private readonly CardUI[] _cardOnBank;

	// Token: 0x0400194A RID: 6474
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400194A")]
	private readonly GameObject[] _slotPositions;

	// Token: 0x0400194B RID: 6475
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400194B")]
	private readonly int _maxCardCount;

	// Token: 0x0400194C RID: 6476
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400194C")]
	private readonly RectTransform _movingCardContainer;

	// Token: 0x0400194D RID: 6477
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400194D")]
	private readonly Dictionary<CardUI, CancellationTokenSource> _movingCards;
}
