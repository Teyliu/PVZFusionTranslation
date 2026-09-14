using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000343")]
public class BigChomper : Chomper
{
	// Token: 0x06000F53 RID: 3923 RVA: 0x00059360 File Offset: 0x00057560
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x41A170", Offset = "0x418770", VA = "0x18041A170", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeFloat = 2.5f;
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00059380 File Offset: 0x00057580
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x41A850", Offset = "0x418E50", VA = "0x18041A850", Slot = "69")]
	protected override void SetAttackRange()
	{
		this.centerOffset = (ulong)1073741824L;
		this.centerOffset.y = 0.5f;
		this.range = (ulong)1077936128L;
		this.range.y = 1.5f;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)2)))
		{
			Vector2 centerOffset = this.centerOffset;
			Vector2 range = this.range;
			this.centerOffset = centerOffset;
			this.range = range;
		}
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x000593FC File Offset: 0x000575FC
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x41A190", Offset = "0x418790", VA = "0x18041A190", Slot = "73")]
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

	// Token: 0x06000F56 RID: 3926 RVA: 0x00059468 File Offset: 0x00057668
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x41A300", Offset = "0x418900", VA = "0x18041A300")]
	private bool CheckBoss(Zombie zombie)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		return flag;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00059488 File Offset: 0x00057688
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x41A360", Offset = "0x418960", VA = "0x18041A360", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		int num = 0;
		if (!(zombie == num))
		{
		}
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			if (flag)
			{
				if (flag <= true)
				{
				}
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (flag2 || !flag3)
				{
				}
			}
			num4++;
		}
		int num5 = 0;
		if (zombie != num5)
		{
			uint num6;
			zombie.Die((int)num6);
		}
		Board board = this.board;
		float swallowMaxCountDown = this.swallowMaxCountDown;
		base.AttributeCountdown = swallowMaxCountDown;
		this.anim.CrossFade("chew", 0.5f);
		this.targetZombie = (ulong)0L;
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		this.theStatus = (PlantStatus)((ulong)22L);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0005955C File Offset: 0x0005775C
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public BigChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}
}
