using System;
using Cpp2IlInjected;

// Token: 0x0200031C RID: 796
[Token(Token = "0x200031C")]
public class IceDoom : DoomShroom
{
	// Token: 0x06000E79 RID: 3705 RVA: 0x000528E4 File Offset: 0x00050AE4
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x447800", Offset = "0x445E00", VA = "0x180447800", Slot = "68")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00052924 File Offset: 0x00050B24
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceDoom()
	{
	}
}
