using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000446 RID: 1094
[Token(Token = "0x2000446")]
public class SuperHypnoDoom : DoomShroom
{
	// Token: 0x0600142E RID: 5166 RVA: 0x00070BFC File Offset: 0x0006EDFC
	[Token(Token = "0x600142E")]
	[Address(RVA = "0x473360", Offset = "0x471960", VA = "0x180473360", Slot = "69")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)19)))
		{
			int thePlantRow = this.thePlantRow;
			this.SetZombie(thePlantRow);
			int thePlantRow2 = this.thePlantRow;
			int num2 = thePlantRow2 - 1;
			if (thePlantRow2 == 0)
			{
				num2 = thePlantRow2;
			}
			this.SetZombie(num2);
			int rowNum = this.board.rowNum;
			int num3 = this.thePlantRow;
			if (num3 != rowNum)
			{
				num3++;
			}
			this.SetZombie(num3);
			return;
		}
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00070C98 File Offset: 0x0006EE98
	[Token(Token = "0x600142F")]
	[Address(RVA = "0x473470", Offset = "0x471A70", VA = "0x180473470")]
	private void SetZombie(int row)
	{
		Board board = this.board;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, row) != BoxType.Water)
		{
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			return;
		}
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00070CE4 File Offset: 0x0006EEE4
	[Token(Token = "0x6001430")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SuperHypnoDoom()
	{
	}
}
