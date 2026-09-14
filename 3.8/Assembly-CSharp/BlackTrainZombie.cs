using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000630 RID: 1584
[Token(Token = "0x2000630")]
public class BlackTrainZombie : Zombie
{
	// Token: 0x06001DFD RID: 7677 RVA: 0x000A0818 File Offset: 0x0009EA18
	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x531EB0", Offset = "0x5304B0", VA = "0x180531EB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x000A0838 File Offset: 0x0009EA38
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x5332E0", Offset = "0x5318E0", VA = "0x1805332E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)33)))
		{
			this.uniqueSpeed = 2.5f;
		}
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x000A0864 File Offset: 0x0009EA64
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x532C70", Offset = "0x531270", VA = "0x180532C70", Slot = "23")]
	protected override void AttributeEvent()
	{
		int theMaxHealth = this.theMaxHealth;
		this.attributeCountDown = 0.1f;
		int num = theMaxHealth.MultiplyPercent(1f);
		this.BodyTakeDamage(num);
		base.UpdateHealthText();
		float uniqueSpeed = this.uniqueSpeed;
		if (uniqueSpeed > 1f)
		{
			this.uniqueSpeed = uniqueSpeed;
		}
		int column = base.Column;
		this.theHealth = (int)((ulong)0L);
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x000A08C4 File Offset: 0x0009EAC4
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x532D50", Offset = "0x531350", VA = "0x180532D50", Slot = "29")]
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
				global::Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000A0900 File Offset: 0x0009EB00
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x000A0910 File Offset: 0x0009EB10
	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x000A0930 File Offset: 0x0009EB30
	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x532F10", Offset = "0x531510", VA = "0x180532F10", Slot = "28")]
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

	// Token: 0x06001E04 RID: 7684 RVA: 0x000A09E8 File Offset: 0x0009EBE8
	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x533290", Offset = "0x531890", VA = "0x180533290", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!global::Lawnf.TravelDebuff((TravelDebuff)((uint)32)))
		{
			base.SetFreeze(time, theFreezeLevel);
		}
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x000A0A08 File Offset: 0x0009EC08
	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x532EC0", Offset = "0x5314C0", VA = "0x180532EC0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!global::Lawnf.TravelDebuff((TravelDebuff)((uint)32)))
		{
			base.Buttered(time, sprite);
		}
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000A0A28 File Offset: 0x0009EC28
	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000A0A38 File Offset: 0x0009EC38
	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x533310", Offset = "0x531910", VA = "0x180533310")]
	public BlackTrainZombie()
	{
		List<Transform> list = new List();
		this.pos = list;
		base..ctor();
	}

	// Token: 0x04001039 RID: 4153
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001039")]
	public List<Transform> pos;
}
