using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070D RID: 1805
[Token(Token = "0x200070D")]
public class SummonedHorse : Zombie
{
	// Token: 0x0600238B RID: 9099 RVA: 0x000B9780 File Offset: 0x000B7980
	[Token(Token = "0x600238B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "48")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x000B9790 File Offset: 0x000B7990
	[Token(Token = "0x600238C")]
	[Address(RVA = "0x5D6F00", Offset = "0x5D5500", VA = "0x1805D6F00", Slot = "47")]
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

	// Token: 0x0600238D RID: 9101 RVA: 0x000B97F8 File Offset: 0x000B79F8
	[Token(Token = "0x600238D")]
	[Address(RVA = "0x5D7010", Offset = "0x5D5610", VA = "0x1805D7010", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		for (;;)
		{
			int num = 0;
			if (collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				goto Block_1;
			}
		}
		int theZombieRow = this.theZombieRow;
		int num2 = 0;
		Plant plant;
		if (plant == num2)
		{
		}
		return;
		Block_1:
		int theZombieRow2 = this.theZombieRow;
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x000B9840 File Offset: 0x000B7A40
	[Token(Token = "0x600238E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x000B9850 File Offset: 0x000B7A50
	[Token(Token = "0x600238F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x000B9860 File Offset: 0x000B7A60
	[Token(Token = "0x6002390")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x000B9870 File Offset: 0x000B7A70
	[Token(Token = "0x6002391")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x000B9880 File Offset: 0x000B7A80
	[Token(Token = "0x6002392")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x000B9894 File Offset: 0x000B7A94
	[Token(Token = "0x6002393")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x000B98A4 File Offset: 0x000B7AA4
	[Token(Token = "0x6002394")]
	[Address(RVA = "0x5D71B0", Offset = "0x5D57B0", VA = "0x1805D71B0")]
	public SummonedHorse()
	{
	}
}
