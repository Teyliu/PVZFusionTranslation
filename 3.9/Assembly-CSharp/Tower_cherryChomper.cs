using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000608 RID: 1544
[Token(Token = "0x2000608")]
public class Tower_cherryChomper : TowerPlant
{
	// Token: 0x06001CEC RID: 7404 RVA: 0x00099DC0 File Offset: 0x00097FC0
	[Token(Token = "0x6001CEC")]
	[Address(RVA = "0x55F4F0", Offset = "0x55DAF0", VA = "0x18055F4F0", Slot = "74")]
	public override string GetUniqueText()
	{
		float num = this.swallowMaxCountDown;
		return string.Format("咀嚼耗时：{0:F0}秒", "咀嚼耗时：{0:F0}秒");
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x00099DE4 File Offset: 0x00097FE4
	[Token(Token = "0x6001CED")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "46")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x00099DF4 File Offset: 0x00097FF4
	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x55F730", Offset = "0x55DD30", VA = "0x18055F730", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.swallowMaxCountDown * 0.5f;
		this.swallowMaxCountDown = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00099E44 File Offset: 0x00098044
	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x55ECE0", Offset = "0x55D2E0", VA = "0x18055ECE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00099E64 File Offset: 0x00098064
	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x55F560", Offset = "0x55DB60", VA = "0x18055F560", Slot = "75")]
	protected virtual void SetAttackRange()
	{
		Transform axis = this.axis;
		this.range = (ulong)1069547520L;
		this.range.y = 1.5f;
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x00099E9C File Offset: 0x0009809C
	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x55F6E0", Offset = "0x55DCE0", VA = "0x18055F6E0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			base.ShootUpdate();
		}
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x00099EC0 File Offset: 0x000980C0
	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x55ECC0", Offset = "0x55D2C0", VA = "0x18055ECC0", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x00099ED0 File Offset: 0x000980D0
	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x55F610", Offset = "0x55DC10", VA = "0x18055F610", Slot = "76")]
	protected virtual void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x00099F08 File Offset: 0x00098108
	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x55F030", Offset = "0x55D630", VA = "0x18055F030", Slot = "77")]
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
				if (!(num != num3))
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
			if (flag2)
			{
				if (flag2 <= true)
				{
				}
				num4++;
			}
			num4++;
		}
		bool flag3;
		if (flag3)
		{
		}
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x00099F9C File Offset: 0x0009819C
	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x47D3F0", Offset = "0x47B9F0", VA = "0x18047D3F0")]
	protected new bool CheckZombie(Zombie zombie)
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

	// Token: 0x06001CF6 RID: 7414 RVA: 0x00099FE0 File Offset: 0x000981E0
	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x55F4A0", Offset = "0x55DAA0", VA = "0x18055F4A0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x0009A000 File Offset: 0x00098200
	[Token(Token = "0x6001CF7")]
	[Address(RVA = "0x55ED20", Offset = "0x55D320", VA = "0x18055ED20", Slot = "78")]
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
		this.ChompBack();
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x0009A07C File Offset: 0x0009827C
	[Token(Token = "0x6001CF8")]
	[Address(RVA = "0x55EF00", Offset = "0x55D500", VA = "0x18055EF00", Slot = "79")]
	protected virtual void Chomp(Zombie zombie)
	{
		zombie.Die(2);
		float num = this.swallowMaxCountDown;
		base.AttributeCountdown = num;
		this.canToChew = true;
		this.targetZombie = (ulong)0L;
		Board board = this.board;
		this.theStatus = (PlantStatus)((ulong)22L);
		Transform axis = zombie.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x0009A0E0 File Offset: 0x000982E0
	[Token(Token = "0x6001CF9")]
	[Address(RVA = "0x55EE60", Offset = "0x55D460", VA = "0x18055EE60")]
	protected void ChompBack()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		this.anim.SetTrigger("back");
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x0009A120 File Offset: 0x00098320
	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x55F680", Offset = "0x55DC80", VA = "0x18055F680")]
	public void ToChew()
	{
		if (this.canToChew)
		{
			this.anim.Play("chew");
		}
		this.canToChew = false;
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x0009A154 File Offset: 0x00098354
	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x55F7B0", Offset = "0x55DDB0", VA = "0x18055F7B0")]
	public Tower_cherryChomper()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000FC6 RID: 4038
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FC6")]
	protected Vector2 pos;

	// Token: 0x04000FC7 RID: 4039
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000FC7")]
	public float swallowMaxCountDown = 40f;

	// Token: 0x04000FC8 RID: 4040
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000FC8")]
	protected bool canToChew;

	// Token: 0x04000FC9 RID: 4041
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000FC9")]
	protected Vector2 range;

	// Token: 0x04000FCA RID: 4042
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000FCA")]
	protected Vector2 centerOffset;
}
