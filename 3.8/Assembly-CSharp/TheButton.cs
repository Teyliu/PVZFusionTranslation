using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020007C1 RID: 1985
[Token(Token = "0x20007C1")]
public class TheButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
	// Token: 0x1700019B RID: 411
	// (get) Token: 0x0600281D RID: 10269 RVA: 0x000DA22C File Offset: 0x000D842C
	// (set) Token: 0x0600281E RID: 10270 RVA: 0x000DA240 File Offset: 0x000D8440
	[Token(Token = "0x1700019B")]
	public bool Interactable
	{
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x6316A0", Offset = "0x62FCA0", VA = "0x1806316A0")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x6316B0", Offset = "0x62FCB0", VA = "0x1806316B0")]
		set
		{
			Image image = this.image;
			this._interactable = value;
			int num = 0;
			if (!(image == num))
			{
				if (value)
				{
				}
				Image image2 = this.image;
				TextMeshProUGUI componentInChildren = this.image.GetComponentInChildren<TextMeshProUGUI>();
				int num2 = 0;
				if (!(componentInChildren == num2))
				{
				}
			}
		}
	}

	// Token: 0x0600281F RID: 10271 RVA: 0x000DA298 File Offset: 0x000D8498
	[Token(Token = "0x600281F")]
	[Address(RVA = "0x631170", Offset = "0x62F770", VA = "0x180631170")]
	private void Awake()
	{
		Image image = this.image;
		int num = 0;
		if (!(image != num))
		{
			Image component = base.GetComponent<Image>();
			this.image = component;
			Image image2 = this.image;
			int num2 = 0;
			if (!(image2 != num2))
			{
				return;
			}
		}
		Sprite sprite = this.image.m_Sprite;
		this.originalSprite = sprite;
		Sprite sprite2 = this.highLightSprite;
		int num3 = 0;
		if (sprite2 == num3)
		{
			Sprite sprite3 = this.image.m_Sprite;
			this.highLightSprite = sprite3;
		}
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x000DA324 File Offset: 0x000D8524
	[Token(Token = "0x6002820")]
	[Address(RVA = "0x6314A0", Offset = "0x62FAA0", VA = "0x1806314A0", Slot = "9")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		if (this._interactable)
		{
			CursorChange.SetClickCursor();
			Image image = this.image;
			int num = 0;
			if (image != num)
			{
				Image image2 = this.image;
				Sprite sprite = this.highLightSprite;
				image2.sprite = sprite;
				return;
			}
		}
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x000DA374 File Offset: 0x000D8574
	[Token(Token = "0x6002821")]
	[Address(RVA = "0x631530", Offset = "0x62FB30", VA = "0x180631530", Slot = "10")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
		if (this._interactable)
		{
			CursorChange.SetDefaultCursor();
			Image image = this.image;
			int num = 0;
			if (image != num)
			{
				Image image2 = this.image;
				Sprite sprite = this.originalSprite;
				image2.sprite = sprite;
				return;
			}
		}
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x000DA3C4 File Offset: 0x000D85C4
	[Token(Token = "0x6002822")]
	[Address(RVA = "0x631360", Offset = "0x62F960", VA = "0x180631360", Slot = "11")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
		if (this._interactable)
		{
			RectTransform rectTransform = this.background;
			int num = 0;
			if (!(rectTransform != num))
			{
				Transform transform = base.transform;
			}
			RectTransform rectTransform2 = this.background;
			int num2 = 0;
			Vector2 anchoredPosition = rectTransform2.anchoredPosition;
			rectTransform2.anchoredPosition = num2;
			UnityEvent unityEvent = this.theEvent;
			if (unityEvent != 0)
			{
				unityEvent.Invoke();
			}
		}
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x000DA42C File Offset: 0x000D862C
	[Token(Token = "0x6002823")]
	[Address(RVA = "0x6315C0", Offset = "0x62FBC0", VA = "0x1806315C0", Slot = "7")]
	public void OnPointerUp(PointerEventData eventData)
	{
		if (this._interactable)
		{
			RectTransform rectTransform = this.background;
			int num = 0;
			if (rectTransform != num)
			{
				throw new NullReferenceException();
			}
			Transform transform = base.transform;
		}
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x000DA468 File Offset: 0x000D8668
	[Token(Token = "0x6002824")]
	[Address(RVA = "0x631340", Offset = "0x62F940", VA = "0x180631340", Slot = "12")]
	public virtual void OnPointerClick(PointerEventData eventData)
	{
		if (this._interactable)
		{
			UnityEvent unityEvent = this.theEvent_up;
			if (unityEvent != 0)
			{
				unityEvent.Invoke();
				return;
			}
		}
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x000DA490 File Offset: 0x000D8690
	[Token(Token = "0x6002825")]
	[Address(RVA = "0x631290", Offset = "0x62F890", VA = "0x180631290")]
	private void OnDisable()
	{
		Image image = this.image;
		int num = 0;
		if (image != num)
		{
			Sprite sprite = this.originalSprite;
			int num2 = 0;
			if (sprite != num2)
			{
				Image image2 = this.image;
				Sprite sprite2 = this.originalSprite;
				image2.sprite = sprite2;
			}
		}
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x000DA4E4 File Offset: 0x000D86E4
	[Token(Token = "0x6002826")]
	[Address(RVA = "0x619F70", Offset = "0x618570", VA = "0x180619F70")]
	public TheButton()
	{
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001682 RID: 5762
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001682")]
	public UnityEvent theEvent;

	// Token: 0x04001683 RID: 5763
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001683")]
	public UnityEvent theEvent_up;

	// Token: 0x04001684 RID: 5764
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001684")]
	public Image image;

	// Token: 0x04001685 RID: 5765
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001685")]
	public Sprite highLightSprite;

	// Token: 0x04001686 RID: 5766
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001686")]
	public bool grave = true;

	// Token: 0x04001687 RID: 5767
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001687")]
	public RectTransform background;

	// Token: 0x04001688 RID: 5768
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001688")]
	private readonly Vector2 clickOffset = (ulong)1065353216L;

	// Token: 0x04001689 RID: 5769
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001689")]
	private Sprite originalSprite;

	// Token: 0x0400168A RID: 5770
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400168A")]
	private bool _interactable;
}
