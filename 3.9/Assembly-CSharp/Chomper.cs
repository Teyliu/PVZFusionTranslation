using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037A RID: 890
[Token(Token = "0x200037A")]
public class Chomper : Attacker
{
	// Token: 0x1700011D RID: 285
	// (get) Token: 0x0600104B RID: 4171 RVA: 0x0005D4AC File Offset: 0x0005B6AC
	// (set) Token: 0x0600104C RID: 4172 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
	[Token(Token = "0x1700011D")]
	public virtual float ChompRange
	{
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x47DE40", Offset = "0x47C440", VA = "0x18047DE40", Slot = "68")]
		get;
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x468010", Offset = "0x466610", VA = "0x180468010", Slot = "69")]
		set;
	} = 2f;

	// Token: 0x0600104D RID: 4173 RVA: 0x0005D4D4 File Offset: 0x0005B6D4
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x47DBB0", Offset = "0x47C1B0", VA = "0x18047DBB0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)1)))
		{
			float attributeSpeed = this.attributeSpeed;
			this.attributeSpeed = attributeSpeed;
		}
		float num;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)2)))
		{
			num = this.ChompRange;
			this.ChompRange = num;
		}
		Board board = this.board;
		num = this.ChompRange;
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0005D53C File Offset: 0x0005B73C
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x47DDF0", Offset = "0x47C3F0", VA = "0x18047DDF0", Slot = "57")]
	protected override void UpgradeEvent(int theCurrentLevel)
	{
		uint num;
		num -= (uint)theCurrentLevel;
		num -= (uint)theCurrentLevel;
		num += num;
		num += num;
		this.swallowMaxCountDown = 5f;
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0005D568 File Offset: 0x0005B768
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x47D270", Offset = "0x47B870", VA = "0x18047D270", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.Swallow();
		AdvantureMission.TryAddCount((AdvantureLevel)((uint)6));
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x0005D584 File Offset: 0x0005B784
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x47DD20", Offset = "0x47C320", VA = "0x18047DD20", Slot = "70")]
	protected virtual void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x0005D5BC File Offset: 0x0005B7BC
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x47D610", Offset = "0x47BC10", VA = "0x18047D610", Slot = "71")]
	public virtual void ChomperSearchZombie([Optional] Collider2D collision)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.CheckZombie(num))
				{
					continue;
				}
				this.targetZombie = num;
				this.anim.SetTrigger("bite");
				this.theStatus = (PlantStatus)((ulong)22L);
			}
		}
		while (num2 != 0);
		int num4 = 0;
		Collider2D[] array;
		if (num4 < array.Length)
		{
			bool flag2;
			bool flag3;
			if (!flag2 || flag3)
			{
			}
			num4++;
		}
		int num5 = 0;
		if (num4 != num5)
		{
		}
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x0005D660 File Offset: 0x0005B860
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x47D3F0", Offset = "0x47B9F0", VA = "0x18047D3F0", Slot = "72")]
	protected virtual bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && !zombie.beforeDying)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Snokle_inWater)
			{
				if (theStatus != ZombieStatus.Bungi_awake)
				{
					goto IL_0030;
				}
			}
		}
		IL_0024:
		while (zombie == (ulong)1L)
		{
		}
		while (zombie == (ulong)7L)
		{
		}
		goto IL_0030;
		goto IL_0024;
		IL_0030:
		throw new NullReferenceException();
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0005D6A4 File Offset: 0x0005B8A4
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x47DB00", Offset = "0x47C100", VA = "0x18047DB00", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x0005D6D0 File Offset: 0x0005B8D0
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x47D2A0", Offset = "0x47B8A0", VA = "0x18047D2A0", Slot = "73")]
	public virtual void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			int theZombieType = (int)this.targetZombie.theZombieType;
			Zombie targetZombie2 = this.targetZombie;
			bool flag;
			if (flag || (targetZombie2.theStatus > ZombieStatus.Pol_run && !targetZombie2.isMindControlled && !targetZombie2.beforeDying))
			{
				PlantType thePlantType = this.thePlantType;
				ulong num2;
				targetZombie2.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0005D744 File Offset: 0x0005B944
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x47D540", Offset = "0x47BB40", VA = "0x18047D540", Slot = "74")]
	protected virtual void Chomp(Zombie zombie)
	{
		zombie.Die(2);
		float num = this.swallowMaxCountDown;
		base.AttributeCountdown = num;
		this.canToChew = true;
		this.targetZombie = (ulong)0L;
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.theStatus = (PlantStatus)((ulong)23L);
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x0005D798 File Offset: 0x0005B998
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x47D4A0", Offset = "0x47BAA0", VA = "0x18047D4A0", Slot = "75")]
	protected virtual void ChompBack()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		this.anim.SetTrigger("back");
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x0005D7D8 File Offset: 0x0005B9D8
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x47DD90", Offset = "0x47C390", VA = "0x18047DD90")]
	public void ToChew()
	{
		if (this.canToChew)
		{
			this.anim.Play("chew");
		}
		this.canToChew = false;
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x0005D80C File Offset: 0x0005BA0C
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x4717B0", Offset = "0x46FDB0", VA = "0x1804717B0")]
	public Chomper()
	{
	}

	// Token: 0x04000BB7 RID: 2999
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BB7")]
	public float swallowMaxCountDown = 40f;

	// Token: 0x04000BB8 RID: 3000
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000BB8")]
	protected bool canToChew;
}
