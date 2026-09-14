using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036A RID: 874
[Token(Token = "0x200036A")]
public class Chomper : Attacker
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0005C4E8 File Offset: 0x0005A6E8
	[Token(Token = "0x170000DA")]
	protected Vector2 Pos
	{
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x4271A0", Offset = "0x4257A0", VA = "0x1804271A0")]
		get
		{
			Transform axis = this.axis;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0005C50C File Offset: 0x0005A70C
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x426FD0", Offset = "0x4255D0", VA = "0x180426FD0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)1)))
		{
			float attributeSpeed = this.attributeSpeed;
			this.attributeSpeed = attributeSpeed;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0005C544 File Offset: 0x0005A744
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x427150", Offset = "0x425750", VA = "0x180427150", Slot = "58")]
	protected override void UpgradeEvent(int theCurrentLevel)
	{
		uint num;
		num -= (uint)theCurrentLevel;
		num -= (uint)theCurrentLevel;
		num += num;
		num += num;
		this.swallowMaxCountDown = 5f;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0005C570 File Offset: 0x0005A770
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x426EF0", Offset = "0x4254F0", VA = "0x180426EF0", Slot = "69")]
	protected virtual void SetAttackRange()
	{
		this.centerOffset = (ulong)1069547520L;
		this.centerOffset.y = 0.5f;
		this.range = (ulong)1069547520L;
		this.range.y = 1.5f;
		if (!AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)2)))
		{
			Board board = this.board;
		}
		Vector2 vector = this.centerOffset;
		Vector2 vector2 = this.range;
		this.centerOffset = vector;
		this.range = vector2;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x426580", Offset = "0x424B80", VA = "0x180426580", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.Swallow();
		AdvantureMission.TryAddCount((AdvantureLevel)((uint)6));
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x0005C610 File Offset: 0x0005A810
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x427080", Offset = "0x425680", VA = "0x180427080", Slot = "70")]
	protected virtual void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x0005C648 File Offset: 0x0005A848
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x426920", Offset = "0x424F20", VA = "0x180426920", Slot = "71")]
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
		bool flag4;
		if (flag4)
		{
		}
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0005C6E0 File Offset: 0x0005A8E0
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x426700", Offset = "0x424D00", VA = "0x180426700", Slot = "72")]
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

	// Token: 0x06001007 RID: 4103 RVA: 0x0005C724 File Offset: 0x0005A924
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x426D80", Offset = "0x425380", VA = "0x180426D80", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x0005C750 File Offset: 0x0005A950
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x4265B0", Offset = "0x424BB0", VA = "0x1804265B0", Slot = "73")]
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

	// Token: 0x06001009 RID: 4105 RVA: 0x0005C7C4 File Offset: 0x0005A9C4
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x426850", Offset = "0x424E50", VA = "0x180426850", Slot = "74")]
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

	// Token: 0x0600100A RID: 4106 RVA: 0x0005C818 File Offset: 0x0005AA18
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x4267B0", Offset = "0x424DB0", VA = "0x1804267B0", Slot = "75")]
	protected virtual void ChompBack()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		this.anim.SetTrigger("back");
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0005C858 File Offset: 0x0005AA58
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x4270F0", Offset = "0x4256F0", VA = "0x1804270F0")]
	public void ToChew()
	{
		if (this.canToChew)
		{
			this.anim.Play("chew");
		}
		this.canToChew = false;
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0005C88C File Offset: 0x0005AA8C
	[Token(Token = "0x600100C")]
	[Address(RVA = "0x426E30", Offset = "0x425430", VA = "0x180426E30")]
	private void OnDrawGizmos()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x0005C8B0 File Offset: 0x0005AAB0
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public Chomper()
	{
	}

	// Token: 0x04000B66 RID: 2918
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B66")]
	public float swallowMaxCountDown = 40f;

	// Token: 0x04000B67 RID: 2919
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B67")]
	protected bool canToChew;

	// Token: 0x04000B68 RID: 2920
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B68")]
	protected Vector2 range;

	// Token: 0x04000B69 RID: 2921
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B69")]
	protected Vector2 centerOffset;
}
