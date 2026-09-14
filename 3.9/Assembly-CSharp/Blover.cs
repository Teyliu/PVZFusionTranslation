using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000358")]
public class Blover : Plant
{
	// Token: 0x06000FB8 RID: 4024 RVA: 0x0005A9E4 File Offset: 0x00058BE4
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x473400", Offset = "0x471A00", VA = "0x180473400", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("blow");
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0005AA10 File Offset: 0x00058C10
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x473140", Offset = "0x471740", VA = "0x180473140", Slot = "68")]
	protected virtual void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		this.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		base.Invoke("DelayDie", 1f);
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0005AA6C File Offset: 0x00058C6C
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x4733E0", Offset = "0x4719E0", VA = "0x1804733E0")]
	protected void DelayDie()
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x0005AA7C File Offset: 0x00058C7C
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x473260", Offset = "0x471860", VA = "0x180473260", Slot = "69")]
	protected virtual void BlowZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				Blow blow = num.AddComponent<Blow>();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x0005AAC4 File Offset: 0x00058CC4
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Blover()
	{
	}
}
