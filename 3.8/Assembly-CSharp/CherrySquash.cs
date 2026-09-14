using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000366 RID: 870
[Token(Token = "0x2000366")]
public class CherrySquash : Squash
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0005C194 File Offset: 0x0005A394
	[Token(Token = "0x170000D9")]
	protected override Vector2 Range
	{
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x424C40", Offset = "0x423240", VA = "0x180424C40", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x0005C1AC File Offset: 0x0005A3AC
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x424B90", Offset = "0x423190", VA = "0x180424B90", Slot = "73")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x0005C1F0 File Offset: 0x0005A3F0
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CherrySquash()
	{
	}
}
