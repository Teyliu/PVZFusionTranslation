using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200063C RID: 1596
[Token(Token = "0x200063C")]
public class CardWithDamage : TheCard
{
	// Token: 0x06001E23 RID: 7715 RVA: 0x000A07FC File Offset: 0x0009E9FC
	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CardWithDamage()
	{
	}

	// Token: 0x04001068 RID: 4200
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001068")]
	public TextMeshProUGUI totalDamage;
}
