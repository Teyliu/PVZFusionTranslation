using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068C RID: 1676
[Token(Token = "0x200068C")]
public class Jackbox_b : Jackbox_a
{
	// Token: 0x0600205C RID: 8284 RVA: 0x000AB304 File Offset: 0x000A9504
	[Token(Token = "0x600205C")]
	[Address(RVA = "0x5547F0", Offset = "0x552DF0", VA = "0x1805547F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
		float boardMaxX = this.board.boardMaxX;
		this.jumpX = boardMaxX;
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000AB354 File Offset: 0x000A9554
	[Token(Token = "0x600205D")]
	[Address(RVA = "0x554890", Offset = "0x552E90", VA = "0x180554890", Slot = "16")]
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

	// Token: 0x0600205E RID: 8286 RVA: 0x000AB414 File Offset: 0x000A9614
	[Token(Token = "0x600205E")]
	[Address(RVA = "0x554520", Offset = "0x552B20", VA = "0x180554520")]
	private void BigJump()
	{
		this.theStatus = (ZombieStatus)((ulong)20L);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000AB448 File Offset: 0x000A9648
	[Token(Token = "0x600205F")]
	[Address(RVA = "0x554590", Offset = "0x552B90", VA = "0x180554590", Slot = "21")]
	protected override void PositionUpdate()
	{
		Rigidbody2D rb = this.rb;
		Vector2 vector;
		rb.velocity = vector;
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000AB510 File Offset: 0x000A9710
	[Token(Token = "0x6002060")]
	[Address(RVA = "0x5544C0", Offset = "0x552AC0", VA = "0x1805544C0")]
	public Jackbox_b()
	{
		this.range = (ulong)1065353216L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x040010CE RID: 4302
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40010CE")]
	protected float waitTime;

	// Token: 0x040010CF RID: 4303
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x40010CF")]
	private bool jumped;

	// Token: 0x040010D0 RID: 4304
	[FieldOffset(Offset = "0x275")]
	[Token(Token = "0x40010D0")]
	protected bool loseJumper;

	// Token: 0x040010D1 RID: 4305
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40010D1")]
	protected float jumpX;
}
