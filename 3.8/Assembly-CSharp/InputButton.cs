using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020007C0 RID: 1984
[Token(Token = "0x20007C0")]
public class InputButton : UIButton
{
	// Token: 0x06002819 RID: 10265 RVA: 0x000DA10C File Offset: 0x000D830C
	[Token(Token = "0x6002819")]
	[Address(RVA = "0x630C20", Offset = "0x62F220", VA = "0x180630C20", Slot = "8")]
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

	// Token: 0x0600281A RID: 10266 RVA: 0x000DA194 File Offset: 0x000D8394
	[Token(Token = "0x600281A")]
	[Address(RVA = "0x630F00", Offset = "0x62F500", VA = "0x180630F00", Slot = "7")]
	protected override void OnMouseUp()
	{
		RectTransform rectTransform = this.rectTransform;
		List<KeyCode> keyCode = GameAPP.keyCode2;
		KeyCode keyCode2 = this.keyCode;
		bool flag = keyCode.Remove(keyCode2);
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x000DA1C4 File Offset: 0x000D83C4
	[Token(Token = "0x600281B")]
	[Address(RVA = "0x630E10", Offset = "0x62F410", VA = "0x180630E10", Slot = "9")]
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

	// Token: 0x0600281C RID: 10268 RVA: 0x000DA210 File Offset: 0x000D8410
	[Token(Token = "0x600281C")]
	[Address(RVA = "0x630FB0", Offset = "0x62F5B0", VA = "0x180630FB0")]
	public InputButton()
	{
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001681 RID: 5761
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001681")]
	public KeyCode keyCode;
}
