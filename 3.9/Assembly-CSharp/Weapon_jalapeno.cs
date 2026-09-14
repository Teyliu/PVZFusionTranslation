using System;
using Cpp2IlInjected;

// Token: 0x020007D7 RID: 2007
[Token(Token = "0x20007D7")]
public class Weapon_jalapeno : PlayerWeapon
{
	// Token: 0x060028CF RID: 10447 RVA: 0x000DBEFC File Offset: 0x000DA0FC
	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x678820", Offset = "0x676E20", VA = "0x180678820", Slot = "10")]
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

	// Token: 0x060028D0 RID: 10448 RVA: 0x000DBF5C File Offset: 0x000DA15C
	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x6787C0", Offset = "0x676DC0", VA = "0x1806787C0", Slot = "8")]
	public override void OnEvoluted()
	{
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)6007));
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x000DBF84 File Offset: 0x000DA184
	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_jalapeno()
	{
	}
}
