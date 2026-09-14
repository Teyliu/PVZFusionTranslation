using System;
using Cpp2IlInjected;

// Token: 0x020006D2 RID: 1746
[Token(Token = "0x20006D2")]
public class Submarine_b2 : Submarine_a
{
	// Token: 0x06002265 RID: 8805 RVA: 0x000B46E4 File Offset: 0x000B28E4
	[Token(Token = "0x6002265")]
	[Address(RVA = "0x572B90", Offset = "0x571190", VA = "0x180572B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.uniqueSpeed = 2f;
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000B470C File Offset: 0x000B290C
	[Token(Token = "0x6002266")]
	[Address(RVA = "0x572B40", Offset = "0x571140", VA = "0x180572B40")]
	public Submarine_b2()
	{
	}
}
