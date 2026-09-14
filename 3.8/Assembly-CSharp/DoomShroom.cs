using System;
using Cpp2IlInjected;

// Token: 0x02000305 RID: 773
[Token(Token = "0x2000305")]
public class DoomShroom : Plant
{
	// Token: 0x06000E1B RID: 3611 RVA: 0x000515C8 File Offset: 0x0004F7C8
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x402970", Offset = "0x400F70", VA = "0x180402970", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00051604 File Offset: 0x0004F804
	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x4028B0", Offset = "0x400EB0", VA = "0x1804028B0", Slot = "69")]
	public virtual void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00051644 File Offset: 0x0004F844
	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x402950", Offset = "0x400F50", VA = "0x180402950", Slot = "36")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00051658 File Offset: 0x0004F858
	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomShroom()
	{
	}
}
