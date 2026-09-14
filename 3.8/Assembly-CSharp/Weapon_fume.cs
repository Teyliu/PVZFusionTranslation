using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079C RID: 1948
[Token(Token = "0x200079C")]
public class Weapon_fume : PlayerWeapon
{
	// Token: 0x0600279A RID: 10138 RVA: 0x000D6CA8 File Offset: 0x000D4EA8
	[Token(Token = "0x600279A")]
	[Address(RVA = "0x614620", Offset = "0x612C20", VA = "0x180614620")]
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

	// Token: 0x0600279B RID: 10139 RVA: 0x000D6CFC File Offset: 0x000D4EFC
	[Token(Token = "0x600279B")]
	[Address(RVA = "0x614320", Offset = "0x612920", VA = "0x180614320")]
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

	// Token: 0x0600279C RID: 10140 RVA: 0x000D6DA8 File Offset: 0x000D4FA8
	[Token(Token = "0x600279C")]
	[Address(RVA = "0x6146B0", Offset = "0x612CB0", VA = "0x1806146B0", Slot = "10")]
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

	// Token: 0x0600279D RID: 10141 RVA: 0x000D6E34 File Offset: 0x000D5034
	[Token(Token = "0x600279D")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_fume()
	{
	}

	// Token: 0x040015F8 RID: 5624
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015F8")]
	public float height;

	// Token: 0x040015F9 RID: 5625
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015F9")]
	public ParticleSystem particle;

	// Token: 0x040015FA RID: 5626
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40015FA")]
	public ParticleSystem fireParticle;
}
