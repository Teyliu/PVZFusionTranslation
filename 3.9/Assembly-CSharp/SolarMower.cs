using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000293 RID: 659
[Token(Token = "0x2000293")]
public class SolarMower : Mower
{
	// Token: 0x06000BE8 RID: 3048 RVA: 0x00043FDC File Offset: 0x000421DC
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x42AA30", Offset = "0x429030", VA = "0x18042AA30", Slot = "5")]
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

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00044038 File Offset: 0x00042238
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x42A860", Offset = "0x428E60", VA = "0x18042A860")]
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

	// Token: 0x06000BEA RID: 3050 RVA: 0x00044090 File Offset: 0x00042290
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x42AAF0", Offset = "0x4290F0", VA = "0x18042AAF0")]
	public SolarMower()
	{
		this.speed = 5f;
		base..ctor();
	}

	// Token: 0x040007E8 RID: 2024
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007E8")]
	private float timer;

	// Token: 0x040007E9 RID: 2025
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40007E9")]
	private readonly float maxTimer = 10f;
}
