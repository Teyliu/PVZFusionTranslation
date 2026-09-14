using System;
using Cpp2IlInjected;

// Token: 0x02000322 RID: 802
[Token(Token = "0x2000322")]
public class Jalakelp : Tanglekelp
{
	// Token: 0x06000E8C RID: 3724 RVA: 0x00052FB8 File Offset: 0x000511B8
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x4480A0", Offset = "0x4466A0", VA = "0x1804480A0", Slot = "51")]
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

	// Token: 0x06000E8D RID: 3725 RVA: 0x00053000 File Offset: 0x00051200
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x4466F0", Offset = "0x444CF0", VA = "0x1804466F0")]
	public Jalakelp()
	{
	}
}
