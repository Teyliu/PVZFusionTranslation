using System;
using Cpp2IlInjected;

// Token: 0x02000461 RID: 1121
[Token(Token = "0x2000461")]
public class UltimateBamboo : Bamboo
{
	// Token: 0x060014A8 RID: 5288 RVA: 0x0007303C File Offset: 0x0007123C
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x47CDD0", Offset = "0x47B3D0", VA = "0x18047CDD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)32)))
		{
			this.theStatus = (PlantStatus)((ulong)25L);
		}
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00073070 File Offset: 0x00071270
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x47CD20", Offset = "0x47B320", VA = "0x18047CD20", Slot = "40")]
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

	// Token: 0x060014AA RID: 5290 RVA: 0x000730B4 File Offset: 0x000712B4
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x47D220", Offset = "0x47B820", VA = "0x18047D220", Slot = "26")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		if (Lawnf.TravelUltimate((UltiBuff)((uint)33)))
		{
		}
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x000730D0 File Offset: 0x000712D0
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x47D1D0", Offset = "0x47B7D0", VA = "0x18047D1D0", Slot = "27")]
	public override void GetShield(float value)
	{
		if (Lawnf.TravelUltimate((UltiBuff)((uint)33)))
		{
		}
		base.GetShield(value);
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x000730F0 File Offset: 0x000712F0
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x47D290", Offset = "0x47B890", VA = "0x18047D290", Slot = "12")]
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

	// Token: 0x060014AD RID: 5293 RVA: 0x0007312C File Offset: 0x0007132C
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x47D0B0", Offset = "0x47B6B0", VA = "0x18047D0B0", Slot = "17")]
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

	// Token: 0x060014AE RID: 5294 RVA: 0x00073180 File Offset: 0x00071380
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x47CE60", Offset = "0x47B460", VA = "0x18047CE60", Slot = "69")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)12015));
		if (!flag)
		{
			ZombieType theZombieType = zombie.theZombieType;
			if (theZombieType > ZombieType.HorseBoss)
			{
				if (theZombieType == ZombieType.UltimateSwordZombie || theZombieType == ZombieType.VoodooDollZombie || theZombieType == ZombieType.FootballBoss)
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
			int currentFirstHealth = zombie.CurrentFirstHealth;
			GameAPP.PlaySound(currentFirstHealth, 0.5f, 1f);
			base.FlashOnce();
			int currentFirstHealth2 = zombie.CurrentFirstHealth;
			PlantType thePlantType = this.thePlantType;
		}
		GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
		base.FlashOnce();
		int currentFirstHealth3 = zombie.CurrentFirstHealth;
		PlantType thePlantType2 = this.thePlantType;
		ulong num;
		zombie.TakeDamage(currentFirstHealth3, this, (DamageType)((uint)1), thePlantType2, num != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x00073244 File Offset: 0x00071444
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x47CE20", Offset = "0x47B420", VA = "0x18047CE20", Slot = "21")]
	public override void Charge()
	{
		int num = 0;
		float num2;
		ulong num3;
		this.Recover(num2, (DamageType)num, true, num3 != 0UL);
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00073260 File Offset: 0x00071460
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x47D210", Offset = "0x47B810", VA = "0x18047D210", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
		this.storedDamage = (int)((ulong)0L);
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00073278 File Offset: 0x00071478
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateBamboo()
	{
	}

	// Token: 0x04000CCF RID: 3279
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CCF")]
	public int storedDamage;
}
