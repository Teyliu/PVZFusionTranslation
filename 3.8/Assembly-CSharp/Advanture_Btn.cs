using System;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020007C7 RID: 1991
[Token(Token = "0x20007C7")]
public class Advanture_Btn : MonoBehaviour
{
	// Token: 0x06002840 RID: 10304 RVA: 0x000DABE8 File Offset: 0x000D8DE8
	[Token(Token = "0x6002840")]
	[Address(RVA = "0x61F970", Offset = "0x61DF70", VA = "0x18061F970")]
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

	// Token: 0x06002841 RID: 10305 RVA: 0x000DAC84 File Offset: 0x000D8E84
	[Token(Token = "0x6002841")]
	[Address(RVA = "0x61F260", Offset = "0x61D860", VA = "0x18061F260")]
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

	// Token: 0x06002842 RID: 10306 RVA: 0x000DAD44 File Offset: 0x000D8F44
	[Token(Token = "0x6002842")]
	[Address(RVA = "0x61F690", Offset = "0x61DC90", VA = "0x18061F690")]
	private void OnMouseEnter()
	{
		Image image = this.image;
		Sprite sprite = this.highLightSprite;
		image.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x000DAD74 File Offset: 0x000D8F74
	[Token(Token = "0x6002843")]
	[Address(RVA = "0x61F6C0", Offset = "0x61DCC0", VA = "0x18061F6C0")]
	private void OnMouseExit()
	{
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x000DADAC File Offset: 0x000D8FAC
	[Token(Token = "0x6002844")]
	[Address(RVA = "0x61F5F0", Offset = "0x61DBF0", VA = "0x18061F5F0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(29, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x000DADD8 File Offset: 0x000D8FD8
	[Token(Token = "0x6002845")]
	[Address(RVA = "0x61F720", Offset = "0x61DD20", VA = "0x18061F720", Slot = "4")]
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

	// Token: 0x06002846 RID: 10310 RVA: 0x000DAEE0 File Offset: 0x000D90E0
	[Token(Token = "0x6002846")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Advanture_Btn()
	{
	}

	// Token: 0x0400169A RID: 5786
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400169A")]
	public Sprite highLightSprite;

	// Token: 0x0400169B RID: 5787
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400169B")]
	public LevelType levelType;

	// Token: 0x0400169C RID: 5788
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400169C")]
	public int buttonNumber;

	// Token: 0x0400169D RID: 5789
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400169D")]
	public GameObject thisMenu;

	// Token: 0x0400169E RID: 5790
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400169E")]
	public ClgLevelMgr levelCtrl;

	// Token: 0x0400169F RID: 5791
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400169F")]
	private Sprite originSprite;

	// Token: 0x040016A0 RID: 5792
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016A0")]
	private Image image;

	// Token: 0x040016A1 RID: 5793
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016A1")]
	private Vector3 originPosition;

	// Token: 0x040016A2 RID: 5794
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016A2")]
	private RectTransform rectTransform;

	// Token: 0x040016A3 RID: 5795
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016A3")]
	public bool limInMobile;

	// Token: 0x040016A4 RID: 5796
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40016A4")]
	public bool randomLevel;
}
