using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class BigChomper : Chomper
{
	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0005A2F8 File Offset: 0x000584F8
	// (set) Token: 0x06000F9F RID: 3999 RVA: 0x0005A30C File Offset: 0x0005850C
	[Token(Token = "0x17000117")]
	public override float ChompRange
	{
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x4717D0", Offset = "0x46FDD0", VA = "0x1804717D0", Slot = "68")]
		get
		{
			return this.<ChompRange>k__BackingField;
		}
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x468010", Offset = "0x466610", VA = "0x180468010", Slot = "69")]
		set
		{
			this.<ChompRange>k__BackingField = value;
		}
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0005A320 File Offset: 0x00058520
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x470FF0", Offset = "0x46F5F0", VA = "0x180470FF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeFloat = 2.5f;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0005A340 File Offset: 0x00058540
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x471010", Offset = "0x46F610", VA = "0x180471010", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (!(targetZombie != num))
		{
		}
		int theZombieType = (int)this.targetZombie.theZombieType;
		Zombie targetZombie2 = this.targetZombie;
		bool flag;
		if (flag || targetZombie2.isMindControlled != flag)
		{
			PlantType thePlantType = this.thePlantType;
			ulong num2;
			targetZombie2.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
			this.targetZombie = (ulong)0L;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0005A3AC File Offset: 0x000585AC
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x471180", Offset = "0x46F780", VA = "0x180471180")]
	private bool CheckBoss(Zombie zombie)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		return flag;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0005A3CC File Offset: 0x000585CC
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x4711E0", Offset = "0x46F7E0", VA = "0x1804711E0", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		if (!(zombie == num2))
		{
		}
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		float chompRange = this.ChompRange;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				if (flag <= true)
				{
				}
				int thePlantRow = this.thePlantRow;
				if (TypeMgr.IsBossZombie((ZombieType)num) || !(num == zombie))
				{
				}
			}
			num++;
		}
		int num4 = 0;
		if (zombie != num4)
		{
			uint num5;
			zombie.Die((int)num5);
		}
		Board board = this.board;
		float swallowMaxCountDown = this.swallowMaxCountDown;
		base.AttributeCountdown = swallowMaxCountDown;
		this.anim.CrossFade("chew", 0.5f);
		this.targetZombie = num;
		uint num6;
		GameAPP.PlaySound((int)num6, 0.5f, 1f);
		this.theStatus = (PlantStatus)((ulong)22L);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0005A4B0 File Offset: 0x000586B0
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x4717B0", Offset = "0x46FDB0", VA = "0x1804717B0")]
	public BigChomper()
	{
		this.swallowMaxCountDown = 40f;
		this.<ChompRange>k__BackingField = 2f;
		base..ctor();
	}
}
