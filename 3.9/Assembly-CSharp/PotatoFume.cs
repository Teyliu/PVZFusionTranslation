using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000577 RID: 1399
[Token(Token = "0x2000577")]
public class PotatoFume : FumeShroom
{
	// Token: 0x060019F8 RID: 6648 RVA: 0x0008BB58 File Offset: 0x00089D58
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0008BB78 File Offset: 0x00089D78
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x539BC0", Offset = "0x5381C0", VA = "0x180539BC0", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0008BB90 File Offset: 0x00089D90
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x539BD0", Offset = "0x5381D0", VA = "0x180539BD0", Slot = "17")]
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

	// Token: 0x060019FB RID: 6651 RVA: 0x0008BBE0 File Offset: 0x00089DE0
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x539C90", Offset = "0x538290", VA = "0x180539C90", Slot = "68")]
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

	// Token: 0x060019FC RID: 6652 RVA: 0x0008BC54 File Offset: 0x00089E54
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x5399F0", Offset = "0x537FF0", VA = "0x1805399F0", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		base.Attack(zombie);
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x0008BCA8 File Offset: 0x00089EA8
	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x50B0A0", Offset = "0x5096A0", VA = "0x18050B0A0")]
	public PotatoFume()
	{
	}

	// Token: 0x04000EF6 RID: 3830
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EF6")]
	private float flashTimer;
}
