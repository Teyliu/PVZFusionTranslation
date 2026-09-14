using System;
using Cpp2IlInjected;

// Token: 0x02000313 RID: 787
[Token(Token = "0x2000313")]
public class Jalapeno : Plant
{
	// Token: 0x06000E45 RID: 3653 RVA: 0x000520F0 File Offset: 0x000502F0
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x403F50", Offset = "0x402550", VA = "0x180403F50", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x0005212C File Offset: 0x0005032C
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x403ED0", Offset = "0x4024D0", VA = "0x180403ED0", Slot = "69")]
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

	// Token: 0x06000E47 RID: 3655 RVA: 0x00052178 File Offset: 0x00050378
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x402950", Offset = "0x400F50", VA = "0x180402950", Slot = "36")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x0005218C File Offset: 0x0005038C
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Jalapeno()
	{
	}
}
