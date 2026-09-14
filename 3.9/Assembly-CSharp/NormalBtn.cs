using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200089D RID: 2205
[Token(Token = "0x200089D")]
public class NormalBtn : MonoBehaviour
{
	// Token: 0x06002D09 RID: 11529 RVA: 0x000F54A4 File Offset: 0x000F36A4
	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x6D2740", Offset = "0x6D0D40", VA = "0x1806D2740")]
	private void Start()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.originPosition.z = z;
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.spriteRenderer = component;
		Sprite sprite = this.spriteRenderer.sprite;
		this.originSprite = sprite;
		throw new NullReferenceException();
	}

	// Token: 0x06002D0A RID: 11530 RVA: 0x000F54F4 File Offset: 0x000F36F4
	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x6D2640", Offset = "0x6D0C40", VA = "0x1806D2640")]
	private void OnMouseEnter()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		Sprite sprite = this.highLightSprite;
		spriteRenderer.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x000F5524 File Offset: 0x000F3724
	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x6D2670", Offset = "0x6D0C70", VA = "0x1806D2670")]
	private void OnMouseExit()
	{
		Transform transform = base.transform;
		float z = this.originPosition.z;
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		Sprite sprite = this.originSprite;
		spriteRenderer.sprite = sprite;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002D0C RID: 11532 RVA: 0x000F5568 File Offset: 0x000F3768
	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x6D2560", Offset = "0x6D0B60", VA = "0x1806D2560")]
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
		Transform transform = base.transform;
	}

	// Token: 0x06002D0D RID: 11533 RVA: 0x000F55A8 File Offset: 0x000F37A8
	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x6D26D0", Offset = "0x6D0CD0", VA = "0x1806D26D0", Slot = "4")]
	protected virtual void OnMouseUpAsButton()
	{
		CursorChange.SetDefaultCursor();
		Transform transform = base.transform;
		float z = this.originPosition.z;
		UnityEvent unityEvent = this.clickEvent;
		if (unityEvent != 0)
		{
			unityEvent.Invoke();
			return;
		}
	}

	// Token: 0x06002D0E RID: 11534 RVA: 0x000F55E8 File Offset: 0x000F37E8
	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public NormalBtn()
	{
	}

	// Token: 0x04001AF0 RID: 6896
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001AF0")]
	public Sprite highLightSprite;

	// Token: 0x04001AF1 RID: 6897
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001AF1")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x04001AF2 RID: 6898
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001AF2")]
	private Sprite originSprite;

	// Token: 0x04001AF3 RID: 6899
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001AF3")]
	private Vector3 originPosition;

	// Token: 0x04001AF4 RID: 6900
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AF4")]
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001AF5 RID: 6901
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AF5")]
	public UnityEvent clickEvent;
}
