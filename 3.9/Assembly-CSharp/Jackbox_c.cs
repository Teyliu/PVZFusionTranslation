using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C3 RID: 1731
[Token(Token = "0x20006C3")]
public class Jackbox_c : Jackbox_b
{
	// Token: 0x06002163 RID: 8547 RVA: 0x000AFE6C File Offset: 0x000AE06C
	[Token(Token = "0x6002163")]
	[Address(RVA = "0x5B87E0", Offset = "0x5B6DE0", VA = "0x1805B87E0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
		Board board = this.board;
		float boardMaxX = board.boardMaxX;
		this.jumpX = boardMaxX;
		float boardMaxX2 = board.boardMaxX;
		this.waitTime = 4.9f;
		this.jumpX = boardMaxX2;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x000AFED8 File Offset: 0x000AE0D8
	[Token(Token = "0x6002164")]
	[Address(RVA = "0x5B8610", Offset = "0x5B6C10", VA = "0x1805B8610", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			zombie.revived = true;
			this.board.SetHealthInTravel(zombie);
		}
		Transform axis2 = this.axis;
		base.Die(2);
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000AFF2C File Offset: 0x000AE12C
	[Token(Token = "0x6002165")]
	[Address(RVA = "0x5B8060", Offset = "0x5B6660", VA = "0x1805B8060")]
	public Jackbox_c()
	{
		this.range = (ulong)1065353216L;
		this.range.y = 2f;
		base..ctor();
	}
}
