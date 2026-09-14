using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D5 RID: 1749
[Token(Token = "0x20006D5")]
public class SummonedHorse : Zombie
{
	// Token: 0x06002271 RID: 8817 RVA: 0x000B49C4 File Offset: 0x000B2BC4
	[Token(Token = "0x6002271")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "46")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000B49D4 File Offset: 0x000B2BD4
	[Token(Token = "0x6002272")]
	[Address(RVA = "0x573890", Offset = "0x571E90", VA = "0x180573890", Slot = "45")]
	public override void DestoryZombie()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)120), num, theZombieRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(142, 0.5f, 1f);
		IEnumerator enumerator = base.FadeDeath();
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000B4A3C File Offset: 0x000B2C3C
	[Token(Token = "0x6002273")]
	[Address(RVA = "0x5739A0", Offset = "0x571FA0", VA = "0x1805739A0", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			int theZombieRow = this.theZombieRow;
			int num2 = 0;
			Plant plant;
			if (plant == num2)
			{
			}
			return;
		}
		bool flag;
		while (!flag)
		{
		}
		int theZombieRow2 = this.theZombieRow;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000B4A80 File Offset: 0x000B2C80
	[Token(Token = "0x6002274")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000B4A90 File Offset: 0x000B2C90
	[Token(Token = "0x6002275")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000B4AA0 File Offset: 0x000B2CA0
	[Token(Token = "0x6002276")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000B4AB0 File Offset: 0x000B2CB0
	[Token(Token = "0x6002277")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000B4AC0 File Offset: 0x000B2CC0
	[Token(Token = "0x6002278")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000B4ADC File Offset: 0x000B2CDC
	[Token(Token = "0x6002279")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000B4AEC File Offset: 0x000B2CEC
	[Token(Token = "0x600227A")]
	[Address(RVA = "0x573B40", Offset = "0x572140", VA = "0x180573B40")]
	public SummonedHorse()
	{
	}
}
