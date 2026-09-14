using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
public class Bullet_cherryJalapeno : Bullet_pierce
{
	// Token: 0x060005B4 RID: 1460 RVA: 0x0001EC0C File Offset: 0x0001CE0C
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x6BEEE0", Offset = "0x6BD4E0", VA = "0x1806BEEE0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1000000L);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0001EC28 File Offset: 0x0001CE28
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x6BEE00", Offset = "0x6BD400", VA = "0x1806BEE00", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		throw new NullReferenceException();
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001EC60 File Offset: 0x0001CE60
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x6BA8E0", Offset = "0x6B8EE0", VA = "0x1806BA8E0", Slot = "18")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cherryJalapeno()
	{
	}
}
