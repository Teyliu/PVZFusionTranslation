using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032B RID: 811
[Token(Token = "0x200032B")]
public class CherryNut : WallNut
{
	// Token: 0x06000ED0 RID: 3792 RVA: 0x00056B4C File Offset: 0x00054D4C
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x424820", Offset = "0x422E20", VA = "0x180424820", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00056B9C File Offset: 0x00054D9C
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CherryNut()
	{
	}
}
