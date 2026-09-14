using System;
using Cpp2IlInjected;

// Token: 0x0200070A RID: 1802
[Token(Token = "0x200070A")]
public class Submarine_b2 : Submarine_a
{
	// Token: 0x0600237F RID: 9087 RVA: 0x000B94A0 File Offset: 0x000B76A0
	[Token(Token = "0x600237F")]
	[Address(RVA = "0x5D6200", Offset = "0x5D4800", VA = "0x1805D6200", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.uniqueSpeed = 2f;
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x000B94C8 File Offset: 0x000B76C8
	[Token(Token = "0x6002380")]
	[Address(RVA = "0x5D61B0", Offset = "0x5D47B0", VA = "0x1805D61B0")]
	public Submarine_b2()
	{
	}
}
