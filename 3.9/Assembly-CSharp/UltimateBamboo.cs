using System;
using Core;
using Cpp2IlInjected;

// Token: 0x02000481 RID: 1153
[Token(Token = "0x2000481")]
public class UltimateBamboo : Bamboo
{
	// Token: 0x06001538 RID: 5432 RVA: 0x00075394 File Offset: 0x00073594
	[Token(Token = "0x6001538")]
	[Address(RVA = "0x4D46E0", Offset = "0x4D2CE0", VA = "0x1804D46E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)32)))
		{
			this.theStatus = (PlantStatus)((ulong)25L);
		}
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x000753C8 File Offset: 0x000735C8
	[Token(Token = "0x6001539")]
	[Address(RVA = "0x4D4630", Offset = "0x4D2C30", VA = "0x1804D4630", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int num = 0;
		float num2;
		ulong num3;
		this.Recover(num2, (DamageType)num, true, num3 != 0UL);
		int thePlantMaxHealth2 = this.thePlantMaxHealth;
		float num4;
		this.GetShield(num4);
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x0007540C File Offset: 0x0007360C
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x4D4BA0", Offset = "0x4D31A0", VA = "0x1804D4BA0", Slot = "25")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)33)))
		{
		}
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00075428 File Offset: 0x00073628
	[Token(Token = "0x600153B")]
	[Address(RVA = "0x4D4B50", Offset = "0x4D3150", VA = "0x1804D4B50", Slot = "26")]
	public override void GetShield(float value)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)33)))
		{
		}
		base.GetShield(value);
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00075448 File Offset: 0x00073648
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x4D4C10", Offset = "0x4D3210", VA = "0x1804D4C10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.UltimateBamboo)
		{
			float num = base.Timers[1];
			int num2 = 0;
			if (num > (float)num2 || damageType != DamageType.JackboxExplode || !base.CheckJackbox())
			{
			}
		}
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00075484 File Offset: 0x00073684
	[Token(Token = "0x600153D")]
	[Address(RVA = "0x4D4A30", Offset = "0x4D3030", VA = "0x1804D4A30", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		int num = 0;
		if (base.Active && this.storedDamage > 0)
		{
			if (this.storedDamage > 1000000)
			{
				int num2 = this.storedDamage;
				if (this.storedDamage <= 1000000)
				{
				}
			}
			num += num;
			base.FlashOnce();
		}
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x000754D8 File Offset: 0x000736D8
	[Token(Token = "0x600153E")]
	[Address(RVA = "0x4D4770", Offset = "0x4D2D70", VA = "0x1804D4770", Slot = "68")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		bool flag;
		if (!flag)
		{
			ZombieType theZombieType = zombie.theZombieType;
			if (theZombieType > ZombieType.HorseBoss)
			{
				if (theZombieType == ZombieType.UltimateSwordZombie || theZombieType == ZombieType.VoodooDollZombie || theZombieType <= ZombieType.FlagZombie)
				{
					return;
				}
			}
			else
			{
				while (theZombieType == ZombieType.ZombieBoss)
				{
				}
				while (theZombieType == ZombieType.ZombieBoss2)
				{
				}
				while (theZombieType == ZombieType.HorseBoss)
				{
				}
			}
			long num = zombie.CurrentFirstHealth;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			base.FlashOnce();
			long num2 = zombie.CurrentFirstHealth;
			num = num2;
			num2 = num;
			int num3 = num2.ToInt();
			PlantType thePlantType = this.thePlantType;
		}
		GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
		base.FlashOnce();
		int num4 = zombie.CurrentFirstHealth.ToInt();
		PlantType thePlantType2 = this.thePlantType;
		throw new NullReferenceException();
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00075598 File Offset: 0x00073798
	[Token(Token = "0x600153F")]
	[Address(RVA = "0x4D4730", Offset = "0x4D2D30", VA = "0x1804D4730", Slot = "21")]
	public override void Charge()
	{
		int num = 0;
		float num2;
		ulong num3;
		this.Recover(num2, (DamageType)num, true, num3 != 0UL);
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000755B4 File Offset: 0x000737B4
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x4D4B90", Offset = "0x4D3190", VA = "0x1804D4B90", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		this.storedDamage = (int)((ulong)0L);
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x000755CC File Offset: 0x000737CC
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateBamboo()
	{
	}

	// Token: 0x04000D5B RID: 3419
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D5B")]
	public int storedDamage;
}
