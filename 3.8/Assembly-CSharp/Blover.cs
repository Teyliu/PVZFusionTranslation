using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000348 RID: 840
[Token(Token = "0x2000348")]
public class Blover : Plant
{
	// Token: 0x06000F6C RID: 3948 RVA: 0x00059A84 File Offset: 0x00057C84
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x41C560", Offset = "0x41AB60", VA = "0x18041C560", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("blow");
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00059AB0 File Offset: 0x00057CB0
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x41C2A0", Offset = "0x41A8A0", VA = "0x18041C2A0", Slot = "69")]
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

	// Token: 0x06000F6E RID: 3950 RVA: 0x00059B0C File Offset: 0x00057D0C
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x41C540", Offset = "0x41AB40", VA = "0x18041C540")]
	protected void DelayDie()
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00059B1C File Offset: 0x00057D1C
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x41C3C0", Offset = "0x41A9C0", VA = "0x18041C3C0", Slot = "70")]
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

	// Token: 0x06000F70 RID: 3952 RVA: 0x00059B64 File Offset: 0x00057D64
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Blover()
	{
	}
}
