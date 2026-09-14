using System;
using Cpp2IlInjected;

// Token: 0x02000318 RID: 792
[Token(Token = "0x2000318")]
public class PortalDoom : DoomShroom
{
	// Token: 0x06000E5D RID: 3677 RVA: 0x000528E0 File Offset: 0x00050AE0
	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x411E80", Offset = "0x410480", VA = "0x180411E80", Slot = "69")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00052920 File Offset: 0x00050B20
	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PortalDoom()
	{
	}
}
