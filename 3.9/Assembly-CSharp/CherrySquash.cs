using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000376 RID: 886
[Token(Token = "0x2000376")]
public class CherrySquash : Squash
{
	// Token: 0x1700011C RID: 284
	// (get) Token: 0x0600103C RID: 4156 RVA: 0x0005D154 File Offset: 0x0005B354
	[Token(Token = "0x1700011C")]
	protected override Vector2 Range
	{
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x47B920", Offset = "0x479F20", VA = "0x18047B920", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0005D16C File Offset: 0x0005B36C
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x47B870", Offset = "0x479E70", VA = "0x18047B870", Slot = "72")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0005D1B0 File Offset: 0x0005B3B0
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CherrySquash()
	{
	}
}
