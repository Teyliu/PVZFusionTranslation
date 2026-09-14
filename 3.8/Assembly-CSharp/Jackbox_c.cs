using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068D RID: 1677
[Token(Token = "0x200068D")]
public class Jackbox_c : Jackbox_b
{
	// Token: 0x06002061 RID: 8289 RVA: 0x000AB540 File Offset: 0x000A9740
	[Token(Token = "0x6002061")]
	[Address(RVA = "0x554C40", Offset = "0x553240", VA = "0x180554C40", Slot = "15")]
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

	// Token: 0x06002062 RID: 8290 RVA: 0x000AB5AC File Offset: 0x000A97AC
	[Token(Token = "0x6002062")]
	[Address(RVA = "0x554A70", Offset = "0x553070", VA = "0x180554A70", Slot = "33")]
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

	// Token: 0x06002063 RID: 8291 RVA: 0x000AB600 File Offset: 0x000A9800
	[Token(Token = "0x6002063")]
	[Address(RVA = "0x5544C0", Offset = "0x552AC0", VA = "0x1805544C0")]
	public Jackbox_c()
	{
		this.range = (ulong)1065353216L;
		this.range.y = 2f;
		base..ctor();
	}
}
