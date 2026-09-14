using System;
using Cpp2IlInjected;

// Token: 0x02000313 RID: 787
[Token(Token = "0x2000313")]
public class DoomKelp : Tanglekelp
{
	// Token: 0x06000E5E RID: 3678 RVA: 0x000523F8 File Offset: 0x000505F8
	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x446670", Offset = "0x444C70", VA = "0x180446670", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x0005242C File Offset: 0x0005062C
	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x4466F0", Offset = "0x444CF0", VA = "0x1804466F0")]
	public DoomKelp()
	{
	}
}
