using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039F RID: 927
[Token(Token = "0x200039F")]
public class HypnoChomper : Chomper
{
	// Token: 0x06001108 RID: 4360 RVA: 0x00061034 File Offset: 0x0005F234
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x43ADC0", Offset = "0x4393C0", VA = "0x18043ADC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00061080 File Offset: 0x0005F280
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x43AC80", Offset = "0x439280", VA = "0x18043AC80", Slot = "72")]
	protected override bool CheckZombie(Zombie zombie)
	{
		if (!zombie.beforeDying)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Snokle_inWater)
			{
				if (theStatus != ZombieStatus.Bungi_awake)
				{
					goto IL_0027;
				}
			}
		}
		IL_001B:
		while (zombie == (ulong)1L)
		{
		}
		while (zombie == (ulong)7L)
		{
		}
		goto IL_0027;
		goto IL_001B;
		IL_0027:
		throw new NullReferenceException();
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x000610BC File Offset: 0x0005F2BC
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x43AD20", Offset = "0x439320", VA = "0x18043AD20", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		base.Chomp(zombie);
		if (zombie.isMindControlled)
		{
			Transform axis = this.axis;
			float num = this.attributeCountdown * 0.25f;
			base.AttributeCountdown = num;
		}
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x000610FC File Offset: 0x0005F2FC
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x43AB30", Offset = "0x439130", VA = "0x18043AB30", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			int theZombieType = (int)this.targetZombie.theZombieType;
			Zombie targetZombie2 = this.targetZombie;
			bool flag;
			if (flag || (targetZombie2.theStatus > ZombieStatus.Pol_run && !targetZombie2.beforeDying))
			{
				PlantType thePlantType = this.thePlantType;
				ulong num2;
				targetZombie2.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00061168 File Offset: 0x0005F368
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x430E90", Offset = "0x42F490", VA = "0x180430E90")]
	public HypnoChomper()
	{
	}
}
