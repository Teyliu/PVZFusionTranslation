using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class Chess : MonoBehaviour
{
	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000BD24 File Offset: 0x00009F24
	[Token(Token = "0x17000078")]
	public int Column
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x40BB90", Offset = "0x40A190", VA = "0x18040BB90")]
		get
		{
			return this.plant.thePlantColumn;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000BD44 File Offset: 0x00009F44
	[Token(Token = "0x17000079")]
	public int Row
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x40BBB0", Offset = "0x40A1B0", VA = "0x18040BBB0")]
		get
		{
			return this.plant.thePlantRow;
		}
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000BD64 File Offset: 0x00009F64
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x40B640", Offset = "0x409C40", VA = "0x18040B640")]
	public void CopyChessData(Chess chess)
	{
		ChessManager chessManager = chess.chessManager;
		this.chessManager = chessManager;
		ChessType chessType = chess.chessType;
		this.chessType = chessType;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000BD94 File Offset: 0x00009F94
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x40B680", Offset = "0x409C80", VA = "0x18040B680")]
	public bool TryMove(int theColumn, int theRow)
	{
		if (this.chessType <= ChessType.将)
		{
			bool flag = this.chessManager.Rule_兵(this, theRow, theRow);
			ChessManager chessManager = this.chessManager;
			Plant plant = this.plant;
			if (theColumn == plant.thePlantColumn || theRow == plant.thePlantRow)
			{
				int thePlantRow = plant.thePlantRow;
				int thePlantColumn = plant.thePlantColumn;
				if (chessManager.IsStraightPathClear(thePlantColumn, thePlantRow, theRow, theRow))
				{
					goto IL_00D2;
				}
				Plant plant2 = this.plant;
				Plant plant3 = this.plant;
				if ((theColumn == 1 && theColumn == 2) || (theColumn == 2 && theColumn == 1))
				{
					Plant plant4 = this.plant;
					List<Plant> list = Lawnf.Get1x1Plants(theColumn, theColumn);
					if (theColumn < 5 && theColumn == 2 && theColumn == 0 && theColumn <= 2 && theColumn == 1 && theRow == theColumn)
					{
						goto IL_00D2;
					}
				}
			}
			while (theColumn > 2)
			{
			}
			Plant plant5 = this.plant;
			Plant plant6 = this.plant;
			if (theColumn == 1)
			{
			}
			while (theColumn != 0)
			{
			}
			if (theRow != 1)
			{
			}
		}
		IL_00D2:
		throw new NullReferenceException();
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000BE7C File Offset: 0x0000A07C
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Chess()
	{
	}

	// Token: 0x0400011F RID: 287
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011F")]
	public ChessManager chessManager;

	// Token: 0x04000120 RID: 288
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000120")]
	public ChessType chessType;

	// Token: 0x04000121 RID: 289
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000121")]
	public Plant plant;
}
