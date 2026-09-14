using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000390 RID: 912
[Token(Token = "0x2000390")]
public class DoomSquash : Squash
{
	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060010BD RID: 4285 RVA: 0x0005F46C File Offset: 0x0005D66C
	[Token(Token = "0x17000122")]
	protected override Vector2 Range
	{
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x47B920", Offset = "0x479F20", VA = "0x18047B920", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0005F484 File Offset: 0x0005D684
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x484CC0", Offset = "0x4832C0", VA = "0x180484CC0", Slot = "72")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		BoardAction boardAction = this.board.boardAction;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public DoomSquash()
	{
	}
}
