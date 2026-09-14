using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013A RID: 314
[Token(Token = "0x200013A")]
public class Bullet_doom_ulti : Bullet_doom
{
	// Token: 0x060005DB RID: 1499 RVA: 0x0001EC3C File Offset: 0x0001CE3C
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x6EC090", Offset = "0x6EA690", VA = "0x1806EC090", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		for (;;)
		{
			Transform transform = base.transform;
			int num = 0;
			Vector3 vector;
			float z = vector.z;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			Bullet_doom_ulti.ActionOnZombie(zombie, this);
			GameObject gameObject;
			Transform transform2 = gameObject.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform3 = base.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			PlantType fromType = this.fromType;
			int damage = this._damage;
			Transform transform4 = base.transform;
			LayerMask zombieLayer = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag && Lawnf.InLandStatus((ZombieStatus)num))
				{
					Bullet_doom_ulti.ActionOnZombie(num, this);
				}
				num++;
			}
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			bool flag2;
			if (flag2)
			{
				break;
			}
			bool flag3;
			while (!flag3)
			{
			}
			uint num4;
			if (global::UnityEngine.Random.Range(0, (int)num4) < 1)
			{
				goto Block_5;
			}
		}
		Mouse instance = Mouse.Instance;
		Transform axis = zombie.axis;
		BoardAction boardAction = this.board.boardAction;
		uint num6;
		int num5 = Mathf.Max(this._damage, (int)num6);
		PlantType fromType2 = this.fromType;
		base.Die();
		return;
		Block_5:
		BoardAction boardAction2 = this.board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0001ED54 File Offset: 0x0001CF54
	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x6EBB20", Offset = "0x6EA120", VA = "0x1806EBB20")]
	public static void ActionOnZombie(Zombie zombie, Bullet bullet)
	{
		if (bullet.fromType != PlantType.UltimateDoomScaredy)
		{
			int num = 0;
			zombie.SetEmbered(num != 0);
			int num2 = 0;
			bool flag;
			if (zombie.HasBuff((EffectType)num2) && !flag)
			{
				int num3 = 0;
				zombie.SetFreeze(1f, num3);
			}
			bool flag2;
			if (flag2)
			{
				int damage = bullet._damage;
				int num4 = 0;
				ulong num5;
				zombie.JalaedExplode(num5 != 0UL, damage, num4 != 0);
			}
			bool flag3;
			if (!flag3)
			{
				goto IL_006C;
			}
			uint num6;
			num6 += num6;
			zombie.DamagedByPoison((float)num6);
		}
		ulong num7;
		zombie.SetEmbered(num7 != 0UL);
		IL_006C:
		PlantType fromType = bullet.fromType;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0001EDDC File Offset: 0x0001CFDC
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x6EBC80", Offset = "0x6EA280", VA = "0x1806EBC80")]
	private void AttackZombies()
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				Bullet_doom_ulti.ActionOnZombie(num, this);
			}
			num++;
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001EE44 File Offset: 0x0001D044
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x6EBE60", Offset = "0x6EA460", VA = "0x1806EBE60", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		GameAPP.PlaySound(70, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		Plant plant2 = plant;
		int num2 = 0;
		int num3 = 0;
		int num4;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)27), num, num4, num5 != 0UL, (float)num2);
		Action <>9__0;
		Action <>9__ = <>9__0;
		DelayAction delayAction = GameAPP.delayAction;
		if (<>9__ == 0)
		{
			Action action = delegate
			{
				Plant plant3 = plant;
				int num6 = 0;
				if (plant3 != num6)
				{
					Plant plant4 = plant;
					Bullet_doom_ulti <>4__this = this;
					int thePlantHealth = plant4.thePlantHealth;
					Plant plant5 = plant;
					Plant plant6 = plant;
					if (thePlantHealth > 0)
					{
						Zombie from_zombie = this.from_zombie;
						int num7 = 0;
						if (from_zombie != num7)
						{
							Zombie from_zombie2 = this.from_zombie;
							long theMaxHealth = from_zombie2.theMaxHealth;
							if (from_zombie2.theHealth < theMaxHealth)
							{
								Zombie from_zombie3 = this.from_zombie;
								from_zombie3.theMaxHealth = theMaxHealth;
								Bullet_doom_ulti <>4__this2 = this;
								Zombie from_zombie4 = <>4__this2.from_zombie;
								<>4__this2.from_zombie.theHealth = from_zombie3;
								Bullet_doom_ulti <>4__this3 = this;
								long num8 = <>4__this3.from_zombie.theHealth;
								num8 += (long)thePlantHealth;
								Zombie from_zombie5 = <>4__this3.from_zombie;
								Zombie from_zombie6 = <>4__this3.from_zombie;
								from_zombie5.theHealth = from_zombie6;
							}
							this.from_zombie.UpdateHealthText();
						}
					}
				}
			};
			<>9__0 = action;
		}
		delayAction.SetAction(<>9__, 1f);
		num3++;
		base.Die();
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_doom_ulti()
	{
	}
}
