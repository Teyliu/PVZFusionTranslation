using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000380 RID: 896
[Token(Token = "0x2000380")]
public class DoomSquash : Squash
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06001071 RID: 4209 RVA: 0x0005E448 File Offset: 0x0005C648
	[Token(Token = "0x170000DF")]
	protected override Vector2 Range
	{
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x424C40", Offset = "0x423240", VA = "0x180424C40", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0005E460 File Offset: 0x0005C660
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x432000", Offset = "0x430600", VA = "0x180432000", Slot = "73")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		BoardAction boardAction = this.board.boardAction;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x0005E4AC File Offset: 0x0005C6AC
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public DoomSquash()
	{
	}
}
