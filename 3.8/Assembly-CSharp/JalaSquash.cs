using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C5 RID: 965
[Token(Token = "0x20003C5")]
public class JalaSquash : Squash
{
	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00063A94 File Offset: 0x00061C94
	[Token(Token = "0x170000EA")]
	protected override Vector2 Range
	{
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x424C40", Offset = "0x423240", VA = "0x180424C40", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00063AAC File Offset: 0x00061CAC
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x445F60", Offset = "0x444560", VA = "0x180445F60", Slot = "73")]
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

	// Token: 0x060011A3 RID: 4515 RVA: 0x00063AFC File Offset: 0x00061CFC
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public JalaSquash()
	{
	}
}
