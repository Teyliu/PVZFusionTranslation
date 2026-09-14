using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000793 RID: 1939
[Token(Token = "0x2000793")]
public class OtherMenu : BaseMenu
{
	// Token: 0x06002763 RID: 10083 RVA: 0x000D59A8 File Offset: 0x000D3BA8
	[Token(Token = "0x6002763")]
	[Address(RVA = "0x603F90", Offset = "0x602590", VA = "0x180603F90")]
	public void UpdateText(string text)
	{
		this.text1.text = text;
		TextMeshProUGUI textMeshProUGUI = this.text2;
		throw new NullReferenceException();
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x000D59D0 File Offset: 0x000D3BD0
	[Token(Token = "0x6002764")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public OtherMenu()
	{
	}

	// Token: 0x040015BE RID: 5566
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40015BE")]
	public TextMeshProUGUI text1;

	// Token: 0x040015BF RID: 5567
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40015BF")]
	public TextMeshProUGUI text2;
}
