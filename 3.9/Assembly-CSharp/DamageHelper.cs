using System;
using Cpp2IlInjected;

// Token: 0x020008E2 RID: 2274
[Token(Token = "0x20008E2")]
public class DamageHelper
{
	// Token: 0x06002E49 RID: 11849 RVA: 0x000FD12C File Offset: 0x000FB32C
	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x6FC370", Offset = "0x6FA970", VA = "0x1806FC370")]
	public static int GetPriority(IDamageable target)
	{
		if (target != 0)
		{
			return 3;
		}
		return 1;
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x000FD148 File Offset: 0x000FB348
	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DamageHelper()
	{
	}
}
