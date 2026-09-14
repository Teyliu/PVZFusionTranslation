using System;
using Cpp2IlInjected;

// Token: 0x02000306 RID: 774
[Token(Token = "0x2000306")]
public class GoldDoom : Plant
{
	// Token: 0x06000E1F RID: 3615 RVA: 0x0005166C File Offset: 0x0004F86C
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x402A00", Offset = "0x401000", VA = "0x180402A00", Slot = "43")]
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

	// Token: 0x06000E20 RID: 3616 RVA: 0x000516D0 File Offset: 0x0004F8D0
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public GoldDoom()
	{
	}
}
