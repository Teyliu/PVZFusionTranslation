using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020007FA RID: 2042
[Token(Token = "0x20007FA")]
public class TheButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x0600294C RID: 10572 RVA: 0x000DF1E8 File Offset: 0x000DD3E8
	// (set) Token: 0x0600294D RID: 10573 RVA: 0x000DF1FC File Offset: 0x000DD3FC
	[Token(Token = "0x170001E5")]
	public bool Interactable
	{
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x695470", Offset = "0x693A70", VA = "0x180695470")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x695480", Offset = "0x693A80", VA = "0x180695480")]
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

	// Token: 0x0600294E RID: 10574 RVA: 0x000DF254 File Offset: 0x000DD454
	[Token(Token = "0x600294E")]
	[Address(RVA = "0x694F40", Offset = "0x693540", VA = "0x180694F40")]
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

	// Token: 0x0600294F RID: 10575 RVA: 0x000DF2E0 File Offset: 0x000DD4E0
	[Token(Token = "0x600294F")]
	[Address(RVA = "0x695270", Offset = "0x693870", VA = "0x180695270", Slot = "9")]
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

	// Token: 0x06002950 RID: 10576 RVA: 0x000DF330 File Offset: 0x000DD530
	[Token(Token = "0x6002950")]
	[Address(RVA = "0x695300", Offset = "0x693900", VA = "0x180695300", Slot = "10")]
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

	// Token: 0x06002951 RID: 10577 RVA: 0x000DF380 File Offset: 0x000DD580
	[Token(Token = "0x6002951")]
	[Address(RVA = "0x695130", Offset = "0x693730", VA = "0x180695130", Slot = "11")]
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

	// Token: 0x06002952 RID: 10578 RVA: 0x000DF3E8 File Offset: 0x000DD5E8
	[Token(Token = "0x6002952")]
	[Address(RVA = "0x695390", Offset = "0x693990", VA = "0x180695390", Slot = "7")]
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

	// Token: 0x06002953 RID: 10579 RVA: 0x000DF424 File Offset: 0x000DD624
	[Token(Token = "0x6002953")]
	[Address(RVA = "0x695110", Offset = "0x693710", VA = "0x180695110", Slot = "12")]
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

	// Token: 0x06002954 RID: 10580 RVA: 0x000DF44C File Offset: 0x000DD64C
	[Token(Token = "0x6002954")]
	[Address(RVA = "0x695060", Offset = "0x693660", VA = "0x180695060")]
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

	// Token: 0x06002955 RID: 10581 RVA: 0x000DF4A0 File Offset: 0x000DD6A0
	[Token(Token = "0x6002955")]
	[Address(RVA = "0x67D810", Offset = "0x67BE10", VA = "0x18067D810")]
	public TheButton()
	{
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x0400175E RID: 5982
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400175E")]
	public UnityEvent theEvent;

	// Token: 0x0400175F RID: 5983
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400175F")]
	public UnityEvent theEvent_up;

	// Token: 0x04001760 RID: 5984
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001760")]
	public Image image;

	// Token: 0x04001761 RID: 5985
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001761")]
	public Sprite highLightSprite;

	// Token: 0x04001762 RID: 5986
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001762")]
	public bool grave = true;

	// Token: 0x04001763 RID: 5987
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001763")]
	public RectTransform background;

	// Token: 0x04001764 RID: 5988
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001764")]
	private readonly Vector2 clickOffset = (ulong)1065353216L;

	// Token: 0x04001765 RID: 5989
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001765")]
	private Sprite originalSprite;

	// Token: 0x04001766 RID: 5990
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001766")]
	private bool _interactable;
}
