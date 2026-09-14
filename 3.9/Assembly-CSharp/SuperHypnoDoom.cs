using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000466 RID: 1126
[Token(Token = "0x2000466")]
public class SuperHypnoDoom : DoomShroom
{
	// Token: 0x060014BE RID: 5310 RVA: 0x00072F28 File Offset: 0x00071128
	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x4CAC10", Offset = "0x4C9210", VA = "0x1804CAC10", Slot = "68")]
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

	// Token: 0x060014BF RID: 5311 RVA: 0x00072FC4 File Offset: 0x000711C4
	[Token(Token = "0x60014BF")]
	[Address(RVA = "0x4CAD20", Offset = "0x4C9320", VA = "0x1804CAD20")]
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

	// Token: 0x060014C0 RID: 5312 RVA: 0x00073010 File Offset: 0x00071210
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SuperHypnoDoom()
	{
	}
}
