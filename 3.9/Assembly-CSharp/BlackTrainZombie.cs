using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000666 RID: 1638
[Token(Token = "0x2000666")]
public class BlackTrainZombie : Zombie
{
	// Token: 0x06001EFF RID: 7935 RVA: 0x000A4F68 File Offset: 0x000A3168
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x588A00", Offset = "0x587000", VA = "0x180588A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x000A4F88 File Offset: 0x000A3188
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x589FC0", Offset = "0x5885C0", VA = "0x180589FC0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)33)))
		{
			this.uniqueSpeed = 2.5f;
		}
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x000A4FB4 File Offset: 0x000A31B4
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x589940", Offset = "0x587F40", VA = "0x180589940", Slot = "24")]
	protected override void AttributeEvent()
	{
		long num = this.theMaxHealth;
		this.attributeCountDown = 0.1f;
		num = num.MultiplyPercent(1f);
		int num2 = num.ToInt();
		this.BodyTakeDamage(num2);
		base.UpdateHealthText();
		float uniqueSpeed = this.uniqueSpeed;
		if (uniqueSpeed > 1f)
		{
			this.uniqueSpeed = uniqueSpeed;
		}
		int column = base.Column;
		this.theHealth = (long)((ulong)0L);
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000A501C File Offset: 0x000A321C
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x589A30", Offset = "0x588030", VA = "0x180589A30", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				global::Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000A5054 File Offset: 0x000A3254
	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000A5064 File Offset: 0x000A3264
	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x000A5084 File Offset: 0x000A3284
	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x589BF0", Offset = "0x5881F0", VA = "0x180589BF0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		int num;
		do
		{
			num = 0;
			GameAPP.PlaySound(43, 0.5f, 1f);
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			int num2 = 0;
			int theZombieRow = this.theZombieRow;
			ulong num3;
			Particle particle = instance.SetParticle((ParticleType)((uint)54), num, theZombieRow, num3 != 0UL, (float)num2);
			List<Transform> list = this.pos;
			bool flag;
			if (flag)
			{
				CreateZombie instance2 = CreateZombie.Instance;
				bool isMindControlled = this.isMindControlled;
				int num4 = 0;
				Zombie zombie;
				if (!(zombie != num4))
				{
					continue;
				}
				this.board.SetHealthInTravel(zombie);
			}
		}
		while (num != 0);
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000A513C File Offset: 0x000A333C
	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x589F70", Offset = "0x588570", VA = "0x180589F70", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!global::Lawnf.TravelDebuff((TravelDebuff)((uint)32)))
		{
			base.SetFreeze(time, theFreezeLevel);
		}
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000A515C File Offset: 0x000A335C
	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x589BA0", Offset = "0x5881A0", VA = "0x180589BA0", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!global::Lawnf.TravelDebuff((TravelDebuff)((uint)32)))
		{
			base.Buttered(time, sprite);
		}
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x000A517C File Offset: 0x000A337C
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x000A518C File Offset: 0x000A338C
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x589FF0", Offset = "0x5885F0", VA = "0x180589FF0")]
	public BlackTrainZombie()
	{
		List<Transform> list = new List();
		this.pos = list;
		base..ctor();
	}

	// Token: 0x04001105 RID: 4357
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001105")]
	public List<Transform> pos;
}
