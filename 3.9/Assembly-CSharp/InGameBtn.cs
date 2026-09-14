using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200087F RID: 2175
[Token(Token = "0x200087F")]
public class InGameBtn : MonoBehaviour
{
	// Token: 0x06002C3D RID: 11325 RVA: 0x000F0F94 File Offset: 0x000EF194
	[Token(Token = "0x6002C3D")]
	[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
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

	// Token: 0x06002C3E RID: 11326 RVA: 0x000F0FF4 File Offset: 0x000EF1F4
	[Token(Token = "0x6002C3E")]
	[Address(RVA = "0x6C1720", Offset = "0x6BFD20", VA = "0x1806C1720")]
	private void OnMouseEnter()
	{
		Mouse instance = Mouse.Instance;
		int num = 0;
		if (instance != num)
		{
			GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
			int num2 = 0;
			if (theItemOnMouse != num2)
			{
				this.existItemOnMouse = true;
				return;
			}
		}
		Image image = this.image;
		this.existItemOnMouse = false;
		Sprite sprite = this.highLightSprite;
		image.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x000F1060 File Offset: 0x000EF260
	[Token(Token = "0x6002C3F")]
	[Address(RVA = "0x6C1810", Offset = "0x6BFE10", VA = "0x1806C1810")]
	private void OnMouseExit()
	{
		if (!this.existItemOnMouse)
		{
			Image image = this.image;
			Sprite sprite = this.originSprite;
			image.sprite = sprite;
			RectTransform rectTransform = this.rectTransform;
			CursorChange.SetDefaultCursor();
			return;
		}
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x000F10A4 File Offset: 0x000EF2A4
	[Token(Token = "0x6002C40")]
	[Address(RVA = "0x6C1880", Offset = "0x6BFE80", VA = "0x1806C1880")]
	private void OnMouseUpAsButton()
	{
		Mouse instance = Mouse.Instance;
		int num = 0;
		if (instance != num)
		{
			GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
			int num2 = 0;
			if (theItemOnMouse != num2)
			{
				return;
			}
		}
		CursorChange.SetDefaultCursor();
		this.rectTransform.anchoredPosition = num;
		if (this.buttonNumber <= 19)
		{
			IZBottomMenu instance2 = IZBottomMenu.Instance;
			int num3 = 0;
			if (instance2 != num3)
			{
				IZBottomMenu.Instance.PauseGame();
				return;
			}
			Board.Instance.Die();
			if (GameAPP.theBoardType != LevelType.Challenge)
			{
				UIMgr.EnterMainMenu();
				return;
			}
			UIMgr.EnterMainMenu();
			UIMgr.EnterChallengeMenu();
			UIResourcesLoader uimanager = GameAPP.UIManager;
		}
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x000F1260 File Offset: 0x000EF460
	[Token(Token = "0x6002C41")]
	[Address(RVA = "0x6C1600", Offset = "0x6BFC00", VA = "0x1806C1600")]
	private void OnMouseDown()
	{
		if (!this.existItemOnMouse)
		{
			if (this.buttonNumber <= 15)
			{
			}
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			RectTransform rectTransform = this.rectTransform;
			return;
		}
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x000F12A0 File Offset: 0x000EF4A0
	[Token(Token = "0x6002C42")]
	[Address(RVA = "0x6C29E0", Offset = "0x6C0FE0", VA = "0x1806C29E0")]
	private void Update()
	{
		if (this.buttonNumber == 3 && Input.GetKeyDownInt(KeyCodeManager.SlowTrigger))
		{
			this.SpeedTrigger();
			return;
		}
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x000F12CC File Offset: 0x000EF4CC
	[Token(Token = "0x6002C43")]
	[Address(RVA = "0x6C2010", Offset = "0x6C0610", VA = "0x1806C2010")]
	private void ShowCards()
	{
		int num;
		GameObject bottom;
		do
		{
			num = 0;
			bottom = InGameUI.Instance.Bottom;
			if (!bottom.activeSelf)
			{
				break;
			}
			int num2 = 0;
			bottom.SetActive(num2 != 0);
			RectTransform component = bottom.GetComponent<RectTransform>();
			InGameUI.Instance.LowerUI();
			Time.timeScale = GameAPP.config.gameSpeed;
			GameAPP.theGameStatus = (GameStatus)num;
			Transform transform = bottom.transform;
			int num3 = 0;
			uint num4;
			ulong num5;
			transform.GetChild(num3).GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			Transform transform2 = bottom.transform;
			int num6 = 0;
			uint num7;
			ulong num8;
			transform2.GetChild(num6).GetChild((int)num7).gameObject.SetActive(num8 != 0UL);
			Transform transform3 = bottom.transform;
			int num9 = 0;
			uint num10;
			ulong num11;
			transform3.GetChild(num9).GetChild((int)num10).gameObject.SetActive(num11 != 0UL);
			GameAPP.lastCards._size = num;
			CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
			List<CardUI> list = new List();
			CardUI[] cardOnBank = cardSlotManager._cardOnBank;
			if (num < cardOnBank.Length)
			{
				CardUI[] cardOnBank2 = cardSlotManager._cardOnBank;
				bool flag;
				if (flag)
				{
					CardUI[] cardOnBank3 = cardSlotManager._cardOnBank;
				}
				num++;
				uint num12;
				num12 += (uint)8;
				CardUI[] cardOnBank4 = cardSlotManager._cardOnBank;
			}
			if (num != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_0141;
					}
					num++;
				}
				bool flag2;
				while (!flag2)
				{
				}
				List<GameAPP.LastCards> list2 = GameAPP.lastCards;
				IL_0141:
				list2 += list2;
			}
			if ("{il2cpp array field local65->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		ulong num13;
		bottom.SetActive(num13 != 0UL);
		RectTransform component2 = bottom.GetComponent<RectTransform>();
		InGameUI.Instance.UpperUI();
		Time.timeScale = (float)0;
		Transform transform4 = bottom.transform;
		int num14 = 0;
		uint num15;
		GameObject gameObject = transform4.GetChild(num14).GetChild((int)num15).gameObject;
		int num16 = 0;
		gameObject.SetActive(num16 != 0);
		Transform transform5 = bottom.transform;
		int num17 = 0;
		uint num18;
		GameObject gameObject2 = transform5.GetChild(num17).GetChild((int)num18).gameObject;
		int num19 = 0;
		gameObject2.SetActive(num19 != 0);
		Transform transform6 = bottom.transform;
		int num20 = 0;
		uint num21;
		GameObject gameObject3 = transform6.GetChild(num20).GetChild((int)num21).gameObject;
		int num22 = 0;
		gameObject3.SetActive(num22 != 0);
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x000F14E4 File Offset: 0x000EF6E4
	[Token(Token = "0x6002C44")]
	[Address(RVA = "0x6C2880", Offset = "0x6C0E80", VA = "0x1806C2880")]
	private void SpeedTrigger()
	{
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x000F151C File Offset: 0x000EF71C
	[Token(Token = "0x6002C45")]
	[Address(RVA = "0x6C0EA0", Offset = "0x6BF4A0", VA = "0x1806C0EA0")]
	private void GetLastCards()
	{
		ulong num7;
		do
		{
			int num = 0;
			Board instance = Board.Instance;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform.parent.Find("Grid").gameObject.transform);
			List<CardUI> list = new List();
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<GameAPP.LastCards> lastCards = GameAPP.lastCards;
				InGameBtn.<>c__DisplayClass16_0 CS$<>8__locals1;
				Func<GameAPP.LastCards, bool> func = delegate(GameAPP.LastCards card)
				{
					CardUI c = CS$<>8__locals1.c;
					if (card != c.theSeedType)
					{
					}
					return card == c.isExtra;
				};
				if (!Enumerable.Any<GameAPP.LastCards>(lastCards, func))
				{
					continue;
				}
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_014A;
			}
			Predicate<CardUI> predicate;
			if (InGameBtn.<>c.<>9__16_0 == 0)
			{
				InGameBtn.<>c.<>9__16_0 = predicate;
			}
			int num3 = list.RemoveAll(predicate);
			List<GameAPP.LastCards> lastCards2 = GameAPP.lastCards;
			bool flag3;
			if (flag3)
			{
				InGameBtn.<>c__DisplayClass16_1 CS$<>8__locals2;
				CS$<>8__locals2.item = num;
				Func<CardUI, bool> func2 = delegate(CardUI card)
				{
					GameAPP.LastCards item = CS$<>8__locals2.item;
					if (card.theSeedType != item)
					{
					}
					bool isExtra = CS$<>8__locals2.item.isExtra;
					return card.isExtra == isExtra;
				};
				CardUI cardUI = Enumerable.FirstOrDefault<CardUI>(list, func2);
				int num4 = 0;
				if (!(cardUI != num4))
				{
					continue;
				}
				Board instance2 = Board.Instance;
				int theSeedType = cardUI.theSeedType;
				bool flag4;
				while (flag4)
				{
				}
				cardUI.isSelected = true;
				InGameUI instance3 = InGameUI.Instance;
				int num5 = 0;
				bool flag5 = instance3.AddCardToBank(cardUI, num5 != 0);
				int theSeedType2 = cardUI.theSeedType;
				bool flag6;
				while (!flag6)
				{
				}
				cardUI.isSelected = true;
				InGameUI instance4 = InGameUI.Instance;
				int num6 = 0;
				bool flag7 = instance4.AddCardToBank(cardUI, num6 != 0);
			}
		}
		while (num7 != (ulong)0L);
		return;
		IL_014A:
		throw new NullReferenceException();
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x000F1698 File Offset: 0x000EF898
	[Token(Token = "0x6002C46")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public InGameBtn()
	{
	}

	// Token: 0x04001A28 RID: 6696
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A28")]
	public Sprite highLightSprite;

	// Token: 0x04001A29 RID: 6697
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A29")]
	public int buttonNumber;

	// Token: 0x04001A2A RID: 6698
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A2A")]
	public GameObject thisMenu;

	// Token: 0x04001A2B RID: 6699
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A2B")]
	public Vector3 originPosition;

	// Token: 0x04001A2C RID: 6700
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A2C")]
	private Sprite originSprite;

	// Token: 0x04001A2D RID: 6701
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A2D")]
	private Image image;

	// Token: 0x04001A2E RID: 6702
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A2E")]
	private RectTransform rectTransform;

	// Token: 0x04001A2F RID: 6703
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A2F")]
	private bool existItemOnMouse;
}
