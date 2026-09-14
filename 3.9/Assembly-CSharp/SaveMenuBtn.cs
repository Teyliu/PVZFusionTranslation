using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020008AB RID: 2219
[Token(Token = "0x20008AB")]
public class SaveMenuBtn : UIBtn
{
	// Token: 0x06002D55 RID: 11605 RVA: 0x000F73B4 File Offset: 0x000F55B4
	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x6D68D0", Offset = "0x6D4ED0", VA = "0x1806D68D0", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		if (this.buttonNumber == 0)
		{
			GameAPP.UIManager.Pop();
			return;
		}
	}

	// Token: 0x06002D56 RID: 11606 RVA: 0x000F73E4 File Offset: 0x000F55E4
	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x6D6950", Offset = "0x6D4F50", VA = "0x1806D6950")]
	public SaveMenuBtn()
	{
	}

	// Token: 0x04001B2B RID: 6955
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B2B")]
	public TextMeshProUGUI theName;

	// Token: 0x04001B2C RID: 6956
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B2C")]
	public int id = (int)((ulong)4294967295L);

	// Token: 0x04001B2D RID: 6957
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001B2D")]
	public int buttonNumber;
}
