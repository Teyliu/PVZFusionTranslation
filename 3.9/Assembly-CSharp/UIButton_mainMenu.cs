using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020007FC RID: 2044
[Token(Token = "0x20007FC")]
public class UIButton_mainMenu : UIButton
{
	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06002964 RID: 10596 RVA: 0x000DF8E4 File Offset: 0x000DDAE4
	// (set) Token: 0x06002965 RID: 10597 RVA: 0x000DF8F8 File Offset: 0x000DDAF8
	[Token(Token = "0x170001E7")]
	public MainMenu.ButtonState State
	{
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x698010", Offset = "0x696610", VA = "0x180698010")]
		get
		{
			return this._state;
		}
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x698020", Offset = "0x696620", VA = "0x180698020")]
		set
		{
			if (value != MainMenu.ButtonState.Default)
			{
				if (value != MainMenu.ButtonState.Default)
				{
					if (value != MainMenu.ButtonState.Hide)
					{
						goto IL_0033;
					}
					Image image = this.image;
				}
				GameObject gameObject = base.gameObject;
			}
			Image image2 = this.image;
			ulong num;
			base.gameObject.SetActive(num != 0UL);
			IL_0033:
			this._state = value;
		}
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x000DF948 File Offset: 0x000DDB48
	[Token(Token = "0x6002966")]
	[Address(RVA = "0x697ED0", Offset = "0x6964D0", VA = "0x180697ED0", Slot = "5")]
	protected override void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
		Image image = this.image;
		Sprite highLightSprite = this.highLightSprite;
		image.sprite = highLightSprite;
		GameAPP.PlaySound((SoundType)((uint)27), 0.5f, 1f);
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000DF98C File Offset: 0x000DDB8C
	[Token(Token = "0x6002967")]
	[Address(RVA = "0x697FB0", Offset = "0x6965B0", VA = "0x180697FB0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		RectTransform rectTransform = this.rectTransform;
		if (this._state == MainMenu.ButtonState.Default)
		{
			this.clickEvent.Invoke();
			CursorChange.SetDefaultCursor();
			return;
		}
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000DF9C4 File Offset: 0x000DDBC4
	[Token(Token = "0x6002968")]
	[Address(RVA = "0x694D80", Offset = "0x693380", VA = "0x180694D80")]
	public UIButton_mainMenu()
	{
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001772 RID: 6002
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001772")]
	[SerializeField]
	private MainMenu.ButtonState _state;
}
