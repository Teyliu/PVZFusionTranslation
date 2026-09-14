using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class Bullet_doom_ulti : Bullet_doom
{
	// Token: 0x060005D4 RID: 1492 RVA: 0x0001F470 File Offset: 0x0001D670
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x6C12B0", Offset = "0x6BF8B0", VA = "0x1806C12B0", Slot = "25")]
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

	// Token: 0x060005D5 RID: 1493 RVA: 0x0001F588 File Offset: 0x0001D788
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x6C0D40", Offset = "0x6BF340", VA = "0x1806C0D40")]
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

	// Token: 0x060005D6 RID: 1494 RVA: 0x0001F610 File Offset: 0x0001D810
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x6C0EA0", Offset = "0x6BF4A0", VA = "0x1806C0EA0")]
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

	// Token: 0x060005D7 RID: 1495 RVA: 0x0001F678 File Offset: 0x0001D878
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x6C1080", Offset = "0x6BF680", VA = "0x1806C1080", Slot = "24")]
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
							int theMaxHealth = from_zombie2.theMaxHealth;
							if (from_zombie2.theHealth < theMaxHealth)
							{
								Bullet_doom_ulti <>4__this2 = this;
								Zombie from_zombie3 = <>4__this2.from_zombie;
								<>4__this2.from_zombie.theMaxHealth = from_zombie3;
								Bullet_doom_ulti <>4__this3 = this;
								Zombie from_zombie4 = <>4__this3.from_zombie;
								<>4__this3.from_zombie.theHealth = from_zombie4;
								Zombie from_zombie5 = this.from_zombie;
								int num8 = from_zombie5.theHealth;
								int theMaxHealth2 = from_zombie5.theMaxHealth;
								num8 += thePlantHealth;
								if (num8 >= theMaxHealth2)
								{
									num8 = theMaxHealth2;
								}
								from_zombie5.theHealth = num8;
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

	// Token: 0x060005D8 RID: 1496 RVA: 0x0001F724 File Offset: 0x0001D924
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_doom_ulti()
	{
	}
}
