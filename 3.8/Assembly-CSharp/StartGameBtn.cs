using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200087F RID: 2175
[Token(Token = "0x200087F")]
public class StartGameBtn : MonoBehaviour
{
	// Token: 0x06002C68 RID: 11368 RVA: 0x000F4598 File Offset: 0x000F2798
	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x685FC0", Offset = "0x6845C0", VA = "0x180685FC0")]
	private void Start()
	{
		RectTransform component = base.GetComponent<RectTransform>();
		this.rectTransform = component;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
		Image component2 = base.GetComponent<Image>();
		this.image = component2;
		Sprite sprite = this.image.m_Sprite;
		this.originSprite = sprite;
		throw new NullReferenceException();
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x000F45F8 File Offset: 0x000F27F8
	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x685790", Offset = "0x683D90", VA = "0x180685790")]
	private void OnMouseEnter()
	{
		base.transform.GetChild(1).gameObject.SetActive(true);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x000F462C File Offset: 0x000F282C
	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x6857F0", Offset = "0x683DF0", VA = "0x1806857F0")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		GameObject gameObject = base.transform.GetChild(1).gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x000F466C File Offset: 0x000F286C
	[Token(Token = "0x6002C6B")]
	[Address(RVA = "0x6856F0", Offset = "0x683CF0", VA = "0x1806856F0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(19, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x000F4698 File Offset: 0x000F2898
	[Token(Token = "0x6002C6C")]
	[Address(RVA = "0x685C50", Offset = "0x684250", VA = "0x180685C50")]
	public static void SaveCards()
	{
		int num;
		do
		{
			num = 0;
			GameAPP.lastCards._size = num;
			if (InGameUI.Instance._cardSlotManager.Cards != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_0037;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_0037;
				}
				IL_0043:
				List<GameAPP.LastCards> list;
				list += list;
				goto IL_0047;
				IL_0037:
				bool flag;
				while (!flag)
				{
				}
				list = GameAPP.lastCards;
				goto IL_0043;
			}
			IL_0047:
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x000F4714 File Offset: 0x000F2914
	[Token(Token = "0x6002C6D")]
	[Address(RVA = "0x685870", Offset = "0x683E70", VA = "0x180685870")]
	private void OnMouseUp()
	{
		ulong num2;
		do
		{
			int num = 0;
			if ((this.clicked ? 1 : 0) != num)
			{
				return;
			}
			StartGameBtn.SaveCards();
			Board instance = Board.Instance;
			List<CardUI> cards = InGameUI.Instance.Cards;
			bool flag;
			if (flag)
			{
				List<TreasureCardData> treasureCards = TreasureData.treasureCards;
				List<TreasureCardData> cardData = TreasureManager.Instance.cardData;
			}
		}
		while (num2 != (ulong)0L);
		int buffCost = TreasureData.GetBuffCost();
		int num3 = TreasureData.treasureMoney;
		num3 -= buffCost;
		TreasureData.treasureMoney = num3;
		SaveInfo.Instance.SavePlayerData();
		this.clicked = true;
		CursorChange.SetDefaultCursor();
		RectTransform rectTransform = this.rectTransform;
		InitBoard.Instance.ready = true;
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x000F4804 File Offset: 0x000F2A04
	[Token(Token = "0x6002C6E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public StartGameBtn()
	{
	}

	// Token: 0x04001A84 RID: 6788
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A84")]
	public Sprite highLightSprite;

	// Token: 0x04001A85 RID: 6789
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A85")]
	private Sprite originSprite;

	// Token: 0x04001A86 RID: 6790
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A86")]
	private Image image;

	// Token: 0x04001A87 RID: 6791
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A87")]
	private Vector3 originPosition;

	// Token: 0x04001A88 RID: 6792
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A88")]
	private RectTransform rectTransform;

	// Token: 0x04001A89 RID: 6793
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A89")]
	private bool clicked;
}
