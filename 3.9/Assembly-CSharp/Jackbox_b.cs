using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C2 RID: 1730
[Token(Token = "0x20006C2")]
public class Jackbox_b : Jackbox_a
{
	// Token: 0x0600215E RID: 8542 RVA: 0x000AFC30 File Offset: 0x000ADE30
	[Token(Token = "0x600215E")]
	[Address(RVA = "0x5B8390", Offset = "0x5B6990", VA = "0x1805B8390", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
		float boardMaxX = this.board.boardMaxX;
		this.jumpX = boardMaxX;
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000AFC80 File Offset: 0x000ADE80
	[Token(Token = "0x600215F")]
	[Address(RVA = "0x5B8430", Offset = "0x5B6A30", VA = "0x1805B8430", Slot = "17")]
	protected override void Update()
	{
		Transform axis = this.axis;
		float num = this.jumpX;
		Transform axis2 = this.axis;
		if (!this.jumped)
		{
			float deltaTime = Time.deltaTime;
			this.waitTime = deltaTime;
			this.theStatus = (ZombieStatus)((ulong)19L);
			Rigidbody2D rb = this.rb;
			Vector2 vector;
			rb.velocity = vector;
			float num2 = this.waitTime;
			this.anim.SetTrigger("jump");
			this.jumped = true;
			this.vx = -4.25f;
			this.vy = 6f;
		}
		Transform axis3 = this.axis;
		Board board = this.board;
		if (!this.jumped)
		{
			this.theStatus = (ZombieStatus)((ulong)14L);
		}
		base.Update();
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x000AFD40 File Offset: 0x000ADF40
	[Token(Token = "0x6002160")]
	[Address(RVA = "0x5B80C0", Offset = "0x5B66C0", VA = "0x1805B80C0")]
	private void BigJump()
	{
		this.theStatus = (ZombieStatus)((ulong)20L);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x000AFD74 File Offset: 0x000ADF74
	[Token(Token = "0x6002161")]
	[Address(RVA = "0x5B8130", Offset = "0x5B6730", VA = "0x1805B8130", Slot = "22")]
	protected override void PositionUpdate()
	{
		Rigidbody2D rb = this.rb;
		Vector2 vector;
		rb.velocity = vector;
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000AFE3C File Offset: 0x000AE03C
	[Token(Token = "0x6002162")]
	[Address(RVA = "0x5B8060", Offset = "0x5B6660", VA = "0x1805B8060")]
	public Jackbox_b()
	{
		this.range = (ulong)1065353216L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x0400119B RID: 4507
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400119B")]
	protected float waitTime;

	// Token: 0x0400119C RID: 4508
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400119C")]
	private bool jumped;

	// Token: 0x0400119D RID: 4509
	[FieldOffset(Offset = "0x295")]
	[Token(Token = "0x400119D")]
	protected bool loseJumper;

	// Token: 0x0400119E RID: 4510
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400119E")]
	protected float jumpX;
}
