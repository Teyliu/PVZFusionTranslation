using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A9 RID: 1961
[Token(Token = "0x20007A9")]
public class Weapon_wallNut : PlayerWeapon
{
	// Token: 0x060027CD RID: 10189 RVA: 0x000D8100 File Offset: 0x000D6300
	[Token(Token = "0x60027CD")]
	[Address(RVA = "0x6198E0", Offset = "0x617EE0", VA = "0x1806198E0", Slot = "10")]
	protected override void Shoot()
	{
		Player player = this.player;
		Mouse instance = Mouse.Instance;
		Transform axis = player.axis;
		Mouse instance2 = Mouse.Instance;
		Transform axis2 = this.player.axis;
		Board instance3 = Board.Instance;
		int attackDamage = base.AttackDamage;
		LoonNut loonNut;
		loonNut.damage = attackDamage;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000D817C File Offset: 0x000D637C
	[Token(Token = "0x60027CE")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_wallNut()
	{
	}
}
