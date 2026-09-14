using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000549 RID: 1353
[Token(Token = "0x2000549")]
public class PotatoFume : FumeShroom
{
	// Token: 0x06001923 RID: 6435 RVA: 0x00087DB0 File Offset: 0x00085FB0
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00087DD0 File Offset: 0x00085FD0
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x4DC440", Offset = "0x4DAA40", VA = "0x1804DC440", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00087DE8 File Offset: 0x00085FE8
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x4DC450", Offset = "0x4DAA50", VA = "0x1804DC450", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			float num = this.flashTimer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.flashTimer = num;
			if (num2 > (int)num)
			{
				this.anim.SetTrigger("flash");
			}
		}
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00087E38 File Offset: 0x00086038
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x4DC510", Offset = "0x4DAB10", VA = "0x1804DC510", Slot = "69")]
	protected override Bullet Shoot1()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform shoot = this.shoot;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)133), num, thePlantRow, num3 != 0UL, (float)num2);
		base.AttackZombie();
		this.theStatus = (PlantStatus)((ulong)0L);
		base.AttributeCountdown = 15f;
		GameAPP.PlaySound(58, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00087EAC File Offset: 0x000860AC
	[Token(Token = "0x6001927")]
	[Address(RVA = "0x4DC270", Offset = "0x4DA870", VA = "0x1804DC270", Slot = "74")]
	protected override void Attack(Zombie zombie)
	{
		base.Attack(zombie);
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00087F00 File Offset: 0x00086100
	[Token(Token = "0x6001928")]
	[Address(RVA = "0x49B750", Offset = "0x499D50", VA = "0x18049B750")]
	public PotatoFume()
	{
	}

	// Token: 0x04000E39 RID: 3641
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E39")]
	private float flashTimer;
}
