using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D8 RID: 2008
[Token(Token = "0x20007D8")]
public class Weapon_laser : PlayerWeapon
{
	// Token: 0x060028D2 RID: 10450 RVA: 0x000DBF98 File Offset: 0x000DA198
	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x679E80", Offset = "0x678480", VA = "0x180679E80", Slot = "9")]
	public override void OnUpdate()
	{
		this.SearchZombie();
		this.UpdateLaser();
		base.OnUpdate();
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x000DBFB8 File Offset: 0x000DA1B8
	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x67A830", Offset = "0x678E30", VA = "0x18067A830")]
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

	// Token: 0x060028D4 RID: 10452 RVA: 0x000DC010 File Offset: 0x000DA210
	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x679A50", Offset = "0x678050", VA = "0x180679A50")]
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

	// Token: 0x060028D5 RID: 10453 RVA: 0x000DC080 File Offset: 0x000DA280
	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x679830", Offset = "0x677E30", VA = "0x180679830")]
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

	// Token: 0x060028D6 RID: 10454 RVA: 0x000DC0BC File Offset: 0x000DA2BC
	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x679D30", Offset = "0x678330", VA = "0x180679D30")]
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

	// Token: 0x060028D7 RID: 10455 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x6799B0", Offset = "0x677FB0", VA = "0x1806799B0")]
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

	// Token: 0x060028D8 RID: 10456 RVA: 0x000DC144 File Offset: 0x000DA344
	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x679EB0", Offset = "0x6784B0", VA = "0x180679EB0")]
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

	// Token: 0x060028D9 RID: 10457 RVA: 0x000DC218 File Offset: 0x000DA418
	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x6797A0", Offset = "0x677DA0", VA = "0x1806797A0")]
	private bool AddZombie(Zombie zombie)
	{
		List<Zombie> list = this.targetZombies;
		return true;
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x000DC238 File Offset: 0x000DA438
	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x67A2A0", Offset = "0x6788A0", VA = "0x18067A2A0", Slot = "10")]
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

	// Token: 0x060028DB RID: 10459 RVA: 0x000DC314 File Offset: 0x000DA514
	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x67AA80", Offset = "0x679080", VA = "0x18067AA80")]
	public Weapon_laser()
	{
		List<Zombie> list = new List();
		this.targetZombies = list;
		List<Weapon_laser_light> list2 = new List();
		this.weapon_Laser_Lights = list2;
		base..ctor();
	}

	// Token: 0x040016D7 RID: 5847
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D7")]
	public List<Zombie> targetZombies;

	// Token: 0x040016D8 RID: 5848
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016D8")]
	public List<Weapon_laser_light> weapon_Laser_Lights;
}
