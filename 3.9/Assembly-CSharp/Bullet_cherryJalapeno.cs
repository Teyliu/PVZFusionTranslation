using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
public class Bullet_cherryJalapeno : Bullet_pierce
{
	// Token: 0x060005BB RID: 1467 RVA: 0x0001E3DC File Offset: 0x0001C5DC
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x6E9CA0", Offset = "0x6E82A0", VA = "0x1806E9CA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)1000000L);
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x6E9BC0", Offset = "0x6E81C0", VA = "0x1806E9BC0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		throw new NullReferenceException();
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0001E430 File Offset: 0x0001C630
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x6E57D0", Offset = "0x6E3DD0", VA = "0x1806E57D0", Slot = "17")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001E470 File Offset: 0x0001C670
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cherryJalapeno()
	{
	}
}
