using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020003F0 RID: 1008
[Token(Token = "0x20003F0")]
public class MagnetBlover : Magnetshroom
{
	// Token: 0x06001283 RID: 4739 RVA: 0x000679BC File Offset: 0x00065BBC
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x4A3100", Offset = "0x4A1700", VA = "0x1804A3100", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		this.attrackMaxTime = 1f;
		anim.SetTrigger("blow");
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00067A00 File Offset: 0x00065C00
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x4A2A90", Offset = "0x4A1090", VA = "0x1804A2A90")]
	private void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		this.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		base.Invoke("DelayDie", 10f);
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00067A5C File Offset: 0x00065C5C
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x4733E0", Offset = "0x4719E0", VA = "0x1804733E0")]
	protected void DelayDie()
	{
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00067A6C File Offset: 0x00065C6C
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x4A2BB0", Offset = "0x4A11B0", VA = "0x1804A2BB0", Slot = "77")]
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

	// Token: 0x06001287 RID: 4743 RVA: 0x00067AB4 File Offset: 0x00065CB4
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x4A2D30", Offset = "0x4A1330", VA = "0x1804A2D30", Slot = "74")]
	protected override void MoveIronItem()
	{
		Transform transform = base.transform.Find("Blover_petal");
		int num = 0;
		Transform child = transform.GetChild(num);
		GameObject targetItem = this.targetItem;
		int num2 = 0;
		IEnumerator enumerator = base.MoveObject(targetItem, num2, 0.3f);
		Coroutine coroutine = base.StartCoroutine(enumerator);
		this.targetItem.transform.parentInternal = child;
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00067B18 File Offset: 0x00065D18
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x4A2E40", Offset = "0x4A1440", VA = "0x1804A2E40", Slot = "69")]
	protected override void SearchZombieWithIron()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> list = new List();
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
			ulong num3;
			if (num3 == (ulong)0L)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00067B74 File Offset: 0x00065D74
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x49B110", Offset = "0x499710", VA = "0x18049B110")]
	public MagnetBlover()
	{
		this.attrackRange = 4f;
		this.attrackMaxTime = 15f;
		this.rangeRow = 2f;
		base..ctor();
	}
}
