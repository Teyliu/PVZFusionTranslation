using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D3 RID: 1491
[Token(Token = "0x20005D3")]
public class Tower_cherryChomper : TowerPlant
{
	// Token: 0x06001BED RID: 7149 RVA: 0x000951A8 File Offset: 0x000933A8
	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x50E2A0", Offset = "0x50C8A0", VA = "0x18050E2A0", Slot = "75")]
	public override string GetUniqueText()
	{
		float num = this.swallowMaxCountDown;
		return string.Format("咀嚼耗时：{0:F0}秒", "咀嚼耗时：{0:F0}秒");
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000951CC File Offset: 0x000933CC
	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "47")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x000951DC File Offset: 0x000933DC
	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x50E4E0", Offset = "0x50CAE0", VA = "0x18050E4E0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.swallowMaxCountDown * 0.5f;
		this.swallowMaxCountDown = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x0009522C File Offset: 0x0009342C
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x50DA90", Offset = "0x50C090", VA = "0x18050DA90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0009524C File Offset: 0x0009344C
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x50E310", Offset = "0x50C910", VA = "0x18050E310", Slot = "76")]
	protected virtual void SetAttackRange()
	{
		Transform axis = this.axis;
		this.range = (ulong)1069547520L;
		this.range.y = 1.5f;
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x00095284 File Offset: 0x00093484
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x50E490", Offset = "0x50CA90", VA = "0x18050E490", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			base.ShootUpdate();
		}
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000952A8 File Offset: 0x000934A8
	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x50DA70", Offset = "0x50C070", VA = "0x18050DA70", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x000952B8 File Offset: 0x000934B8
	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x50E3C0", Offset = "0x50C9C0", VA = "0x18050E3C0", Slot = "77")]
	protected virtual void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x000952F0 File Offset: 0x000934F0
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x50DDE0", Offset = "0x50C3E0", VA = "0x18050DDE0", Slot = "78")]
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

	// Token: 0x06001BF6 RID: 7158 RVA: 0x00095384 File Offset: 0x00093584
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x426700", Offset = "0x424D00", VA = "0x180426700")]
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

	// Token: 0x06001BF7 RID: 7159 RVA: 0x000953C8 File Offset: 0x000935C8
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x50E250", Offset = "0x50C850", VA = "0x18050E250", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x000953E8 File Offset: 0x000935E8
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x50DAD0", Offset = "0x50C0D0", VA = "0x18050DAD0", Slot = "79")]
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

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00095464 File Offset: 0x00093664
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x50DCB0", Offset = "0x50C2B0", VA = "0x18050DCB0", Slot = "80")]
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

	// Token: 0x06001BFA RID: 7162 RVA: 0x000954C8 File Offset: 0x000936C8
	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x50DC10", Offset = "0x50C210", VA = "0x18050DC10")]
	protected void ChompBack()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		this.anim.SetTrigger("back");
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00095508 File Offset: 0x00093708
	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0x50E430", Offset = "0x50CA30", VA = "0x18050E430")]
	public void ToChew()
	{
		if (this.canToChew)
		{
			this.anim.Play("chew");
		}
		this.canToChew = false;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x0009553C File Offset: 0x0009373C
	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0x50E560", Offset = "0x50CB60", VA = "0x18050E560")]
	public Tower_cherryChomper()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000EFE RID: 3838
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EFE")]
	protected Vector2 pos;

	// Token: 0x04000EFF RID: 3839
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EFF")]
	public float swallowMaxCountDown = 40f;

	// Token: 0x04000F00 RID: 3840
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000F00")]
	protected bool canToChew;

	// Token: 0x04000F01 RID: 3841
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F01")]
	protected Vector2 range;

	// Token: 0x04000F02 RID: 3842
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000F02")]
	protected Vector2 centerOffset;
}
