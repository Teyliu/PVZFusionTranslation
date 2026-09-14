using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x02000883 RID: 2179
[Token(Token = "0x2000883")]
public class CardSlotManager
{
	// Token: 0x06002C4E RID: 11342 RVA: 0x000F178C File Offset: 0x000EF98C
	[Token(Token = "0x6002C4E")]
	[Address(RVA = "0x6B0910", Offset = "0x6AEF10", VA = "0x1806B0910")]
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

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000F1804 File Offset: 0x000EFA04
	[Token(Token = "0x170001F9")]
	public IReadOnlyList<CardUI> Cards
	{
		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0x6AFED0", Offset = "0x6AE4D0", VA = "0x1806AFED0")]
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

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000F186C File Offset: 0x000EFA6C
	[Token(Token = "0x170001FA")]
	public bool IsFull
	{
		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x6B0BC0", Offset = "0x6AF1C0", VA = "0x1806B0BC0")]
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

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000F18C8 File Offset: 0x000EFAC8
	[Token(Token = "0x170001FB")]
	public int ActiveCardCount
	{
		[Token(Token = "0x6002C51")]
		[Address(RVA = "0x6B0AF0", Offset = "0x6AF0F0", VA = "0x1806B0AF0")]
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

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000F1918 File Offset: 0x000EFB18
	[Token(Token = "0x170001FC")]
	public int MaxCardCount
	{
		[Token(Token = "0x6002C52")]
		[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
		get
		{
			return this._maxCardCount;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000F192C File Offset: 0x000EFB2C
	[Token(Token = "0x170001FD")]
	public int TotalSlots
	{
		[Token(Token = "0x6002C53")]
		[Address(RVA = "0x6B0CA0", Offset = "0x6AF2A0", VA = "0x1806B0CA0")]
		get
		{
			return this._slotPositions.Length;
		}
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x000F194C File Offset: 0x000EFB4C
	[Token(Token = "0x6002C54")]
	[Address(RVA = "0x6AF7F0", Offset = "0x6ADDF0", VA = "0x1806AF7F0")]
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

	// Token: 0x06002C55 RID: 11349 RVA: 0x000F1A60 File Offset: 0x000EFC60
	[Token(Token = "0x6002C55")]
	[Address(RVA = "0x6B0530", Offset = "0x6AEB30", VA = "0x1806B0530")]
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

	// Token: 0x06002C56 RID: 11350 RVA: 0x000F1B1C File Offset: 0x000EFD1C
	[Token(Token = "0x6002C56")]
	[Address(RVA = "0x6AFE00", Offset = "0x6AE400", VA = "0x1806AFE00")]
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

	// Token: 0x06002C57 RID: 11351 RVA: 0x000F1B68 File Offset: 0x000EFD68
	[Token(Token = "0x6002C57")]
	[Address(RVA = "0x6B0010", Offset = "0x6AE610", VA = "0x1806B0010")]
	public CardUI GetCardAtIndex(int index)
	{
		CardUI[] cardOnBank = this._cardOnBank;
		if (index < cardOnBank.Length)
		{
			return cardOnBank[index];
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x000F1B98 File Offset: 0x000EFD98
	[Token(Token = "0x6002C58")]
	[Address(RVA = "0x6B0050", Offset = "0x6AE650", VA = "0x1806B0050")]
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

	// Token: 0x06002C59 RID: 11353 RVA: 0x000F1BE4 File Offset: 0x000EFDE4
	[Token(Token = "0x6002C59")]
	[Address(RVA = "0x6AFB80", Offset = "0x6AE180", VA = "0x1806AFB80")]
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

	// Token: 0x06002C5A RID: 11354 RVA: 0x000F1C28 File Offset: 0x000EFE28
	[Token(Token = "0x6002C5A")]
	[Address(RVA = "0x6AFAD0", Offset = "0x6AE0D0", VA = "0x1806AFAD0")]
	public void CancelCardMovement(CardUI card)
	{
		Dictionary<CardUI, CancellationTokenSource> movingCards = this._movingCards;
		bool flag;
		if (flag)
		{
			bool flag2 = this._movingCards.Remove(card);
		}
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x000F1C54 File Offset: 0x000EFE54
	[Token(Token = "0x6002C5B")]
	[Address(RVA = "0x6B0400", Offset = "0x6AEA00", VA = "0x1806B0400")]
	public void MoveCardToTarget(CardUI card, bool quick = false)
	{
		int num = 0;
		if (!(card == num))
		{
		}
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x000F1C70 File Offset: 0x000EFE70
	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x6B0240", Offset = "0x6AE840", VA = "0x1806B0240")]
	private UniTaskVoid MoveCardAsync(CardUI card, bool quick, [Optional] Transform targetParent)
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x000F1C8C File Offset: 0x000EFE8C
	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x6B0330", Offset = "0x6AE930", VA = "0x1806B0330")]
	private UniTaskVoid MoveCardToTargetAsync(CardUI card, bool quick)
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x000F1CA8 File Offset: 0x000EFEA8
	[Token(Token = "0x6002C5E")]
	[Address(RVA = "0x6B06E0", Offset = "0x6AECE0", VA = "0x1806B06E0")]
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

	// Token: 0x06002C5F RID: 11359 RVA: 0x000F1D74 File Offset: 0x000EFF74
	[Token(Token = "0x6002C5F")]
	[Address(RVA = "0x6AFED0", Offset = "0x6AE4D0", VA = "0x1806AFED0")]
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

	// Token: 0x06002C60 RID: 11360 RVA: 0x000F1DDC File Offset: 0x000EFFDC
	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x6B0130", Offset = "0x6AE730", VA = "0x1806B0130")]
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

	// Token: 0x04001A34 RID: 6708
	[Token(Token = "0x4001A34")]
	public const int MaxSlotCount = 14;

	// Token: 0x04001A35 RID: 6709
	[Token(Token = "0x4001A35")]
	public const int DefaultMaxCardCount = 14;

	// Token: 0x04001A36 RID: 6710
	[Token(Token = "0x4001A36")]
	public const float DefaultMoveDuration = 0.1f;

	// Token: 0x04001A37 RID: 6711
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A37")]
	private readonly CardUI[] _cardOnBank;

	// Token: 0x04001A38 RID: 6712
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A38")]
	private readonly GameObject[] _slotPositions;

	// Token: 0x04001A39 RID: 6713
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A39")]
	private readonly int _maxCardCount;

	// Token: 0x04001A3A RID: 6714
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A3A")]
	private readonly RectTransform _movingCardContainer;

	// Token: 0x04001A3B RID: 6715
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A3B")]
	private readonly Dictionary<CardUI, CancellationTokenSource> _movingCards;
}
