using System;
using Cpp2IlInjected;

// Token: 0x02000323 RID: 803
[Token(Token = "0x2000323")]
public class Jalapeno : Plant
{
	// Token: 0x06000E8E RID: 3726 RVA: 0x00053014 File Offset: 0x00051214
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x448180", Offset = "0x446780", VA = "0x180448180", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00053050 File Offset: 0x00051250
	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x448100", Offset = "0x446700", VA = "0x180448100", Slot = "68")]
	public virtual void AnimExplode()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
		throw new NullReferenceException();
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0005309C File Offset: 0x0005129C
	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x446BA0", Offset = "0x4451A0", VA = "0x180446BA0", Slot = "35")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x000530B0 File Offset: 0x000512B0
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Jalapeno()
	{
	}
}
