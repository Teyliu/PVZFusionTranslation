using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class Bullet_nuclear : Bullet_pierce
{
	// Token: 0x060006B2 RID: 1714 RVA: 0x000227C0 File Offset: 0x000209C0
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000227D8 File Offset: 0x000209D8
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x806D60", Offset = "0x805360", VA = "0x180806D60", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		int num = 0;
		int damage = this._damage;
		BoardAction boardAction2 = this.board.boardAction;
		int column = zombie.Column;
		PlantType fromType2 = this.fromType;
		int damage2 = this._damage;
		if ((GameAPP.config.distablexplodeFlash ? 1 : 0) == num)
		{
			Transform axis = zombie.axis;
			Board board = this.board;
		}
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00022864 File Offset: 0x00020A64
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x806C90", Offset = "0x805290", VA = "0x180806C90", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000228A0 File Offset: 0x00020AA0
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_nuclear()
	{
	}
}
