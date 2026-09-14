using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class Bullet_ultimateCactus : Bullet_iceDoom
{
	// Token: 0x060007D4 RID: 2004 RVA: 0x00027724 File Offset: 0x00025924
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x6E9CA0", Offset = "0x6E82A0", VA = "0x1806E9CA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)1000000L);
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00027740 File Offset: 0x00025940
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x815670", Offset = "0x813C70", VA = "0x180815670", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		if (zombie == 0)
		{
		}
		bool alive = zombie.Alive;
		this.TrySetMindControl(zombie, damage);
		Plant from = this.from;
		int num2 = 0;
		if (from != num2)
		{
			if (!zombie.isMindControlled)
			{
				bool alive2 = zombie.Alive;
				if (alive == alive2)
				{
					goto IL_0053;
				}
			}
			this.from.KillZombie(zombie);
		}
		IL_0053:
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theZombieRow = zombie.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)28), num3, theZombieRow, num4 != 0UL, (float)num);
		GameAPP.PlaySound(70, 0.5f, 1f);
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x000277E8 File Offset: 0x000259E8
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x815570", Offset = "0x813B70", VA = "0x180815570", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)28), num, theBulletRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00027840 File Offset: 0x00025A40
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x815860", Offset = "0x813E60", VA = "0x180815860")]
	private void SmallDoom(Zombie z)
	{
		Transform axis = z.axis;
		Vector3 vector;
		float z2 = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				PlantType fromType = this.fromType;
			}
			num3++;
		}
		Transform axis2 = z.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x000278B4 File Offset: 0x00025AB4
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x815AB0", Offset = "0x8140B0", VA = "0x180815AB0")]
	private void TrySetMindControl(Zombie zombie, int damage)
	{
		for (;;)
		{
			long currentFirstHealth = zombie.CurrentFirstHealth;
			if (zombie <= 0)
			{
			}
			float value = global::UnityEngine.Random.value;
			if (zombie <= 0)
			{
			}
			if (value < 0.75f)
			{
				break;
			}
			int num = 0;
			zombie.SetMindControl(num);
			this.SmallDoom(zombie);
			while (!zombie.isMindControlled)
			{
			}
			if (zombie.BoxType != BoxType.Water)
			{
				goto Block_2;
			}
		}
		PlantType fromType = this.fromType;
		bool flag;
		if (flag)
		{
		}
		int num2 = 0;
		uint num3;
		zombie.AddfreezeLevel((int)num3, num2);
		return;
		Block_2:
		Transform axis = zombie.axis;
		CreateZombie instance = CreateZombie.Instance;
		bool flag2;
		bool flag3;
		if (!flag2 || flag3)
		{
		}
		uint num4;
		zombie.Die((int)num4);
		throw new NullReferenceException();
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0002794C File Offset: 0x00025B4C
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_ultimateCactus()
	{
	}
}
