using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007C2 RID: 1986
[Token(Token = "0x20007C2")]
public class UIButton : MonoBehaviour
{
	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06002827 RID: 10279 RVA: 0x000DA524 File Offset: 0x000D8724
	// (set) Token: 0x06002828 RID: 10280 RVA: 0x000DA538 File Offset: 0x000D8738
	[Token(Token = "0x1700019C")]
	public bool Interactable
	{
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x633B90", Offset = "0x632190", VA = "0x180633B90")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x633DA0", Offset = "0x6323A0", VA = "0x180633DA0")]
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

	// Token: 0x06002829 RID: 10281 RVA: 0x000DA590 File Offset: 0x000D8790
	[Token(Token = "0x6002829")]
	[Address(RVA = "0x6339C0", Offset = "0x631FC0", VA = "0x1806339C0", Slot = "4")]
	protected virtual void Start()
	{
		RectTransform rectTransform = this.rectTransform;
		int num = 0;
		if (rectTransform == num)
		{
			Transform transform = base.transform;
			int num2 = 0;
			if (transform == 0)
			{
				this.rectTransform = num2;
			}
			this.rectTransform = transform;
		}
		Image image = this.image;
		int num3 = 0;
		bool flag;
		if (!(image == num3) || flag)
		{
			Sprite sprite = this.image.m_Sprite;
			this.originSprite = sprite;
		}
		Sprite sprite2 = this.highLightSprite;
		int num4 = 0;
		if (sprite2 == num4)
		{
			Sprite sprite3 = this.originSprite;
			this.highLightSprite = sprite3;
		}
		if (this.useLight)
		{
			Image image2 = this.image;
			int num5 = 0;
			if (image2 != num5)
			{
				Image image3 = this.image;
				int num6 = 0;
				image3.SetMaterial((MaterialType)num6);
			}
		}
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x000DA660 File Offset: 0x000D8860
	[Token(Token = "0x600282A")]
	[Address(RVA = "0x633710", Offset = "0x631D10", VA = "0x180633710", Slot = "5")]
	protected virtual void OnMouseEnter()
	{
		if (this._interactable)
		{
			CursorChange.SetClickCursor();
			Image image = this.image;
			if (!this.useLight)
			{
				Sprite sprite = this.highLightSprite;
				image.sprite = sprite;
				return;
			}
		}
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x000DA6A4 File Offset: 0x000D88A4
	[Token(Token = "0x600282B")]
	[Address(RVA = "0x633520", Offset = "0x631B20", VA = "0x180633520")]
	private void OnDisable()
	{
		Image image = this.image;
		int num = 0;
		if (image != num)
		{
			Sprite sprite = this.originSprite;
			int num2 = 0;
			if (sprite != num2)
			{
				Image image2 = this.image;
				Sprite sprite2 = this.originSprite;
				image2.sprite = sprite2;
			}
		}
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x000DA6F8 File Offset: 0x000D88F8
	[Token(Token = "0x600282C")]
	[Address(RVA = "0x6337B0", Offset = "0x631DB0", VA = "0x1806337B0", Slot = "6")]
	protected virtual void OnMouseExit()
	{
		if (this._interactable)
		{
			CursorChange.SetDefaultCursor();
			Image image = this.image;
			if (!this.useLight)
			{
				Sprite sprite = this.originSprite;
				image.sprite = sprite;
				return;
			}
			image.SetBrightness(1f);
		}
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000DA748 File Offset: 0x000D8948
	[Token(Token = "0x600282D")]
	[Address(RVA = "0x633900", Offset = "0x631F00", VA = "0x180633900", Slot = "7")]
	protected virtual void OnMouseUp()
	{
		if (this._interactable)
		{
			RectTransform rectTransform = this.rectTransform;
			return;
		}
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x000DA770 File Offset: 0x000D8970
	[Token(Token = "0x600282E")]
	[Address(RVA = "0x6335D0", Offset = "0x631BD0", VA = "0x1806335D0", Slot = "8")]
	protected virtual void OnMouseDown()
	{
		if (this._interactable)
		{
			ButtonSoundType buttonSoundType = this.buttonSoundType;
			if (buttonSoundType == ButtonSoundType.Default || buttonSoundType == ButtonSoundType.Default || buttonSoundType == ButtonSoundType.Grave)
			{
				uint num;
				GameAPP.PlaySound((int)num, 0.5f, 1f);
			}
			RectTransform rectTransform = this.rectTransform;
			int num2 = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			int num3 = 0;
			RectTransform rectTransform2 = this.rectTransform;
			this.originPosition.z = (float)num3;
			rectTransform2.anchoredPosition = num2;
		}
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x000DA7E4 File Offset: 0x000D89E4
	[Token(Token = "0x600282F")]
	[Address(RVA = "0x633850", Offset = "0x631E50", VA = "0x180633850", Slot = "9")]
	protected virtual void OnMouseUpAsButton()
	{
		if (this._interactable)
		{
			RectTransform rectTransform = this.rectTransform;
			if (!this.useLight)
			{
				UnityEvent unityEvent = this.clickEvent;
				while (unityEvent == 0)
				{
				}
				unityEvent.Invoke();
				return;
			}
			this.selectedLight.SetActive(true);
			UnityEvent<UIButton> unityEvent2 = this.onSelect;
			if (unityEvent2 != 0)
			{
				unityEvent2.Invoke(this);
				return;
			}
		}
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x000DA844 File Offset: 0x000D8A44
	[Token(Token = "0x6002830")]
	[Address(RVA = "0x633470", Offset = "0x631A70", VA = "0x180633470")]
	public void OnClicked()
	{
		if (this.useLight)
		{
			this.selectedLight.SetActive(true);
			UnityEvent<UIButton> unityEvent = this.onSelect;
			if (unityEvent != 0)
			{
				unityEvent.Invoke(this);
				return;
			}
		}
		else
		{
			UnityEvent unityEvent2 = this.clickEvent;
			if (unityEvent2 != 0)
			{
				unityEvent2.Invoke();
				return;
			}
		}
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x000DA894 File Offset: 0x000D8A94
	[Token(Token = "0x6002831")]
	[Address(RVA = "0x6334F0", Offset = "0x631AF0", VA = "0x1806334F0")]
	public void OnDisSelect()
	{
		GameObject gameObject = this.selectedLight;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x000DA8B8 File Offset: 0x000D8AB8
	[Token(Token = "0x6002832")]
	[Address(RVA = "0x633950", Offset = "0x631F50", VA = "0x180633950")]
	private void OnSelect()
	{
		this.selectedLight.SetActive(true);
		UnityEvent<UIButton> unityEvent = this.onSelect;
		if (unityEvent != 0)
		{
			unityEvent.Invoke(this);
			return;
		}
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x000DA8EC File Offset: 0x000D8AEC
	[Token(Token = "0x6002833")]
	[Address(RVA = "0x633450", Offset = "0x631A50", VA = "0x180633450")]
	public void Confirm()
	{
		UnityEvent unityEvent = this.clickEvent;
		if (unityEvent != 0)
		{
			unityEvent.Invoke();
			return;
		}
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x000DA90C File Offset: 0x000D8B0C
	[Token(Token = "0x6002834")]
	[Address(RVA = "0x630FB0", Offset = "0x62F5B0", VA = "0x180630FB0")]
	public UIButton()
	{
	}

	// Token: 0x0400168B RID: 5771
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400168B")]
	public UnityEvent clickEvent;

	// Token: 0x0400168C RID: 5772
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400168C")]
	public UnityEvent<UIButton> onSelect;

	// Token: 0x0400168D RID: 5773
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400168D")]
	public Sprite highLightSprite;

	// Token: 0x0400168E RID: 5774
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400168E")]
	public Image image;

	// Token: 0x0400168F RID: 5775
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400168F")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x04001690 RID: 5776
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001690")]
	public RectTransform rectTransform;

	// Token: 0x04001691 RID: 5777
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001691")]
	public bool useLight;

	// Token: 0x04001692 RID: 5778
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001692")]
	public GameObject selectedLight;

	// Token: 0x04001693 RID: 5779
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001693")]
	private Sprite originSprite;

	// Token: 0x04001694 RID: 5780
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001694")]
	protected Vector3 originPosition;

	// Token: 0x04001695 RID: 5781
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001695")]
	private bool _interactable = true;
}
