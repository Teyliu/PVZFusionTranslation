using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E2 RID: 2018
[Token(Token = "0x20007E2")]
public class Weapon_wallNut : PlayerWeapon
{
	// Token: 0x060028FC RID: 10492 RVA: 0x000DD0BC File Offset: 0x000DB2BC
	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x67D180", Offset = "0x67B780", VA = "0x18067D180", Slot = "10")]
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

	// Token: 0x060028FD RID: 10493 RVA: 0x000DD138 File Offset: 0x000DB338
	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_wallNut()
	{
	}
}
