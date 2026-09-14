using System;
using Cpp2IlInjected;

// Token: 0x02000312 RID: 786
[Token(Token = "0x2000312")]
public class Jalakelp : Tanglekelp
{
	// Token: 0x06000E43 RID: 3651 RVA: 0x00052078 File Offset: 0x00050278
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x403E70", Offset = "0x402470", VA = "0x180403E70", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, 1800, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x000520C0 File Offset: 0x000502C0
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public Jalakelp()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}
}
