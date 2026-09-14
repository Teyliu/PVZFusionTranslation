using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020008D8 RID: 2264
[Token(Token = "0x20008D8")]
public class UIBtn : MonoBehaviour
{
	// Token: 0x06002E22 RID: 11810 RVA: 0x000FC838 File Offset: 0x000FAA38
	[Token(Token = "0x6002E22")]
	[Address(RVA = "0x70E8E0", Offset = "0x70CEE0", VA = "0x18070E8E0", Slot = "4")]
	protected virtual void Awake()
	{
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
		Image component = base.GetComponent<Image>();
		this.image = component;
		Sprite sprite = this.image.m_Sprite;
		this.originSprite = sprite;
		throw new NullReferenceException();
	}

	// Token: 0x06002E23 RID: 11811 RVA: 0x000FC888 File Offset: 0x000FAA88
	[Token(Token = "0x6002E23")]
	[Address(RVA = "0x682F80", Offset = "0x681580", VA = "0x180682F80", Slot = "5")]
	protected virtual void OnMouseEnter()
	{
		Image image = this.image;
		Sprite sprite = this.highLightSprite;
		image.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002E24 RID: 11812 RVA: 0x000FC8B8 File Offset: 0x000FAAB8
	[Token(Token = "0x6002E24")]
	[Address(RVA = "0x70EA50", Offset = "0x70D050", VA = "0x18070EA50", Slot = "6")]
	protected virtual void OnMouseExit()
	{
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002E25 RID: 11813 RVA: 0x000FC8F0 File Offset: 0x000FAAF0
	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x70E980", Offset = "0x70CF80", VA = "0x18070E980")]
	private void OnMouseDown()
	{
		ButtonSoundType buttonSoundType = this.buttonSoundType;
		if (buttonSoundType == ButtonSoundType.Default)
		{
		}
		if (buttonSoundType == ButtonSoundType.Grave)
		{
			GameAPP.PlaySound(28, 0.5f, 1f);
		}
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002E26 RID: 11814 RVA: 0x000FC92C File Offset: 0x000FAB2C
	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x70EAB0", Offset = "0x70D0B0", VA = "0x18070EAB0", Slot = "7")]
	protected virtual void OnMouseUpAsButton()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		this.clickEvent.Invoke();
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x000FC970 File Offset: 0x000FAB70
	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UIBtn()
	{
	}

	// Token: 0x04001BFB RID: 7163
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001BFB")]
	public Sprite highLightSprite;

	// Token: 0x04001BFC RID: 7164
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001BFC")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x04001BFD RID: 7165
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001BFD")]
	public RectTransform rectTransform;

	// Token: 0x04001BFE RID: 7166
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001BFE")]
	public UnityEvent clickEvent;

	// Token: 0x04001BFF RID: 7167
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BFF")]
	private Sprite originSprite;

	// Token: 0x04001C00 RID: 7168
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001C00")]
	private Image image;

	// Token: 0x04001C01 RID: 7169
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001C01")]
	private Vector3 originPosition;
}
