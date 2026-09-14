using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D5 RID: 2005
[Token(Token = "0x20007D5")]
public class Weapon_fume : PlayerWeapon
{
	// Token: 0x060028C9 RID: 10441 RVA: 0x000DBC64 File Offset: 0x000D9E64
	[Token(Token = "0x60028C9")]
	[Address(RVA = "0x677EB0", Offset = "0x6764B0", VA = "0x180677EB0")]
	private void FixedUpdate()
	{
		float attributeTimer = this.attributeTimer;
		int num = 0;
		if (attributeTimer > (float)num)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.attributeTimer = attributeTimer;
			this.AttackZombies();
			ParticleSystem particleSystem = this.particle;
			this.attributeTimer = 0f;
			ParticleSystem.MainModule main = particleSystem.main;
		}
	}

	// Token: 0x060028CA RID: 10442 RVA: 0x000DBCB8 File Offset: 0x000D9EB8
	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x677BB0", Offset = "0x6761B0", VA = "0x180677BB0")]
	private void AttackZombies()
	{
		int num = this.shootCount;
		int num2 = 0;
		num += 5;
		Player player = this.player;
		if (player.towards != Towards.Right || (player.moving ? 1 : 0) != num2)
		{
		}
		int attackDamage = base.AttackDamage;
		int evolution = this.evolution;
		if (evolution > 0)
		{
			int attackDamage2 = base.AttackDamage;
			Player player2 = this.player;
		}
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (Lawnf.InLandStatus((ZombieStatus)num2))
				{
					int num5 = num2.System.IConvertible.ToInt32(num4);
					if (evolution > 0)
					{
					}
				}
			}
			num2++;
		}
	}

	// Token: 0x060028CB RID: 10443 RVA: 0x000DBD64 File Offset: 0x000D9F64
	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x677F40", Offset = "0x676540", VA = "0x180677F40", Slot = "10")]
	protected override void Shoot()
	{
		ParticleSystem.MainModule main = this.particle.main;
		ParticleSystem particleSystem = this.fireParticle;
		this.particle = particleSystem;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		ParticleSystem particleSystem2 = this.particle;
		this.attributeTimer = 1f;
		ParticleSystem.MainModule main2 = particleSystem2.main;
		ParticleSystem.MainModule main3 = this.particle.main;
		ParticleSystem.MainModule main4 = this.particle.main;
		float num = this.height;
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x000DBDF0 File Offset: 0x000D9FF0
	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_fume()
	{
	}

	// Token: 0x040016D4 RID: 5844
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D4")]
	public float height;

	// Token: 0x040016D5 RID: 5845
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016D5")]
	public ParticleSystem particle;

	// Token: 0x040016D6 RID: 5846
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016D6")]
	public ParticleSystem fireParticle;
}
