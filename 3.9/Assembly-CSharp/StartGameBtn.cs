using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008BB RID: 2235
[Token(Token = "0x20008BB")]
public class StartGameBtn : MonoBehaviour
{
	// Token: 0x06002D9A RID: 11674 RVA: 0x000F922C File Offset: 0x000F742C
	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x6FF590", Offset = "0x6FDB90", VA = "0x1806FF590")]
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

	// Token: 0x06002D9B RID: 11675 RVA: 0x000F928C File Offset: 0x000F748C
	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x6FED50", Offset = "0x6FD350", VA = "0x1806FED50")]
	private void OnMouseEnter()
	{
		base.transform.GetChild(1).gameObject.SetActive(true);
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002D9C RID: 11676 RVA: 0x000F92C0 File Offset: 0x000F74C0
	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x6FEDB0", Offset = "0x6FD3B0", VA = "0x1806FEDB0")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		GameObject gameObject = base.transform.GetChild(1).gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002D9D RID: 11677 RVA: 0x000F9300 File Offset: 0x000F7500
	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x6FECB0", Offset = "0x6FD2B0", VA = "0x1806FECB0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(19, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x000F932C File Offset: 0x000F752C
	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x6FF220", Offset = "0x6FD820", VA = "0x1806FF220")]
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

	// Token: 0x06002D9F RID: 11679 RVA: 0x000F93A8 File Offset: 0x000F75A8
	[Token(Token = "0x6002D9F")]
	[Address(RVA = "0x6FEE30", Offset = "0x6FD430", VA = "0x1806FEE30")]
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

	// Token: 0x06002DA0 RID: 11680 RVA: 0x000F9484 File Offset: 0x000F7684
	[Token(Token = "0x6002DA0")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public StartGameBtn()
	{
	}

	// Token: 0x04001B72 RID: 7026
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B72")]
	public Sprite highLightSprite;

	// Token: 0x04001B73 RID: 7027
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B73")]
	private Sprite originSprite;

	// Token: 0x04001B74 RID: 7028
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B74")]
	private Image image;

	// Token: 0x04001B75 RID: 7029
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B75")]
	private Vector3 originPosition;

	// Token: 0x04001B76 RID: 7030
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B76")]
	private RectTransform rectTransform;

	// Token: 0x04001B77 RID: 7031
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B77")]
	private bool clicked;
}
