using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033B RID: 827
[Token(Token = "0x200033B")]
public class CherryNut : WallNut
{
	// Token: 0x06000F1A RID: 3866 RVA: 0x00057BC0 File Offset: 0x00055DC0
	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x458C30", Offset = "0x457230", VA = "0x180458C30", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00057C10 File Offset: 0x00055E10
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CherryNut()
	{
	}
}
