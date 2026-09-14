using System;
using Cpp2IlInjected;

// Token: 0x02000316 RID: 790
[Token(Token = "0x2000316")]
public class GoldDoom : Plant
{
	// Token: 0x06000E68 RID: 3688 RVA: 0x000525D8 File Offset: 0x000507D8
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x446C50", Offset = "0x445250", VA = "0x180446C50", Slot = "42")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int attackDamage = this.attackDamage;
			int num2 = 0;
			this.flashCountDown = 30f;
			ulong num3;
			base.Recover(flashCountDown, (DamageType)num2, true, num3 != 0UL);
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x0005263C File Offset: 0x0005083C
	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public GoldDoom()
	{
	}
}
