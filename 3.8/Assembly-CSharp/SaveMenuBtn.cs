using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200086F RID: 2159
[Token(Token = "0x200086F")]
public class SaveMenuBtn : UIBtn
{
	// Token: 0x06002C23 RID: 11299 RVA: 0x000F279C File Offset: 0x000F099C
	[Token(Token = "0x6002C23")]
	[Address(RVA = "0x671D00", Offset = "0x670300", VA = "0x180671D00", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		if (this.buttonNumber == 0)
		{
			GameAPP.UIManager.Pop();
			return;
		}
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x000F27CC File Offset: 0x000F09CC
	[Token(Token = "0x6002C24")]
	[Address(RVA = "0x671D80", Offset = "0x670380", VA = "0x180671D80")]
	public SaveMenuBtn()
	{
	}

	// Token: 0x04001A3D RID: 6717
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A3D")]
	public TextMeshProUGUI theName;

	// Token: 0x04001A3E RID: 6718
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A3E")]
	public int id = (int)((ulong)4294967295L);

	// Token: 0x04001A3F RID: 6719
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001A3F")]
	public int buttonNumber;
}
