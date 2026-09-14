using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020007F9 RID: 2041
[Token(Token = "0x20007F9")]
public class InputButton : UIButton
{
	// Token: 0x06002948 RID: 10568 RVA: 0x000DF0C8 File Offset: 0x000DD2C8
	[Token(Token = "0x6002948")]
	[Address(RVA = "0x6949F0", Offset = "0x692FF0", VA = "0x1806949F0", Slot = "8")]
	protected override void OnMouseDown()
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
		KeyCode keyCode = this.keyCode;
		int size = GameAPP.keyCode2._size;
		string playerName = GameAPP.playerName;
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000DF150 File Offset: 0x000DD350
	[Token(Token = "0x6002949")]
	[Address(RVA = "0x694CD0", Offset = "0x6932D0", VA = "0x180694CD0", Slot = "7")]
	protected override void OnMouseUp()
	{
		RectTransform rectTransform = this.rectTransform;
		List<KeyCode> keyCode = GameAPP.keyCode2;
		KeyCode keyCode2 = this.keyCode;
		bool flag = keyCode.Remove(keyCode2);
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x000DF180 File Offset: 0x000DD380
	[Token(Token = "0x600294A")]
	[Address(RVA = "0x694BE0", Offset = "0x6931E0", VA = "0x180694BE0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		RectTransform rectTransform = this.rectTransform;
		this.selectedLight.SetActive(true);
		UnityEvent<UIButton> onSelect = this.onSelect;
		if (onSelect != 0)
		{
			onSelect.Invoke(this);
		}
		GameAPP.keyCode = this.keyCode;
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x000DF1CC File Offset: 0x000DD3CC
	[Token(Token = "0x600294B")]
	[Address(RVA = "0x694D80", Offset = "0x693380", VA = "0x180694D80")]
	public InputButton()
	{
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x0400175D RID: 5981
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400175D")]
	public KeyCode keyCode;
}
