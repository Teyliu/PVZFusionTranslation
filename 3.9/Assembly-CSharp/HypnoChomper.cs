using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B3 RID: 947
[Token(Token = "0x20003B3")]
public class HypnoChomper : Chomper
{
	// Token: 0x06001164 RID: 4452 RVA: 0x0006268C File Offset: 0x0006088C
	[Token(Token = "0x6001164")]
	[Address(RVA = "0x48E610", Offset = "0x48CC10", VA = "0x18048E610", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x000626D8 File Offset: 0x000608D8
	[Token(Token = "0x6001165")]
	[Address(RVA = "0x48E4D0", Offset = "0x48CAD0", VA = "0x18048E4D0", Slot = "72")]
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

	// Token: 0x06001166 RID: 4454 RVA: 0x00062714 File Offset: 0x00060914
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x48E570", Offset = "0x48CB70", VA = "0x18048E570", Slot = "74")]
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

	// Token: 0x06001167 RID: 4455 RVA: 0x00062754 File Offset: 0x00060954
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x48E380", Offset = "0x48C980", VA = "0x18048E380", Slot = "73")]
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

	// Token: 0x06001168 RID: 4456 RVA: 0x000627C0 File Offset: 0x000609C0
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public HypnoChomper()
	{
	}
}
