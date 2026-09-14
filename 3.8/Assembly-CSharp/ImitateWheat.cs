using System;
using Cpp2IlInjected;

// Token: 0x020003C0 RID: 960
[Token(Token = "0x20003C0")]
public class ImitateWheat : Plant
{
	// Token: 0x0600118E RID: 4494 RVA: 0x00063748 File Offset: 0x00061948
	[Token(Token = "0x600118E")]
	[Address(RVA = "0x444CF0", Offset = "0x4432F0", VA = "0x180444CF0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		ImitateEffect imitateEffect = new ImitateEffect(this, 3f);
		this.effects[(uint)100] = imitateEffect;
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x0006377C File Offset: 0x0006197C
	[Token(Token = "0x600118F")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public ImitateWheat()
	{
	}
}
