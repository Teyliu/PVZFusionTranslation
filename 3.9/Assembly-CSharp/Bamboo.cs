using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000350 RID: 848
[Token(Token = "0x2000350")]
public class Bamboo : Plant
{
	// Token: 0x06000F8E RID: 3982 RVA: 0x00059D0C File Offset: 0x00057F0C
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x470F30", Offset = "0x46F530", VA = "0x180470F30", Slot = "15")]
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

	// Token: 0x06000F8F RID: 3983 RVA: 0x00059D54 File Offset: 0x00057F54
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00059D64 File Offset: 0x00057F64
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x470EC0", Offset = "0x46F4C0", VA = "0x180470EC0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00059D90 File Offset: 0x00057F90
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x470DA0", Offset = "0x46F3A0", VA = "0x180470DA0")]
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

	// Token: 0x06000F92 RID: 3986 RVA: 0x00059DF4 File Offset: 0x00057FF4
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x470AC0", Offset = "0x46F0C0", VA = "0x180470AC0", Slot = "68")]
	protected virtual void CrashWithZombie(Zombie zombie, float x)
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
		long currentFirstHealth = zombie.CurrentFirstHealth;
		GameAPP.PlaySound((int)currentFirstHealth, 0.5f, 1f);
		base.FlashOnce();
		long currentFirstHealth2 = zombie.CurrentFirstHealth;
		int num = 0;
		zombie.theHealth = (long)num;
		zombie.theFirstArmorHealth = num;
		zombie.theSecondArmorHealth = num;
		PlantType thePlantType = this.thePlantType;
		int num2 = 0;
		zombie.Die(num2);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num3 = 0;
		base.Die((Plant.DieReason)num3);
		GameAPP.PlaySound((int)this.thePlantType, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00059ECC File Offset: 0x000580CC
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00059EDC File Offset: 0x000580DC
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Bamboo()
	{
	}
}
