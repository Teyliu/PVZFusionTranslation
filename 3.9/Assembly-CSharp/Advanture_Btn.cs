using System;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000800 RID: 2048
[Token(Token = "0x2000800")]
public class Advanture_Btn : MonoBehaviour
{
	// Token: 0x0600296F RID: 10607 RVA: 0x000DFBA4 File Offset: 0x000DDDA4
	[Token(Token = "0x600296F")]
	[Address(RVA = "0x683260", Offset = "0x681860", VA = "0x180683260")]
	private void Start()
	{
		if (!string.Equals(base.name, "Window"))
		{
			RectTransform component = base.GetComponent<RectTransform>();
		}
		RectTransform component2 = base.transform.parent.gameObject.GetComponent<RectTransform>();
		this.rectTransform = component2;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
		Image component3 = base.GetComponent<Image>();
		this.image = component3;
		Sprite sprite = this.image.m_Sprite;
		this.originSprite = sprite;
		if (this.buttonNumber > 0)
		{
			this.CheckTropy();
			return;
		}
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x000DFC40 File Offset: 0x000DDE40
	[Token(Token = "0x6002970")]
	[Address(RVA = "0x682B50", Offset = "0x681150", VA = "0x180682B50")]
	private void CheckTropy()
	{
		if (!this.randomLevel)
		{
			uint num;
			Transform child = base.transform.GetChild((int)num);
			GameObject gameObject = child.gameObject;
			if (this.levelType <= LevelType.StarAdvanture)
			{
				if (this.buttonNumber != 52)
				{
					bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
					int num2 = this.buttonNumber;
				}
				bool[] clgLevelCompleted2 = GameAPP.clgLevelCompleted;
				if ("{il2cpp array field local12->}" != (ulong)0L)
				{
					ulong num3;
					gameObject.SetActive(num3 != 0UL);
				}
			}
		}
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000DFD00 File Offset: 0x000DDF00
	[Token(Token = "0x6002971")]
	[Address(RVA = "0x682F80", Offset = "0x681580", VA = "0x180682F80")]
	private void OnMouseEnter()
	{
		Image image = this.image;
		Sprite sprite = this.highLightSprite;
		image.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000DFD30 File Offset: 0x000DDF30
	[Token(Token = "0x6002972")]
	[Address(RVA = "0x682FB0", Offset = "0x6815B0", VA = "0x180682FB0")]
	private void OnMouseExit()
	{
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000DFD68 File Offset: 0x000DDF68
	[Token(Token = "0x6002973")]
	[Address(RVA = "0x682EE0", Offset = "0x6814E0", VA = "0x180682EE0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(29, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x000DFD94 File Offset: 0x000DDF94
	[Token(Token = "0x6002974")]
	[Address(RVA = "0x683010", Offset = "0x681610", VA = "0x180683010", Slot = "4")]
	protected virtual void OnMouseUp()
	{
		RectTransform rectTransform = this.rectTransform;
		int num = this.buttonNumber;
		num += 3;
		if (rectTransform == 0)
		{
			ClgLevelMgr clgLevelMgr = this.levelCtrl;
			while (clgLevelMgr.currentPage <= 0)
			{
			}
			int currentPage = clgLevelMgr.currentPage;
			clgLevelMgr.ChangePage(currentPage);
			return;
		}
		if (rectTransform == 0)
		{
			ClgLevelMgr clgLevelMgr2 = this.levelCtrl;
			while (clgLevelMgr2.currentPage >= 2)
			{
			}
			int num2 = clgLevelMgr2.currentPage;
			num2++;
			clgLevelMgr2.ChangePage(num2);
			return;
		}
		if (num == 1)
		{
			CursorChange.SetDefaultCursor();
			UIMgr.EnterMainMenu();
			return;
		}
		CursorChange.SetDefaultCursor();
		if (this.levelType == LevelType.Survival)
		{
			int num3 = this.buttonNumber;
			return;
		}
		if (!this.randomLevel)
		{
			int num4 = this.buttonNumber;
			int num5 = 0;
			uint num6;
			UIMgr.EnterGame(this.levelType, num4, (int)num6, num5);
			return;
		}
		Array values = Enum.GetValues(typeof(ChallengeLevel));
		if (values == 0 || values != 0)
		{
			ChallengeLevel random = ListExtensions.GetRandom<ChallengeLevel>(Enumerable.ToList<ChallengeLevel>(values));
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x000DFE9C File Offset: 0x000DE09C
	[Token(Token = "0x6002975")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Advanture_Btn()
	{
	}

	// Token: 0x04001776 RID: 6006
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001776")]
	public Sprite highLightSprite;

	// Token: 0x04001777 RID: 6007
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001777")]
	public LevelType levelType;

	// Token: 0x04001778 RID: 6008
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001778")]
	public int buttonNumber;

	// Token: 0x04001779 RID: 6009
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001779")]
	public GameObject thisMenu;

	// Token: 0x0400177A RID: 6010
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400177A")]
	public ClgLevelMgr levelCtrl;

	// Token: 0x0400177B RID: 6011
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400177B")]
	private Sprite originSprite;

	// Token: 0x0400177C RID: 6012
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400177C")]
	private Image image;

	// Token: 0x0400177D RID: 6013
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400177D")]
	private Vector3 originPosition;

	// Token: 0x0400177E RID: 6014
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400177E")]
	private RectTransform rectTransform;

	// Token: 0x0400177F RID: 6015
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400177F")]
	public bool limInMobile;

	// Token: 0x04001780 RID: 6016
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4001780")]
	public bool randomLevel;
}
