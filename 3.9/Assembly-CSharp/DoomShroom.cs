using System;
using Cpp2IlInjected;

// Token: 0x02000315 RID: 789
[Token(Token = "0x2000315")]
public class DoomShroom : Plant
{
	// Token: 0x06000E64 RID: 3684 RVA: 0x00052534 File Offset: 0x00050734
	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x446BC0", Offset = "0x4451C0", VA = "0x180446BC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00052570 File Offset: 0x00050770
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x446B00", Offset = "0x445100", VA = "0x180446B00", Slot = "68")]
	public virtual void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x000525B0 File Offset: 0x000507B0
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x446BA0", Offset = "0x4451A0", VA = "0x180446BA0", Slot = "35")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x000525C4 File Offset: 0x000507C4
	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomShroom()
	{
	}
}
