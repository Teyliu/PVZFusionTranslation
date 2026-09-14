using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000715 RID: 1813
[Token(Token = "0x2000715")]
public class YellowGargantuar : Gargantuar
{
	// Token: 0x0600246E RID: 9326 RVA: 0x000BDB0C File Offset: 0x000BBD0C
	[Token(Token = "0x600246E")]
	[Address(RVA = "0x5920B0", Offset = "0x5906B0", VA = "0x1805920B0", Slot = "75")]
	protected override Zombie AnimThrow()
	{
		int num = 0;
		Zombie zombie = base.AnimThrow();
		int num2 = 0;
		if (zombie != num2)
		{
			Transform transform = zombie.transform;
			float num3 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		}
		num++;
		throw new NullReferenceException();
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x000BDB58 File Offset: 0x000BBD58
	[Token(Token = "0x600246F")]
	[Address(RVA = "0x5921B0", Offset = "0x5907B0", VA = "0x1805921B0")]
	public YellowGargantuar()
	{
	}
}
