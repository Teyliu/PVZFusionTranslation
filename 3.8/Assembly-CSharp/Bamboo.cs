using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000340 RID: 832
[Token(Token = "0x2000340")]
public class Bamboo : Plant
{
	// Token: 0x06000F43 RID: 3907 RVA: 0x00058D4C File Offset: 0x00056F4C
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x41A060", Offset = "0x418660", VA = "0x18041A060", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
			int num = this.thePlantMaxHealth;
			num += num;
			this.thePlantMaxHealth = num;
			int num2 = this.thePlantHealth;
			num2 += num2;
			this.thePlantHealth = num2;
		}
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00058D94 File Offset: 0x00056F94
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00058DA4 File Offset: 0x00056FA4
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x419FF0", Offset = "0x4185F0", VA = "0x180419FF0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00058DD0 File Offset: 0x00056FD0
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x419ED0", Offset = "0x4184D0", VA = "0x180419ED0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num;
		for (;;)
		{
			num = 0;
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)12015)))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				goto Block_3;
			}
		}
		if (collision.TryGetComponent<Zombie>(num))
		{
			int thePlantRow = this.thePlantRow;
			if (Lawnf.InLandStatus((ZombieStatus)num))
			{
				this.CrashWithZombie(num, 1f);
			}
		}
		return;
		Block_3:
		this.CrashWithZombie(num, 1f);
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00058E34 File Offset: 0x00057034
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x419BF0", Offset = "0x4181F0", VA = "0x180419BF0", Slot = "69")]
	protected virtual void CrashWithZombie(Zombie zombie, float x)
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
		int num = 0;
		zombie.theHealth = num;
		zombie.theFirstArmorHealth = num;
		zombie.theSecondArmorHealth = num;
		PlantType thePlantType = this.thePlantType;
		int num2 = 0;
		zombie.Die(num2);
		AdvantureMission.TryAddCount((AdvantureLevel)((uint)66));
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num3 = 0;
		int num4 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)109), num3, thePlantRow, num5 != 0UL, (float)num4);
		int num6 = 0;
		base.Die((Plant.DieReason)num6);
		GameAPP.PlaySound((int)this.thePlantType, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00058F34 File Offset: 0x00057134
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00058F44 File Offset: 0x00057144
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Bamboo()
	{
	}
}
