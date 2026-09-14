using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020007BF RID: 1983
[Token(Token = "0x20007BF")]
public class ExploreMakeZombieButton : TheButton
{
	// Token: 0x06002816 RID: 10262 RVA: 0x000D9FE8 File Offset: 0x000D81E8
	[Token(Token = "0x6002816")]
	[Address(RVA = "0x62F650", Offset = "0x62DC50", VA = "0x18062F650")]
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

	// Token: 0x06002817 RID: 10263 RVA: 0x000DA044 File Offset: 0x000D8244
	[Token(Token = "0x6002817")]
	[Address(RVA = "0x62F4D0", Offset = "0x62DAD0", VA = "0x18062F4D0", Slot = "11")]
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

	// Token: 0x06002818 RID: 10264 RVA: 0x000DA0CC File Offset: 0x000D82CC
	[Token(Token = "0x6002818")]
	[Address(RVA = "0x619F70", Offset = "0x618570", VA = "0x180619F70")]
	public ExploreMakeZombieButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x0400167D RID: 5757
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400167D")]
	public ZombieType theZombieType;

	// Token: 0x0400167E RID: 5758
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400167E")]
	public TextMeshProUGUI sceneText;

	// Token: 0x0400167F RID: 5759
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400167F")]
	public bool selected;

	// Token: 0x04001680 RID: 5760
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001680")]
	private ExploreMakeMenu menu;
}
