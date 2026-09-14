using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200089C RID: 2204
[Token(Token = "0x200089C")]
public class UIBtn : MonoBehaviour
{
	// Token: 0x06002CF0 RID: 11504 RVA: 0x000F7CC8 File Offset: 0x000F5EC8
	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x694920", Offset = "0x692F20", VA = "0x180694920", Slot = "4")]
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

	// Token: 0x06002CF1 RID: 11505 RVA: 0x000F7D18 File Offset: 0x000F5F18
	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x61F690", Offset = "0x61DC90", VA = "0x18061F690", Slot = "5")]
	protected virtual void OnMouseEnter()
	{
		Image image = this.image;
		Sprite sprite = this.highLightSprite;
		image.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x000F7D48 File Offset: 0x000F5F48
	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x694A90", Offset = "0x693090", VA = "0x180694A90", Slot = "6")]
	protected virtual void OnMouseExit()
	{
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x000F7D80 File Offset: 0x000F5F80
	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x6949C0", Offset = "0x692FC0", VA = "0x1806949C0")]
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

	// Token: 0x06002CF4 RID: 11508 RVA: 0x000F7DBC File Offset: 0x000F5FBC
	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x694AF0", Offset = "0x6930F0", VA = "0x180694AF0", Slot = "7")]
	protected virtual void OnMouseUpAsButton()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
		Image image = this.image;
		Sprite sprite = this.originSprite;
		image.sprite = sprite;
		this.clickEvent.Invoke();
	}

	// Token: 0x06002CF5 RID: 11509 RVA: 0x000F7E00 File Offset: 0x000F6000
	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UIBtn()
	{
	}

	// Token: 0x04001B0D RID: 6925
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B0D")]
	public Sprite highLightSprite;

	// Token: 0x04001B0E RID: 6926
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B0E")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x04001B0F RID: 6927
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B0F")]
	public RectTransform rectTransform;

	// Token: 0x04001B10 RID: 6928
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B10")]
	public UnityEvent clickEvent;

	// Token: 0x04001B11 RID: 6929
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B11")]
	private Sprite originSprite;

	// Token: 0x04001B12 RID: 6930
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B12")]
	private Image image;

	// Token: 0x04001B13 RID: 6931
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B13")]
	private Vector3 originPosition;
}
