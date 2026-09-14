using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D9 RID: 985
[Token(Token = "0x20003D9")]
public class JalaSquash : Squash
{
	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060011FD RID: 4605 RVA: 0x000650B4 File Offset: 0x000632B4
	[Token(Token = "0x1700012D")]
	protected override Vector2 Range
	{
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x47B920", Offset = "0x479F20", VA = "0x18047B920", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x000650CC File Offset: 0x000632CC
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x49A3F0", Offset = "0x4989F0", VA = "0x18049A3F0", Slot = "72")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x0006511C File Offset: 0x0006331C
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public JalaSquash()
	{
	}
}
