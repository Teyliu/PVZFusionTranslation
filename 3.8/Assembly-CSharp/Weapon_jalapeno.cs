using System;
using Cpp2IlInjected;

// Token: 0x0200079E RID: 1950
[Token(Token = "0x200079E")]
public class Weapon_jalapeno : PlayerWeapon
{
	// Token: 0x060027A0 RID: 10144 RVA: 0x000D6F40 File Offset: 0x000D5140
	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x614F90", Offset = "0x613590", VA = "0x180614F90", Slot = "10")]
	protected override void Shoot()
	{
		Board instance = Board.Instance;
		Player player = this.player;
		BoardAction boardAction = instance.boardAction;
		int num = player.Row;
		int attackDamage = base.AttackDamage;
		Player player2 = this.player;
		num = this.player.Row;
		int attackDamage2 = base.AttackDamage;
		Player player3 = this.player;
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x000D6FA0 File Offset: 0x000D51A0
	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x614F30", Offset = "0x613530", VA = "0x180614F30", Slot = "8")]
	public override void OnEvoluted()
	{
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)6007));
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x000D6FC8 File Offset: 0x000D51C8
	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_jalapeno()
	{
	}
}
