using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
public class Bullet_cabbage_explode : Bullet_cabbage
{
	// Token: 0x06000577 RID: 1399 RVA: 0x0001DA5C File Offset: 0x0001BC5C
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x6BA990", Offset = "0x6B8F90", VA = "0x1806BA990", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetJalaed();
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x6BA8E0", Offset = "0x6B8EE0", VA = "0x1806BA8E0", Slot = "18")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cabbage_explode()
	{
	}
}
