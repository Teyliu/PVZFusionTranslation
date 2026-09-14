using System;
using Cpp2IlInjected;

// Token: 0x020003D4 RID: 980
[Token(Token = "0x20003D4")]
public class ImitateWheat : Plant
{
	// Token: 0x060011EA RID: 4586 RVA: 0x00064D68 File Offset: 0x00062F68
	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x496C40", Offset = "0x495240", VA = "0x180496C40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		ImitateEffect imitateEffect = new ImitateEffect(this, 3f);
		this.effects[(uint)100] = imitateEffect;
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00064D9C File Offset: 0x00062F9C
	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public ImitateWheat()
	{
	}
}
