using System;
using Cpp2IlInjected;

// Token: 0x020003DC RID: 988
[Token(Token = "0x20003DC")]
public class LanternBlover : Blover
{
	// Token: 0x06001207 RID: 4615 RVA: 0x000652A0 File Offset: 0x000634A0
	[Token(Token = "0x6001207")]
	[Address(RVA = "0x49A6D0", Offset = "0x498CD0", VA = "0x18049A6D0", Slot = "68")]
	protected override void AnimBlow()
	{
		base.AnimBlow();
		this.board.TempAddLightLevel(30f);
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x000652CC File Offset: 0x000634CC
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public LanternBlover()
	{
	}
}
