using System;
using Cpp2IlInjected;

// Token: 0x02000303 RID: 771
[Token(Token = "0x2000303")]
public class DoomKelp : Tanglekelp
{
	// Token: 0x06000E15 RID: 3605 RVA: 0x00051458 File Offset: 0x0004F658
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x4023C0", Offset = "0x4009C0", VA = "0x1804023C0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		base.OnFixedUpdate();
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00051494 File Offset: 0x0004F694
	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public DoomKelp()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}
}
