using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020007CC RID: 1996
[Token(Token = "0x20007CC")]
public class OtherMenu : BaseMenu
{
	// Token: 0x06002892 RID: 10386 RVA: 0x000DA990 File Offset: 0x000D8B90
	[Token(Token = "0x6002892")]
	[Address(RVA = "0x6677A0", Offset = "0x665DA0", VA = "0x1806677A0")]
	public void UpdateText(string text)
	{
		this.text1.text = text;
		TextMeshProUGUI textMeshProUGUI = this.text2;
		throw new NullReferenceException();
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
	[Token(Token = "0x6002893")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public OtherMenu()
	{
	}

	// Token: 0x0400169A RID: 5786
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400169A")]
	public TextMeshProUGUI text1;

	// Token: 0x0400169B RID: 5787
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400169B")]
	public TextMeshProUGUI text2;
}
