using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x20001CD")]
public class Bullet_ultimateCattail : Bullet
{
	// Token: 0x060007DA RID: 2010 RVA: 0x00027960 File Offset: 0x00025B60
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00027990 File Offset: 0x00025B90
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x815F40", Offset = "0x814540", VA = "0x180815F40", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x000279C0 File Offset: 0x00025BC0
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x815E30", Offset = "0x814430", VA = "0x180815E30", Slot = "22")]
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

	// Token: 0x060007DD RID: 2013 RVA: 0x00027A1C File Offset: 0x00025C1C
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x815D80", Offset = "0x814380", VA = "0x180815D80", Slot = "17")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00027A5C File Offset: 0x00025C5C
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ultimateCattail()
	{
	}

	// Token: 0x040003BB RID: 955
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003BB")]
	private Transform tail;
}
