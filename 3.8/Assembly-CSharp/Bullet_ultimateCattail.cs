using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x20001C3")]
public class Bullet_ultimateCattail : Bullet
{
	// Token: 0x060007C3 RID: 1987 RVA: 0x00027E18 File Offset: 0x00026018
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00027E48 File Offset: 0x00026048
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x7E86A0", Offset = "0x7E6CA0", VA = "0x1807E86A0", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00027E78 File Offset: 0x00026078
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x7E8590", Offset = "0x7E6B90", VA = "0x1807E8590", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetJalaed();
		if (zombie.theStatus != ZombieStatus.Flying)
		{
		}
		zombie.KnockBack(0.3f, (Zombie.KnockBackReason)((uint)2));
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00027ED4 File Offset: 0x000260D4
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x7E84E0", Offset = "0x7E6AE0", VA = "0x1807E84E0", Slot = "18")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00027F14 File Offset: 0x00026114
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ultimateCattail()
	{
	}

	// Token: 0x040003B1 RID: 945
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40003B1")]
	private Transform tail;
}
