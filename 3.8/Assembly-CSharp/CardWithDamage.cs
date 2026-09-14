using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000607 RID: 1543
[Token(Token = "0x2000607")]
public class CardWithDamage : TheCard
{
	// Token: 0x06001D24 RID: 7460 RVA: 0x0009BD20 File Offset: 0x00099F20
	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CardWithDamage()
	{
	}

	// Token: 0x04000FA0 RID: 4000
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000FA0")]
	public TextMeshProUGUI totalDamage;
}
