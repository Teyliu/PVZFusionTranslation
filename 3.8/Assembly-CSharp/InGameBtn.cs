using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000843 RID: 2115
[Token(Token = "0x2000843")]
public class InGameBtn : MonoBehaviour
{
	// Token: 0x06002B0B RID: 11019 RVA: 0x000EC298 File Offset: 0x000EA498
	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x65EA90", Offset = "0x65D090", VA = "0x18065EA90")]
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

	// Token: 0x06002B0C RID: 11020 RVA: 0x000EC2F8 File Offset: 0x000EA4F8
	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x65D8A0", Offset = "0x65BEA0", VA = "0x18065D8A0")]
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

	// Token: 0x06002B0D RID: 11021 RVA: 0x000EC364 File Offset: 0x000EA564
	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x65D990", Offset = "0x65BF90", VA = "0x18065D990")]
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

	// Token: 0x06002B0E RID: 11022 RVA: 0x000EC3A8 File Offset: 0x000EA5A8
	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x65DA00", Offset = "0x65C000", VA = "0x18065DA00")]
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

	// Token: 0x06002B0F RID: 11023 RVA: 0x000EC564 File Offset: 0x000EA764
	[Token(Token = "0x6002B0F")]
	[Address(RVA = "0x65D780", Offset = "0x65BD80", VA = "0x18065D780")]
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

	// Token: 0x06002B10 RID: 11024 RVA: 0x000EC5A4 File Offset: 0x000EA7A4
	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x65EB60", Offset = "0x65D160", VA = "0x18065EB60")]
	private void Update()
	{
		if (this.buttonNumber == 3 && Input.GetKeyDownInt(KeyCodeManager.SlowTrigger))
		{
			this.SpeedTrigger();
			return;
		}
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x000EC5D0 File Offset: 0x000EA7D0
	[Token(Token = "0x6002B11")]
	[Address(RVA = "0x65E190", Offset = "0x65C790", VA = "0x18065E190")]
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

	// Token: 0x06002B12 RID: 11026 RVA: 0x000EC7E8 File Offset: 0x000EA9E8
	[Token(Token = "0x6002B12")]
	[Address(RVA = "0x65EA00", Offset = "0x65D000", VA = "0x18065EA00")]
	private void SpeedTrigger()
	{
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x000EC820 File Offset: 0x000EAA20
	[Token(Token = "0x6002B13")]
	[Address(RVA = "0x65D020", Offset = "0x65B620", VA = "0x18065D020")]
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
				goto IL_013B;
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
				Func<CardUI, bool> func2;
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
		IL_013B:
		throw new NullReferenceException();
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x000EC98C File Offset: 0x000EAB8C
	[Token(Token = "0x6002B14")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public InGameBtn()
	{
	}

	// Token: 0x0400193A RID: 6458
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400193A")]
	public Sprite highLightSprite;

	// Token: 0x0400193B RID: 6459
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400193B")]
	public int buttonNumber;

	// Token: 0x0400193C RID: 6460
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400193C")]
	public GameObject thisMenu;

	// Token: 0x0400193D RID: 6461
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400193D")]
	public Vector3 originPosition;

	// Token: 0x0400193E RID: 6462
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400193E")]
	private Sprite originSprite;

	// Token: 0x0400193F RID: 6463
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400193F")]
	private Image image;

	// Token: 0x04001940 RID: 6464
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001940")]
	private RectTransform rectTransform;

	// Token: 0x04001941 RID: 6465
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001941")]
	private bool existItemOnMouse;
}
