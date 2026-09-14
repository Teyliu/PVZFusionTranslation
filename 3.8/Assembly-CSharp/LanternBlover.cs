using System;
using Cpp2IlInjected;

// Token: 0x020003C8 RID: 968
[Token(Token = "0x20003C8")]
public class LanternBlover : Blover
{
	// Token: 0x060011AB RID: 4523 RVA: 0x00063C80 File Offset: 0x00061E80
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x446240", Offset = "0x444840", VA = "0x180446240", Slot = "69")]
	protected override void AnimBlow()
	{
		base.AnimBlow();
		this.board.TempAddLightLevel(30f);
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00063CAC File Offset: 0x00061EAC
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public LanternBlover()
	{
	}
}
