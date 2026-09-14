using System;
using Cpp2IlInjected;

// Token: 0x0200030C RID: 780
[Token(Token = "0x200030C")]
public class IceDoom : DoomShroom
{
	// Token: 0x06000E30 RID: 3632 RVA: 0x00051980 File Offset: 0x0004FB80
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x403580", Offset = "0x401B80", VA = "0x180403580", Slot = "69")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x000519C0 File Offset: 0x0004FBC0
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceDoom()
	{
	}
}
