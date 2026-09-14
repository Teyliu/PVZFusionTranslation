using System;
using Cpp2IlInjected;

// Token: 0x02000631 RID: 1585
[Token(Token = "0x2000631")]
public class BlueGargantuar : Gargantuar
{
	// Token: 0x06001E08 RID: 7688 RVA: 0x000A0A58 File Offset: 0x0009EC58
	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x5333B0", Offset = "0x5319B0", VA = "0x1805333B0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float theOriginSpeed = this.theOriginSpeed;
		this.theOriginSpeed = theOriginSpeed;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x000A0A7C File Offset: 0x0009EC7C
	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x5333E0", Offset = "0x5319E0", VA = "0x1805333E0")]
	public BlueGargantuar()
	{
	}
}
