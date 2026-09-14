using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200074E RID: 1870
[Token(Token = "0x200074E")]
public class YellowGargantuar : Gargantuar
{
	// Token: 0x0600258E RID: 9614 RVA: 0x000C28F8 File Offset: 0x000C0AF8
	[Token(Token = "0x600258E")]
	[Address(RVA = "0x60C1D0", Offset = "0x60A7D0", VA = "0x18060C1D0", Slot = "77")]
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

	// Token: 0x0600258F RID: 9615 RVA: 0x000C2944 File Offset: 0x000C0B44
	[Token(Token = "0x600258F")]
	[Address(RVA = "0x60C2D0", Offset = "0x60A8D0", VA = "0x18060C2D0")]
	public YellowGargantuar()
	{
	}
}
