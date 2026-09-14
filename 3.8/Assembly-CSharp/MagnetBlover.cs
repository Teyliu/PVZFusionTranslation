using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020003DA RID: 986
[Token(Token = "0x20003DA")]
public class MagnetBlover : Magnetshroom
{
	// Token: 0x06001220 RID: 4640 RVA: 0x000660FC File Offset: 0x000642FC
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x44E930", Offset = "0x44CF30", VA = "0x18044E930", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		this.attrackMaxTime = 1f;
		anim.SetTrigger("blow");
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00066140 File Offset: 0x00064340
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x44E2C0", Offset = "0x44C8C0", VA = "0x18044E2C0")]
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

	// Token: 0x06001222 RID: 4642 RVA: 0x0006619C File Offset: 0x0006439C
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x41C540", Offset = "0x41AB40", VA = "0x18041C540")]
	protected void DelayDie()
	{
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x000661AC File Offset: 0x000643AC
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x44E3E0", Offset = "0x44C9E0", VA = "0x18044E3E0", Slot = "78")]
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

	// Token: 0x06001224 RID: 4644 RVA: 0x000661F4 File Offset: 0x000643F4
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x44E560", Offset = "0x44CB60", VA = "0x18044E560", Slot = "75")]
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

	// Token: 0x06001225 RID: 4645 RVA: 0x00066258 File Offset: 0x00064458
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x44E670", Offset = "0x44CC70", VA = "0x18044E670", Slot = "70")]
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

	// Token: 0x06001226 RID: 4646 RVA: 0x000662B4 File Offset: 0x000644B4
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x446C80", Offset = "0x445280", VA = "0x180446C80")]
	public MagnetBlover()
	{
		this.attrackRange = 4f;
		this.attrackMaxTime = 15f;
		this.rangeRow = 2f;
		base..ctor();
	}
}
