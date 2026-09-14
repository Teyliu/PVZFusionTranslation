using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020007C3 RID: 1987
[Token(Token = "0x20007C3")]
public class UIButton_mainMenu : UIButton
{
	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06002835 RID: 10293 RVA: 0x000DA928 File Offset: 0x000D8B28
	// (set) Token: 0x06002836 RID: 10294 RVA: 0x000DA93C File Offset: 0x000D8B3C
	[Token(Token = "0x1700019D")]
	public MainMenu.ButtonState State
	{
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x633CE0", Offset = "0x6322E0", VA = "0x180633CE0")]
		get
		{
			return this._state;
		}
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x633CF0", Offset = "0x6322F0", VA = "0x180633CF0")]
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

	// Token: 0x06002837 RID: 10295 RVA: 0x000DA98C File Offset: 0x000D8B8C
	[Token(Token = "0x6002837")]
	[Address(RVA = "0x633BA0", Offset = "0x6321A0", VA = "0x180633BA0", Slot = "5")]
	protected override void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
		Image image = this.image;
		Sprite highLightSprite = this.highLightSprite;
		image.sprite = highLightSprite;
		GameAPP.PlaySound((SoundType)((uint)27), 0.5f, 1f);
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x000DA9D0 File Offset: 0x000D8BD0
	[Token(Token = "0x6002838")]
	[Address(RVA = "0x633C80", Offset = "0x632280", VA = "0x180633C80", Slot = "9")]
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

	// Token: 0x06002839 RID: 10297 RVA: 0x000DAA08 File Offset: 0x000D8C08
	[Token(Token = "0x6002839")]
	[Address(RVA = "0x630FB0", Offset = "0x62F5B0", VA = "0x180630FB0")]
	public UIButton_mainMenu()
	{
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001696 RID: 5782
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001696")]
	[SerializeField]
	private MainMenu.ButtonState _state;
}
