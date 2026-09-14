using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007FB RID: 2043
[Token(Token = "0x20007FB")]
public class UIButton : MonoBehaviour
{
	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06002956 RID: 10582 RVA: 0x000DF4E0 File Offset: 0x000DD6E0
	// (set) Token: 0x06002957 RID: 10583 RVA: 0x000DF4F4 File Offset: 0x000DD6F4
	[Token(Token = "0x170001E6")]
	public bool Interactable
	{
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x697EC0", Offset = "0x6964C0", VA = "0x180697EC0")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x6980D0", Offset = "0x6966D0", VA = "0x1806980D0")]
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

	// Token: 0x06002958 RID: 10584 RVA: 0x000DF54C File Offset: 0x000DD74C
	[Token(Token = "0x6002958")]
	[Address(RVA = "0x697CF0", Offset = "0x6962F0", VA = "0x180697CF0", Slot = "4")]
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

	// Token: 0x06002959 RID: 10585 RVA: 0x000DF61C File Offset: 0x000DD81C
	[Token(Token = "0x6002959")]
	[Address(RVA = "0x697A40", Offset = "0x696040", VA = "0x180697A40", Slot = "5")]
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

	// Token: 0x0600295A RID: 10586 RVA: 0x000DF660 File Offset: 0x000DD860
	[Token(Token = "0x600295A")]
	[Address(RVA = "0x697850", Offset = "0x695E50", VA = "0x180697850")]
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

	// Token: 0x0600295B RID: 10587 RVA: 0x000DF6B4 File Offset: 0x000DD8B4
	[Token(Token = "0x600295B")]
	[Address(RVA = "0x697AE0", Offset = "0x6960E0", VA = "0x180697AE0", Slot = "6")]
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

	// Token: 0x0600295C RID: 10588 RVA: 0x000DF704 File Offset: 0x000DD904
	[Token(Token = "0x600295C")]
	[Address(RVA = "0x697C30", Offset = "0x696230", VA = "0x180697C30", Slot = "7")]
	protected virtual void OnMouseUp()
	{
		if (this._interactable)
		{
			RectTransform rectTransform = this.rectTransform;
			return;
		}
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x000DF72C File Offset: 0x000DD92C
	[Token(Token = "0x600295D")]
	[Address(RVA = "0x697900", Offset = "0x695F00", VA = "0x180697900", Slot = "8")]
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

	// Token: 0x0600295E RID: 10590 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
	[Token(Token = "0x600295E")]
	[Address(RVA = "0x697B80", Offset = "0x696180", VA = "0x180697B80", Slot = "9")]
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

	// Token: 0x0600295F RID: 10591 RVA: 0x000DF800 File Offset: 0x000DDA00
	[Token(Token = "0x600295F")]
	[Address(RVA = "0x6977A0", Offset = "0x695DA0", VA = "0x1806977A0")]
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

	// Token: 0x06002960 RID: 10592 RVA: 0x000DF850 File Offset: 0x000DDA50
	[Token(Token = "0x6002960")]
	[Address(RVA = "0x697820", Offset = "0x695E20", VA = "0x180697820")]
	public void OnDisSelect()
	{
		GameObject gameObject = this.selectedLight;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x000DF874 File Offset: 0x000DDA74
	[Token(Token = "0x6002961")]
	[Address(RVA = "0x697C80", Offset = "0x696280", VA = "0x180697C80")]
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

	// Token: 0x06002962 RID: 10594 RVA: 0x000DF8A8 File Offset: 0x000DDAA8
	[Token(Token = "0x6002962")]
	[Address(RVA = "0x697780", Offset = "0x695D80", VA = "0x180697780")]
	public void Confirm()
	{
		UnityEvent unityEvent = this.clickEvent;
		if (unityEvent != 0)
		{
			unityEvent.Invoke();
			return;
		}
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000DF8C8 File Offset: 0x000DDAC8
	[Token(Token = "0x6002963")]
	[Address(RVA = "0x694D80", Offset = "0x693380", VA = "0x180694D80")]
	public UIButton()
	{
	}

	// Token: 0x04001767 RID: 5991
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001767")]
	public UnityEvent clickEvent;

	// Token: 0x04001768 RID: 5992
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001768")]
	public UnityEvent<UIButton> onSelect;

	// Token: 0x04001769 RID: 5993
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001769")]
	public Sprite highLightSprite;

	// Token: 0x0400176A RID: 5994
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400176A")]
	public Image image;

	// Token: 0x0400176B RID: 5995
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400176B")]
	public ButtonSoundType buttonSoundType;

	// Token: 0x0400176C RID: 5996
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400176C")]
	public RectTransform rectTransform;

	// Token: 0x0400176D RID: 5997
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400176D")]
	public bool useLight;

	// Token: 0x0400176E RID: 5998
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400176E")]
	public GameObject selectedLight;

	// Token: 0x0400176F RID: 5999
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400176F")]
	private Sprite originSprite;

	// Token: 0x04001770 RID: 6000
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001770")]
	protected Vector3 originPosition;

	// Token: 0x04001771 RID: 6001
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001771")]
	private bool _interactable = true;
}
