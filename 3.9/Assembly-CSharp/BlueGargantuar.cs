using System;
using Cpp2IlInjected;

// Token: 0x02000667 RID: 1639
[Token(Token = "0x2000667")]
public class BlueGargantuar : Gargantuar
{
	// Token: 0x06001F0A RID: 7946 RVA: 0x000A51AC File Offset: 0x000A33AC
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x58A090", Offset = "0x588690", VA = "0x18058A090", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		float theOriginSpeed = this.theOriginSpeed;
		this.theOriginSpeed = theOriginSpeed;
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000A51D0 File Offset: 0x000A33D0
	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x58A0C0", Offset = "0x5886C0", VA = "0x18058A0C0")]
	public BlueGargantuar()
	{
	}
}
