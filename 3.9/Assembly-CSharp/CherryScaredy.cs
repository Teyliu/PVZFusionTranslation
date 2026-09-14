using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F8 RID: 1272
[Token(Token = "0x20004F8")]
public class CherryScaredy : ScaredyShroom
{
	// Token: 0x060017F3 RID: 6131 RVA: 0x00082F10 File Offset: 0x00081110
	[Token(Token = "0x60017F3")]
	[Address(RVA = "0x51E980", Offset = "0x51CF80", VA = "0x18051E980")]
	private void AnimScaredy()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x00082F44 File Offset: 0x00081144
	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x51EA20", Offset = "0x51D020", VA = "0x18051EA20", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x00082FA0 File Offset: 0x000811A0
	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CherryScaredy()
	{
	}
}
