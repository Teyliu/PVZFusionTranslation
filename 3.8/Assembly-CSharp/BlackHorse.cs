using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200062D RID: 1581
[Token(Token = "0x200062D")]
public class BlackHorse : SuperHorse
{
	// Token: 0x06001DEC RID: 7660 RVA: 0x000A0374 File Offset: 0x0009E574
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x5321B0", Offset = "0x5307B0", VA = "0x1805321B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)43L);
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000A0394 File Offset: 0x0009E594
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x5322E0", Offset = "0x5308E0", VA = "0x1805322E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("run");
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x000A03C0 File Offset: 0x0009E5C0
	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x000A03D0 File Offset: 0x0009E5D0
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x531F30", Offset = "0x530530", VA = "0x180531F30", Slot = "76")]
	protected override void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Vector3 vector;
		float z = vector.z;
		int num3 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)121), num2, theZombieRow, num4 != 0UL, (float)num3);
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		int num5 = 0;
		Transform child2 = axis2.GetChild(num5);
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			int theMaxHealth = this.theMaxHealth;
			zombie.theHealth = theMaxHealth;
			int theMaxHealth2 = this.theMaxHealth;
			zombie.theMaxHealth = theMaxHealth2;
		}
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000A049C File Offset: 0x0009E69C
	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x5321D0", Offset = "0x5307D0", VA = "0x1805321D0", Slot = "66")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		Plant plant = base.CrashEntity(collision, inWater, knockBack);
		int num = 0;
		if (plant != num)
		{
			bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 1f);
		}
		return plant;
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x000A0510 File Offset: 0x0009E710
	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x532340", Offset = "0x530940", VA = "0x180532340")]
	public BlackHorse()
	{
	}
}
