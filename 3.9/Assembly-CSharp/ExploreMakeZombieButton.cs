using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020007F8 RID: 2040
[Token(Token = "0x20007F8")]
public class ExploreMakeZombieButton : TheButton
{
	// Token: 0x06002945 RID: 10565 RVA: 0x000DEFA4 File Offset: 0x000DD1A4
	[Token(Token = "0x6002945")]
	[Address(RVA = "0x693400", Offset = "0x691A00", VA = "0x180693400")]
	private void Start()
	{
		ExploreMakeMenu instance = ExploreMakeMenu.Instance;
		this.menu = instance;
		string name = Lawnf.GetName(this.theZombieType);
		ZombieType zombieType = this.theZombieType;
		TextMeshProUGUI textMeshProUGUI = this.sceneText;
		string text = string.Format("({0})", name);
		string text2 = name + text;
		textMeshProUGUI.text = text2;
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x000DF000 File Offset: 0x000DD200
	[Token(Token = "0x6002946")]
	[Address(RVA = "0x693280", Offset = "0x691880", VA = "0x180693280", Slot = "11")]
	public override void OnPointerDown(PointerEventData eventData)
	{
		base.OnPointerDown(eventData);
		ExploreMakeZombieButton[] componentsInChildren = this.menu.selectedZombieContent.GetComponentsInChildren<ExploreMakeZombieButton>();
		if (!this.selected)
		{
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				ZombieType zombieType = this.theZombieType;
				num++;
			}
			RectTransform selectedZombieContent = this.menu.selectedZombieContent;
			global::UnityEngine.Object.Instantiate<ExploreMakeZombieButton>(this, selectedZombieContent).selected = true;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		CursorChange.SetDefaultCursor();
		this.menu.UpdateContentSize();
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x000DF088 File Offset: 0x000DD288
	[Token(Token = "0x6002947")]
	[Address(RVA = "0x67D810", Offset = "0x67BE10", VA = "0x18067D810")]
	public ExploreMakeZombieButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001759 RID: 5977
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001759")]
	public ZombieType theZombieType;

	// Token: 0x0400175A RID: 5978
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400175A")]
	public TextMeshProUGUI sceneText;

	// Token: 0x0400175B RID: 5979
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400175B")]
	public bool selected;

	// Token: 0x0400175C RID: 5980
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400175C")]
	private ExploreMakeMenu menu;
}
