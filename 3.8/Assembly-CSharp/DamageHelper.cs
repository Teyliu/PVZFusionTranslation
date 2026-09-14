using System;
using Cpp2IlInjected;

// Token: 0x020008A6 RID: 2214
[Token(Token = "0x20008A6")]
public class DamageHelper
{
	// Token: 0x06002D16 RID: 11542 RVA: 0x000F85A8 File Offset: 0x000F67A8
	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x682DB0", Offset = "0x6813B0", VA = "0x180682DB0")]
	public static int GetPriority(IDamageable target)
	{
		if (target != 0)
		{
			return 3;
		}
		return 1;
	}

	// Token: 0x06002D17 RID: 11543 RVA: 0x000F85C4 File Offset: 0x000F67C4
	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DamageHelper()
	{
	}
}
