using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000861 RID: 2145
[Token(Token = "0x2000861")]
public class NormalBtn : MonoBehaviour
{
	// Token: 0x06002BD7 RID: 11223 RVA: 0x000F0814 File Offset: 0x000EEA14
	[Token(Token = "0x6002BD7")]
	[Address(RVA = "0x66DC00", Offset = "0x66C200", VA = "0x18066DC00")]
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

	// Token: 0x06002BD8 RID: 11224 RVA: 0x000F0864 File Offset: 0x000EEA64
	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x66DB00", Offset = "0x66C100", VA = "0x18066DB00")]
	private void OnMouseEnter()
	{
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		Sprite sprite = this.highLightSprite;
		spriteRenderer.sprite = sprite;
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x000F0894 File Offset: 0x000EEA94
	[Token(Token = "0x6002BD9")]
	[Address(RVA = "0x66DB30", Offset = "0x66C130", VA = "0x18066DB30")]
	private void OnMouseExit()
	{
		Transform transform = base.transform;
		float z = this.originPosition.z;
		SpriteRenderer spriteRenderer = this.spriteRenderer;
		Sprite sprite = this.originSprite;
		spriteRenderer.sprite = sprite;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002BDA RID: 11226 RVA: 0x000F08D8 File Offset: 0x000EEAD8
	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x66DA20", Offset = "0x66C020", VA = "0x18066DA20")]
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

	// Token: 0x06002BDB RID: 11227 RVA: 0x000F0918 File Offset: 0x000EEB18
	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x66DB90", Offset = "0x66C190", VA = "0x18066DB90", Slot = "4")]
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

	// Token: 0x06002BDC RID: 11228 RVA: 0x000F0958 File Offset: 0x000EEB58
	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public NormalBtn()
	{
	}

	// Token: 0x04001A02 RID: 6658
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A02")]
	public Sprite highLightSprite;

	// Token: 0x04001A03 RID: 6659
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A03")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x04001A04 RID: 6660
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A04")]
	private Sprite originSprite;

	// Token: 0x04001A05 RID: 6661
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A05")]
	private Vector3 originPosition;

	// Token: 0x04001A06 RID: 6662
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A06")]
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001A07 RID: 6663
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A07")]
	public UnityEvent clickEvent;
}
