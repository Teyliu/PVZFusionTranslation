using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200028D RID: 653
[Token(Token = "0x200028D")]
public class SolarMower : Mower
{
	// Token: 0x06000BCC RID: 3020 RVA: 0x00044170 File Offset: 0x00042370
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x3DC890", Offset = "0x3DAE90", VA = "0x1803DC890", Slot = "5")]
	protected override void Update()
	{
		base.Update();
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			Animator anim = this.anim;
			float num3 = this.maxTimer;
			this.timer = num3;
			anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x000441CC File Offset: 0x000423CC
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x3DC6C0", Offset = "0x3DACC0", VA = "0x1803DC6C0")]
	private void AnimShoot()
	{
		ulong num;
		do
		{
			Board board = this.board;
			if (board.theSun > 15000)
			{
				int theSun = board.theSun;
				board.UseSun((float)theSun);
			}
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				while (flag <= true)
				{
				}
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00044224 File Offset: 0x00042424
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x3DC950", Offset = "0x3DAF50", VA = "0x1803DC950")]
	public SolarMower()
	{
		this.speed = 5f;
		base..ctor();
	}

	// Token: 0x040007DC RID: 2012
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007DC")]
	private float timer;

	// Token: 0x040007DD RID: 2013
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40007DD")]
	private readonly float maxTimer = 10f;
}
