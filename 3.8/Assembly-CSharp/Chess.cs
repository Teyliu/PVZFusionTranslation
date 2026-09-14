using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A1 RID: 161
[Token(Token = "0x20000A1")]
public class Chess : MonoBehaviour
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000B978 File Offset: 0x00009B78
	[Token(Token = "0x1700003B")]
	public int Column
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x3BEDE0", Offset = "0x3BD3E0", VA = "0x1803BEDE0")]
		get
		{
			return this.plant.thePlantColumn;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000B998 File Offset: 0x00009B98
	[Token(Token = "0x1700003C")]
	public int Row
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x3BEE00", Offset = "0x3BD400", VA = "0x1803BEE00")]
		get
		{
			return this.plant.thePlantRow;
		}
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000B9B8 File Offset: 0x00009BB8
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x3BE890", Offset = "0x3BCE90", VA = "0x1803BE890")]
	public void CopyChessData(Chess chess)
	{
		ChessManager chessManager = chess.chessManager;
		this.chessManager = chessManager;
		ChessType chessType = chess.chessType;
		this.chessType = chessType;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0000B9E8 File Offset: 0x00009BE8
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x3BE8D0", Offset = "0x3BCED0", VA = "0x1803BE8D0")]
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

	// Token: 0x060002BB RID: 699 RVA: 0x0000BAD0 File Offset: 0x00009CD0
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Chess()
	{
	}

	// Token: 0x04000112 RID: 274
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000112")]
	public ChessManager chessManager;

	// Token: 0x04000113 RID: 275
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000113")]
	public ChessType chessType;

	// Token: 0x04000114 RID: 276
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000114")]
	public Plant plant;
}
