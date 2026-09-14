using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079F RID: 1951
[Token(Token = "0x200079F")]
public class Weapon_laser : PlayerWeapon
{
	// Token: 0x060027A3 RID: 10147 RVA: 0x000D6FDC File Offset: 0x000D51DC
	[Token(Token = "0x60027A3")]
	[Address(RVA = "0x6165F0", Offset = "0x614BF0", VA = "0x1806165F0", Slot = "9")]
	public override void OnUpdate()
	{
		this.SearchZombie();
		this.UpdateLaser();
		base.OnUpdate();
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x000D6FFC File Offset: 0x000D51FC
	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x616FA0", Offset = "0x6155A0", VA = "0x180616FA0")]
	private void UpdateLaser()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> list = this.targetZombies;
			bool flag;
			if (flag)
			{
				if (this.CheckLightTarget(num))
				{
					continue;
				}
				this.GetFreeWeapon().zombie = num;
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_0042;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_0042:
		throw new NullReferenceException();
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x000D7054 File Offset: 0x000D5254
	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x6161C0", Offset = "0x6147C0", VA = "0x1806161C0")]
	private Weapon_laser_light GetFreeWeapon()
	{
		ulong num;
		do
		{
			List<Weapon_laser_light> list = this.weapon_Laser_Lights;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
		GameObject gameObject = Resources.Load<GameObject>("Plants/Umbrellaleaf/LaserUmbrella/theLight");
		Transform transform = Board.Instance.transform;
		Weapon_laser_light weapon_laser_light = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).AddComponent<Weapon_laser_light>();
		weapon_laser_light.weapon_Laser = 0;
		weapon_laser_light.weapon_Laser = weapon_laser_light;
		throw new NullReferenceException();
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x000D70C4 File Offset: 0x000D52C4
	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x615FA0", Offset = "0x6145A0", VA = "0x180615FA0")]
	private bool CheckLightTarget(Zombie zombie)
	{
		for (;;)
		{
			List<Weapon_laser_light> list = this.weapon_Laser_Lights;
			bool flag;
			if (flag)
			{
				break;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_1;
			}
		}
		bool flag2;
		while (!flag2)
		{
		}
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000D7100 File Offset: 0x000D5300
	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x6164A0", Offset = "0x614AA0", VA = "0x1806164A0")]
	private void OnDestroy()
	{
		ulong num;
		do
		{
			List<Weapon_laser_light> list = this.weapon_Laser_Lights;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x000D7134 File Offset: 0x000D5334
	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x616120", Offset = "0x614720", VA = "0x180616120")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus))
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (col != num && zombie.theStatus != ZombieStatus.Dying)
			{
				return !zombie.beforeDying;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x000D7188 File Offset: 0x000D5388
	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x616620", Offset = "0x614C20", VA = "0x180616620")]
	private void SearchZombie()
	{
		ulong num5;
		do
		{
			int size = this.targetZombies._size;
			int num = size - 1;
			if (size > 0)
			{
				Zombie zombie = this.targetZombies[num];
				int num2 = 0;
				if (zombie == num2 || !this.CheckZombie(zombie))
				{
					this.targetZombies.RemoveAt(num);
				}
			}
			List<Zombie> list = this.targetZombies;
			List<Zombie> list2 = new List();
			Board instance = Board.Instance;
			int num3 = 0;
			Zombie zombie2 = instance.zombieArray[num3];
			int num4 = 0;
			if (!(zombie2 != num4) || this.CheckZombie(zombie2))
			{
			}
			num3++;
			Func<Zombie, float> func;
			List<Zombie> list3 = Enumerable.ToList<Zombie>(Enumerable.OrderBy<Zombie, float>(list2, func));
			bool flag;
			if (flag)
			{
				List<Zombie> list4 = this.targetZombies;
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x000D725C File Offset: 0x000D545C
	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x615F10", Offset = "0x614510", VA = "0x180615F10")]
	private bool AddZombie(Zombie zombie)
	{
		List<Zombie> list = this.targetZombies;
		return true;
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000D727C File Offset: 0x000D547C
	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x616A10", Offset = "0x615010", VA = "0x180616A10", Slot = "10")]
	protected override void Shoot()
	{
		ulong num9;
		do
		{
			int num = 0;
			List<Zombie> list = this.targetZombies;
			int num2 = 0;
			Transform axis = list[num2].axis;
			Vector3 vector;
			float z = vector.z;
			int num3 = this.zombieLayer;
			int num4 = 0;
			int num5 = 0;
			Collider2D[] array;
			if (num5 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					int attackDamage = base.AttackDamage;
					int num6 = this.shootCount;
					num6 += num6;
				}
				num4++;
			}
			uint num7;
			GameAPP.PlaySound((int)num7, 0.5f, 1f);
			List<Zombie> list2 = this.targetZombies;
			bool flag3;
			if (flag3)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
				int attackDamage2 = base.AttackDamage;
			}
		}
		while (num9 != (ulong)0L);
		uint num10;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num10), 0.5f, 1f);
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x000D7358 File Offset: 0x000D5558
	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x6171F0", Offset = "0x6157F0", VA = "0x1806171F0")]
	public Weapon_laser()
	{
		List<Zombie> list = new List();
		this.targetZombies = list;
		List<Weapon_laser_light> list2 = new List();
		this.weapon_Laser_Lights = list2;
		base..ctor();
	}

	// Token: 0x040015FB RID: 5627
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015FB")]
	public List<Zombie> targetZombies;

	// Token: 0x040015FC RID: 5628
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015FC")]
	public List<Weapon_laser_light> weapon_Laser_Lights;
}
